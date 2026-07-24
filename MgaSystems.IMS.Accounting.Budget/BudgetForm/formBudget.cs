// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.BudgetForm.formBudget
// Assembly: MgaSystems.IMS.Accounting.Budget, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6BC25DF1-D5D5-4DAC-8821-336F88BA639E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.CalcEngine;
using Infragistics.Win.UltraWinCalcManager;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Budget.Charting;
using MGASystems.IMS.Accounting.Budget.Datasets;
using MGASystems.IMS.Accounting.Budget.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Budget.BudgetForm;

[SecureResource("{A767F4EC-3E41-438B-B80F-2686297BE699}", "GL Budget Access Rights", "Users with this permission are granted access to the budget functions within the accounting system.", "Accounting")]
public class formBudget : FormBase
{
  private int _glCompanyid;
  private string _fiscalYear;
  private IContainer components;
  private dsGLAccountBudgets dsGLAccountBudgets1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formBudget_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formBudget_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formBudget_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formBudget_Toolbars_Dock_Area_Bottom;
  private MGASimpleComboBox comboFiscalYear;
  private MGASimpleComboBox comboGLCompanyId;
  private dsCostCenters dsCostCenters1;
  private dsFiscalYearList dsFiscalYearList1;
  private Panel panelCurtain;
  private Panel panelLoading;
  private Label label1;
  private MGADateTimePicker dateTimeActualAsOf;
  private UltraToolTipManager ultraToolTipManager1;
  private UltraTabControl ultraTabControl2;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage2;
  private UltraTabPageControl ultraTabPageControl3;
  private UltraGrid gridBudget;
  private UltraTabPageControl ultraTabPageControl1;
  private BudgetTrends budgetTrends1;
  private QuarterlyByCostCenter quarterlyByCostCenter1;
  private LedgerAccountBudgets ledgerAccountBudgets1;
  private Timer timer1;
  private StatusStrip statusStrip1;
  private ToolStripStatusLabel labelStatusStrip;
  private UltraCalcManager ultraCalcManager1;

  public formBudget() => this.InitializeComponent();

  private void GetFiscalYearList()
  {
    int year = DateTime.Now.Year;
    for (int index = year - 25; index <= year + 5; ++index)
      this.dsFiscalYearList1.FiscalYears.AddFiscalYearsRow(index.ToString());
    this.comboFiscalYear.Value = (object) DateTime.Now.Year;
  }

  private void LoadGLCompanies()
  {
    ((UltraGridBase) this.comboGLCompanyId).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations");
    ((UltraDropDownBase) this.comboGLCompanyId).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboGLCompanyId).ValueMember = "ID";
    this.comboGLCompanyId.Value = (object) CurrentUser.Instance.OfficeID;
  }

  private void formBudget_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.GetFiscalYearList();
    this.LoadGLCompanies();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
    {
      case 754423037:
        if (!(key == "COPYVALUE") || ((GridItemBase) this.gridBudget.ActiveCell).Band.Index != 1)
          break;
        this.CopyValue(this.gridBudget.ActiveCell);
        break;
      case 900713019:
        int num = key == "Cancel" ? 1 : 0;
        break;
      case 1294818664:
        if (!(key == "Save"))
          break;
        try
        {
          this.Cursor = MgaCursors.WaitCursor;
          this.SaveBudget();
          this.GetBudgetData();
          break;
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
      case 2900749117:
        if (!(key == "GETACTUAL"))
          break;
        this.LoadActuals(this._fiscalYear);
        break;
      case 2991429977:
        if (!(key == "SHOWQ4"))
          break;
        this.ToggleShowVariance(4, !((StateButtonTool) ((ToolEventArgs) e).Tool).Checked);
        break;
      case 3008207596:
        if (!(key == "SHOWQ3"))
          break;
        this.ToggleShowVariance(3, !((StateButtonTool) ((ToolEventArgs) e).Tool).Checked);
        break;
      case 3024985215:
        if (!(key == "SHOWQ2"))
          break;
        this.ToggleShowVariance(2, !((StateButtonTool) ((ToolEventArgs) e).Tool).Checked);
        break;
      case 3041762834:
        if (!(key == "SHOWQ1"))
          break;
        this.ToggleShowVariance(1, !((StateButtonTool) ((ToolEventArgs) e).Tool).Checked);
        break;
      case 3326517961:
        if (!(key == "Search"))
          break;
        try
        {
          this.Cursor = MgaCursors.WaitCursor;
          this.GetBudgetData();
          break;
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
    }
  }

  private void ToggleShowVariance(int quarter, bool show)
  {
    int num = ((StateButtonTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["GETACTUAL"]).Checked ? 1 : 0;
    switch (quarter)
    {
      case 1:
        ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Groups["Q1"].Hidden = show;
        break;
      case 2:
        ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Groups["Q2"].Hidden = show;
        break;
      case 3:
        ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Groups["Q3"].Hidden = show;
        break;
      case 4:
        ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Groups["Q4"].Hidden = show;
        break;
    }
  }

  private void ToggleShowActual(bool show)
  {
    if (((StateButtonTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["GETACTUAL"]).Checked)
      this.LoadActuals(this.comboFiscalYear.Value.ToString());
    ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Actual"].Hidden = show;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["ActualVBudget"].Hidden = show;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["ActualVBudgetPCT"].Hidden = show;
    if (!((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Groups["Q1"].Hidden)
    {
      ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Q1ActualVBudget"].Hidden = show;
      ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Q1ActualVBudgetPCT"].Hidden = show;
    }
    if (!((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Groups["Q2"].Hidden)
    {
      ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Q2ActualVBudget"].Hidden = show;
      ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Q2ActualVBudgetPCT"].Hidden = show;
    }
    if (!((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Groups["Q3"].Hidden)
    {
      ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Q3ActualVBudget"].Hidden = show;
      ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Q3ActualVBudgetPCT"].Hidden = show;
    }
    if (((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Groups["Q4"].Hidden)
      return;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Q4ActualVBudget"].Hidden = show;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Bands["BudgetDetail_BudgetDetailRevision"].Columns["Q4ActualVBudgetPCT"].Hidden = show;
  }

  private bool VerifyFiscalBudget(string fiscalYear, int glCompanyId)
  {
    return (bool) DefaultDatabase.ExecuteScalar(CommandType.Text, "select dbo.FiscalBudgetExists(@fiscalYear, @glcompanyId)", new object[4]
    {
      (object) "@fiscalYear",
      (object) fiscalYear,
      (object) "@glcompanyid",
      (object) glCompanyId
    });
  }

  private void CheckMissingCostCenters(int glCompanyId, string fiscalYear)
  {
    if (!(bool) DefaultDatabase.ExecuteScalar(CommandType.Text, "select dbo.IsBudgetMissingCostCenters(@glcompanyId, @fiscalYear)", new object[4]
    {
      (object) "@glcompanyid",
      (object) glCompanyId,
      (object) "@fiscalYear",
      (object) fiscalYear
    }))
      return;
    try
    {
      DefaultDatabase.ExecuteScalar("dbo.spFin_UpdateBudgetCostCenters", new object[6]
      {
        (object) "@glcompanyId",
        (object) glCompanyId,
        (object) "@fisclaYear",
        (object) fiscalYear,
        (object) "@userGuid",
        (object) CurrentUser.Instance.UserGUID
      });
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void CheckMissingGLAccounts(int glCompanyId, string fiscalYear)
  {
    if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "select dbo.IsBudgetMissingGLAccounts(@glcompanyId, @fiscalYear)", new object[4]
    {
      (object) "@glcompanyid",
      (object) glCompanyId,
      (object) "@fiscalYear",
      (object) fiscalYear
    }))
      return;
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_UpdateBudgetGLAccounts", new object[6]
    {
      (object) "@glcompanyId",
      (object) glCompanyId,
      (object) "@fiscalYear",
      (object) fiscalYear,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  private void GetBudgetData()
  {
    this.panelCurtain.Visible = true;
    this.panelCurtain.BringToFront();
    this.panelCurtain.Refresh();
    this.panelLoading.Visible = true;
    this.panelLoading.Refresh();
    DateTime now = DateTime.Now;
    int num1 = (int) this.comboGLCompanyId.Value;
    string str = this.comboFiscalYear.Value.ToString();
    if (((UltraDropDownBase) this.comboFiscalYear).SelectedRow == null || ((UltraDropDownBase) this.comboGLCompanyId).SelectedRow == null)
    {
      int num2 = (int) MessageBox.Show(Resources.ERROR_FISCALGL_REQUIRED, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.panelLoading.Visible = false;
    }
    else
    {
      if (!this.VerifyFiscalBudget(this.comboFiscalYear.Value.ToString(), (int) this.comboGLCompanyId.Value))
      {
        if (MessageBox.Show(Resources.ERROR_BUDGETNOTFOUND_MESSAGE, Resources.ERROR_BUDGETNOTFOUND_HEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          DefaultDatabase.ExecuteNonQuery("spFin_GenerateEmptyFiscalBudget", new object[6]
          {
            (object) "@glcompanyid",
            (object) num1,
            (object) "@fiscalYear",
            (object) str,
            (object) "@userGuid",
            (object) CurrentUser.Instance.UserGUID
          });
        }
        else
        {
          this.panelLoading.Visible = false;
          return;
        }
      }
      this._glCompanyid = (int) this.comboGLCompanyId.Value;
      this._fiscalYear = this.comboFiscalYear.Value.ToString();
      this.CheckMissingCostCenters(this._glCompanyid, this._fiscalYear);
      this.CheckMissingGLAccounts(this._glCompanyid, this._fiscalYear);
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        this.labelStatusStrip.Text = "Loading budget data...";
        this.dsGLAccountBudgets1.Clear();
        DefaultDatabase.LoadDataSet((DataSet) this.dsGLAccountBudgets1, new string[4]
        {
          "Budget",
          "FiscalPeriods",
          "BudgetDetail",
          "BudgetDetailRevision"
        }, "spFin_GetBudget", new object[4]
        {
          (object) "@glcompanyid",
          (object) this._glCompanyid,
          (object) "@fiscalYear",
          (object) this._fiscalYear
        });
        this.labelStatusStrip.Text = $"Finished loading budget data. Query returned in {(DateTime.Now - now).TotalSeconds} seconds. Transforming data...";
        this.TransformBudgetData();
        this.dsGLAccountBudgets1.AcceptChanges();
        ((UltraGridBase) this.gridBudget).DataSource = (object) this.dsGLAccountBudgets1;
        this.labelStatusStrip.Text = "Loading actuals...";
        this.LoadActuals(this._fiscalYear);
        this.labelStatusStrip.Text = $"Finished loading actuals. Query returned in {(DateTime.Now - now).TotalSeconds} seconds.";
        this.panelCurtain.Visible = false;
        ((UltraGridBase) this.gridBudget).Rows[0].ExpandAll();
        ((UltraGridBase) this.gridBudget).Rows[0].CollapseAll();
        this.timer1.Start();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void TransformBudgetData()
  {
    foreach (DataRow row in (InternalDataCollectionBase) this.dsGLAccountBudgets1.FiscalPeriods.DefaultView.ToTable(true, "FiscalPeriod", "FiscalKey").Rows)
    {
      ((HeaderBase) ((UltraGridBase) this.gridBudget).DisplayLayout.Bands[0].Columns[row["FiscalKey"].ToString()].Header).Caption = row["FiscalPeriod"].ToString();
      ((HeaderBase) ((UltraGridBase) this.gridBudget).DisplayLayout.Bands[1].Columns[row["FiscalKey"].ToString()].Header).Caption = row["FiscalPeriod"].ToString();
    }
  }

  private void SaveBudget()
  {
    ((UltraGridBase) this.gridBudget).UpdateData();
    foreach (dsGLAccountBudgets.BudgetDetailRow row in (InternalDataCollectionBase) this.dsGLAccountBudgets1.BudgetDetail.Rows)
    {
      if (row.RowState == DataRowState.Modified)
      {
        foreach (DataColumn column in (InternalDataCollectionBase) row.Table.Columns)
        {
          if (column.ColumnName.StartsWith("F"))
          {
            DataRow[] dataRowArray = this.dsGLAccountBudgets1.BudgetDetailRevision.Select($"CostCenterId = {row.CostCenterId} AND GLAcctId = {row.GLAcctId} AND FiscalKey = '{column.ColumnName}'");
            DefaultDatabase.ExecuteNonQuery("spFin_SaveBudget", new object[22]
            {
              (object) "@FiscalYear",
              (object) this._fiscalYear,
              (object) "@GLCompanyId",
              (object) this._glCompanyid,
              (object) "@GLAcctId",
              (object) row.GLAcctId,
              (object) "@OriginalAmount",
              row[column.ColumnName],
              (object) "@Q1Amount",
              dataRowArray[0]["Q1"],
              (object) "@Q2Amount",
              dataRowArray[0]["Q2"],
              (object) "@Q3Amount",
              dataRowArray[0]["Q3"],
              (object) "@Q4Amount",
              dataRowArray[0]["Q4"],
              (object) "@CostCenterId",
              (object) row.CostCenterId,
              (object) "@UserGuid",
              (object) CurrentUser.Instance.UserGUID,
              (object) "@BudgetMonthName",
              dataRowArray[0]["FiscalPeriod"]
            });
          }
        }
      }
    }
    this.dsGLAccountBudgets1.AcceptChanges();
  }

  private void gridBudget_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (((GridItemBase) e.Cell).Band.Index != 3)
      return;
    Decimal num1 = (Decimal) e.Cell.Row.Cells["Original"].Value;
    Decimal num2 = (Decimal) e.Cell.Row.Cells["Q1"].Value;
    Decimal num3 = (Decimal) e.Cell.Row.Cells["Q2"].Value;
    Decimal num4 = (Decimal) e.Cell.Row.Cells["Q3"].Value;
    Decimal num5 = (Decimal) e.Cell.Row.Cells["Q4"].Value;
    switch (((KeyedSubObjectBase) e.Cell.Column).Key)
    {
      case "Original":
        e.Cell.Row.Cells["Q1PercentageFromOriginal"].Value = (object) (num2 / (num1 == 0M ? 1M : num1) / 100M);
        e.Cell.Row.Cells["Q2PercentageFromOriginal"].Value = (object) (num3 / (num1 == 0M ? 1M : num1) / 100M);
        e.Cell.Row.Cells["Q3PercentageFromOriginal"].Value = (object) (num4 / (num1 == 0M ? 1M : num1) / 100M);
        e.Cell.Row.Cells["Q4PercentageFromOriginal"].Value = (object) (num5 / (num1 == 0M ? 1M : num1) / 100M);
        break;
      case "Q1":
        e.Cell.Row.Cells["Q1PercentageFromOriginal"].Value = (object) (num2 / (num1 == 0M ? 1M : num1) / 100M);
        e.Cell.Row.Cells["Q2PercentageFromPriorQtr"].Value = (object) (num3 / (num2 == 0M ? 1M : num2) / 100M);
        e.Cell.Row.Cells["Q3PercentageFromPriorQtr1"].Value = (object) (num4 / (num2 == 0M ? 1M : num2) / 100M);
        e.Cell.Row.Cells["Q4PercentageFromPriorQtr1"].Value = (object) (num5 / (num2 == 0M ? 1M : num2) / 100M);
        break;
      case "Q2":
        e.Cell.Row.Cells["Q2PercentageFromOriginal"].Value = (object) (num3 / (num1 == 0M ? 1M : num1) / 100M);
        e.Cell.Row.Cells["Q2PercentageFromPriorQtr"].Value = (object) (num3 / (num2 == 0M ? 1M : num2) / 100M);
        e.Cell.Row.Cells["Q3PercentageFromPriorQtr2"].Value = (object) (num4 / (num3 == 0M ? 1M : num3) / 100M);
        e.Cell.Row.Cells["Q4PercentageFromPriorQtr2"].Value = (object) (num5 / (num3 == 0M ? 1M : num3) / 100M);
        break;
      case "Q3":
        e.Cell.Row.Cells["Q3PercentageFromOriginal"].Value = (object) (num4 / (num1 == 0M ? 1M : num1) / 100M);
        e.Cell.Row.Cells["Q3PercentageFromPriorQtr2"].Value = (object) (num4 / (num3 == 0M ? 1M : num3) / 100M);
        e.Cell.Row.Cells["Q3PercentageFromPriorQtr1"].Value = (object) (num4 / (num2 == 0M ? 1M : num2) / 100M);
        e.Cell.Row.Cells["Q4PercentageFromPriorQtr3"].Value = (object) (num5 / (num4 == 0M ? 1M : num4) / 100M);
        break;
      case "Q4":
        e.Cell.Row.Cells["Q4PercentageFromOriginal"].Value = (object) (num5 / (num1 == 0M ? 1M : num1) / 100M);
        e.Cell.Row.Cells["Q4PercentageFromPriorQtr3"].Value = (object) (num5 / (num4 == 0M ? 1M : num4) / 100M);
        e.Cell.Row.Cells["Q4PercentageFromPriorQtr2"].Value = (object) (num5 / (num3 == 0M ? 1M : num3) / 100M);
        e.Cell.Row.Cells["Q4PercentageFromPriorQtr1"].Value = (object) (num5 / (num2 == 0M ? 1M : num2) / 100M);
        break;
    }
    if (Decimal.Parse(e.Cell.Row.Cells["ActualVBudget"].Value.ToString()) == 0M)
      ((AppearanceBase) e.Cell.Row.Cells["ActualVBudget"].Appearance).Image = (object) null;
    else if (Decimal.Parse(e.Cell.Row.Cells["ActualVBudget"].Value.ToString()) > 0M)
      ((AppearanceBase) e.Cell.Row.Cells["ActualVBudget"].Appearance).Image = (object) Resources.arrow_up_2;
    else
      ((AppearanceBase) e.Cell.Row.Cells["ActualVBudget"].Appearance).Image = (object) Resources.arrow_down;
  }

  private void UpdateRevisionPercentages()
  {
    foreach (dsGLAccountBudgets.BudgetDetailRevisionRow detailRevisionRow in (TypedTableBase<dsGLAccountBudgets.BudgetDetailRevisionRow>) this.dsGLAccountBudgets1.BudgetDetailRevision)
    {
      Decimal original = detailRevisionRow.Original;
      Decimal q1 = detailRevisionRow.Q1;
      Decimal q2 = detailRevisionRow.Q2;
      Decimal q3 = detailRevisionRow.Q3;
      Decimal q4 = detailRevisionRow.Q4;
      detailRevisionRow["Q1PercentageFromOriginal"] = (object) (q1 != 0M ? q1 / (original == 0M ? 1M : original) / 100M : 0M);
      detailRevisionRow["Q2PercentageFromOriginal"] = (object) (q2 != 0M ? q2 / (original == 0M ? 1M : original) / 100M : 0M);
      detailRevisionRow["Q3PercentageFromOriginal"] = (object) (q3 != 0M ? q3 / (original == 0M ? 1M : original) / 100M : 0M);
      detailRevisionRow["Q4PercentageFromOriginal"] = (object) (q4 != 0M ? q4 / (original == 0M ? 1M : original) / 100M : 0M);
      detailRevisionRow["Q2PercentageFromPriorQtr"] = (object) (q2 != 0M ? q2 / (q1 == 0M ? 1M : q1) / 100M : 0M);
      detailRevisionRow["Q3PercentageFromPriorQtr2"] = (object) (q3 != 0M ? q3 / (q2 == 0M ? 1M : q2) / 100M : 0M);
      detailRevisionRow["Q3PercentageFromPriorQtr1"] = (object) (q3 != 0M ? q3 / (q1 == 0M ? 1M : q1) / 100M : 0M);
      detailRevisionRow["Q4PercentageFromPriorQtr3"] = (object) (q4 != 0M ? q4 / (q3 == 0M ? 1M : q3) / 100M : 0M);
      detailRevisionRow["Q4PercentageFromPriorQtr2"] = (object) (q4 != 0M ? q4 / (q2 == 0M ? 1M : q2) / 100M : 0M);
      detailRevisionRow["Q4PercentageFromPriorQtr1"] = (object) (q4 != 0M ? q4 / (q1 == 0M ? 1M : q1) / 100M : 0M);
    }
  }

  private void LoadActuals(string fiscalYear)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_BudgetGetActual", new object[4]
      {
        (object) "@GLCompanyId",
        (object) this._glCompanyid,
        (object) "@fiscalyear",
        (object) fiscalYear
      });
      if (dataTable.Rows.Count == 0)
        return;
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      {
        DataRow[] dataRowArray = this.dsGLAccountBudgets1.BudgetDetailRevision.Select($"GLAcctId = {row["Glacctid"]} AND CostCenterId = {row["CostCenterId"]} AND FiscalPeriod = '{row["ActualMonthName"]}'");
        for (int index = 0; index < dataRowArray.Length; ++index)
        {
          dataRowArray[index]["Actual"] = row["ActualAmount"];
          dataRowArray[index]["ActualVBudget"] = (object) (Decimal.Parse(dataRowArray[index]["Original"].ToString()) - Decimal.Parse(row["ActualAmount"].ToString()));
          dataRowArray[index]["ActualVBudgetPCT"] = !(Decimal.Parse(dataRowArray[index]["Original"].ToString()) == 0M) ? (object) (Decimal.Parse(dataRowArray[index]["ActualVBudget"].ToString()) / Decimal.Parse(dataRowArray[index]["Original"].ToString()) * -1M * -1M) : (object) 0;
          dataRowArray[index]["Q1ActualVBudget"] = (object) (Decimal.Parse(row["ActualAmount"].ToString()) - Decimal.Parse(dataRowArray[index]["Q1"].ToString()));
          dataRowArray[index]["Q1ActualVBudgetPCT"] = (object) (Decimal.Parse(dataRowArray[index]["Q1ActualVBudget"].ToString()) / (Decimal.Parse(row["ActualAmount"].ToString()) == 0M ? 1M : Decimal.Parse(row["ActualAmount"].ToString())) * -1M);
          dataRowArray[index]["Q2ActualVBudget"] = (object) (Decimal.Parse(row["ActualAmount"].ToString()) - Decimal.Parse(dataRowArray[index]["Q2"].ToString()));
          dataRowArray[index]["Q2ActualVBudgetPCT"] = (object) (Decimal.Parse(dataRowArray[index]["Q2ActualVBudget"].ToString()) / (Decimal.Parse(row["ActualAmount"].ToString()) == 0M ? 1M : Decimal.Parse(row["ActualAmount"].ToString())) * -1M);
          dataRowArray[index]["Q3ActualVBudget"] = (object) (Decimal.Parse(row["ActualAmount"].ToString()) - Decimal.Parse(dataRowArray[index]["Q3"].ToString()));
          dataRowArray[index]["Q3ActualVBudgetPCT"] = (object) (Decimal.Parse(dataRowArray[index]["Q3ActualVBudget"].ToString()) / (Decimal.Parse(row["ActualAmount"].ToString()) == 0M ? 1M : Decimal.Parse(row["ActualAmount"].ToString())) * -1M);
          dataRowArray[index]["Q4ActualVBudget"] = (object) (Decimal.Parse(row["ActualAmount"].ToString()) - Decimal.Parse(dataRowArray[index]["Q4"].ToString()));
          dataRowArray[index]["Q4ActualVBudgetPCT"] = (object) (Decimal.Parse(dataRowArray[index]["Q4ActualVBudget"].ToString()) / (Decimal.Parse(row["ActualAmount"].ToString()) == 0M ? 1M : Decimal.Parse(row["ActualAmount"].ToString())) * -1M);
        }
      }
      ((UltraGridBase) this.gridBudget).UpdateData();
      this.dsGLAccountBudgets1.AcceptChanges();
      this.budgetTrends1.DisplayData(this.dsGLAccountBudgets1);
      this.quarterlyByCostCenter1.DisplayData(this.dsGLAccountBudgets1);
      this.ledgerAccountBudgets1.DisplayData(this.dsGLAccountBudgets1);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void gridBudget_SummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
  {
    if (((DisposableObjectCollectionBase) e.SummaryValue.ParentRows).Count == 0 || ((GridItemBase) e.SummaryValue.ParentRows[0]).Band.Index == 0)
      return;
    e.SummaryValue.ParentRows[0].ParentRow.Cells[e.SummaryValue.Key].Value = e.SummaryValue.Value;
  }

  private void gridBudget_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
  }

  private void gridBudget_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (((GridItemBase) e.Row).Band.Index == 2)
    {
      if (Decimal.Parse(e.Row.Cells["ActualVBudget"].Value.ToString()) == 0M)
        ((AppearanceBase) e.Row.Cells["ActualVBudget"].Appearance).Image = (object) null;
      else if (Decimal.Parse(e.Row.Cells["ActualVBudget"].Value.ToString()) > 0M)
        ((AppearanceBase) e.Row.Cells["ActualVBudget"].Appearance).Image = (object) Resources.arrow_down;
      else
        ((AppearanceBase) e.Row.Cells["ActualVBudget"].Appearance).Image = (object) Resources.arrow_up_2;
    }
    if (((GridItemBase) e.Row).Band.Index != 0)
      return;
    Decimal num = 0M;
    foreach (UltraGridCell cell in e.Row.Cells)
    {
      if (((KeyedSubObjectBase) cell.Column).Key != "Total" && cell.Column.DataType == typeof (Decimal) && !((KeyedSubObjectBase) cell.Column).Key.Contains("SUM") && !DBNull.Value.Equals(cell.Value))
        num += Decimal.Parse(cell.Value.ToString());
    }
    e.Row.Cells["Total"].Value = (object) num;
  }

  private void CopyValue(UltraGridCell cell)
  {
    cell.Row.Update();
    foreach (UltraGridCell cell1 in cell.Row.Cells)
    {
      if (cell1.Column.DataType == typeof (Decimal))
        cell1.Value = cell.Value;
    }
  }

  private void timer1_Tick(object sender, EventArgs e)
  {
    this.statusStrip1.Visible = false;
    this.timer1.Stop();
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("Budget", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GlAcctID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Fiscal Year");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FullName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("F1");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("F2");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("F3");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("F4");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("F5");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("F6");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("F7");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("F8");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("F9");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("F10");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("F11");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("F12");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("GLAccountTypeId");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Budget_BudgetDetail");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Total", 0);
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("F1SUM", 1);
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("F2SUM", 2);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("F3SUM", 3);
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("F4SUM", 4);
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("F5SUM", 5);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("F6SUM", 6);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("F7SUM", 7);
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("F8SUM", 8);
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("F9SUM", 9);
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("F10SUM", 10);
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("F11SUM", 11);
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("F12SUM", 12);
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("TotalSUM", 13);
    Appearance appearance28 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, "-sum( [F1SUM] )", "F1", 3, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance29 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 6, "-sum( [F2SUM] )", "F2", 4, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance30 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 6, "-sum( [F3SUM] )", "F3", 5, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance31 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 6, "-sum( [F4SUM] )", "F4", 6, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance32 = new Appearance();
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 6, "-sum( [F5SUM] )", "F5", 7, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance33 = new Appearance();
    SummarySettings summarySettings6 = new SummarySettings("", (SummaryType) 6, "-sum( [F6SUM] )", "F6", 8, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance34 = new Appearance();
    SummarySettings summarySettings7 = new SummarySettings("", (SummaryType) 6, "-sum( [F7SUM] )", "F7", 9, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance35 = new Appearance();
    SummarySettings summarySettings8 = new SummarySettings("", (SummaryType) 6, "-sum( [F8SUM] )", "F8", 10, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance36 = new Appearance();
    SummarySettings summarySettings9 = new SummarySettings("", (SummaryType) 6, "-sum( [F9SUM] )", "F9", 11, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance37 = new Appearance();
    SummarySettings summarySettings10 = new SummarySettings("", (SummaryType) 6, "-sum( [F10SUM] )", "F10", 12, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance38 = new Appearance();
    SummarySettings summarySettings11 = new SummarySettings("", (SummaryType) 6, "-sum( [F11SUM] )", "F11", 13, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance39 = new Appearance();
    SummarySettings summarySettings12 = new SummarySettings("", (SummaryType) 6, "-sum( [F12SUM] )", "F12", 14, true, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance40 = new Appearance();
    SummarySettings summarySettings13 = new SummarySettings("", (SummaryType) 6, "-sum( [TotalSUM] )", "Total", 0, false, "Budget", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance41 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Budget_BudgetDetail", 0);
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("GLAcctId");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("CostCenter");
    Appearance appearance42 = new Appearance();
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("F1");
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("F2");
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("F3");
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("F4");
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("F5");
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("F6");
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("F7");
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("F8");
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("F9");
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("F10");
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("F11");
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("F12");
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("BudgetDetail_BudgetDetailRevision");
    SummarySettings summarySettings14 = new SummarySettings("F1", (SummaryType) 1, (string) null, "F1", 3, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance67 = new Appearance();
    SummarySettings summarySettings15 = new SummarySettings("F2", (SummaryType) 1, (string) null, "F2", 4, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance68 = new Appearance();
    SummarySettings summarySettings16 = new SummarySettings("F3", (SummaryType) 1, (string) null, "F3", 5, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance69 = new Appearance();
    SummarySettings summarySettings17 = new SummarySettings("F4", (SummaryType) 1, (string) null, "F4", 6, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance70 = new Appearance();
    SummarySettings summarySettings18 = new SummarySettings("F5", (SummaryType) 1, (string) null, "F5", 7, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance71 = new Appearance();
    SummarySettings summarySettings19 = new SummarySettings("F6", (SummaryType) 1, (string) null, "F6", 8, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance72 = new Appearance();
    SummarySettings summarySettings20 = new SummarySettings("F7", (SummaryType) 1, (string) null, "F7", 9, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance73 = new Appearance();
    SummarySettings summarySettings21 = new SummarySettings("F8", (SummaryType) 1, (string) null, "F8", 10, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance74 = new Appearance();
    SummarySettings summarySettings22 = new SummarySettings("F9", (SummaryType) 1, (string) null, "F9", 11, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance75 = new Appearance();
    SummarySettings summarySettings23 = new SummarySettings("F10", (SummaryType) 1, (string) null, "F10", 12, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance76 = new Appearance();
    SummarySettings summarySettings24 = new SummarySettings("F11", (SummaryType) 1, (string) null, "F11", 13, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance77 = new Appearance();
    SummarySettings summarySettings25 = new SummarySettings("F12", (SummaryType) 1, (string) null, "F12", 14, true, "Budget_BudgetDetail", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance78 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("BudgetDetail_BudgetDetailRevision", 1);
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("FiscalPeriod", -1, (object) null, 94883881, 0, 0);
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("Original", -1, (object) null, 94883876, 1, 0);
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("Actual", -1, (object) null, 94883876, 0, 0);
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("ActualVBudget", -1, (object) null, 94883876, 2, 0);
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("ActualVBudgetPCT", -1, (object) null, 94883876, 3, 0);
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("Q1", -1, (object) null, 94883877, 0, 0);
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("Q1PercentageFromOriginal", -1, (object) null, 94883877, 3, 0);
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("Q1Actual");
    Appearance appearance91 = new Appearance();
    Appearance appearance92 = new Appearance();
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("Q1ActualVBudget", -1, (object) null, 94883877, 1, 0);
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("Q1ActualVBudgetPCT", -1, (object) null, 94883877, 2, 0);
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("Q2", -1, (object) null, 94883878, 0, 0);
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("Q2PercentageFromPriorQtr", -1, (object) null, 94883878, 4, 0);
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("Q2PercentageFromOriginal", -1, (object) null, 94883878, 3, 0);
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("Q2Actual");
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("Q2ActualVBudget", -1, (object) null, 94883878, 1, 0);
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("Q2ActualVBudgetPCT", -1, (object) null, 94883878, 2, 0);
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("Q3", -1, (object) null, 94883879, 0, 0);
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("Q3PercentageFromPriorQtr1", -1, (object) null, 94883879, 4, 0);
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("Q3PercentageFromPriorQtr2", -1, (object) null, 94883879, 5, 0);
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("Q3PercentageFromOriginal", -1, (object) null, 94883879, 3, 0);
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("Q3Actual");
    Appearance appearance117 = new Appearance();
    Appearance appearance118 = new Appearance();
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("Q3ActualVBudget", -1, (object) null, 94883879, 1, 0);
    Appearance appearance119 = new Appearance();
    Appearance appearance120 = new Appearance();
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("Q3ActualVBudgetPCT", -1, (object) null, 94883879, 2, 0);
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("Q4", -1, (object) null, 94883880, 0, 0);
    Appearance appearance123 = new Appearance();
    Appearance appearance124 = new Appearance();
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("Q4PercentageFromPriorQtr1", -1, (object) null, 94883880, 4, 0);
    Appearance appearance125 = new Appearance();
    Appearance appearance126 = new Appearance();
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("Q4PercentageFromPriorQtr2", -1, (object) null, 94883880, 5, 0);
    Appearance appearance127 = new Appearance();
    Appearance appearance128 = new Appearance();
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("Q4PercentageFromPriorQtr3", -1, (object) null, 94883880, 6, 0);
    Appearance appearance129 = new Appearance();
    Appearance appearance130 = new Appearance();
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("Q4PercentageFromOriginal", -1, (object) null, 94883880, 3, 0);
    Appearance appearance131 = new Appearance();
    Appearance appearance132 = new Appearance();
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("Q4Actual");
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("Q4ActualVBudget", -1, (object) null, 94883880, 1, 0);
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("Q4ActualVBudgetPCT", -1, (object) null, 94883880, 2, 0);
    Appearance appearance137 = new Appearance();
    Appearance appearance138 = new Appearance();
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("GLAcctId");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("CostCenter");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("SystemDefined");
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("BudgetMonth");
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("FiscalKey");
    UltraGridGroup ultraGridGroup1 = new UltraGridGroup("Original", 94883876);
    UltraGridGroup ultraGridGroup2 = new UltraGridGroup("Q1", 94883877);
    UltraGridGroup ultraGridGroup3 = new UltraGridGroup("Q2", 94883878);
    UltraGridGroup ultraGridGroup4 = new UltraGridGroup("Q3", 94883879);
    UltraGridGroup ultraGridGroup5 = new UltraGridGroup("Q4", 94883880);
    UltraGridGroup ultraGridGroup6 = new UltraGridGroup("FiscalPeriod", 94883881);
    Appearance appearance139 = new Appearance();
    Appearance appearance140 = new Appearance();
    Appearance appearance141 = new Appearance();
    Appearance appearance142 = new Appearance();
    Appearance appearance143 = new Appearance();
    Appearance appearance144 = new Appearance();
    Appearance appearance145 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance146 = new Appearance();
    Appearance appearance147 = new Appearance();
    Appearance appearance148 = new Appearance();
    Appearance appearance149 = new Appearance();
    UltraToolbar ultraToolbar1 = new UltraToolbar("MainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("Save");
    ButtonTool buttonTool2 = new ButtonTool("Cancel");
    StateButtonTool stateButtonTool1 = new StateButtonTool("SHOWQ1", "");
    StateButtonTool stateButtonTool2 = new StateButtonTool("SHOWQ2", "");
    StateButtonTool stateButtonTool3 = new StateButtonTool("SHOWQ3", "");
    StateButtonTool stateButtonTool4 = new StateButtonTool("SHOWQ4", "");
    ButtonTool buttonTool3 = new ButtonTool("GETACTUAL");
    ButtonTool buttonTool4 = new ButtonTool("COPYVALUE");
    UltraToolbar ultraToolbar2 = new UltraToolbar("SearchOptions");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("FiscalYear");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("GL Company");
    ButtonTool buttonTool5 = new ButtonTool("Search");
    UltraToolbar ultraToolbar3 = new UltraToolbar("ChartingToolbar");
    ButtonTool buttonTool6 = new ButtonTool("Export Chart");
    ButtonTool buttonTool7 = new ButtonTool("Save");
    Appearance appearance150 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formBudget));
    Appearance appearance151 = new Appearance();
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("FiscalYear");
    Appearance appearance152 = new Appearance();
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("GL Company");
    ButtonTool buttonTool8 = new ButtonTool("Search");
    Appearance appearance153 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("Cancel");
    Appearance appearance154 = new Appearance();
    StateButtonTool stateButtonTool5 = new StateButtonTool("SHOWQ4", "");
    Appearance appearance155 = new Appearance();
    StateButtonTool stateButtonTool6 = new StateButtonTool("SHOWQ3", "");
    Appearance appearance156 = new Appearance();
    StateButtonTool stateButtonTool7 = new StateButtonTool("SHOWQ2", "");
    Appearance appearance157 = new Appearance();
    StateButtonTool stateButtonTool8 = new StateButtonTool("SHOWQ1", "");
    Appearance appearance158 = new Appearance();
    StateButtonTool stateButtonTool9 = new StateButtonTool("PIECHART", "");
    Appearance appearance159 = new Appearance();
    StateButtonTool stateButtonTool10 = new StateButtonTool("BARCHART", "");
    Appearance appearance160 = new Appearance();
    ControlContainerTool controlContainerTool5 = new ControlContainerTool("ACTUAL");
    Appearance appearance161 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("HIDEACTUAL");
    Appearance appearance162 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("ChartOptions");
    Appearance appearance163 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("Export Chart");
    Appearance appearance164 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("COPYVALUE");
    Appearance appearance165 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("GETACTUAL");
    Appearance appearance166 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    this.ultraTabPageControl3 = new UltraTabPageControl();
    this.statusStrip1 = new StatusStrip();
    this.labelStatusStrip = new ToolStripStatusLabel();
    this.gridBudget = new UltraGrid();
    this.ultraCalcManager1 = new UltraCalcManager(this.components);
    this.dsGLAccountBudgets1 = new dsGLAccountBudgets();
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.ledgerAccountBudgets1 = new LedgerAccountBudgets();
    this.quarterlyByCostCenter1 = new QuarterlyByCostCenter();
    this.budgetTrends1 = new BudgetTrends();
    this.panelCurtain = new Panel();
    this.panelLoading = new Panel();
    this.label1 = new Label();
    this.dateTimeActualAsOf = new MGADateTimePicker();
    this.dsCostCenters1 = new dsCostCenters();
    this.comboGLCompanyId = new MGASimpleComboBox();
    this.comboFiscalYear = new MGASimpleComboBox();
    this.dsFiscalYearList1 = new dsFiscalYearList();
    this._formBudget_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formBudget_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formBudget_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formBudget_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.ultraToolTipManager1 = new UltraToolTipManager(this.components);
    this.ultraTabControl2 = new UltraTabControl();
    this.ultraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.timer1 = new Timer(this.components);
    ((Control) this.ultraTabPageControl3).SuspendLayout();
    this.statusStrip1.SuspendLayout();
    ((ISupportInitialize) this.gridBudget).BeginInit();
    ((ISupportInitialize) this.ultraCalcManager1).BeginInit();
    this.dsGLAccountBudgets1.BeginInit();
    ((Control) this.ultraTabPageControl1).SuspendLayout();
    this.panelCurtain.SuspendLayout();
    this.panelLoading.SuspendLayout();
    ((ISupportInitialize) this.dateTimeActualAsOf).BeginInit();
    this.dsCostCenters1.BeginInit();
    ((ISupportInitialize) this.comboGLCompanyId).BeginInit();
    ((ISupportInitialize) this.comboFiscalYear).BeginInit();
    this.dsFiscalYearList1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.ultraTabControl2).BeginInit();
    ((Control) this.ultraTabControl2).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.statusStrip1);
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.gridBudget);
    ((Control) this.ultraTabPageControl3).Location = new Point(1, 22);
    ((Control) this.ultraTabPageControl3).Name = "ultraTabPageControl3";
    ((Control) this.ultraTabPageControl3).Size = new Size(1283, 597);
    this.statusStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.labelStatusStrip
    });
    this.statusStrip1.Location = new Point(0, 575);
    this.statusStrip1.Name = "statusStrip1";
    this.statusStrip1.Size = new Size(1283, 22);
    this.statusStrip1.TabIndex = 2;
    this.statusStrip1.Text = "statusStrip1";
    this.labelStatusStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
    this.labelStatusStrip.Name = "labelStatusStrip";
    this.labelStatusStrip.Size = new Size(0, 17);
    ((UltraGridBase) this.gridBudget).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    ((UltraGridBase) this.gridBudget).DataSource = (object) this.dsGLAccountBudgets1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridBudget).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 106;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 116;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "GL Account Name";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).Fixed = true;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 201;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn4.Format = "###,##0;###,###";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn5.Format = "###,##0;###,###";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn6.Format = "###,##0;###,###";
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn7.Format = "###,##0;###,###";
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance10;
    ultraGridColumn8.Format = "###,##0;###,###";
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn9.Format = "###,##0;###,###";
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn10.Format = "###,##0;###,###";
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 9;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance16;
    ultraGridColumn11.Format = "###,##0;###,###";
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance17;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 10;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance18;
    ultraGridColumn12.Format = "###,##0;###,###";
    ((AppearanceBase) appearance19).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance19;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 11;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance20;
    ultraGridColumn13.Format = "###,##0;###,###";
    ((AppearanceBase) appearance21).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 12;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance22;
    ultraGridColumn14.Format = "###,##0;###,###";
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 13;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance24;
    ultraGridColumn15.Format = "###,##0;###,###";
    ((AppearanceBase) appearance25).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 14;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 30;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance26).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance26;
    ultraGridColumn18.DataType = typeof (Decimal);
    ultraGridColumn18.Format = "###,##0;###,###";
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance27;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.DataType = typeof (Decimal);
    ultraGridColumn19.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F1], ([F1] * -1)))";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 17;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.DataType = typeof (Decimal);
    ultraGridColumn20.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F2], ([F2] * -1)))";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 18;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.DataType = typeof (Decimal);
    ultraGridColumn21.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F3], ([F3] * -1)))";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 19;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.DataType = typeof (Decimal);
    ultraGridColumn22.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F4], ([F4] * -1)))";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 20;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.DataType = typeof (Decimal);
    ultraGridColumn23.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F5], ([F5] * -1)))";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 21;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.DataType = typeof (Decimal);
    ultraGridColumn24.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F6], ([F6] * -1)))";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 22;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn25.DataType = typeof (Decimal);
    ultraGridColumn25.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F7], ([F7] * -1)))";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 23;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.DataType = typeof (Decimal);
    ultraGridColumn26.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F8], ([F8] * -1)))";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 24;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.DataType = typeof (Decimal);
    ultraGridColumn27.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F9], ([F9] * -1)))";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 25;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.DataType = typeof (Decimal);
    ultraGridColumn28.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F10], ([F10] * -1)))";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 26;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn29.DataType = typeof (Decimal);
    ultraGridColumn29.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F11], ([F11] * -1)))";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 27;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn30.DataType = typeof (Decimal);
    ultraGridColumn30.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [F12], ([F12] * -1)))";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 28;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn31.DataType = typeof (Decimal);
    ultraGridColumn31.Formula = "IF( [GLAccountTypeId]  = 'P', 0, IF( [GLAccountTypeId]  = 'E', [Total], ([Total] * -1)))";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 29;
    ultraGridColumn31.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[31 /*0x1F*/]
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
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
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
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ultraGridBand1.Override.HeaderAppearance = (AppearanceBase) appearance28;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand1.Override.HeaderStyle = (HeaderStyle) 3;
    ((AppearanceBase) appearance29).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance29;
    summarySettings1.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance30).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance30;
    summarySettings2.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance31).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance31;
    summarySettings3.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance32).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance32;
    summarySettings4.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance33).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance33;
    summarySettings5.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance34).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    summarySettings6.Appearance = (AppearanceBase) appearance34;
    summarySettings6.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance35).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Right";
    summarySettings7.Appearance = (AppearanceBase) appearance35;
    summarySettings7.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance36).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Right";
    summarySettings8.Appearance = (AppearanceBase) appearance36;
    summarySettings8.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance37).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    summarySettings9.Appearance = (AppearanceBase) appearance37;
    summarySettings9.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance38).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    summarySettings10.Appearance = (AppearanceBase) appearance38;
    summarySettings10.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance39).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    summarySettings11.Appearance = (AppearanceBase) appearance39;
    summarySettings11.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance40).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    summarySettings12.Appearance = (AppearanceBase) appearance40;
    summarySettings12.DisplayFormat = "{0:###,###,##0.#0}";
    ((AppearanceBase) appearance41).BackColor = Color.AntiqueWhite;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Right";
    summarySettings13.Appearance = (AppearanceBase) appearance41;
    summarySettings13.DisplayFormat = "{0:###,###,##0.#0}";
    ultraGridBand1.Summaries.AddRange(new SummarySettings[13]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3,
      summarySettings4,
      summarySettings5,
      summarySettings6,
      summarySettings7,
      summarySettings8,
      summarySettings9,
      summarySettings10,
      summarySettings11,
      summarySettings12,
      summarySettings13
    });
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 0;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 1;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn34.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn34.Header).Appearance = (AppearanceBase) appearance42;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Cost Center";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 2;
    ultraGridColumn34.Width = 182;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance43).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance43).TextHAlignAsString = "Right";
    ultraGridColumn35.CellAppearance = (AppearanceBase) appearance43;
    ultraGridColumn35.Format = "###,##0;###,###";
    ((AppearanceBase) appearance44).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn35.Header).Appearance = (AppearanceBase) appearance44;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 3;
    ultraGridColumn35.NullText = "0";
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance45).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance45).TextHAlignAsString = "Right";
    ultraGridColumn36.CellAppearance = (AppearanceBase) appearance45;
    ultraGridColumn36.Format = "###,##0;###,###";
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn36.Header).Appearance = (AppearanceBase) appearance46;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 4;
    ultraGridColumn36.NullText = "0";
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance47).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    ultraGridColumn37.CellAppearance = (AppearanceBase) appearance47;
    ultraGridColumn37.Format = "###,##0;###,###";
    ((AppearanceBase) appearance48).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn37.Header).Appearance = (AppearanceBase) appearance48;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 5;
    ultraGridColumn37.NullText = "0";
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance49).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    ultraGridColumn38.CellAppearance = (AppearanceBase) appearance49;
    ultraGridColumn38.Format = "###,##0;###,###";
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn38.Header).Appearance = (AppearanceBase) appearance50;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 6;
    ultraGridColumn38.NullText = "0";
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance51).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ultraGridColumn39.CellAppearance = (AppearanceBase) appearance51;
    ultraGridColumn39.Format = "###,##0;###,###";
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn39.Header).Appearance = (AppearanceBase) appearance52;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 7;
    ultraGridColumn39.NullText = "0";
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance53).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    ultraGridColumn40.CellAppearance = (AppearanceBase) appearance53;
    ultraGridColumn40.Format = "###,##0;###,###";
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn40.Header).Appearance = (AppearanceBase) appearance54;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 8;
    ultraGridColumn40.NullText = "0";
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance55).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    ultraGridColumn41.CellAppearance = (AppearanceBase) appearance55;
    ultraGridColumn41.Format = "###,##0;###,###";
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn41.Header).Appearance = (AppearanceBase) appearance56;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 9;
    ultraGridColumn41.NullText = "0";
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance57).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ultraGridColumn42.CellAppearance = (AppearanceBase) appearance57;
    ultraGridColumn42.Format = "###,##0;###,###";
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn42.Header).Appearance = (AppearanceBase) appearance58;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn42.Header).VisiblePosition = 10;
    ultraGridColumn42.NullText = "0";
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance59).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ultraGridColumn43.CellAppearance = (AppearanceBase) appearance59;
    ultraGridColumn43.Format = "###,##0;###,###";
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn43.Header).Appearance = (AppearanceBase) appearance60;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn43.Header).VisiblePosition = 11;
    ultraGridColumn43.NullText = "0";
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance61).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance61).TextHAlignAsString = "Right";
    ultraGridColumn44.CellAppearance = (AppearanceBase) appearance61;
    ultraGridColumn44.Format = "###,##0;###,###";
    ((AppearanceBase) appearance62).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn44.Header).Appearance = (AppearanceBase) appearance62;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn44.Header).VisiblePosition = 12;
    ultraGridColumn44.NullText = "0";
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance63).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance63).TextHAlignAsString = "Right";
    ultraGridColumn45.CellAppearance = (AppearanceBase) appearance63;
    ultraGridColumn45.Format = "###,##0;###,###";
    ((AppearanceBase) appearance64).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn45.Header).Appearance = (AppearanceBase) appearance64;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn45.Header).VisiblePosition = 13;
    ultraGridColumn45.NullText = "0";
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance65).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance65).TextHAlignAsString = "Right";
    ultraGridColumn46.CellAppearance = (AppearanceBase) appearance65;
    ultraGridColumn46.Format = "###,##0;###,###";
    ((AppearanceBase) appearance66).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn46.Header).Appearance = (AppearanceBase) appearance66;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn46.Header).VisiblePosition = 14;
    ultraGridColumn46.NullText = "0";
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn47.Header).VisiblePosition = 15;
    ultraGridBand2.Columns.AddRange(new object[16 /*0x10*/]
    {
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47
    });
    ((AppearanceBase) appearance67).TextHAlignAsString = "Right";
    summarySettings14.Appearance = (AppearanceBase) appearance67;
    summarySettings14.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance68).TextHAlignAsString = "Right";
    summarySettings15.Appearance = (AppearanceBase) appearance68;
    summarySettings15.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance69).TextHAlignAsString = "Right";
    summarySettings16.Appearance = (AppearanceBase) appearance69;
    summarySettings16.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance70).TextHAlignAsString = "Right";
    summarySettings17.Appearance = (AppearanceBase) appearance70;
    summarySettings17.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance71).TextHAlignAsString = "Right";
    summarySettings18.Appearance = (AppearanceBase) appearance71;
    summarySettings18.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance72).TextHAlignAsString = "Right";
    summarySettings19.Appearance = (AppearanceBase) appearance72;
    summarySettings19.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance73).TextHAlignAsString = "Right";
    summarySettings20.Appearance = (AppearanceBase) appearance73;
    summarySettings20.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance74).TextHAlignAsString = "Right";
    summarySettings21.Appearance = (AppearanceBase) appearance74;
    summarySettings21.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance75).TextHAlignAsString = "Right";
    summarySettings22.Appearance = (AppearanceBase) appearance75;
    summarySettings22.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance76).TextHAlignAsString = "Right";
    summarySettings23.Appearance = (AppearanceBase) appearance76;
    summarySettings23.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance77).TextHAlignAsString = "Right";
    summarySettings24.Appearance = (AppearanceBase) appearance77;
    summarySettings24.DisplayFormat = "{0:##,##0}";
    ((AppearanceBase) appearance78).TextHAlignAsString = "Right";
    summarySettings25.Appearance = (AppearanceBase) appearance78;
    summarySettings25.DisplayFormat = "{0:##,##0}";
    ultraGridBand2.Summaries.AddRange(new SummarySettings[12]
    {
      summarySettings14,
      summarySettings15,
      summarySettings16,
      summarySettings17,
      summarySettings18,
      summarySettings19,
      summarySettings20,
      summarySettings21,
      summarySettings22,
      summarySettings23,
      summarySettings24,
      summarySettings25
    });
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn48.CellActivation = (Activation) 3;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn49.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance79).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance79).TextHAlignAsString = "Right";
    ultraGridColumn49.CellAppearance = (AppearanceBase) appearance79;
    ultraGridColumn49.Format = "###,##0;###,###";
    ((AppearanceBase) appearance80).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn49.Header).Appearance = (AppearanceBase) appearance80;
    ((HeaderBase) ultraGridColumn49.Header).Caption = "Budget";
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn50.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance81).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance81).TextHAlignAsString = "Right";
    ultraGridColumn50.CellAppearance = (AppearanceBase) appearance81;
    ultraGridColumn50.Format = "###,##0;###,###";
    ((AppearanceBase) appearance82).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn50.Header).Appearance = (AppearanceBase) appearance82;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn51.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance83).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance83).TextHAlignAsString = "Right";
    ultraGridColumn51.CellAppearance = (AppearanceBase) appearance83;
    ultraGridColumn51.Format = "###,##0;###,###";
    ((AppearanceBase) appearance84).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn51.Header).Appearance = (AppearanceBase) appearance84;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn52.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance85).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance85).TextHAlignAsString = "Right";
    ultraGridColumn52.CellAppearance = (AppearanceBase) appearance85;
    ultraGridColumn52.Format = "p";
    ((AppearanceBase) appearance86).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn52.Header).Appearance = (AppearanceBase) appearance86;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance87).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance87).TextHAlignAsString = "Right";
    ultraGridColumn53.CellAppearance = (AppearanceBase) appearance87;
    ultraGridColumn53.Format = "###,##0;###,###";
    ((AppearanceBase) appearance88).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn53.Header).Appearance = (AppearanceBase) appearance88;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn54.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance89).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance89).TextHAlignAsString = "Right";
    ultraGridColumn54.CellAppearance = (AppearanceBase) appearance89;
    ultraGridColumn54.Format = "p";
    ((AppearanceBase) appearance90).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn54.Header).Appearance = (AppearanceBase) appearance90;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn55.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance91).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance91).TextHAlignAsString = "Right";
    ultraGridColumn55.CellAppearance = (AppearanceBase) appearance91;
    ultraGridColumn55.Format = "###,##0;###,###";
    ((AppearanceBase) appearance92).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn55.Header).Appearance = (AppearanceBase) appearance92;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn55.Header).VisiblePosition = 27;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn56.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance93).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance93).TextHAlignAsString = "Right";
    ultraGridColumn56.CellAppearance = (AppearanceBase) appearance93;
    ultraGridColumn56.Format = "###,##0;###,###";
    ((AppearanceBase) appearance94).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn56.Header).Appearance = (AppearanceBase) appearance94;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn57.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance95).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance95).TextHAlignAsString = "Right";
    ultraGridColumn57.CellAppearance = (AppearanceBase) appearance95;
    ultraGridColumn57.Format = "p";
    ((AppearanceBase) appearance96).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn57.Header).Appearance = (AppearanceBase) appearance96;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance97).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance97).TextHAlignAsString = "Right";
    ultraGridColumn58.CellAppearance = (AppearanceBase) appearance97;
    ultraGridColumn58.Format = "###,##0;###,###";
    ((AppearanceBase) appearance98).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn58.Header).Appearance = (AppearanceBase) appearance98;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn59.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance99).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance99).TextHAlignAsString = "Right";
    ultraGridColumn59.CellAppearance = (AppearanceBase) appearance99;
    ultraGridColumn59.Format = "p";
    ((AppearanceBase) appearance100).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn59.Header).Appearance = (AppearanceBase) appearance100;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn60.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance101).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance101).TextHAlignAsString = "Right";
    ultraGridColumn60.CellAppearance = (AppearanceBase) appearance101;
    ultraGridColumn60.Format = "p";
    ((AppearanceBase) appearance102).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn60.Header).Appearance = (AppearanceBase) appearance102;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn61.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance103).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance103).TextHAlignAsString = "Right";
    ultraGridColumn61.CellAppearance = (AppearanceBase) appearance103;
    ultraGridColumn61.Format = "###,##0;###,###";
    ((AppearanceBase) appearance104).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn61.Header).Appearance = (AppearanceBase) appearance104;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn61.Header).VisiblePosition = 28;
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn62.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance105).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance105).TextHAlignAsString = "Right";
    ultraGridColumn62.CellAppearance = (AppearanceBase) appearance105;
    ultraGridColumn62.Format = "###,##0;###,###";
    ((AppearanceBase) appearance106).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn62.Header).Appearance = (AppearanceBase) appearance106;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn63.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance107).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance107).TextHAlignAsString = "Right";
    ultraGridColumn63.CellAppearance = (AppearanceBase) appearance107;
    ultraGridColumn63.Format = "p";
    ((AppearanceBase) appearance108).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn63.Header).Appearance = (AppearanceBase) appearance108;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance109).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance109).TextHAlignAsString = "Right";
    ultraGridColumn64.CellAppearance = (AppearanceBase) appearance109;
    ultraGridColumn64.Format = "###,##0;###,###";
    ((AppearanceBase) appearance110).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn64.Header).Appearance = (AppearanceBase) appearance110;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn65.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance111).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance111).TextHAlignAsString = "Right";
    ultraGridColumn65.CellAppearance = (AppearanceBase) appearance111;
    ultraGridColumn65.Format = "p";
    ((AppearanceBase) appearance112).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn65.Header).Appearance = (AppearanceBase) appearance112;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn66.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance113).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance113).TextHAlignAsString = "Right";
    ultraGridColumn66.CellAppearance = (AppearanceBase) appearance113;
    ultraGridColumn66.Format = "p";
    ((AppearanceBase) appearance114).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn66.Header).Appearance = (AppearanceBase) appearance114;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn67.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance115).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance115).TextHAlignAsString = "Right";
    ultraGridColumn67.CellAppearance = (AppearanceBase) appearance115;
    ultraGridColumn67.Format = "p";
    ((AppearanceBase) appearance116).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn67.Header).Appearance = (AppearanceBase) appearance116;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn68.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance117).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance117).TextHAlignAsString = "Right";
    ultraGridColumn68.CellAppearance = (AppearanceBase) appearance117;
    ultraGridColumn68.Format = "###,##0;###,###";
    ((AppearanceBase) appearance118).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn68.Header).Appearance = (AppearanceBase) appearance118;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn68.Header).VisiblePosition = 29;
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn69.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance119).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance119).TextHAlignAsString = "Right";
    ultraGridColumn69.CellAppearance = (AppearanceBase) appearance119;
    ultraGridColumn69.Format = "###,##0;###,###";
    ((AppearanceBase) appearance120).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn69.Header).Appearance = (AppearanceBase) appearance120;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn70.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance121).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance121).TextHAlignAsString = "Right";
    ultraGridColumn70.CellAppearance = (AppearanceBase) appearance121;
    ultraGridColumn70.Format = "p";
    ((AppearanceBase) appearance122).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn70.Header).Appearance = (AppearanceBase) appearance122;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance123).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance123).TextHAlignAsString = "Right";
    ultraGridColumn71.CellAppearance = (AppearanceBase) appearance123;
    ultraGridColumn71.Format = "###,##0;###,###";
    ((AppearanceBase) appearance124).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn71.Header).Appearance = (AppearanceBase) appearance124;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn72.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance125).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance125).TextHAlignAsString = "Right";
    ultraGridColumn72.CellAppearance = (AppearanceBase) appearance125;
    ultraGridColumn72.Format = "p";
    ((AppearanceBase) appearance126).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn72.Header).Appearance = (AppearanceBase) appearance126;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn73.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance127).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance127).TextHAlignAsString = "Right";
    ultraGridColumn73.CellAppearance = (AppearanceBase) appearance127;
    ultraGridColumn73.Format = "p";
    ((AppearanceBase) appearance128).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn73.Header).Appearance = (AppearanceBase) appearance128;
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn74.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance129).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance129).TextHAlignAsString = "Right";
    ultraGridColumn74.CellAppearance = (AppearanceBase) appearance129;
    ultraGridColumn74.Format = "p";
    ((AppearanceBase) appearance130).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn74.Header).Appearance = (AppearanceBase) appearance130;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn75.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn75.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance131).BackColor = Color.DarkOrange;
    ((AppearanceBase) appearance131).TextHAlignAsString = "Right";
    ultraGridColumn75.CellAppearance = (AppearanceBase) appearance131;
    ultraGridColumn75.Format = "p";
    ((AppearanceBase) appearance132).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn75.Header).Appearance = (AppearanceBase) appearance132;
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn76.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance133).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance133).TextHAlignAsString = "Right";
    ultraGridColumn76.CellAppearance = (AppearanceBase) appearance133;
    ultraGridColumn76.Format = "###,##0;###,###";
    ((AppearanceBase) appearance134).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn76.Header).Appearance = (AppearanceBase) appearance134;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn76.Header).VisiblePosition = 30;
    ultraGridColumn77.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn77.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance135).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance135).TextHAlignAsString = "Right";
    ultraGridColumn77.CellAppearance = (AppearanceBase) appearance135;
    ultraGridColumn77.Format = "###,##0;###,###";
    ((AppearanceBase) appearance136).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn77.Header).Appearance = (AppearanceBase) appearance136;
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn78.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance137).BackColor = Color.Cornsilk;
    ((AppearanceBase) appearance137).TextHAlignAsString = "Right";
    ultraGridColumn78.CellAppearance = (AppearanceBase) appearance137;
    ultraGridColumn78.Format = "p";
    ((AppearanceBase) appearance138).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn78.Header).Appearance = (AppearanceBase) appearance138;
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn79.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn79.Header).VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn79.Hidden = true;
    ultraGridColumn80.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn80.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn80.Header).VisiblePosition = 32 /*0x20*/;
    ultraGridColumn80.Hidden = true;
    ultraGridColumn81.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn81.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn81.Header).VisiblePosition = 33;
    ultraGridColumn81.Hidden = true;
    ultraGridColumn82.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn82.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn82.Header).VisiblePosition = 34;
    ultraGridColumn82.Hidden = true;
    ultraGridColumn83.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn83.Header).VisiblePosition = 35;
    ultraGridColumn84.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn84.Header).VisiblePosition = 36;
    ultraGridBand3.Columns.AddRange(new object[37]
    {
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55,
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75,
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78,
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82,
      (object) ultraGridColumn83,
      (object) ultraGridColumn84
    });
    ((HeaderBase) ultraGridGroup1.Header).Caption = "Original Budget";
    ((HeaderBase) ultraGridGroup1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridGroup1.Header).VisiblePosition = 1;
    ((KeyedSubObjectBase) ultraGridGroup1).Key = "Original";
    ((HeaderBase) ultraGridGroup2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridGroup2.Header).VisiblePosition = 2;
    ultraGridGroup2.Hidden = true;
    ((KeyedSubObjectBase) ultraGridGroup2).Key = "Q1";
    ((HeaderBase) ultraGridGroup3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridGroup3.Header).VisiblePosition = 3;
    ultraGridGroup3.Hidden = true;
    ((KeyedSubObjectBase) ultraGridGroup3).Key = "Q2";
    ((HeaderBase) ultraGridGroup4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridGroup4.Header).VisiblePosition = 4;
    ultraGridGroup4.Hidden = true;
    ((KeyedSubObjectBase) ultraGridGroup4).Key = "Q3";
    ((HeaderBase) ultraGridGroup5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridGroup5.Header).VisiblePosition = 5;
    ultraGridGroup5.Hidden = true;
    ((KeyedSubObjectBase) ultraGridGroup5).Key = "Q4";
    ((HeaderBase) ultraGridGroup6.Header).Caption = "";
    ((HeaderBase) ultraGridGroup6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridGroup6.Header).VisiblePosition = 0;
    ((KeyedSubObjectBase) ultraGridGroup6).Key = "FiscalPeriod";
    ultraGridBand3.Groups.AddRange(new UltraGridGroup[6]
    {
      ultraGridGroup1,
      ultraGridGroup2,
      ultraGridGroup3,
      ultraGridGroup4,
      ultraGridGroup5,
      ultraGridGroup6
    });
    ((UltraGridBase) this.gridBudget).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridBudget).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridBudget).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridBudget).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance139).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance139).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance139).ForeColor = Color.Black;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance139;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance140).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance140;
    ((AppearanceBase) appearance141).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance141;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance142).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance142;
    ((AppearanceBase) appearance143).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance143;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance144).BackColor = Color.Transparent;
    ((AppearanceBase) appearance144).ForeColor = Color.Black;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance144;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance145).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridBudget).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance145;
    ((AppearanceBase) appearance146).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance146).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance146;
    ((AppearanceBase) appearance147).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance147;
    ((UltraGridBase) this.gridBudget).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridBudget).Dock = DockStyle.Fill;
    ((Control) this.gridBudget).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridBudget).Location = new Point(0, 0);
    ((Control) this.gridBudget).Name = "gridBudget";
    ((Control) this.gridBudget).Size = new Size(1283, 597);
    ((Control) this.gridBudget).TabIndex = 0;
    this.gridBudget.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridBudget).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridBudget).UseOsThemes = (DefaultableBoolean) 2;
    this.gridBudget.AfterCellUpdate += new CellEventHandler(this.gridBudget_AfterCellUpdate);
    this.gridBudget.InitializeLayout += new InitializeLayoutEventHandler(this.gridBudget_InitializeLayout);
    this.gridBudget.InitializeRow += new InitializeRowEventHandler(this.gridBudget_InitializeRow);
    this.gridBudget.SummaryValueChanged += new SummaryValueChangedEventHandler(this.gridBudget_SummaryValueChanged);
    this.ultraCalcManager1.ContainingControl = (ContainerControl) this;
    this.dsGLAccountBudgets1.DataSetName = "dsGLAccountBudgets";
    this.dsGLAccountBudgets1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.ledgerAccountBudgets1);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.quarterlyByCostCenter1);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.budgetTrends1);
    ((Control) this.ultraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(1283, 597);
    this.ledgerAccountBudgets1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.ledgerAccountBudgets1.Location = new Point(770, 4);
    this.ledgerAccountBudgets1.Name = "ledgerAccountBudgets1";
    this.ledgerAccountBudgets1.Size = new Size(510, 413);
    this.ledgerAccountBudgets1.TabIndex = 2;
    this.quarterlyByCostCenter1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.quarterlyByCostCenter1.BackColor = Color.Transparent;
    this.quarterlyByCostCenter1.Font = new Font("Tahoma", 8.25f);
    this.quarterlyByCostCenter1.Location = new Point(2, 4);
    this.quarterlyByCostCenter1.Name = "quarterlyByCostCenter1";
    this.quarterlyByCostCenter1.Size = new Size(762, 413);
    this.quarterlyByCostCenter1.TabIndex = 1;
    this.budgetTrends1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.budgetTrends1.BackColor = Color.Transparent;
    this.budgetTrends1.Location = new Point(1, 423);
    this.budgetTrends1.Name = "budgetTrends1";
    this.budgetTrends1.Size = new Size(1276, 174);
    this.budgetTrends1.TabIndex = 0;
    this.panelCurtain.Controls.Add((Control) this.panelLoading);
    this.panelCurtain.Controls.Add((Control) this.dateTimeActualAsOf);
    this.panelCurtain.Dock = DockStyle.Fill;
    this.panelCurtain.Location = new Point(0, 56);
    this.panelCurtain.Name = "panelCurtain";
    this.panelCurtain.Size = new Size(1285, 620);
    this.panelCurtain.TabIndex = 1;
    this.panelLoading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelLoading.Controls.Add((Control) this.label1);
    this.panelLoading.Location = new Point(0, 236);
    this.panelLoading.Name = "panelLoading";
    this.panelLoading.Size = new Size(1281, 340);
    this.panelLoading.TabIndex = 1;
    this.panelLoading.Visible = false;
    this.label1.Dock = DockStyle.Fill;
    this.label1.Location = new Point(0, 0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(1281, 340);
    this.label1.TabIndex = 1;
    this.label1.Text = "Loading budget data...";
    this.label1.TextAlign = ContentAlignment.MiddleCenter;
    ((AppearanceBase) appearance148).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance148).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance148).FontData.SizeInPoints = 8.25f;
    this.dateTimeActualAsOf.Appearance = (AppearanceBase) appearance148;
    ((AppearanceBase) appearance149).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance149).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance149).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance149).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance149).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance149).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance149).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance149).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance149).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance149).ForegroundAlpha = (Alpha) 2;
    this.dateTimeActualAsOf.ButtonAppearance = (AppearanceBase) appearance149;
    this.dateTimeActualAsOf.DateTime = new DateTime(2011, 7, 20, 0, 0, 0, 0);
    ((Control) this.dateTimeActualAsOf).Location = new Point(183, (int) byte.MaxValue);
    this.dateTimeActualAsOf.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeActualAsOf).Name = "dateTimeActualAsOf";
    ((Control) this.dateTimeActualAsOf).Size = new Size(85, 20);
    ((Control) this.dateTimeActualAsOf).TabIndex = 2;
    ((UltraControlBase) this.dateTimeActualAsOf).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeActualAsOf).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeActualAsOf.Value = (object) new DateTime(2011, 7, 20, 0, 0, 0, 0);
    this.dsCostCenters1.DataSetName = "dsCostCenters";
    this.dsCostCenters1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.comboGLCompanyId.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboGLCompanyId).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    this.comboGLCompanyId.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGLCompanyId).Location = new Point(442, 95);
    this.comboGLCompanyId.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompanyId).Name = "comboGLCompanyId";
    ((Control) this.comboGLCompanyId).Size = new Size(293, 21);
    ((Control) this.comboGLCompanyId).TabIndex = 1;
    ((UltraControlBase) this.comboGLCompanyId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompanyId).UseOsThemes = (DefaultableBoolean) 2;
    this.comboFiscalYear.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboFiscalYear).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    ((UltraGridBase) this.comboFiscalYear).DataMember = "FiscalYears";
    ((UltraGridBase) this.comboFiscalYear).DataSource = (object) this.dsFiscalYearList1;
    ((UltraDropDownBase) this.comboFiscalYear).DisplayMember = "FiscalYear";
    this.comboFiscalYear.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboFiscalYear).Location = new Point(267, 109);
    this.comboFiscalYear.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboFiscalYear).Name = "comboFiscalYear";
    ((Control) this.comboFiscalYear).Size = new Size(119, 21);
    ((Control) this.comboFiscalYear).TabIndex = 0;
    ((UltraControlBase) this.comboFiscalYear).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboFiscalYear).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboFiscalYear).ValueMember = "FiscalYear";
    this.dsFiscalYearList1.DataSetName = "FiscalYearList";
    this.dsFiscalYearList1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._formBudget_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formBudget_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formBudget_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formBudget_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formBudget_Toolbars_Dock_Area_Left).Location = new Point(0, 56);
    ((Control) this._formBudget_Toolbars_Dock_Area_Left).Name = "_formBudget_Toolbars_Dock_Area_Left";
    ((Control) this._formBudget_Toolbars_Dock_Area_Left).Size = new Size(0, 620);
    this._formBudget_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 0;
    ((ToolBase) stateButtonTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) stateButtonTool1,
      (ToolBase) stateButtonTool2,
      (ToolBase) stateButtonTool3,
      (ToolBase) stateButtonTool4,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ultraToolbar1.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.FillEntireRow = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar1.Text = "MainToolbar";
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 1;
    controlContainerTool1.ControlName = "comboFiscalYear";
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).InstanceProps).Width = 205;
    controlContainerTool2.ControlName = "comboGLCompanyId";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).InstanceProps).Width = 372;
    ((UltraToolbarBase) ultraToolbar2).NonInheritedTools.AddRange(new ToolBase[3]
    {
      (ToolBase) controlContainerTool1,
      (ToolBase) controlContainerTool2,
      (ToolBase) buttonTool5
    });
    ultraToolbar2.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar2.Text = "SearchOptions";
    ultraToolbar3.DockedColumn = 1;
    ultraToolbar3.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar3).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool6
    });
    ultraToolbar3.Text = "ChartingToolbar";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[3]
    {
      ultraToolbar1,
      ultraToolbar2,
      ultraToolbar3
    });
    ((AppearanceBase) appearance150).Image = componentResourceManager.GetObject("appearance3.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance150;
    ((AppearanceBase) appearance151).Image = componentResourceManager.GetObject("appearance4.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance151;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool3.ControlName = "comboFiscalYear";
    ((AppearanceBase) appearance152).Image = componentResourceManager.GetObject("appearance5.Image");
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance152;
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).Caption = "Fiscal Year";
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).Width = 205;
    controlContainerTool4.ControlName = "comboGLCompanyId";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Caption = "GL Company";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Width = 372;
    ((AppearanceBase) appearance153).Image = componentResourceManager.GetObject("appearance6.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance153;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Search";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance154).Image = componentResourceManager.GetObject("appearance7.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance154;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Cancel Changes";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance155).Image = componentResourceManager.GetObject("appearance8.Image");
    ((ToolPropsBase) ((ToolBase) stateButtonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance155;
    ((ToolPropsBase) ((ToolBase) stateButtonTool5).SharedPropsInternal).Caption = "Q4";
    ((ToolPropsBase) ((ToolBase) stateButtonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) stateButtonTool5).SharedPropsInternal.Enabled = false;
    ((AppearanceBase) appearance156).Image = componentResourceManager.GetObject("appearance9.Image");
    ((ToolPropsBase) ((ToolBase) stateButtonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance156;
    ((ToolPropsBase) ((ToolBase) stateButtonTool6).SharedPropsInternal).Caption = "Q3";
    ((ToolPropsBase) ((ToolBase) stateButtonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) stateButtonTool6).SharedPropsInternal.Enabled = false;
    ((AppearanceBase) appearance157).Image = componentResourceManager.GetObject("appearance10.Image");
    ((ToolPropsBase) ((ToolBase) stateButtonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance157;
    ((ToolPropsBase) ((ToolBase) stateButtonTool7).SharedPropsInternal).Caption = "Q2";
    ((ToolBase) stateButtonTool7).SharedPropsInternal.Category = "Q2";
    ((ToolPropsBase) ((ToolBase) stateButtonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) stateButtonTool7).SharedPropsInternal.Enabled = false;
    ((AppearanceBase) appearance158).Image = componentResourceManager.GetObject("appearance11.Image");
    ((ToolPropsBase) ((ToolBase) stateButtonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance158;
    ((ToolPropsBase) ((ToolBase) stateButtonTool8).SharedPropsInternal).Caption = "Q1";
    ((ToolPropsBase) ((ToolBase) stateButtonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) stateButtonTool8).SharedPropsInternal.Enabled = false;
    ((AppearanceBase) appearance159).Image = componentResourceManager.GetObject("appearance12.Image");
    ((ToolPropsBase) ((ToolBase) stateButtonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance159;
    ((ToolPropsBase) ((ToolBase) stateButtonTool9).SharedPropsInternal).Caption = "Pie Chart";
    ((AppearanceBase) appearance160).Image = componentResourceManager.GetObject("appearance13.Image");
    ((ToolPropsBase) ((ToolBase) stateButtonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance160;
    ((ToolPropsBase) ((ToolBase) stateButtonTool10).SharedPropsInternal).Caption = "Bar Chart";
    controlContainerTool5.ControlName = "dateTimeActualAsOf";
    ((AppearanceBase) appearance161).Image = componentResourceManager.GetObject("appearance14.Image");
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance161;
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).Caption = "Actual as of";
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance162).Image = componentResourceManager.GetObject("appearance15.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance162;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Hide Actual";
    ((ToolBase) buttonTool10).SharedPropsInternal.ToolTipText = "Click here to hide the actual numbers.";
    ((ToolBase) buttonTool10).SharedPropsInternal.ToolTipTitle = "Hide Actual";
    ((AppearanceBase) appearance163).Image = componentResourceManager.GetObject("appearance16.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance163;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Show Chart";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance164).Image = componentResourceManager.GetObject("appearance17.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance164;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Export Chart";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance165).Image = componentResourceManager.GetObject("appearance18.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance165;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Copy Budget Value";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool13).SharedPropsInternal.Shortcut = Shortcut.AltRightArrow;
    ((AppearanceBase) appearance166).Image = componentResourceManager.GetObject("appearance19.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance166;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Refresh Actuals";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool14).SharedPropsInternal.ToolTipText = "Click to show the actual numbers as of the date specified.";
    ((ToolBase) buttonTool14).SharedPropsInternal.ToolTipTitle = "Show Actual";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[17]
    {
      (ToolBase) buttonTool7,
      (ToolBase) controlContainerTool3,
      (ToolBase) controlContainerTool4,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) stateButtonTool5,
      (ToolBase) stateButtonTool6,
      (ToolBase) stateButtonTool7,
      (ToolBase) stateButtonTool8,
      (ToolBase) stateButtonTool9,
      (ToolBase) stateButtonTool10,
      (ToolBase) controlContainerTool5,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._formBudget_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formBudget_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formBudget_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formBudget_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formBudget_Toolbars_Dock_Area_Right).Location = new Point(1285, 56);
    ((Control) this._formBudget_Toolbars_Dock_Area_Right).Name = "_formBudget_Toolbars_Dock_Area_Right";
    ((Control) this._formBudget_Toolbars_Dock_Area_Right).Size = new Size(0, 620);
    this._formBudget_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formBudget_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formBudget_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formBudget_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formBudget_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formBudget_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formBudget_Toolbars_Dock_Area_Top).Name = "_formBudget_Toolbars_Dock_Area_Top";
    ((Control) this._formBudget_Toolbars_Dock_Area_Top).Size = new Size(1285, 56);
    this._formBudget_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formBudget_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formBudget_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formBudget_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formBudget_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formBudget_Toolbars_Dock_Area_Bottom).Location = new Point(0, 676);
    ((Control) this._formBudget_Toolbars_Dock_Area_Bottom).Name = "_formBudget_Toolbars_Dock_Area_Bottom";
    ((Control) this._formBudget_Toolbars_Dock_Area_Bottom).Size = new Size(1285, 0);
    this._formBudget_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolTipManager1.ContainingControl = (Control) this;
    ((Control) this.ultraTabControl2).Controls.Add((Control) this.ultraTabSharedControlsPage2);
    ((Control) this.ultraTabControl2).Controls.Add((Control) this.ultraTabPageControl3);
    ((Control) this.ultraTabControl2).Controls.Add((Control) this.ultraTabPageControl1);
    ((Control) this.ultraTabControl2).Dock = DockStyle.Fill;
    ((Control) this.ultraTabControl2).Location = new Point(0, 56);
    ((Control) this.ultraTabControl2).Name = "ultraTabControl2";
    ((UltraTabControlBase) this.ultraTabControl2).SharedControlsPage = this.ultraTabSharedControlsPage2;
    ((Control) this.ultraTabControl2).Size = new Size(1285, 620);
    ((UltraTabControlBase) this.ultraTabControl2).Style = (UltraTabControlStyle) 13;
    ((Control) this.ultraTabControl2).TabIndex = 5;
    ((UltraTabControlBase) this.ultraTabControl2).TabLayoutStyle = (TabLayoutStyle) 1;
    ultraTab1.TabPage = this.ultraTabPageControl3;
    ultraTab1.Text = "Budget Data";
    ultraTab2.TabPage = this.ultraTabPageControl1;
    ultraTab2.Text = "Data Visualization";
    ((UltraTabControlBase) this.ultraTabControl2).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.ultraTabControl2).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage2).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage2).Name = "ultraTabSharedControlsPage2";
    ((Control) this.ultraTabSharedControlsPage2).Size = new Size(1283, 597);
    this.timer1.Interval = 30000;
    this.timer1.Tick += new EventHandler(this.timer1_Tick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1285, 676);
    this.Controls.Add((Control) this.ultraTabControl2);
    this.Controls.Add((Control) this.comboGLCompanyId);
    this.Controls.Add((Control) this.comboFiscalYear);
    this.Controls.Add((Control) this.panelCurtain);
    this.Controls.Add((Control) this._formBudget_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formBudget_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formBudget_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formBudget_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formBudget);
    this.Text = "GL Budget Management";
    this.Load += new EventHandler(this.formBudget_Load);
    ((Control) this.ultraTabPageControl3).ResumeLayout(false);
    ((Control) this.ultraTabPageControl3).PerformLayout();
    this.statusStrip1.ResumeLayout(false);
    this.statusStrip1.PerformLayout();
    ((ISupportInitialize) this.gridBudget).EndInit();
    ((ISupportInitialize) this.ultraCalcManager1).EndInit();
    this.dsGLAccountBudgets1.EndInit();
    ((Control) this.ultraTabPageControl1).ResumeLayout(false);
    this.panelCurtain.ResumeLayout(false);
    this.panelCurtain.PerformLayout();
    this.panelLoading.ResumeLayout(false);
    ((ISupportInitialize) this.dateTimeActualAsOf).EndInit();
    this.dsCostCenters1.EndInit();
    ((ISupportInitialize) this.comboGLCompanyId).EndInit();
    ((ISupportInitialize) this.comboFiscalYear).EndInit();
    this.dsFiscalYearList1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.ultraTabControl2).EndInit();
    ((Control) this.ultraTabControl2).ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
