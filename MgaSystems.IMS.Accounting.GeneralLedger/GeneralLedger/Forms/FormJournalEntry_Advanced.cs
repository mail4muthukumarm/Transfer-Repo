// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.FormJournalEntry_Advanced
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.GeneralLedger.JournalEntry_Advanced;
using MGASystems.IMS.Accounting.GeneralLedger.Properties;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.Services.Forms;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[SecureResource("{C2FD50F8-2B5C-44b6-A521-12EA29B24FC1}", "Journal Entry Entry Rights", "Determines whether or not a user has the ability to enter journal entries in the IMS.", "Accounting")]
public class FormJournalEntry_Advanced : FormBase
{
  internal static string REVERSALENTRIES_ENABLED = nameof (REVERSALENTRIES_ENABLED);
  private static string SHOWMSG = "JOURNALENTRY_SAVETEMPLATEMESSAGE";
  private bool _reversalEnabled;
  protected int _glCompanyId;
  private int _transactNum;
  protected int templateId;
  private IContainer components;
  private Panel FormJournalEntry_Advanced_Fill_Panel;
  private UltraToolbarsDockArea _FormJournalEntry_Advanced_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormJournalEntry_Advanced_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormJournalEntry_Advanced_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom;
  protected dsJournalEntryAdvanced dsJournalEntryAdvanced1;
  protected UltraToolbarsManager ultraToolbarsManager1;
  protected UltraGrid gridJournalEntry;
  protected dsGLAccountList dsGLAccountList1;
  protected HelpProvider helpProvider1;
  protected UltraDropDown dropDownGLAccountList;
  protected MGASimpleComboBox comboGLCompanyId;
  protected UltraDropDown dropDownCostCenters;
  protected MGASimpleComboBox comboCurrencyCode;
  private ucReversalDate ucReversalDate1;

  protected int GLCompanyId
  {
    get => this._glCompanyId;
    set => this._glCompanyId = value;
  }

  protected int TransactNum
  {
    get => this._transactNum;
    set => this._transactNum = value;
  }

  public FormJournalEntry_Advanced() => this.InitializeComponent();

  private void FormJournalEntry_Advanced_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadGLCompanies();
    this.helpProvider1.HelpNamespace = "IMSAccountingHelp.chm";
    this._reversalEnabled = SystemSettings.KeyExists(FormJournalEntry_Advanced.REVERSALENTRIES_ENABLED) && SystemSettings.GetBoolSetting(FormJournalEntry_Advanced.REVERSALENTRIES_ENABLED);
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["labelReversal"].SharedProps.Visible = this._reversalEnabled;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["REVERSAL"].SharedProps.Visible = this._reversalEnabled;
  }

  protected virtual void LoadGLCompanies()
  {
    DataSet officeLocationDataset = (DataSet) Methods.GetOfficeLocationDataset();
    ((UltraGridBase) this.comboGLCompanyId).DataSource = (object) officeLocationDataset;
    ((UltraDropDownBase) this.comboGLCompanyId).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboGLCompanyId).ValueMember = "ID";
    this.comboGLCompanyId.Value = officeLocationDataset.Tables[0].Rows[0]["ID"];
    this._glCompanyId = (int) officeLocationDataset.Tables[0].Rows[0]["ID"];
    this.LoadGLAccounts(this._glCompanyId);
  }

  protected void LoadGLAccounts(int glCompanyId)
  {
    this.dsGLAccountList1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsGLAccountList1, new string[1]
    {
      "Accounts"
    }, "spFin_GetGLAccountList", new object[2]
    {
      (object) "@GLCompanyId",
      (object) glCompanyId
    });
    ((UltraGridBase) this.dropDownGLAccountList).DataSource = (object) this.dsGLAccountList1;
  }

  private void comboGLCompanyId_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboGLCompanyId).SelectedRow == null)
      return;
    if ((int) this.comboGLCompanyId.Value != this._glCompanyId && ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridJournalEntry).Rows).Count != 0)
    {
      if (MessageBox.Show("Changing the office location will result in loss of all detail items, do you wish to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
      {
        this.dsJournalEntryAdvanced1.Clear();
        this._glCompanyId = (int) this.comboGLCompanyId.Value;
      }
      else
      {
        this.comboGLCompanyId.EventManager.SetEnabled((ComboEventIds) 7, false);
        this.comboGLCompanyId.Value = (object) this._glCompanyId;
        this.comboGLCompanyId.EventManager.SetEnabled((ComboEventIds) 7, true);
      }
    }
    else
      this._glCompanyId = (int) this.comboGLCompanyId.Value;
    this.LoadGLAccounts(this._glCompanyId);
    this.LoadCostCenters(this._glCompanyId);
    this.LoadCurrencyCode();
  }

  protected void LoadCostCenters(int glCompanyId)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spfin_GetCostCentersList", new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyId
    });
    dataTable.Rows.Add((object) 99999, (object) "Multiple...");
    ((UltraGridBase) this.dropDownCostCenters).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.dropDownCostCenters).DisplayMember = "Name";
    ((UltraDropDownBase) this.dropDownCostCenters).ValueMember = "CostCenterId";
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Bands[0].Columns["CostCenterId"].Hidden = true;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Bands[0].Columns["Name"].Width = 200;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Bands[0].ColHeadersVisible = false;
  }

  protected virtual void gridJournalEntry_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (((KeyedSubObjectBase) e.Cell.Column).Key == "GLAcctId")
    {
      if (e.Cell.Row.HasChild())
      {
        foreach (UltraGridRow ultraGridRow in (UltraGridRow[]) ((SubObjectsCollectionBase) e.Cell.Row.ChildBands[0].Rows).All)
          ultraGridRow.Delete(false);
        ((UltraGridBase) this.gridJournalEntry).UpdateData();
      }
      e.Cell.Row.ExpandAll();
    }
    if (((KeyedSubObjectBase) e.Cell.Column).Key == "Debit" || ((KeyedSubObjectBase) e.Cell.Column).Key == "Credit")
    {
      List<Allocation> allocationList1 = new List<Allocation>();
      if (e.Cell.Row.Cells["AllocationSplits"].Value != null && e.Cell.Row.Cells["AllocationSplits"].Value != DBNull.Value)
      {
        List<Allocation> allocationList2 = (List<Allocation>) e.Cell.Row.Cells["AllocationSplits"].Value;
        if (allocationList2.Count == 1)
        {
          allocationList2[0].AllocatedAmount = (Decimal) e.Cell.Value;
          allocationList2[0].Percentage = new Decimal?((Decimal) 1);
        }
        else
        {
          e.Cell.Row.Cells["AllocationSplits"].Value = (object) null;
          e.Cell.Row.Cells["Allocations"].Value = (object) -1;
        }
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Allocation");
        stringBuilder.AppendLine("Allocated Amount: ");
        stringBuilder.Append(allocationList2[0].AllocatedAmount.ToString());
      }
    }
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "Percentage") || e.Cell.Value == null || e.Cell.Value == DBNull.Value)
      return;
    object obj1 = e.Cell.Row.ParentRow.Cells["Debit"].Value;
    object obj2 = e.Cell.Row.ParentRow.Cells["Credit"].Value;
    if (obj1 == null || obj1 == DBNull.Value)
      obj1 = (object) 0M;
    if (obj2 == null || obj2 == DBNull.Value)
      obj2 = (object) 0M;
    Decimal num = !((Decimal) obj2 == 0M) ? (Decimal) obj2 * (Decimal) e.Cell.Value : (Decimal) obj1 * (Decimal) e.Cell.Value;
    e.Cell.Row.Cells["Amount"].Value = (object) num;
    e.Cell.Row.Update();
  }

  private void gridJournalEntry_AfterRowUpdate(object sender, RowEventArgs e)
  {
  }

  protected void ShowAllocationsIndicator(UltraGridRow row)
  {
  }

  private void gridJournalEntry_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (((GridItemBase) e.Row).Band.Index != 0)
      return;
    object obj1 = e.Row.Cells["Debit"].Value;
    object obj2 = e.Row.Cells["Credit"].Value;
    if ((obj1 == null || obj1 == DBNull.Value) && (obj2 == null || obj2 == DBNull.Value))
    {
      int num = (int) MessageBox.Show("You must specify a debit or credit amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (obj1 == null || obj1 == DBNull.Value)
        obj1 = (object) 0M;
      if (obj2 == null || obj2 == DBNull.Value)
        obj2 = (object) 0M;
      if (!((Decimal) obj1 != 0M) || !((Decimal) obj2 != 0M))
        return;
      int num = (int) MessageBox.Show("You can only specify a debit amount or credit amount. You can not specify both a debit and a credit amount on the same line.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    this.gridJournalEntry.PerformAction((UltraGridAction) 44);
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 4:
        switch (key[0])
        {
          case 'H':
            if (!(key == "Help"))
              return;
            Help.ShowHelp((Control) this, "imsaccountinghelp.chm", HelpNavigator.Topic, (object) "addingasimplejournalentry.htm");
            return;
          case 'L':
            if (!(key == "LOAD"))
              return;
            this.LoadTemplate();
            return;
          case 'P':
            if (!(key == "POST"))
              return;
            this.PostJournalEntry();
            return;
          case 'S':
            if (!(key == "SAVE"))
              return;
            if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridJournalEntry).Rows).Count == 0)
            {
              int num = (int) MessageBox.Show("You must enter GL account rows to continue.", "No Entries Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            this.SaveTemplate();
            return;
          default:
            return;
        }
      case 5:
        if (!(key == "Print"))
          break;
        this.gridJournalEntry.PrintPreview(((UltraGridBase) this.gridJournalEntry).DisplayLayout, new PrintDocument(), (RowPropertyCategories) 0);
        break;
      case 6:
        switch (key[4])
        {
          case 'E':
            if (!(key == "CANCEL"))
              return;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            return;
          case 'R':
            if (!(key == "IMPORT"))
              return;
            this.ImportTemplate();
            return;
          case 'c':
            if (!(key == "Legacy"))
              return;
            int num1 = (int) new formLedgerEntryWizard().ShowDialog();
            return;
          case 'n':
            if (!(key == "Expand"))
              return;
            ((UltraGridBase) this.gridJournalEntry).Rows.ExpandAll(true);
            return;
          case 'r':
            int num2 = key == "Export" ? 1 : 0;
            return;
          default:
            return;
        }
      case 7:
        int num3 = key == "CONVERT" ? 1 : 0;
        break;
      case 8:
        if (!(key == "Collapse"))
          break;
        ((UltraGridBase) this.gridJournalEntry).Rows.CollapseAll(true);
        break;
      case 11:
        if (!(key == "Delete Line") || ((UltraGridBase) this.gridJournalEntry).ActiveRow == null)
          break;
        ((UltraGridBase) this.gridJournalEntry).ActiveRow.Delete();
        break;
    }
  }

  protected virtual void LoadTemplate()
  {
    using (FormJournalEntryTemplates journalEntryTemplates = new FormJournalEntryTemplates(true))
    {
      if (journalEntryTemplates.ShowDialog() != DialogResult.OK)
        return;
      this.dsJournalEntryAdvanced1.Clear();
      this.templateId = journalEntryTemplates.SelectedTemplateId;
      DataSet dataSet = DefaultDatabase.ExecuteDataSet("spFin_GetJournalEntryTemplate", new object[2]
      {
        (object) "@TemplateId",
        (object) journalEntryTemplates.SelectedTemplateId
      });
      this._glCompanyId = (int) dataSet.Tables[0].Rows[0]["GLCompanyId"];
      this.comboGLCompanyId.Value = (object) this._glCompanyId;
      this.LoadGLAccounts(this._glCompanyId);
      this.gridJournalEntry.EventManager.SetEnabled((EventGroups) 0, false);
      foreach (DataRow row1 in (InternalDataCollectionBase) dataSet.Tables[1].Rows)
      {
        dsJournalEntryAdvanced.GLAccountListingRow row2 = this.dsJournalEntryAdvanced1.GLAccountListing.NewGLAccountListingRow();
        row2.RowId = (int) row1["TemplateDetailId"];
        row2.GLAcctId = (int) row1["glacctid"];
        if (row1["comment"] != DBNull.Value)
          row2.Comment = row1["Comment"].ToString();
        if (row1["debit"] == DBNull.Value)
          row2.Credit = (Decimal) row1["credit"];
        else
          row2.Debit = (Decimal) row1["debit"];
        List<Allocation> allocationList = new List<Allocation>();
        DataRow[] dataRowArray = dataSet.Tables[2].Select($"TemplateDetailId = {(int) row1["TemplateDetailId"]}");
        if (dataRowArray.Length != 0)
        {
          for (int index = 0; index < dataRowArray.Length; ++index)
          {
            Allocation allocation = new Allocation();
            allocation.CostCenterId = (int) dataRowArray[index]["CostCenterId"];
            if (dataRowArray[index]["Percentage"] != DBNull.Value)
              allocation.Percentage = new Decimal?((Decimal) dataRowArray[index]["Percentage"]);
            allocation.AllocatedAmount = (Decimal) dataRowArray[index]["Amount"];
            allocationList.Add(allocation);
          }
        }
        row2.AllocationSplits = (object) allocationList;
        row2.Allocations = dataRowArray.Length <= 1 ? ((DataTable) ((UltraGridBase) this.dropDownCostCenters).DataSource).Select($"CostCenterId = {dataRowArray[0]["CostCenterId"]}")[0]["Name"].ToString() : "Multiple...";
        this.dsJournalEntryAdvanced1.GLAccountListing.AddGLAccountListingRow(row2);
      }
      this.gridJournalEntry.EventManager.SetEnabled((EventGroups) 0, true);
    }
  }

  protected void CommitGridChanges() => this.gridJournalEntry.PerformAction((UltraGridAction) 47);

  protected virtual void SaveTemplate()
  {
    this.CommitGridChanges();
    if (!this.VerifyEntry())
      return;
    using (FormJournalEntryTemplates f = new FormJournalEntryTemplates(false))
    {
      if (f.ShowDialog() != DialogResult.OK)
        return;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
      {
        int templateId = int.Parse(DefaultDatabase.ExecuteScalar("spFin_InsertJournalEntryTemplate", new object[8]
        {
          (object) "@UserGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@GLCompanyId",
          (object) this._glCompanyId,
          (object) "@IsPrivate",
          (object) f.IsPrivate,
          (object) "@TemplateName",
          (object) f.TemplateName
        }).ToString());
        foreach (UltraGridRow row in ((UltraGridBase) this.gridJournalEntry).Rows)
        {
          if (!row.IsTemplateAddRow && !row.IsUnmodifiedTemplateAddRow && row.Cells["glacctid"].Value != DBNull.Value)
          {
            int templateDetailId = int.Parse(DefaultDatabase.ExecuteScalar("spFin_InsertJournalEntryTemplateDetail", new object[10]
            {
              (object) "@Templateid",
              (object) templateId,
              (object) "@GLAcctId",
              row.Cells["GLAcctId"].Value,
              (object) "@Comment",
              row.Cells["Comment"].Value,
              (object) "@Debit",
              row.Cells["Debit"].Value == DBNull.Value || row.Cells["Debit"].Value == null ? (object) SqlMoney.Null : row.Cells["Debit"].Value,
              (object) "@Credit",
              row.Cells["Credit"].Value == DBNull.Value || row.Cells["Credit"].Value == null ? (object) SqlMoney.Null : row.Cells["Credit"].Value
            }).ToString());
            this.OnTemplateDetailSaved(templateId, templateDetailId, row);
            List<Allocation> allocationList1 = new List<Allocation>();
            List<Allocation> allocationList2 = (List<Allocation>) row.Cells["AllocationSplits"].Value;
            for (int index = 0; index < allocationList2.Count; ++index)
              DefaultDatabase.ExecuteNonQuery("spFin_InsertJournalEntryTemplateDetailAllocation", new object[10]
              {
                (object) "@Templateid",
                (object) templateId,
                (object) "@TemplateDetailId",
                (object) templateDetailId,
                (object) "@CostCenterId",
                (object) allocationList2[index].CostCenterId,
                (object) "@Amount",
                (object) allocationList2[index].AllocatedAmount,
                (object) "@Percentage",
                (object) allocationList2[index].Percentage
              });
          }
        }
        e.Transaction.Commit();
      }));
    }
  }

  protected event FormJournalEntry_Advanced.TemplateDetailSavedHandler TemplateDetailSaved;

  protected void OnTemplateDetailSaved(int templateId, int templateDetailId, UltraGridRow gridRow)
  {
    if (this.TemplateDetailSaved == null)
      return;
    this.TemplateDetailSaved(templateId, templateDetailId, gridRow);
  }

  protected virtual void ImportTemplate()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridJournalEntry).Rows).Count != 0 && MessageBox.Show("Importing a new journal entry will clear all unsaved changes, continue?", "Clear Unsaved Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      openFileDialog.Filter = "Excel Files (97-2003) *.xls|*.xls|Excel Files (*.xlsx)|*.xlsx";
      StringBuilder stringBuilder = new StringBuilder();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      Workbook workbook = new Workbook(openFileDialog.FileName);
      using (FormImportJournalEntry form = (FormImportJournalEntry) ObjectFactory.Instance.CreateForm(typeof (FormImportJournalEntry), new object[2]
      {
        (object) openFileDialog.FileName,
        (object) workbook
      }))
      {
        if (form.ShowDialog() != DialogResult.OK)
          return;
        this._glCompanyId = form.GLCompanyId;
        this.comboGLCompanyId.Value = (object) this._glCompanyId;
        string str = string.Empty;
        string costCenterName = string.Empty;
        this.dsJournalEntryAdvanced1.Clear();
        for (int index = 0; index < workbook.Worksheets[form.WorksheetName].Cells.MaxDataRow; ++index)
        {
          int intValue = workbook.Worksheets[form.WorksheetName].Cells[form.FirstRowColumnNames ? index + 1 : index, form.GLAccountColumn].IntValue;
          if (form.CommentColumn != -1)
            str = workbook.Worksheets[form.WorksheetName].Cells[form.FirstRowColumnNames ? index + 1 : index, form.CommentColumn].StringValue;
          if (form.CostCenterColumn != -1)
            costCenterName = workbook.Worksheets[form.WorksheetName].Cells[form.FirstRowColumnNames ? index + 1 : index, form.CostCenterColumn].StringValue;
          Decimal doubleValue1 = workbook.Worksheets[form.WorksheetName].Cells[form.FirstRowColumnNames ? index + 1 : index, form.DebitAmountColumn].Value != null ? (Decimal) workbook.Worksheets[form.WorksheetName].Cells[form.FirstRowColumnNames ? index + 1 : index, form.DebitAmountColumn].DoubleValue : 0M;
          Decimal doubleValue2 = workbook.Worksheets[form.WorksheetName].Cells[form.FirstRowColumnNames ? index + 1 : index, form.CreditAmountColumn].Value != null ? (Decimal) workbook.Worksheets[form.WorksheetName].Cells[form.FirstRowColumnNames ? index + 1 : index, form.CreditAmountColumn].DoubleValue : 0M;
          if (!(doubleValue1 == 0M) || !(doubleValue2 == 0M))
          {
            if (doubleValue1 != 0M && doubleValue2 != 0M)
            {
              stringBuilder.Append("The system cannot import both a credit amount and a debit amount on the same line for GL account ");
              stringBuilder.Append(intValue.ToString());
              stringBuilder.AppendLine(".");
            }
            else
            {
              DataRow[] glAccountRows = this.GetGLAccountRows(intValue);
              DataRow[] dataRowArray = (DataRow[]) null;
              if (!string.IsNullOrEmpty(costCenterName))
                dataRowArray = (((UltraGridBase) this.dropDownCostCenters).DataSource as DataTable).Select($"Name = '{costCenterName}'");
              if (glAccountRows.Length != 0)
              {
                dsJournalEntryAdvanced.GLAccountListingRow row = this.dsJournalEntryAdvanced1.GLAccountListing.NewGLAccountListingRow();
                row.GLAcctId = (int) glAccountRows[0]["glacctid"];
                row.Comment = str;
                if (doubleValue1 != 0M)
                  row.Debit = doubleValue1;
                if (doubleValue2 != 0M)
                  row.Credit = doubleValue2;
                if (!string.IsNullOrEmpty(costCenterName) && dataRowArray != null && dataRowArray.Length != 0)
                {
                  row.Allocations = costCenterName;
                  row.AllocationSplits = (object) new List<Allocation>()
                  {
                    new Allocation(costCenterName, (int) dataRowArray[0]["costCenterId"], doubleValue1 == 0M ? doubleValue2 : doubleValue1)
                  };
                }
                this.dsJournalEntryAdvanced1.GLAccountListing.AddGLAccountListingRow(row);
              }
              else
              {
                stringBuilder.Append("The system could not find GL account number ");
                stringBuilder.Append(intValue.ToString());
                stringBuilder.AppendLine(".");
              }
            }
          }
        }
        foreach (UltraGridRow row in ((UltraGridBase) this.gridJournalEntry).Rows)
        {
          ((UltraGridBase) this.gridJournalEntry).UpdateData();
          this.ShowAllocationsIndicator(row);
        }
        ((UltraGridBase) this.gridJournalEntry).Rows.CollapseAll(true);
        if (stringBuilder.Length <= 0)
          return;
        using (FormImportErrors formImportErrors = new FormImportErrors(stringBuilder.ToString()))
        {
          int num = (int) formImportErrors.ShowDialog();
        }
      }
    }
  }

  protected virtual DataRow[] GetGLAccountRows(int value)
  {
    return this.dsGLAccountList1.Accounts.Select($"AcctNum = '{value}'");
  }

  private void PostJournalEntry()
  {
    if (!this.VerifyEntry())
      return;
    using (FormPostJournalEntry postJournalEntry = new FormPostJournalEntry())
    {
      if (postJournalEntry.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.Post(postJournalEntry.PostDate, postJournalEntry.PostingComments);
        if (SystemSettings.KeyExists(FormJournalEntry_Advanced.SHOWMSG) && SystemSettings.GetBoolSetting(FormJournalEntry_Advanced.SHOWMSG) && MessageBox.Show("Would you like to save this entry as a template?", "Save Template?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          this.SaveTemplate();
        this.ClearScreen();
      }
      catch
      {
        throw;
      }
    }
  }

  protected virtual void Post(DateTime postDate, string postingComments)
  {
    string currencyCode = this.comboCurrencyCode.Value.ToString();
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      try
      {
        this.TransactNum = (int) DefaultDatabase.ExecuteScalar("spFin_PostJournalEntry_Header", new object[8]
        {
          (object) "@postDate",
          (object) postDate,
          (object) "@comments",
          (object) postingComments,
          (object) "@userGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@GLCompanyId",
          (object) this._glCompanyId
        });
        foreach (UltraGridRow row in ((UltraGridBase) this.gridJournalEntry).Rows)
        {
          if (row.Cells["debit"].Value != DBNull.Value && !((Decimal) row.Cells["debit"].Value == 0M) || row.Cells["credit"].Value != DBNull.Value && !((Decimal) row.Cells["credit"].Value == 0M))
          {
            bool flag;
            object obj;
            if (row.Cells["debit"].Value != DBNull.Value && (Decimal) row.Cells["debit"].Value != 0M)
            {
              flag = false;
              obj = DefaultDatabase.ExecuteScalar("spFin_PostJournalEntry_Detail", new object[12]
              {
                (object) "@transactNum",
                (object) this.TransactNum,
                (object) "@glAcctId",
                row.Cells["GLAcctId"].Value,
                (object) "@comment",
                row.Cells["comment"].Value,
                (object) "@amount",
                row.Cells["Debit"].Value,
                (object) "@currencyCode",
                (object) currencyCode,
                (object) "@GLCompanyId",
                (object) this._glCompanyId
              });
            }
            else
            {
              flag = true;
              obj = DefaultDatabase.ExecuteScalar("spFin_PostJournalEntry_Detail", new object[12]
              {
                (object) "@transactNum",
                (object) this.TransactNum,
                (object) "@glAcctId",
                row.Cells["GLAcctId"].Value,
                (object) "@comment",
                row.Cells["comment"].Value,
                (object) "@amount",
                (object) ((Decimal) row.Cells["credit"].Value * -1M),
                (object) "@currencyCode",
                (object) currencyCode,
                (object) "@GLCompanyId",
                (object) this._glCompanyId
              });
            }
            List<Allocation> allocationList1 = new List<Allocation>();
            List<Allocation> allocationList2 = (List<Allocation>) row.Cells["AllocationSplits"].Value;
            for (int index = 0; index < allocationList2.Count; ++index)
              DefaultDatabase.ExecuteNonQuery("spFin_InsertCostCenterAllocation", new object[6]
              {
                (object) "@PostingNum",
                obj,
                (object) "@CostCenterId",
                (object) allocationList2[index].CostCenterId,
                (object) "@Amount",
                (object) (flag ? allocationList2[index].AllocatedAmount * -1M : allocationList2[index].AllocatedAmount)
              });
          }
        }
        if (this._reversalEnabled)
        {
          if (this.ucReversalDate1.ReversalEnabled)
          {
            DateTime? reversalDate = this.ucReversalDate1.ReversalDate;
            if (reversalDate.HasValue)
            {
              object[] objArray = new object[6]
              {
                (object) "@transactNum",
                (object) this.TransactNum,
                (object) "@postDate",
                null,
                null,
                null
              };
              reversalDate = this.ucReversalDate1.ReversalDate;
              objArray[3] = (object) reversalDate.Value;
              objArray[4] = (object) "@userGuid";
              objArray[5] = (object) CurrentUser.Instance.UserGUID;
              DefaultDatabase.ExecuteNonQuery("spFin_JournalEntryReversingEntry", objArray);
            }
          }
        }
      }
      catch (Exception ex)
      {
        throw;
      }
      e.Transaction.Commit();
    }));
    SectionReport objectAs = (SectionReport) ObjectFactory.Instance.CreateObjectAs<rptJournalTransaction>((object) this.TransactNum);
    objectAs.Run();
    ReportFactory.Instance.ShowReport(objectAs);
  }

  private void ClearScreen()
  {
    this.dsJournalEntryAdvanced1.Clear();
    this.LoadGLCompanies();
  }

  private bool VerifyEntry()
  {
    if (((UltraDropDownBase) this.comboCurrencyCode).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a currency code to continue.", "Required field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    this.gridJournalEntry.EventManager.SetEnabled((EventGroups) 0, false);
    ((UltraGridBase) this.gridJournalEntry).UpdateData();
    this.gridJournalEntry.EventManager.SetEnabled((EventGroups) 0, true);
    int num1 = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridJournalEntry).Rows)
    {
      if (!row.IsTemplateAddRow)
        ++num1;
    }
    if (num1 == 0 || num1 == 1)
    {
      int num2 = (int) MessageBox.Show("GL Accounts rows missing or invalid. You must enter GL account rows to continue.", "No Entries Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    bool flag = true;
    Decimal num3 = 0M;
    Decimal num4 = 0M;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridJournalEntry).Rows)
    {
      Decimal num5 = 0M;
      if (row.Cells["debit"].Value != DBNull.Value && !((Decimal) row.Cells["debit"].Value == 0M) || row.Cells["credit"].Value != DBNull.Value && !((Decimal) row.Cells["credit"].Value == 0M))
      {
        Decimal num6;
        if (row.Cells["debit"].Value != DBNull.Value && (Decimal) row.Cells["debit"].Value != 0M)
        {
          num4 += (Decimal) row.Cells["debit"].Value;
          num6 = (Decimal) row.Cells["debit"].Value;
        }
        else
        {
          num3 += (Decimal) row.Cells["credit"].Value;
          num6 = (Decimal) row.Cells["credit"].Value;
        }
        List<Allocation> allocationList1 = new List<Allocation>();
        if (row.Cells["AllocationSplits"].Value == DBNull.Value)
        {
          int num7 = (int) MessageBox.Show("You have not allocated an amount to a cost center. All debits and credits must be fully allocated to a cost center(s) to continue.", "Invalid Allocations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          break;
        }
        List<Allocation> allocationList2 = (List<Allocation>) row.Cells["AllocationSplits"].Value;
        for (int index = 0; index < allocationList2.Count; ++index)
          num5 += allocationList2[index].AllocatedAmount;
        if (num5 != num6)
        {
          int num8 = (int) MessageBox.Show($"Allocated amount must equal the debit or credit amount. GL: {row.Cells["GLAcctId"].Value.ToString()} Amt: {num6.ToString("c")} Allocated:{num5.ToString("c")}", "Invalid Allocations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row.Activate();
          ((GridItemBase) row).Selected = true;
          flag = false;
          break;
        }
      }
    }
    if (flag && num4 != num3)
    {
      int num9 = (int) MessageBox.Show("Entry is not in balance. Debit amount must equal credit amount.", "Transaction Does Not Balance!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    if (flag && this._glCompanyId <= 0)
    {
      int num10 = (int) MessageBox.Show("You must specify a GL office to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    return flag;
  }

  private void gridJournalEntry_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
  }

  protected void gridJournalEntry_ClickCellButton(object sender, CellEventArgs e)
  {
  }

  private void gridJournalEntry_CellDataError(object sender, CellDataErrorEventArgs e)
  {
    if (!(((KeyedSubObjectBase) this.gridJournalEntry.ActiveCell.Column).Key == "GLAcctId"))
      return;
    DataRow[] dataRowArray = this.dsGLAccountList1.Accounts.Select($"AcctNum = '{this.gridJournalEntry.ActiveCell.Text}'");
    if (dataRowArray.Length != 0)
    {
      e.RaiseErrorEvent = false;
      this.gridJournalEntry.ActiveCell.Value = dataRowArray[0]["glacctid"];
      this.gridJournalEntry.ActiveCell = this.gridJournalEntry.ActiveCell.Row.Cells["Debit"];
      e.RestoreOriginalValue = false;
      e.StayInEditMode = false;
    }
    else
    {
      e.RestoreOriginalValue = true;
      e.StayInEditMode = true;
      int num = (int) MessageBox.Show("The GL Account entered could not be found!", "Invalid GL Account!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void gridJournalEntry_CellListSelect(object sender, CellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "Allocations"))
      return;
    object obj1 = e.Cell.Row.Cells["Debit"].Value;
    object obj2 = e.Cell.Row.Cells["Credit"].Value;
    if (e.Cell.Text == "Multiple...")
    {
      if ((obj1 == null || obj1 == DBNull.Value) && (obj2 == null || obj2 == DBNull.Value))
      {
        int num1 = (int) MessageBox.Show("You must specify a debit or credit amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        if (obj1 == null || obj1 == DBNull.Value)
          obj1 = (object) 0M;
        if (obj2 == null || obj2 == DBNull.Value)
          obj2 = (object) 0M;
        if (e.Cell.Row.Cells["AllocationSplits"].Value == DBNull.Value || e.Cell.Row.Cells["AllocationSplits"].Value == null)
          e.Cell.Row.Cells["AllocationSplits"].Value = (object) new List<Allocation>();
        using (FormAllocations formAllocations = new FormAllocations(this._glCompanyId, (Decimal) obj1 == 0M ? (Decimal) obj2 : (Decimal) obj1, (List<Allocation>) e.Cell.Row.Cells["AllocationSplits"].Value))
        {
          if (formAllocations.ShowDialog() != DialogResult.Cancel)
          {
            e.Cell.Row.Cells["AllocationSplits"].Value = (object) formAllocations.CostCenterAllocations;
            if (formAllocations.CostCenterAllocations.Count > 1)
              e.Cell.Row.Cells["Allocations"].Value = (object) 99999;
            else
              e.Cell.Row.Cells["Allocations"].Value = (object) formAllocations.CostCenterAllocations[0].CostCenterId;
          }
          else
            e.Cell.Row.CancelUpdate();
        }
      }
    }
    else
    {
      List<Allocation> allocationList = new List<Allocation>();
      Allocation allocation = new Allocation();
      string empty = string.Empty;
      int num2 = int.Parse(((UltraDropDownBase) this.dropDownCostCenters).SelectedRow.Cells["CostCenterId"].Value.ToString());
      string str = ((UltraDropDownBase) this.dropDownCostCenters).SelectedRow.Cells["Name"].Value.ToString();
      if ((obj1 == null || obj1 == DBNull.Value) && obj2 != null && obj2 != DBNull.Value)
      {
        allocation.CostCenterId = num2;
        allocation.CostCenterName = str;
        allocation.Percentage = new Decimal?((Decimal) 1);
        allocation.AllocatedAmount = (Decimal) obj2;
      }
      else
      {
        allocation.CostCenterId = num2;
        allocation.CostCenterName = str;
        allocation.Percentage = new Decimal?((Decimal) 1);
        allocation.AllocatedAmount = (Decimal) obj1;
      }
      allocationList.Add(allocation);
      ((UltraGridBase) this.gridJournalEntry).ActiveRow.Cells["AllocationSplits"].Value = (object) allocationList;
    }
  }

  private void dropDownCostCenters_RowSelected(object sender, RowSelectedEventArgs e)
  {
  }

  private void gridJournalEntry_InitializeTemplateAddRow(
    object sender,
    InitializeTemplateAddRowEventArgs e)
  {
  }

  private void CalculateDefaultBalancingValue(UltraGridRow row)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridJournalEntry).Rows).Count == 0)
      return;
    Decimal num1 = Decimal.Parse(((UltraGridBase) this.gridJournalEntry).Rows.SummaryValues["CreditSummary"].Value.ToString(), NumberStyles.Any);
    Decimal num2 = Decimal.Parse(((UltraGridBase) this.gridJournalEntry).Rows.SummaryValues["DebitSummary"].Value.ToString(), NumberStyles.Any);
    if (num1 > num2)
      row.Cells["debit"].Value = (object) Math.Abs(num2 - num1);
    if (!(num2 > num1))
      return;
    row.Cells["credit"].Value = (object) Math.Abs(num1 - num2);
  }

  private void gridJournalEntry_AfterRowInsert(object sender, RowEventArgs e)
  {
    this.CalculateDefaultBalancingValue(e.Row);
  }

  private void LoadCurrencyCode()
  {
    DataTable dataTable;
    if (((UltraDropDownBase) this.comboGLCompanyId).SelectedRow == null)
    {
      dataTable = new DataTable();
      dataTable.Columns.Add("CurrencyCode", typeof (string));
      dataTable.Rows.Add((object) "USD");
    }
    else
      dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetAuthorizedCurrencies", new object[2]
      {
        (object) "@GLCompanyId",
        this.comboGLCompanyId.Value
      });
    ((UltraGridBase) this.comboCurrencyCode).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboCurrencyCode).DisplayMember = "CurrencyCode";
    ((UltraDropDownBase) this.comboCurrencyCode).ValueMember = "CurrencyCode";
    if (dataTable.Rows.Count == 1)
    {
      this.comboCurrencyCode.Value = (object) dataTable.Rows[0]["CurrencyCode"].ToString();
      ((Control) this.comboCurrencyCode).Enabled = false;
    }
    else
    {
      this.comboCurrencyCode.Value = (object) null;
      ((Control) this.comboCurrencyCode).Enabled = true;
    }
  }

  private void gridJournalEntry_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
  }

  private void gridJournalEntry_Leave(object sender, EventArgs e)
  {
    this.gridJournalEntry.PerformAction((UltraGridAction) 44);
    ((UltraGridBase) this.gridJournalEntry).UpdateData();
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
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Accounts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLAcctId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("AcctNum");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FullName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AcctClassName");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("GLAccountListing", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("RowId");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("GLAcctId", -1, (object) "dropDownGLAccountList");
    Appearance appearance28 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Comment");
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Debit");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Credit");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Allocations", -1, (object) "dropDownCostCenters");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("AllocationSplits");
    Appearance appearance36 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("DebitSummary", (SummaryType) 1, (string) null, "Debit", 3, true, "GLAccountListing", 0, (SummaryPosition) 3, "Debit", 3, true);
    Appearance appearance37 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("CreditSummary", (SummaryType) 1, (string) null, "Credit", 4, true, "GLAccountListing", 0, (SummaryPosition) 3, "Credit", 4, true);
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("InitialLayout");
    Appearance appearance47 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("GLAccountListing", -1);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("RowId");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("GLAcctId");
    Appearance appearance48 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Debit");
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Credit");
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("GLAccountListing_CostCenterAllocations");
    Appearance appearance53 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "Debit", 2, true, "GLAccountListing", 0, (SummaryPosition) 3, "Debit", 2, true);
    Appearance appearance54 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "Credit", 3, true, "GLAccountListing", 0, (SummaryPosition) 3, "Credit", 3, true);
    Appearance appearance55 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("GLAccountListing_CostCenterAllocations", 0);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("RowId");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("GLAcctId");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("CostCenter");
    Appearance appearance56 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Amount");
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 1, (string) null, "Amount", 4, true, "GLAccountListing_CostCenterAllocations", 1, (SummaryPosition) 3, "Amount", 4, true);
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    UltraToolbar ultraToolbar1 = new UltraToolbar("MainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("CANCEL");
    ButtonTool buttonTool2 = new ButtonTool("POST");
    ButtonTool buttonTool3 = new ButtonTool("SAVE");
    ButtonTool buttonTool4 = new ButtonTool("LOAD");
    ButtonTool buttonTool5 = new ButtonTool("IMPORT");
    ButtonTool buttonTool6 = new ButtonTool("CONVERT");
    ButtonTool buttonTool7 = new ButtonTool("Expand");
    ButtonTool buttonTool8 = new ButtonTool("Collapse");
    ButtonTool buttonTool9 = new ButtonTool("Print");
    ButtonTool buttonTool10 = new ButtonTool("Export");
    LabelTool labelTool1 = new LabelTool("labelReversal");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("REVERSAL");
    ButtonTool buttonTool11 = new ButtonTool("Help");
    UltraToolbar ultraToolbar2 = new UltraToolbar("GLCompanyId");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("GLCOMPANY");
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("CurrencyCode");
    UltraToolbar ultraToolbar3 = new UltraToolbar("gridContext");
    ButtonTool buttonTool12 = new ButtonTool("Delete Line");
    ButtonTool buttonTool13 = new ButtonTool("POST");
    Appearance appearance69 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("LOAD");
    Appearance appearance70 = new Appearance();
    ButtonTool buttonTool15 = new ButtonTool("SAVE");
    Appearance appearance71 = new Appearance();
    ButtonTool buttonTool16 = new ButtonTool("CANCEL");
    Appearance appearance72 = new Appearance();
    ButtonTool buttonTool17 = new ButtonTool("IMPORT");
    Appearance appearance73 = new Appearance();
    ButtonTool buttonTool18 = new ButtonTool("CONVERT");
    Appearance appearance74 = new Appearance();
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("GLCOMPANY");
    Appearance appearance75 = new Appearance();
    ButtonTool buttonTool19 = new ButtonTool("Collapse");
    Appearance appearance76 = new Appearance();
    ButtonTool buttonTool20 = new ButtonTool("Expand");
    Appearance appearance77 = new Appearance();
    ButtonTool buttonTool21 = new ButtonTool("Print");
    ButtonTool buttonTool22 = new ButtonTool("Export");
    ButtonTool buttonTool23 = new ButtonTool("Help");
    Appearance appearance78 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("GridContextMenu");
    ButtonTool buttonTool24 = new ButtonTool("Delete Line");
    ButtonTool buttonTool25 = new ButtonTool("Delete Line");
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    ButtonTool buttonTool26 = new ButtonTool("Legacy");
    Appearance appearance81 = new Appearance();
    ControlContainerTool controlContainerTool5 = new ControlContainerTool("CurrencyCode");
    Appearance appearance82 = new Appearance();
    PopupControlContainerTool controlContainerTool6 = new PopupControlContainerTool("REVERSINGENTRY");
    Appearance appearance83 = new Appearance();
    ControlContainerTool controlContainerTool7 = new ControlContainerTool("REVERSAL");
    LabelTool labelTool2 = new LabelTool("labelReversal");
    Appearance appearance84 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormJournalEntry_Advanced));
    this.FormJournalEntry_Advanced_Fill_Panel = new Panel();
    this.ucReversalDate1 = new ucReversalDate();
    this.comboCurrencyCode = new MGASimpleComboBox();
    this.dropDownCostCenters = new UltraDropDown();
    this.comboGLCompanyId = new MGASimpleComboBox();
    this.dropDownGLAccountList = new UltraDropDown();
    this.dsGLAccountList1 = new dsGLAccountList();
    this.gridJournalEntry = new UltraGrid();
    this.dsJournalEntryAdvanced1 = new dsJournalEntryAdvanced();
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.helpProvider1 = new HelpProvider();
    this.FormJournalEntry_Advanced_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.comboCurrencyCode).BeginInit();
    ((ISupportInitialize) this.dropDownCostCenters).BeginInit();
    ((ISupportInitialize) this.comboGLCompanyId).BeginInit();
    ((ISupportInitialize) this.dropDownGLAccountList).BeginInit();
    this.dsGLAccountList1.BeginInit();
    ((ISupportInitialize) this.gridJournalEntry).BeginInit();
    this.dsJournalEntryAdvanced1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.FormJournalEntry_Advanced_Fill_Panel.BackColor = Color.Transparent;
    this.FormJournalEntry_Advanced_Fill_Panel.Controls.Add((Control) this.ucReversalDate1);
    this.FormJournalEntry_Advanced_Fill_Panel.Controls.Add((Control) this.comboCurrencyCode);
    this.FormJournalEntry_Advanced_Fill_Panel.Controls.Add((Control) this.dropDownCostCenters);
    this.FormJournalEntry_Advanced_Fill_Panel.Controls.Add((Control) this.comboGLCompanyId);
    this.FormJournalEntry_Advanced_Fill_Panel.Controls.Add((Control) this.dropDownGLAccountList);
    this.FormJournalEntry_Advanced_Fill_Panel.Controls.Add((Control) this.gridJournalEntry);
    this.FormJournalEntry_Advanced_Fill_Panel.Cursor = Cursors.Default;
    this.FormJournalEntry_Advanced_Fill_Panel.Dock = DockStyle.Fill;
    this.FormJournalEntry_Advanced_Fill_Panel.Location = new Point(0, 53);
    this.FormJournalEntry_Advanced_Fill_Panel.Name = "FormJournalEntry_Advanced_Fill_Panel";
    this.FormJournalEntry_Advanced_Fill_Panel.Size = new Size(930, 464);
    this.FormJournalEntry_Advanced_Fill_Panel.TabIndex = 0;
    this.ucReversalDate1.BackColor = Color.Transparent;
    this.ucReversalDate1.Font = new Font("Tahoma", 8.25f);
    this.ucReversalDate1.Location = new Point(669, 380);
    this.ucReversalDate1.Name = "ucReversalDate1";
    this.ucReversalDate1.Size = new Size(119, 21);
    this.ucReversalDate1.TabIndex = 7;
    this.comboCurrencyCode.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCurrencyCode.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCurrencyCode).Location = new Point(415, 313);
    this.comboCurrencyCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCurrencyCode).Name = "comboCurrencyCode";
    ((Control) this.comboCurrencyCode).Size = new Size(110, 21);
    ((Control) this.comboCurrencyCode).TabIndex = 5;
    ((UltraControlBase) this.comboCurrencyCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCurrencyCode).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance1).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance1).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance2).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance4).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance4).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance5).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance5).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance6).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance7).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    ((AppearanceBase) appearance8).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance9).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance9).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance9).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownCostCenters).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.dropDownCostCenters).Location = new Point(253, 192 /*0xC0*/);
    ((Control) this.dropDownCostCenters).Name = "dropDownCostCenters";
    ((Control) this.dropDownCostCenters).Size = new Size(424, 80 /*0x50*/);
    ((Control) this.dropDownCostCenters).TabIndex = 4;
    ((Control) this.dropDownCostCenters).Visible = false;
    this.dropDownCostCenters.RowSelected += new RowSelectedEventHandler(this.dropDownCostCenters_RowSelected);
    this.comboGLCompanyId.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLCompanyId.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGLCompanyId).Location = new Point(24, 289);
    this.comboGLCompanyId.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompanyId).Name = "comboGLCompanyId";
    ((Control) this.comboGLCompanyId).Size = new Size(281, 21);
    ((Control) this.comboGLCompanyId).TabIndex = 3;
    ((UltraControlBase) this.comboGLCompanyId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompanyId).UseOsThemes = (DefaultableBoolean) 2;
    this.comboGLCompanyId.RowSelected += new RowSelectedEventHandler(this.comboGLCompanyId_RowSelected);
    ((UltraGridBase) this.dropDownGLAccountList).DataMember = "Accounts";
    ((UltraGridBase) this.dropDownGLAccountList).DataSource = (object) this.dsGLAccountList1;
    ((AppearanceBase) appearance14).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance14).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Appearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 56;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 120;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 283;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 128 /*0x80*/;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance15).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance15).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance16;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance17).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance17).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance17).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance18).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance18).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance19).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance20).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    ((AppearanceBase) appearance21).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance22).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance22).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance22).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance22).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 1;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance25).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownGLAccountList).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropDownGLAccountList).DisplayMember = "FullName";
    ((Control) this.dropDownGLAccountList).Location = new Point(24, 112 /*0x70*/);
    ((Control) this.dropDownGLAccountList).Name = "dropDownGLAccountList";
    ((Control) this.dropDownGLAccountList).Size = new Size(533, 80 /*0x50*/);
    ((Control) this.dropDownGLAccountList).TabIndex = 2;
    ((UltraDropDownBase) this.dropDownGLAccountList).ValueMember = "GLAcctId";
    ((Control) this.dropDownGLAccountList).Visible = false;
    this.dsGLAccountList1.DataSetName = "dsGLAccountList";
    this.dsGLAccountList1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridJournalEntry, "GridContextMenu");
    ((UltraGridBase) this.gridJournalEntry).DataSource = (object) this.dsJournalEntryAdvanced1;
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Appearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 57;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance28;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.Style = (ColumnStyle) 7;
    ultraGridColumn6.Width = 261;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 2;
    ultraGridColumn7.Width = (int) byte.MaxValue;
    ((AppearanceBase) appearance30).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 3;
    ultraGridColumn8.Width = 126;
    ((AppearanceBase) appearance32).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance32;
    ultraGridColumn9.Format = "c";
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 4;
    ultraGridColumn9.Width = (int) sbyte.MaxValue;
    ((AppearanceBase) appearance34).BackColor = Color.LightSteelBlue;
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 5;
    ultraGridColumn10.Style = (ColumnStyle) 6;
    ultraGridColumn10.Width = 159;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 6;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 77;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ultraGridBand2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand2.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand2.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand2.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand2.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand2.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand2.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand2.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand2.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand2.Override.InvalidValueBehavior = (InvalidValueBehavior) 1;
    ((AppearanceBase) appearance36).BackColor = Color.CornflowerBlue;
    ultraGridBand2.Override.SummaryFooterAppearance = (AppearanceBase) appearance36;
    ultraGridBand2.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance37).BackColor = Color.CornflowerBlue;
    ((AppearanceBase) appearance37).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance37;
    summarySettings1.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance38).BackColor = Color.CornflowerBlue;
    ((AppearanceBase) appearance38).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance38;
    summarySettings2.DisplayFormat = "{0:c}";
    ultraGridBand2.Summaries.AddRange(new SummarySettings[2]
    {
      summarySettings1,
      summarySettings2
    });
    ultraGridBand2.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance39).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 5;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance40).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance41).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance42).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance44).BackColor = Color.Transparent;
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance44;
    ((AppearanceBase) appearance45).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance45).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.gridJournalEntry).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridJournalEntry).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance47).BackColor = Color.White;
    ((AppearanceBase) appearance47).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout.Appearance = (AppearanceBase) appearance47;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 0;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 64 /*0x40*/;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance48;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 1;
    ultraGridColumn13.Width = 298;
    ((AppearanceBase) appearance49).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance49;
    ultraGridColumn14.Format = "c";
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance50;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 2;
    ultraGridColumn14.Width = 211;
    ((AppearanceBase) appearance51).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance51;
    ultraGridColumn15.Format = "c";
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance52;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 3;
    ultraGridColumn15.Width = 216;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 4;
    ultraGridColumn16.Width = 203;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ultraGridBand3.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand3.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand3.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand3.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand3.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand3.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand3.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand3.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand3.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand3.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand3.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand3.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand3.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand3.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand3.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand3.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand3.Override.InvalidValueBehavior = (InvalidValueBehavior) 1;
    ((AppearanceBase) appearance53).BackColor = Color.CornflowerBlue;
    ultraGridBand3.Override.SummaryFooterAppearance = (AppearanceBase) appearance53;
    ultraGridBand3.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance54).BackColor = Color.CornflowerBlue;
    ((AppearanceBase) appearance54).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance54;
    summarySettings3.DisplayFormat = "Total Debits = {0:c}";
    ((AppearanceBase) appearance55).BackColor = Color.CornflowerBlue;
    ((AppearanceBase) appearance55).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance55;
    summarySettings4.DisplayFormat = "Total Credits = {0:c}";
    ultraGridBand3.Summaries.AddRange(new SummarySettings[2]
    {
      summarySettings3,
      summarySettings4
    });
    ultraGridBand3.SummaryFooterCaption = "";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 114;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 1;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 136;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 2;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 172;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Left";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance56;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Cost Center";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 3;
    ultraGridColumn20.Width = 605;
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance57;
    ultraGridColumn21.Format = "c";
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance58;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 4;
    ultraGridColumn21.Width = 323;
    ultraGridBand4.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    ultraGridBand4.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand4.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand4.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand4.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand4.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand4.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand4.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand4.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand4.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand4.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand4.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand4.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand4.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand4.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand4.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand4.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand4.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance59).BackColor = Color.CornflowerBlue;
    ultraGridBand4.Override.SummaryFooterAppearance = (AppearanceBase) appearance59;
    ultraGridBand4.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance60).BackColor = Color.CornflowerBlue;
    ((AppearanceBase) appearance60).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance60;
    summarySettings5.DisplayFormat = "Total Allocations: {0:c}";
    ultraGridBand4.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings5
    });
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "InitialLayout";
    ((AppearanceBase) appearance61).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance61).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance61).ForeColor = Color.Black;
    ultraGridLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance61;
    ultraGridLayout.Override.AllowAddNew = (AllowAddNew) 5;
    ultraGridLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance62).BorderColor = Color.LightGray;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance62;
    ultraGridLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance63).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance63;
    ultraGridLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance64).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance64;
    ((AppearanceBase) appearance65).BorderColor = Color.LightGray;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance65;
    ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance66).BackColor = Color.Transparent;
    ((AppearanceBase) appearance66).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance66;
    ((AppearanceBase) appearance67).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance67).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance67;
    ((AppearanceBase) appearance68).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance68;
    ultraGridLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridJournalEntry).Layouts.Add(ultraGridLayout);
    ((Control) this.gridJournalEntry).Location = new Point(0, 0);
    ((Control) this.gridJournalEntry).Name = "gridJournalEntry";
    this.gridJournalEntry.RowUpdateCancelAction = (RowUpdateCancelAction) 1;
    ((Control) this.gridJournalEntry).Size = new Size(930, 464);
    ((Control) this.gridJournalEntry).TabIndex = 0;
    this.gridJournalEntry.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridJournalEntry).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridJournalEntry).UseOsThemes = (DefaultableBoolean) 2;
    this.gridJournalEntry.AfterCellUpdate += new CellEventHandler(this.gridJournalEntry_AfterCellUpdate);
    this.gridJournalEntry.InitializeTemplateAddRow += new InitializeTemplateAddRowEventHandler(this.gridJournalEntry_InitializeTemplateAddRow);
    this.gridJournalEntry.AfterRowInsert += new RowEventHandler(this.gridJournalEntry_AfterRowInsert);
    this.gridJournalEntry.AfterRowUpdate += new RowEventHandler(this.gridJournalEntry_AfterRowUpdate);
    this.gridJournalEntry.BeforeRowUpdate += new CancelableRowEventHandler(this.gridJournalEntry_BeforeRowUpdate);
    this.gridJournalEntry.CellListSelect += new CellEventHandler(this.gridJournalEntry_CellListSelect);
    this.gridJournalEntry.ClickCellButton += new CellEventHandler(this.gridJournalEntry_ClickCellButton);
    this.gridJournalEntry.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridJournalEntry_BeforeCellUpdate);
    this.gridJournalEntry.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(this.gridJournalEntry_BeforeRowsDeleted);
    this.gridJournalEntry.CellDataError += new CellDataErrorEventHandler(this.gridJournalEntry_CellDataError);
    ((Control) this.gridJournalEntry).Leave += new EventHandler(this.gridJournalEntry_Leave);
    this.dsJournalEntryAdvanced1.DataSetName = "dsJournalEntryAdvanced";
    this.dsJournalEntryAdvanced1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left).Location = new Point(0, 53);
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left).Name = "_FormJournalEntry_Advanced_Toolbars_Dock_Area_Left";
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left).Size = new Size(0, 464);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.LockToolbars = true;
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.MiniToolbar.ToolRowCount = 3;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 0;
    ultraToolbar1.FloatingLocation = new Point(534, 159);
    ultraToolbar1.FloatingSize = new Size(566, 48 /*0x30*/);
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool9).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool10).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) labelTool1).InstanceProps.IsFirstInGroup = true;
    controlContainerTool1.ControlName = "ucReversalDate1";
    ((ToolBase) buttonTool11).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[13]
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
      (ToolBase) labelTool1,
      (ToolBase) controlContainerTool1,
      (ToolBase) buttonTool11
    });
    ultraToolbar1.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.CaptionPlacement = (TextPlacement) 4;
    ultraToolbar1.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar1.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar1.Settings).ToolDisplayStyle = (ToolDisplayStyle) 5;
    ultraToolbar1.Text = "MainToolbar";
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 1;
    ultraToolbar2.FloatingLocation = new Point(657, 430);
    ultraToolbar2.FloatingSize = new Size(363, 45);
    controlContainerTool2.ControlName = "comboGLCompanyId";
    controlContainerTool3.ControlName = "comboCurrencyCode";
    ((UltraToolbarBase) ultraToolbar2).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) controlContainerTool2,
      (ToolBase) controlContainerTool3
    });
    ultraToolbar2.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar2.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar2.Text = "GLCompanyId";
    ultraToolbar3.DockedColumn = 0;
    ultraToolbar3.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar3).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool12
    });
    ultraToolbar3.Text = "gridContext";
    ultraToolbar3.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[3]
    {
      ultraToolbar1,
      ultraToolbar2,
      ultraToolbar3
    });
    ((AppearanceBase) appearance69).Image = (object) Resources.pencil_go;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance69;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Post Journal Entry";
    ((ToolBase) buttonTool13).SharedPropsInternal.Category = "FileOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance70).Image = componentResourceManager.GetObject("appearance28.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance70;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Load Template";
    ((ToolBase) buttonTool14).SharedPropsInternal.Category = "FileOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance71).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance71;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Save Template";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance72).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance72;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance73).Image = (object) Resources.ExcelIco1;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance73;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "Import Template";
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance74).Image = componentResourceManager.GetObject("appearance32.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance74;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "Convert Journal Entry";
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool18).SharedPropsInternal.Visible = false;
    controlContainerTool4.ControlName = "comboGLCompanyId";
    ((AppearanceBase) appearance75).ForeColor = Color.Navy;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance75;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Caption = "GL Company: ";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance76).Image = (object) Resources.cog_delete;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance76;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).Caption = "Collapse";
    ((ToolBase) buttonTool19).SharedPropsInternal.ToolTipText = "Collapse all rows.";
    ((ToolBase) buttonTool19).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance77).Image = (object) Resources.cog_add;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance77;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).Caption = "Expand";
    ((ToolBase) buttonTool20).SharedPropsInternal.ToolTipText = "Expand all rows.";
    ((ToolBase) buttonTool20).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).Caption = "Print";
    ((ToolBase) buttonTool21).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "Export";
    ((ToolBase) buttonTool22).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance78).Image = (object) Resources.help;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance78;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).Caption = "Help";
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "GridContextMenu";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool24
    });
    ((AppearanceBase) appearance79).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance79;
    ((AppearanceBase) appearance80).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance80;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "Delete Line";
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance81).Image = (object) Resources.wrench_orange;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance81;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Legacy View";
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool5.ControlName = "comboCurrencyCode";
    ((AppearanceBase) appearance82).ForeColor = Color.MidnightBlue;
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance82;
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).Caption = "Currency Code:";
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance83).Image = (object) Resources.arrow_switch;
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance83;
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).Caption = "Reversing Entry";
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool7.ControlName = "ucReversalDate1";
    ((AppearanceBase) appearance84).Image = (object) Resources.arrow_switch;
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance84;
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedPropsInternal).Caption = "Reversing Entry";
    ((ToolPropsBase) ((ToolBase) labelTool2).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[19]
    {
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) controlContainerTool4,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) controlContainerTool5,
      (ToolBase) controlContainerTool6,
      (ToolBase) controlContainerTool7,
      (ToolBase) labelTool2
    });
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 1;
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right).Location = new Point(930, 53);
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right).Name = "_FormJournalEntry_Advanced_Toolbars_Dock_Area_Right";
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right).Size = new Size(0, 464);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top).Name = "_FormJournalEntry_Advanced_Toolbars_Dock_Area_Top";
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top).Size = new Size(930, 53);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom).Location = new Point(0, 517);
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom).Name = "_FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom).Size = new Size(930, 0);
    this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.helpProvider1.HelpNamespace = "C:\\Team System Projects\\MGA Systems Output\\IMSHelp.chm";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(930, 517);
    this.Controls.Add((Control) this.FormJournalEntry_Advanced_Fill_Panel);
    this.Controls.Add((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormJournalEntry_Advanced_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.HelpButton = true;
    this.helpProvider1.SetHelpKeyword((Control) this, "AddingASimpleJournalEntry.htm");
    this.helpProvider1.SetHelpNavigator((Control) this, HelpNavigator.Topic);
    this.helpProvider1.SetHelpString((Control) this, "AddingASimpleJournalEntry.htm");
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormJournalEntry_Advanced);
    this.helpProvider1.SetShowHelp((Control) this, true);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Journal Entry";
    this.Load += new EventHandler(this.FormJournalEntry_Advanced_Load);
    this.FormJournalEntry_Advanced_Fill_Panel.ResumeLayout(false);
    this.FormJournalEntry_Advanced_Fill_Panel.PerformLayout();
    ((ISupportInitialize) this.comboCurrencyCode).EndInit();
    ((ISupportInitialize) this.dropDownCostCenters).EndInit();
    ((ISupportInitialize) this.comboGLCompanyId).EndInit();
    ((ISupportInitialize) this.dropDownGLAccountList).EndInit();
    this.dsGLAccountList1.EndInit();
    ((ISupportInitialize) this.gridJournalEntry).EndInit();
    this.dsJournalEntryAdvanced1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  public delegate void TemplateDetailSavedHandler(
    int templateId,
    int templateDetailId,
    UltraGridRow gridRow);
}
