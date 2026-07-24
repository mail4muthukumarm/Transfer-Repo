// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormExpenseTransfer
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.Claims.Reports;
using MGASystems.IMS.Reporting;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormExpenseTransfer : FormBase
{
  private IContainer components;
  private BindingSource dsExpenseTransfer1BindingSource;
  private Panel FormExpenseTransfer_Fill_Panel;
  private UltraToolbarsDockArea _FormExpenseTransfer_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormExpenseTransfer_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormExpenseTransfer_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormExpenseTransfer_Toolbars_Dock_Area_Bottom;
  protected dsExpenseTransfer dsExpenseTransfer1;
  protected UltraGrid gridExpenses;
  protected UltraToolbarsManager ultraToolbarsManager1;

  public FormExpenseTransfer() => this.InitializeComponent();

  private void FormExpenseTransfer_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadExpenseTransfer();
  }

  protected virtual void LoadExpenseTransfer()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsExpenseTransfer1, new string[2]
    {
      "Companies",
      "Expenses"
    }, "spClaims_GetExpenseTransfer");
    ((UltraGridBase) this.gridExpenses).Rows.ExpandAll(true);
  }

  private void gridExpenses_InitializeRow(object sender, InitializeRowEventArgs e)
  {
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void TransferExpenses()
  {
    ((UltraGridBase) this.gridExpenses).UpdateData();
    this.dsExpenseTransfer1.AcceptChanges();
    ((UltraGridBase) this.gridExpenses).DataSource = (object) null;
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += new DoWorkEventHandler(this.DoTransfer);
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        if (e.Error == null)
        {
          this.CreateReportDataset();
          this.DialogResult = DialogResult.OK;
          this.Close();
        }
        else
          ExceptionDispatchInfo.Capture(e.Error).Throw();
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  protected virtual int GetGLCompanyId() => Utility.GetSetting("GLCO");

  protected virtual void DoTransfer(object sender, DoWorkEventArgs e)
  {
    int glCompanyId = this.GetGLCompanyId();
    DataRow[] rows;
    int trxNumber;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((execSender, execArgs) =>
    {
      foreach (dsExpenseTransfer.CompaniesRow company in (TypedTableBase<dsExpenseTransfer.CompaniesRow>) this.dsExpenseTransfer1.Companies)
      {
        if (company.Selected)
        {
          rows = this.dsExpenseTransfer1.Expenses.Select($"CompanyGuid = '{company.CompanyGuid.ToString()}'");
          if (rows.Length != 0)
          {
            trxNumber = (int) DefaultDatabase.ExecuteScalar("spClaims_ExpenseTransferHeader", new object[6]
            {
              (object) "@UserGuid",
              (object) CurrentUser.Instance.UserGUID,
              (object) "@Comments",
              (object) string.Empty,
              (object) "@GLCompanyID",
              (object) glCompanyId
            });
            for (int index = 0; index < rows.Length; ++index)
            {
              if ((rows[index] as dsExpenseTransfer.ExpensesRow).Selected)
                DefaultDatabase.ExecuteScalar("spClaims_ExpenseTransferDetail", new object[12]
                {
                  (object) "@TransactNum",
                  (object) trxNumber,
                  (object) "@UserGuid",
                  (object) CurrentUser.Instance.UserGUID,
                  (object) "@ClaimId",
                  (object) (rows[index] as dsExpenseTransfer.ExpensesRow).ClaimId,
                  (object) "@UAExpenseId",
                  (object) (rows[index] as dsExpenseTransfer.ExpensesRow).UAExpenseId,
                  (object) "@Amount",
                  (object) (rows[index] as dsExpenseTransfer.ExpensesRow).GrandTotal,
                  (object) "@EntityGuid",
                  (object) (rows[index] as dsExpenseTransfer.ExpensesRow).CompanyGuid
                });
            }
          }
        }
      }
      execArgs.Transaction.Commit();
    }));
  }

  private void buttonTransfer_Click(object sender, EventArgs e) => this.TransferExpenses();

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "TRANSFER":
        this.TransferExpenses();
        break;
      case "CANCEL":
        this.DialogResult = DialogResult.Cancel;
        this.Close();
        break;
      case "SELECTALL":
        this.ToggleCheckAll(true);
        break;
      case "DESELECTALL":
        this.ToggleCheckAll(false);
        break;
      case "CHECKSELECTED":
        this.ToggleCheckSelected(true);
        break;
      case "UNCHECKSELECTED":
        this.ToggleCheckSelected(false);
        break;
    }
  }

  private void ToggleCheckAll(bool value)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      foreach (UltraGridRow row1 in ((UltraGridBase) this.gridExpenses).Rows)
      {
        row1.Cells["Selected"].Value = (object) value;
        row1.Update();
        foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
        {
          row2.Cells["Selected"].Value = (object) value;
          row2.Update();
        }
      }
      this.dsExpenseTransfer1.AcceptChanges();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void ToggleCheckSelected(bool value)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      foreach (UltraGridRow row1 in ((UltraGridBase) this.gridExpenses).Rows)
      {
        if (((GridItemBase) row1).Selected)
        {
          row1.Cells["Selected"].Value = (object) value;
          row1.Update();
        }
        foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
        {
          if (((GridItemBase) row2).Selected)
          {
            row2.Cells["Selected"].Value = (object) value;
            row2.Update();
          }
        }
      }
      this.dsExpenseTransfer1.AcceptChanges();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void CreateReportDataset()
  {
    string officeLocation = Utility.GetOfficeLocation(Utility.GetSetting("GLCO"));
    foreach (dsExpenseTransfer.CompaniesRow company in (TypedTableBase<dsExpenseTransfer.CompaniesRow>) this.dsExpenseTransfer1.Companies)
    {
      if (company.Selected)
      {
        DataTable table1 = new DataTable();
        table1.Columns.AddRange(new DataColumn[3]
        {
          new DataColumn("DateFrom", typeof (DateTime)),
          new DataColumn("DateTo", typeof (DateTime)),
          new DataColumn("CompanyName", typeof (string))
        });
        table1.Rows.Add(this.dsExpenseTransfer1.Expenses.Compute("MIN(DateEntered)", $"CompanyGuid = '{company.CompanyGuid.ToString()}' AND Selected = 1"), this.dsExpenseTransfer1.Expenses.Compute("MAX(DateEntered)", $"CompanyGuid = '{company.CompanyGuid.ToString()}' AND Selected = 1"), (object) company.Company);
        DataSet dataSet = new DataSet();
        dataSet.Tables.Add(table1);
        DataTable table2 = new DataTable();
        table2.Columns.AddRange(new DataColumn[12]
        {
          new DataColumn("OfficeLocation", typeof (string)),
          new DataColumn("CompanyName", typeof (string)),
          new DataColumn("CompanyGuid", typeof (Guid)),
          new DataColumn("Policy", typeof (string)),
          new DataColumn("Insured", typeof (string)),
          new DataColumn("LossDate", typeof (DateTime)),
          new DataColumn("ClaimNumber", typeof (string)),
          new DataColumn("Time", typeof (Decimal)),
          new DataColumn("Hourly", typeof (Decimal)),
          new DataColumn("Equipment", typeof (Decimal)),
          new DataColumn("Other", typeof (Decimal)),
          new DataColumn("Total", typeof (Decimal))
        });
        DataRow[] dataRowArray = this.dsExpenseTransfer1.Expenses.Select($"CompanyGuid = '{company.CompanyGuid.ToString()}' AND Selected = 1");
        if (dataRowArray.Length != 0)
        {
          for (int index = 0; index < dataRowArray.Length; ++index)
          {
            DataRow row = table2.NewRow();
            row["OfficeLocation"] = (object) officeLocation;
            row["CompanyName"] = (object) company.Company;
            row["CompanyGuid"] = (object) company.CompanyGuid;
            row["Policy"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).PolicyNumber;
            row["Insured"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).InsuredName;
            row["LossDate"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).LossDate;
            row["ClaimNumber"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).ClaimNumber;
            row["Time"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).Hours;
            row["Hourly"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).HourlyTotal;
            row["Equipment"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).EquipmentTotal;
            row["Other"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).OtherTotal;
            row["Total"] = (object) (dataRowArray[index] as dsExpenseTransfer.ExpensesRow).GrandTotal;
            table2.Rows.Add(row);
          }
          dataSet.Tables.Add(table2);
          SectionReport objectAs = (SectionReport) ObjectFactory.Instance.CreateObjectAs<BillingRecapReport>((object) dataSet);
          objectAs.Run();
          ReportFactory.Instance.ShowReport(objectAs);
        }
      }
    }
  }

  protected virtual void HandleRowSelected(object sender, CellEventArgs e)
  {
    this.gridExpenses.EventManager.SetEnabled((EventGroups) 0, false);
    if (((GridItemBase) e.Cell.Row).Band.Index == 0)
    {
      foreach (UltraGridRow row in e.Cell.Row.ChildBands[0].Rows)
      {
        row.Cells["SELECTED"].Value = e.Cell.Value;
        row.Update();
      }
    }
    else if ((bool) e.Cell.Value)
    {
      e.Cell.Row.ParentRow.Cells["SELECTED"].Value = (object) true;
      e.Cell.Row.ParentRow.Update();
    }
    else
    {
      bool flag = false;
      foreach (UltraGridRow row in e.Cell.Row.ParentRow.ChildBands[0].Rows)
      {
        if ((bool) row.Cells["SELECTED"].Value)
        {
          flag = true;
          break;
        }
      }
      e.Cell.Row.ParentRow.Cells["SELECTED"].Value = (object) flag;
      e.Cell.Row.ParentRow.Update();
    }
    this.gridExpenses.EventManager.SetEnabled((EventGroups) 0, true);
  }

  private void gridExpenses_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (((KeyedSubObjectBase) e.Cell.Column).Key.ToUpper() != "SELECTED")
      return;
    this.HandleRowSelected(sender, e);
  }

  private void gridExpenses_ClickCellButton(object sender, CellEventArgs e) => e.Cell.Row.Update();

  private void gridExpenses_CellChange(object sender, CellEventArgs e) => e.Cell.Row.Update();

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("Companies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Company");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Companies_Expenses");
    UltraGridBand ultraGridBand2 = new UltraGridBand("Companies_Expenses", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("UAExpenseId");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ClaimId");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ClaimNumber");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Expense");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Hours");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("HourlyTotal");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("EquipmentTotal");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("OtherTotal");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("GrandTotal");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("LossDate");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("InsuredName");
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
    ButtonTool buttonTool1 = new ButtonTool("TRANSFER");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("SELECTALL");
    ButtonTool buttonTool4 = new ButtonTool("DESELECTALL");
    ButtonTool buttonTool5 = new ButtonTool("CHECKSELECTED");
    ButtonTool buttonTool6 = new ButtonTool("UNCHECKSELECTED");
    ButtonTool buttonTool7 = new ButtonTool("TRANSFER");
    Appearance appearance23 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("CANCEL");
    Appearance appearance24 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("SELECTALL");
    Appearance appearance25 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("DESELECTALL");
    Appearance appearance26 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("CHECKSELECTED");
    Appearance appearance27 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("UNCHECKSELECTED");
    Appearance appearance28 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormExpenseTransfer));
    this.gridExpenses = new UltraGrid();
    this.dsExpenseTransfer1BindingSource = new BindingSource(this.components);
    this.dsExpenseTransfer1 = new dsExpenseTransfer();
    this.FormExpenseTransfer_Fill_Panel = new Panel();
    this._FormExpenseTransfer_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormExpenseTransfer_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.gridExpenses).BeginInit();
    ((ISupportInitialize) this.dsExpenseTransfer1BindingSource).BeginInit();
    this.dsExpenseTransfer1.BeginInit();
    this.FormExpenseTransfer_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.gridExpenses).DataMember = "Companies";
    ((UltraGridBase) this.gridExpenses).DataSource = (object) this.dsExpenseTransfer1BindingSource;
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 546;
    ultraGridColumn2.DefaultCellValue = (object) "True";
    ((HeaderBase) ultraGridColumn2.Header).Caption = "";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 19;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).FontData.BoldAsString = "True";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 1008;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand1.Override.HeaderPlacement = (HeaderPlacement) 2;
    ultraGridBand1.Override.HeaderStyle = (HeaderStyle) 3;
    ultraGridBand1.Override.RowSpacingBefore = 5;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 48 /*0x30*/;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 157;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Claim Id";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 3;
    ultraGridColumn7.Width = 60;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridColumn8.Style = (ColumnStyle) 3;
    ultraGridColumn8.Width = 18;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 4;
    ultraGridColumn9.Width = 95;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Claim #";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 5;
    ultraGridColumn10.Width = 79;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 6;
    ultraGridColumn11.Width = 77;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 7;
    ultraGridColumn12.Width = 98;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 8;
    ultraGridColumn13.Width = 91;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 9;
    ultraGridColumn14.Width = 96 /*0x60*/;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn15.Format = "";
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 10;
    ultraGridColumn15.Width = 65;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn16.Format = "c";
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Hourly Total";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 11;
    ultraGridColumn16.Width = 78;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn17.Format = "c";
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Equip Total";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 12;
    ultraGridColumn17.Width = 79;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn18.Format = "c";
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Other Total";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 13;
    ultraGridColumn18.Width = 88;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance11;
    ultraGridColumn19.Format = "c";
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Grand Total";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 14;
    ultraGridColumn19.Width = 84;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 15;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 83;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 84;
    ultraGridBand2.Columns.AddRange(new object[17]
    {
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
      (object) ultraGridColumn21
    });
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand2.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridBand2.Header).Editor = (EmbeddableEditorBase) null;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridExpenses).Dock = DockStyle.Fill;
    ((Control) this.gridExpenses).Location = new Point(0, 0);
    ((Control) this.gridExpenses).Name = "gridExpenses";
    ((Control) this.gridExpenses).Size = new Size(1048, 625);
    ((Control) this.gridExpenses).TabIndex = 0;
    ((UltraControlBase) this.gridExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridExpenses).UseOsThemes = (DefaultableBoolean) 2;
    this.gridExpenses.AfterCellUpdate += new CellEventHandler(this.gridExpenses_AfterCellUpdate);
    this.gridExpenses.InitializeRow += new InitializeRowEventHandler(this.gridExpenses_InitializeRow);
    this.gridExpenses.CellChange += new CellEventHandler(this.gridExpenses_CellChange);
    this.dsExpenseTransfer1BindingSource.DataSource = (object) this.dsExpenseTransfer1;
    this.dsExpenseTransfer1BindingSource.Position = 0;
    this.dsExpenseTransfer1.DataSetName = "dsExpenseTransfer";
    this.dsExpenseTransfer1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.FormExpenseTransfer_Fill_Panel.BackColor = Color.Transparent;
    this.FormExpenseTransfer_Fill_Panel.Controls.Add((Control) this.gridExpenses);
    this.FormExpenseTransfer_Fill_Panel.Cursor = Cursors.Default;
    this.FormExpenseTransfer_Fill_Panel.Dock = DockStyle.Fill;
    this.FormExpenseTransfer_Fill_Panel.Location = new Point(0, 72);
    this.FormExpenseTransfer_Fill_Panel.Name = "FormExpenseTransfer_Fill_Panel";
    this.FormExpenseTransfer_Fill_Panel.Size = new Size(1048, 625);
    this.FormExpenseTransfer_Fill_Panel.TabIndex = 0;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Left).Location = new Point(0, 72);
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Left).Name = "_FormExpenseTransfer_Toolbars_Dock_Area_Left";
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Left).Size = new Size(0, 625);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
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
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance23).Image = (object) Resources.Transfer;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Transfer";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance24).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance25).Image = (object) Resources.SelectAll;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Select All";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance26).Image = (object) Resources.DeSelectAll;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance26;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "De-Select All";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance27).Image = (object) Resources.SelectAll;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance27;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Check Selected Rows";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance28).Image = (object) Resources.DeSelectAll;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance28;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Un-Check Selected Rows";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Right).Location = new Point(1048, 72);
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Right).Name = "_FormExpenseTransfer_Toolbars_Dock_Area_Right";
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Right).Size = new Size(0, 625);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Top).Name = "_FormExpenseTransfer_Toolbars_Dock_Area_Top";
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Top).Size = new Size(1048, 72);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom).Location = new Point(0, 697);
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom).Name = "_FormExpenseTransfer_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom).Size = new Size(1048, 0);
    this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1048, 697);
    this.Controls.Add((Control) this.FormExpenseTransfer_Fill_Panel);
    this.Controls.Add((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormExpenseTransfer_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormExpenseTransfer);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claims Expense Transfer";
    this.Load += new EventHandler(this.FormExpenseTransfer_Load);
    ((ISupportInitialize) this.gridExpenses).EndInit();
    ((ISupportInitialize) this.dsExpenseTransfer1BindingSource).EndInit();
    this.dsExpenseTransfer1.EndInit();
    this.FormExpenseTransfer_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
