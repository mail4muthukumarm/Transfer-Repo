// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.formMultiACHSettingsManagement
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
using MGASystems.Data.Repository.Interface;
using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount;
using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.DataAccess;
using MGASystems.IMS.Accounting.Core.Forms.ACH.PayeeMissingBankAccount.Model;
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

public class formMultiACHSettingsManagement : FormBase
{
  private PayeeMissingBankAccountDto[] _payeeMissingBankAccounts;
  protected string _getACHSettingsProc = "dbo.spFin_GetACHSettings";
  private Panel gridPanel;
  protected UltraGrid settingsGrid;
  private UltraToolbarsManager ultraToolbarsManager;
  private IContainer components;
  private UltraToolbarsDockArea _formMultiACHSettingsManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formMultiACHSettingsManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formMultiACHSettingsManagement_Toolbars_Dock_Area_Top;

  public formMultiACHSettingsManagement() => this.InitializeComponent();

  private void formMultiACHSettingsManagement_Load(object sender, EventArgs e)
  {
    this.CheckToolbarPermissions();
    this.LoadSettings();
    this.ActiveControl = (Control) this.settingsGrid;
    this.LoadMissingBanks();
  }

  private void SetPayeeMissingBankAccountButtonVisibility()
  {
    if (((IEnumerable<PayeeMissingBankAccountDto>) this._payeeMissingBankAccounts).Any<PayeeMissingBankAccountDto>())
      return;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["UnmappedPayees"].SharedProps.Enabled = false;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["UnmappedPayees"].SharedProps.Visible = false;
  }

  private void LoadMissingBanks()
  {
    this._payeeMissingBankAccounts = ((IGetAllRepository<PayeeMissingBankAccountDto, Guid>) ObjectFactory.Instance.CreateObjectAs<IPayeeMissingBankAccountRepository>()).GetAll();
    this.SetPayeeMissingBankAccountButtonVisibility();
  }

  private void settingsGrid_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.settingsGrid).ActiveRow == null || !MultiACHSettingsSecurity.CanEditSettings)
      return;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["BARDEFAULT"].SharedProps.Enabled = ((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow != null && ((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow.ParentRow != null;
  }

  private void settingsGrid_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
  }

  private void settingsGrid_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (!MultiACHSettingsSecurity.CanEditSettings)
      return;
    this.EditSetting();
  }

  private void settingsGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
  }

  private void settingsGrid_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right || !(((UIElement) ((UltraGridBase) this.settingsGrid).DisplayLayout.UIElement).ElementFromPoint(e.Location).GetContext(typeof (UltraGridRow)) is UltraGridRow context) || !context.IsDataRow)
      return;
    this.SelectRow(context);
    if (!MultiACHSettingsSecurity.CanEditSettings)
      return;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["DEFAULT"].SharedProps.Visible = context.ParentRow?.ParentRow != null;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["BARDEFAULT"].SharedProps.Enabled = ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["DEFAULT"].SharedProps.Visible;
  }

  private void ultraToolbarsManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 4:
        if (!(key == "EDIT"))
          return;
        goto label_30;
      case 5:
        return;
      case 6:
        switch (key[0])
        {
          case 'B':
            if (!(key == "BARNEW"))
              return;
            this.NewSetting();
            return;
          case 'D':
            if (!(key == "DELETE"))
              return;
            goto label_29;
          default:
            return;
        }
      case 7:
        switch (key[0])
        {
          case 'B':
            if (!(key == "BAREDIT"))
              return;
            goto label_30;
          case 'D':
            if (!(key == "DEFAULT"))
              return;
            break;
          default:
            return;
        }
        break;
      case 8:
        return;
      case 9:
        if (!(key == "BARDELETE"))
          return;
        goto label_29;
      case 10:
        switch (key[3])
        {
          case 'D':
            if (!(key == "BARDEFAULT"))
              return;
            break;
          case 'P':
            if (!(key == "BARPENDING"))
              return;
            this.ShowApprovals();
            return;
          default:
            return;
        }
        break;
      case 11:
        return;
      case 12:
        return;
      case 13:
        return;
      case 14:
        if (!(key == "UnmappedPayees"))
          return;
        this.ShowSelectUnmapped();
        return;
      default:
        return;
    }
    this.SetDefaultSetting();
    return;
label_29:
    this.DeleteSetting();
    return;
label_30:
    this.EditSetting();
  }

  private void ShowSelectUnmapped()
  {
    PayeeMissingBankAccountGridModel accountGridModel = new PayeeMissingBankAccountGridModel(this._payeeMissingBankAccounts);
    using (PayeeMissingBankAccountSelector objectAs = ObjectFactory.Instance.CreateObjectAs<PayeeMissingBankAccountSelector>((object) accountGridModel))
    {
      if (objectAs.ShowDialog() != DialogResult.OK)
        return;
      PayeeMissingBankAccountDto selected = accountGridModel.Selected;
      if (selected == null)
        return;
      using (Form form = ObjectFactory.Instance.CreateForm(typeof (formMultiACHSettingsEditor), new object[2]
      {
        (object) (selected.InsuredGuid ?? selected.EntityGuid),
        (object) selected.Name
      }))
      {
        if (form.ShowDialog() != DialogResult.OK)
          return;
        this.ReloadSettings();
      }
    }
  }

  private void CheckToolbarPermissions()
  {
    RootToolsCollection tools = this.ultraToolbarsManager.Tools;
    if (!MultiACHSettingsSecurity.CanApproveSettings)
      ((ToolsCollectionBase) tools)["BARPENDING"].SharedProps.Enabled = false;
    if (!MultiACHSettingsSecurity.CanCreateSettings)
      ((ToolsCollectionBase) tools)["BARNEW"].SharedProps.Enabled = false;
    if (!MultiACHSettingsSecurity.CanDeleteSettings)
    {
      ((ToolsCollectionBase) tools)["DELETE"].SharedProps.Enabled = false;
      ((ToolsCollectionBase) tools)["BARDELETE"].SharedProps.Enabled = false;
    }
    if (MultiACHSettingsSecurity.CanEditSettings)
      return;
    ((ToolsCollectionBase) tools)["DEFAULT"].SharedProps.Enabled = false;
    ((ToolsCollectionBase) tools)["BARDEFAULT"].SharedProps.Enabled = false;
    ((ToolPropsBase) ((ToolsCollectionBase) tools)["EDIT"].SharedProps).Caption = "View";
    ((ToolPropsBase) ((ToolsCollectionBase) tools)["EDIT"].SharedProps).AppearancesSmall.Appearance.Image = (object) Resources.table_go;
    ((ToolPropsBase) ((ToolsCollectionBase) tools)["BAREDIT"].SharedProps).Caption = "View";
    ((ToolPropsBase) ((ToolsCollectionBase) tools)["BAREDIT"].SharedProps).AppearancesSmall.Appearance.Image = (object) Resources.table_go;
  }

  private void DeleteSetting()
  {
    if (((SparseCollectionBase) this.settingsGrid.Selected.Rows).Count == 0)
      return;
    object obj1 = (object) null;
    object obj2 = ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["EntityGUid"].Value;
    formMultiACHSettingsEditor.ActiveRow activeRow;
    if (((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow == null)
      activeRow = formMultiACHSettingsEditor.ActiveRow.Entity;
    else if (((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow.ParentRow == null)
    {
      obj1 = ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["ACHSettingsBankID"].Value;
      activeRow = formMultiACHSettingsEditor.ActiveRow.Bank;
    }
    else
    {
      obj1 = ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["ACHSettingsAccountID"].Value;
      activeRow = formMultiACHSettingsEditor.ActiveRow.Account;
    }
    string text = (string) null;
    string str = (string) null;
    string caption = (string) null;
    List<object> objectList = new List<object>()
    {
      (object) "@EntityGuid",
      obj2
    };
    switch (activeRow)
    {
      case formMultiACHSettingsEditor.ActiveRow.Entity:
        text = "Are you sure you want to delete the setting? This will also delete all the banks and accounts for the entity.";
        caption = "Delete Setting";
        str = "dbo.spFin_DeleteACHSetting_Entity_Grid";
        break;
      case formMultiACHSettingsEditor.ActiveRow.Bank:
        text = "Are you sure you want to delete the bank? This will also delete all the accounts for the bank.";
        caption = "Delete Bank";
        str = "dbo.spFin_DeleteACHSetting_Bank_Grid";
        objectList.Add((object) "@ACHSettingsBankID");
        objectList.Add(obj1);
        break;
      case formMultiACHSettingsEditor.ActiveRow.Account:
        text = "Are you sure you want to delete the account?";
        caption = "Delete Account";
        str = "dbo.spFin_DeleteACHSetting_Account_Grid";
        objectList.Add((object) "@ACHSettingsAccountID");
        objectList.Add(obj1);
        break;
    }
    if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DataSet dataSet = DefaultDatabase.ExecuteDataSet(str, objectList.ToArray());
      if (dataSet.Tables[0].Rows.Count > 0)
      {
        foreach (DataRow row in (InternalDataCollectionBase) dataSet.Tables[0].Rows)
        {
          StringBuilder stringBuilder = new StringBuilder(200);
          stringBuilder.Append("Deleted ACH account setting:" + Environment.NewLine);
          stringBuilder.Append($"   Entity: {ExtensionsMethods.FieldAs<string>(row, "EntityName", DataRowVersion.Current)} ({obj2}){Environment.NewLine}");
          stringBuilder.Append($"   Bank Name: {ExtensionsMethods.FieldAs<string>(row, "BankName", DataRowVersion.Current)}{Environment.NewLine}");
          stringBuilder.Append($"   Account Name: {ExtensionsMethods.FieldAs<string>(row, "AccountName", DataRowVersion.Current)}{Environment.NewLine}");
          CurrentUser.Instance.LogAction(stringBuilder.ToString(), MultiACHSettingsSecurity.LogContext);
        }
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.ReloadSettings();
  }

  private void EditSetting()
  {
    if (((UltraGridBase) this.settingsGrid).ActiveRow == null)
      return;
    Guid guid = (Guid) ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["EntityGuid"].Value;
    formMultiACHSettingsEditor.ActiveRow activeRow = formMultiACHSettingsEditor.ActiveRow.Entity;
    int num = 0;
    if (((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow != null)
    {
      if (((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow.ParentRow == null)
      {
        activeRow = formMultiACHSettingsEditor.ActiveRow.Bank;
        num = (int) ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["ACHSettingsBankID"].Value;
      }
      else
      {
        activeRow = formMultiACHSettingsEditor.ActiveRow.Account;
        num = (int) ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["ACHSettingsAccountID"].Value;
      }
    }
    using (Form form = ObjectFactory.Instance.CreateForm(typeof (formMultiACHSettingsEditor), new object[4]
    {
      (object) guid,
      (object) activeRow,
      (object) num,
      (object) MultiACHSettingsSecurity.CanEditSettings
    }))
    {
      if (form.ShowDialog() != DialogResult.OK)
        return;
      this.ReloadSettings();
    }
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
      DataSet dataSet = DefaultDatabase.ExecuteDataSet(this._getACHSettingsProc);
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
      for (int index = 1; index < 3; ++index)
      {
        if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[index].Columns).Exists("StatusImage"))
        {
          UltraGridColumn ultraGridColumn = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[index].Columns.Add("StatusImage", string.Empty);
          ultraGridColumn.AllowRowFiltering = (DefaultableBoolean) 2;
          ultraGridColumn.DataType = typeof (Image);
          ((HeaderBase) ultraGridColumn.Header).VisiblePosition = 0;
          ultraGridColumn.Hidden = false;
          ultraGridColumn.SortIndicator = (SortIndicator) 0;
          ultraGridColumn.Width = 35;
        }
      }
      foreach (UltraGridRow row1 in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (r => (IEnumerable<UltraGridRow>) r.ChildBands[0].Rows)))
      {
        row1.Cells["SWIFTCode"].Value = (object) MultiACHSettingsSecurity.Decrypt(row1.Cells["SWIFTCode"].Value);
        row1.Cells["SWIFTCodeMasked"].Value = (object) row1.Cells["SWIFTCode"].Value.ToString().TruncateToLastFour();
        row1.Cells["SortCode"].Value = (object) MultiACHSettingsSecurity.Decrypt(row1.Cells["SortCode"].Value);
        row1.Cells["SortCodeMasked"].Value = (object) row1.Cells["SortCode"].Value.ToString().TruncateToLastFour();
        row1.Cells["DateEntered"].Value = (object) DateTime.SpecifyKind(DateTime.Parse(row1.Cells["DateEntered"].Value.ToString()), DateTimeKind.Utc).ToLocalTime();
        formMultiACHSettingsManagement.SetPendingApprovalColumn(row1);
        if (row1.ChildBands.HasChildRows)
        {
          foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
          {
            row2.Cells["AccountNumber"].Value = (object) MultiACHSettingsSecurity.Decrypt(row2.Cells["AccountNumber"].Value);
            row2.Cells["AccountNumberMasked"].Value = (object) row2.Cells["AccountNumber"].Value.ToString().TruncateToLastFour();
            row2.Cells["AccountType"].Value = (object) formMultiACHSettingsManagement.GetAccountType(row2.Cells["AccountType"].Value);
            row2.Cells["CHIPNumber"].Value = (object) MultiACHSettingsSecurity.Decrypt(row2.Cells["CHIPNumber"].Value);
            row2.Cells["IBAN"].Value = (object) MultiACHSettingsSecurity.Decrypt(row2.Cells["IBAN"].Value);
            row2.Cells["IBANMasked"].Value = (object) row2.Cells["IBAN"].Value.ToString().TruncateToLastFour();
            formMultiACHSettingsManagement.SetPendingApprovalColumn(row2);
            formMultiACHSettingsManagement.SetDefaultColumn(row2);
          }
        }
      }
      ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[0].Columns["EntityName"].SortIndicator = (SortIndicator) 1;
      ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns["BankName"].SortIndicator = (SortIndicator) 1;
      ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[2].Columns["AccountName"].SortIndicator = (SortIndicator) 1;
      ((UltraControlBase) this.settingsGrid).EndUpdate();
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.settingsGrid).Rows).Count > 0)
        this.SelectRow(((UltraGridBase) this.settingsGrid).Rows[0]);
      ((ToolsCollectionBase) this.ultraToolbarsManager.Tools)["BARDEFAULT"].SharedProps.Enabled = false;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void NewSetting()
  {
    using (formMultiACHSettingsEditor form = (formMultiACHSettingsEditor) ObjectFactory.Instance.CreateForm(typeof (formMultiACHSettingsEditor)))
    {
      switch (form.ShowDialog())
      {
        case DialogResult.OK:
          this.ReloadSettings();
          break;
        case DialogResult.Abort:
          if (!(form.OpenEntity != Guid.Empty))
            break;
          this.DisplayExistingEditor(form);
          break;
      }
    }
  }

  private void DisplayExistingEditor(formMultiACHSettingsEditor editor)
  {
    using (Form form = ObjectFactory.Instance.CreateForm(typeof (formMultiACHSettingsEditor), new object[2]
    {
      (object) editor.OpenEntity,
      (object) formMultiACHSettingsEditor.ActiveRow.Entity
    }))
    {
      if (form.ShowDialog() != DialogResult.OK)
        return;
      this.ReloadSettings();
    }
  }

  private void ReloadSettings()
  {
    HashSet<object> expandedEntityRows = new HashSet<object>(((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => r.Expanded)).Select<UltraGridRow, object>((System.Func<UltraGridRow, object>) (r => r.Cells["EntityGuid"].Value)));
    HashSet<object> expandedBankRows = new HashSet<object>(((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (r => (IEnumerable<UltraGridRow>) r.ChildBands[0].Rows)).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (cr => cr.Expanded)).Select<UltraGridRow, object>((System.Func<UltraGridRow, object>) (cr => cr.Cells["ACHSettingsBankID"].Value)));
    object activeRowId = (object) null;
    formMultiACHSettingsEditor.ActiveRow activeRow = formMultiACHSettingsEditor.ActiveRow.None;
    if (((UltraGridBase) this.settingsGrid).ActiveRow != null)
    {
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
    this.LoadMissingBanks();
    ((UltraControlBase) this.settingsGrid).EndUpdate();
  }

  private void SelectRow(UltraGridRow row)
  {
    this.settingsGrid.Selected.Rows.Clear();
    this.settingsGrid.Selected.Rows.Add(row);
    ((UltraGridBase) this.settingsGrid).ActiveRow = row;
  }

  private static void SetDefaultColumn(UltraGridRow row)
  {
    if (!(bool) row.Cells["IsDefault"].Value)
      return;
    if ((bool) row.Cells["IsApproved"].Value)
    {
      row.Cells["StatusImage"].Value = (object) Resources.accept;
      row.Cells["StatusImage"].ToolTipText = "Default Account";
    }
    else
    {
      row.Cells["StatusImage"].Value = (object) Resources.pendingdefault;
      row.Cells["StatusImage"].ToolTipText = "Default Account, Pending Approval";
    }
    if ((bool) row.ParentRow.Cells["IsApproved"].Value)
    {
      row.ParentRow.Cells["StatusImage"].Value = (object) Resources.accept;
      row.ParentRow.Cells["StatusImage"].ToolTipText = "Default Bank";
    }
    else
    {
      row.ParentRow.Cells["StatusImage"].Value = (object) Resources.pendingdefault;
      row.ParentRow.Cells["StatusImage"].ToolTipText = "Default Bank, Pending Approval";
    }
  }

  private void SetDefaultSetting()
  {
    if (((SparseCollectionBase) this.settingsGrid.Selected.Rows).Count == 0 || this.settingsGrid.Selected.Rows[0].ParentRow == null)
      return;
    if (this.settingsGrid.Selected.Rows[0].Cells["IsDefault"].Value.Equals((object) true))
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      object obj1 = this.settingsGrid.Selected.Rows[0].Cells["EntityGuid"].Value;
      object obj2 = this.settingsGrid.Selected.Rows[0].Cells["ACHSettingsAccountID"].Value;
      DataSet dataSet = DefaultDatabase.ExecuteDataSet("dbo.spFin_SetDefaultACHSetting_Account", new object[6]
      {
        (object) "@EntityGuid",
        obj1,
        (object) "@ACHSettingsAccountID",
        obj2,
        (object) "@EnteredBy",
        (object) CurrentUser.Instance.UserGUID
      });
      if (dataSet.Tables[0].Rows.Count > 0)
      {
        foreach (DataRow row in (InternalDataCollectionBase) dataSet.Tables[0].Rows)
        {
          bool flag = ExtensionsMethods.FieldAs<bool>(row, "IsDefault", DataRowVersion.Current);
          StringBuilder stringBuilder = new StringBuilder(200);
          stringBuilder.Append("Updated ACH account setting:" + Environment.NewLine);
          stringBuilder.Append($"   Entity: {ExtensionsMethods.FieldAs<string>(row, "EntityName", DataRowVersion.Current)} ({obj1}){Environment.NewLine}");
          stringBuilder.Append($"   Bank Name: {ExtensionsMethods.FieldAs<string>(row, "BankName", DataRowVersion.Current)}{Environment.NewLine}");
          stringBuilder.Append($"   Account Name: {ExtensionsMethods.FieldAs<string>(row, "AccountName", DataRowVersion.Current)}{Environment.NewLine}");
          stringBuilder.Append($"   IsDefault: {flag} (original: {!flag}){Environment.NewLine}");
          CurrentUser.Instance.LogAction(stringBuilder.ToString(), MultiACHSettingsSecurity.LogContext);
        }
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.ReloadSettings();
  }

  private static void SetPendingApprovalColumn(UltraGridRow row)
  {
    if ((bool) row.Cells["IsApproved"].Value)
      return;
    row.Cells["StatusImage"].Value = (object) Resources.error;
    row.Cells["StatusImage"].ToolTipText = "Pending Approval";
    foreach (UltraGridCell cell in row.Cells)
      ((AppearanceBase) cell.Appearance).ForeColor = Color.DimGray;
  }

  private void ShowApprovals()
  {
    using (Form form = ObjectFactory.Instance.CreateForm(typeof (formMultiACHSettingsPending)))
    {
      int num = (int) form.ShowDialog();
      this.ReloadSettings();
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
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("PayMethodID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("IsDefault");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("IsApproved");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Currency");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraToolbar ultraToolbar1 = new UltraToolbar("gridContext");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("gridContext");
    UltraToolbar ultraToolbar2 = new UltraToolbar("mainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("BARNEW");
    ButtonTool buttonTool2 = new ButtonTool("BAREDIT");
    ButtonTool buttonTool3 = new ButtonTool("BARDELETE");
    ButtonTool buttonTool4 = new ButtonTool("BARDEFAULT");
    ButtonTool buttonTool5 = new ButtonTool("BARPENDING");
    ButtonTool buttonTool6 = new ButtonTool("UnmappedPayees");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("gridContext");
    ButtonTool buttonTool7 = new ButtonTool("EDIT");
    ButtonTool buttonTool8 = new ButtonTool("DELETE");
    ButtonTool buttonTool9 = new ButtonTool("DEFAULT");
    ButtonTool buttonTool10 = new ButtonTool("EDIT");
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formMultiACHSettingsManagement));
    ButtonTool buttonTool11 = new ButtonTool("DELETE");
    Appearance appearance11 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("BARNEW");
    Appearance appearance12 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("BAREDIT");
    Appearance appearance13 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("DEFAULT");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ButtonTool buttonTool15 = new ButtonTool("BARDELETE");
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool16 = new ButtonTool("BARDEFAULT");
    Appearance appearance17 = new Appearance();
    ButtonTool buttonTool17 = new ButtonTool("BARPENDING");
    Appearance appearance18 = new Appearance();
    ButtonTool buttonTool18 = new ButtonTool("UnmappedPayees");
    Appearance appearance19 = new Appearance();
    this.gridPanel = new Panel();
    this.settingsGrid = new UltraGrid();
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager = new UltraToolbarsManager(this.components);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
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
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 132;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 1;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 158;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Bank Name";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Width = 216;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "SWIFT Code";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 3;
    ultraGridColumn7.Width = 213;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 5;
    ultraGridColumn8.Width = 213;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 6;
    ultraGridColumn9.Width = 205;
    ultraGridColumn10.CellActivation = (Activation) 3;
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
    ultraGridColumn12.Width = 205;
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
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 76;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 1;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 94;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 2;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 66;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 3;
    ultraGridColumn16.Width = 101;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Alternative Payee";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 6;
    ultraGridColumn17.Width = 116;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 4;
    ultraGridColumn18.Width = 118;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 5;
    ultraGridColumn19.Width = 93;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 7;
    ultraGridColumn20.Width = 93;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "CHIP Number";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 8;
    ultraGridColumn21.Width = 107;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Payment Format";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 9;
    ultraGridColumn22.Width = 105;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 11;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 78;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 12;
    ultraGridColumn24.Width = 100;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 13;
    ultraGridColumn25.Width = 100;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 14;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 84;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 15;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 84;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 10;
    ultraGridColumn28.Width = 100;
    ultraGridBand3.Columns.AddRange(new object[16 /*0x10*/]
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
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28
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
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
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
    this.settingsGrid.AfterRowActivate += new EventHandler(this.settingsGrid_AfterRowActivate);
    this.settingsGrid.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(this.settingsGrid_BeforeRowsDeleted);
    this.settingsGrid.DoubleClickRow += new DoubleClickRowEventHandler(this.settingsGrid_DoubleClickRow);
    ((Control) this.settingsGrid).MouseDown += new MouseEventHandler(this.settingsGrid_MouseDown);
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 45);
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left).Name = "_formMultiACHSettingsManagement_Toolbars_Dock_Area_Left";
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 467);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager;
    this.ultraToolbarsManager.DesignerFlags = 1;
    this.ultraToolbarsManager.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager.MdiMergeable = false;
    this.ultraToolbarsManager.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 1;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar1.Text = "gridContext";
    ultraToolbar1.Visible = false;
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 0;
    ultraToolbar2.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar2).NonInheritedTools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ultraToolbar2.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar2.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar2.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar2.Text = "mainToolbar";
    this.ultraToolbarsManager.Toolbars.AddRange(new UltraToolbar[2]
    {
      ultraToolbar1,
      ultraToolbar2
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "gridContext";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9
    });
    ((AppearanceBase) appearance10).Image = componentResourceManager.GetObject("appearance1.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Edit ACH Setting";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance11).Image = componentResourceManager.GetObject("appearance2.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Delete ACH Setting";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance12).Image = (object) Resources.add;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "New";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance13).Image = (object) Resources.pencil;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Edit";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance14).Image = (object) Resources.accept;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).Image = (object) Resources.accept;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Set as Default";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance16).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Delete";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance17).Image = (object) Resources.accept;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Set Default";
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance18).Image = (object) Resources.table_add;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "Pending Approval";
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance19).Image = (object) Resources.book_add;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "Unmapped Payees";
    ((ToolBase) buttonTool18).SharedPropsInternal.CustomizerCaption = "Unmapped Payees";
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools).AddRange(new ToolBase[10]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18
    });
    this.ultraToolbarsManager.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager_ToolClick);
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right).Location = new Point(1109, 45);
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right).Name = "_formMultiACHSettingsManagement_Toolbars_Dock_Area_Right";
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 467);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top).Name = "_formMultiACHSettingsManagement_Toolbars_Dock_Area_Top";
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top).Size = new Size(1109, 45);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 512 /*0x0200*/);
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom).Name = "_formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom).Size = new Size(1109, 0);
    this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager;
    this.ClientSize = new Size(1109, 512 /*0x0200*/);
    this.Controls.Add((Control) this.gridPanel);
    this.Controls.Add((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formMultiACHSettingsManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formMultiACHSettingsManagement);
    this.Text = "ACH Settings Management";
    this.Load += new EventHandler(this.formMultiACHSettingsManagement_Load);
    this.gridPanel.ResumeLayout(false);
    ((ISupportInitialize) this.settingsGrid).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager).EndInit();
    this.ResumeLayout(false);
  }
}
