// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry.FormPolicyInquiryDrillDown
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.SharedForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry;

[SecureResource("{C6E6F51E-79FC-42DE-A122-D497F2CF4F55}", "Advanced Policy Search Rights", "Determines whether or not a user has rights to access the advanced policy search utility.", "Accounting")]
public class FormPolicyInquiryDrillDown : FormBase
{
  private IContainer components;
  private UltraToolbarsDockArea _FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom;
  protected UltraToolbarsManager ultraToolbarsManager1;
  protected Panel FormPolicyInquiryDrillDown_Fill_Panel;
  protected Panel panelQueryOptions;
  protected PolicyInquirySearchCriteria policyInquirySearchCriteria2;
  protected UltraGrid gridDetail;
  protected dsExtendedPolicyInquiry dsExtendedPolicyInquiry1;
  protected StatusStrip statusStrip1;
  protected ToolStripStatusLabel labelStatusStrip;
  protected UltraGridExcelExporter ultraGridExcelExporter1;

  public FormPolicyInquiryDrillDown() => this.InitializeComponent();

  protected virtual void Search()
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.gridDetail.EventManager.SetEnabled((EventGroups) 0, false);
      this.dsExtendedPolicyInquiry1.Clear();
      this.gridDetail.EventManager.SetEnabled((EventGroups) 0, true);
      DateTime now = DateTime.Now;
      DefaultDatabase.LoadDataSet((DataSet) this.dsExtendedPolicyInquiry1, new string[1]
      {
        "PolicyHeader"
      }, "dbo.spFin_ExtendedPolicyInquirySearch", new object[36]
      {
        (object) "@GlCompanyId",
        (object) this.policyInquirySearchCriteria2.GLCompanyId,
        (object) "@EntityGuid",
        (object) (this.policyInquirySearchCriteria2.EntityGuid == Guid.Empty ? SqlGuid.Null : (SqlGuid) this.policyInquirySearchCriteria2.EntityGuid),
        (object) "@EntityType",
        (object) (string.IsNullOrEmpty(this.policyInquirySearchCriteria2.EntityType) ? SqlString.Null : (SqlString) this.policyInquirySearchCriteria2.EntityType),
        (object) "@LineGuid",
        (object) (this.policyInquirySearchCriteria2.LineGuid == Guid.Empty ? SqlGuid.Null : (SqlGuid) this.policyInquirySearchCriteria2.LineGuid),
        (object) "@PolicyNumber",
        (object) (string.IsNullOrEmpty(this.policyInquirySearchCriteria2.PolicyNumber) ? SqlString.Null : (SqlString) this.policyInquirySearchCriteria2.PolicyNumber),
        (object) "@InvoiceNumber",
        (object) this.policyInquirySearchCriteria2.InvoiceNumber,
        (object) "@ControlNumber",
        (object) this.policyInquirySearchCriteria2.ControlNumber,
        (object) "@PolicyStatusId",
        (object) this.policyInquirySearchCriteria2.PolicyStatusId,
        (object) "@EffectiveDateFrom",
        (object) this.policyInquirySearchCriteria2.EffectiveDateFrom,
        (object) "@EffectiveDateTo",
        (object) this.policyInquirySearchCriteria2.EffectiveDateTo,
        (object) "@ExpirationDateFrom",
        (object) this.policyInquirySearchCriteria2.ExpirationDateFrom,
        (object) "@ExpirationDateTo",
        (object) this.policyInquirySearchCriteria2.ExpirationDateTo,
        (object) "@InvoiceDateFrom",
        (object) this.policyInquirySearchCriteria2.InvoiceDueDateFrom,
        (object) "@InvoiceDateTo",
        (object) this.policyInquirySearchCriteria2.InvoiceDueDateTo,
        (object) "@InsuredAddress",
        (object) (string.IsNullOrEmpty(this.policyInquirySearchCriteria2.InsuredAddress) ? SqlString.Null : (SqlString) this.policyInquirySearchCriteria2.InsuredAddress),
        (object) "@InsuredCity",
        (object) (string.IsNullOrEmpty(this.policyInquirySearchCriteria2.InsuredCity) ? SqlString.Null : (SqlString) this.policyInquirySearchCriteria2.InsuredCity),
        (object) "@InsuredState",
        (object) (string.IsNullOrEmpty(this.policyInquirySearchCriteria2.InsuredState) ? SqlString.Null : (SqlString) this.policyInquirySearchCriteria2.InsuredState),
        (object) "@InsuredZip",
        (object) (string.IsNullOrEmpty(this.policyInquirySearchCriteria2.InsuredZip) ? SqlString.Null : (SqlString) this.policyInquirySearchCriteria2.InsuredZip)
      });
      if (this.dsExtendedPolicyInquiry1.Tables[0].Rows.Count == 50)
        this.labelStatusStrip.Text = $"The query limited the results to 50 items. Please narrow your search if you do not see what where searching for. Query returned in {(DateTime.Now - now).TotalSeconds} seconds.";
      else
        this.labelStatusStrip.Text = $"{this.dsExtendedPolicyInquiry1.Tables[0].Rows.Count} Records found that match the specified criteria. Query returned in {(DateTime.Now - now).TotalSeconds} seconds";
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void policyInquirySearchCriteria2_SearchButtonClicked(object sender, EventArgs e)
  {
    this.Search();
  }

  private void gridDetail_BeforeRowExpanded(object sender, CancelableRowEventArgs e)
  {
    this.LoadChildRows(e.Row);
  }

  private void LoadChildRows(UltraGridRow row)
  {
    if (((GridItemBase) row).Band.Index == 0 && row.HasChild() || ((GridItemBase) row).Band.Index == 1 && ((DisposableObjectCollectionBase) row.ChildBands[0].Rows).Count != 0)
      return;
    switch (((GridItemBase) row).Band.Index)
    {
      case 0:
        DefaultDatabase.LoadDataSet((DataSet) this.dsExtendedPolicyInquiry1, new string[2]
        {
          "PolicyInvoices",
          "InvoicePayees"
        }, "dbo.spFin_ExtendedPolicyInquirySearch_Invoices", new object[2]
        {
          (object) "@QuoteId",
          row.Cells["QuoteId"].Value
        });
        break;
      case 1:
        DefaultDatabase.LoadDataSet((DataSet) this.dsExtendedPolicyInquiry1, new string[1]
        {
          "InvoiceActivity"
        }, "dbo.spFin_ExtendedPolicyInquirySearch_Transactions", new object[2]
        {
          (object) "@InvoiceNum",
          row.Cells["InvoiceNum"].Value
        });
        break;
    }
  }

  private void gridDetail_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    foreach (UltraGridCell cell in e.Row.Cells)
    {
      if (cell.Column.DataType == typeof (Decimal) && cell.Value != null && string.IsNullOrEmpty(cell.Value.ToString()))
      {
        if (!string.IsNullOrEmpty(cell.Value.ToString()))
        {
          if ((Decimal) cell.Value < 0M)
            ((AppearanceBase) cell.Appearance).ForeColor = Color.Red;
          else
            ((AppearanceBase) cell.Appearance).ForeColor = Color.Black;
        }
      }
      else
        ((AppearanceBase) cell.Appearance).ForeColor = Color.Black;
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((UltraGridBase) this.gridDetail).ActiveRow != null && ((SparseCollectionBase) this.gridDetail.Selected.Rows).Count == 0)
      ((GridItemBase) ((UltraGridBase) this.gridDetail).ActiveRow).Selected = true;
    UltraGridRow row = (UltraGridRow) null;
    if (((SparseCollectionBase) this.gridDetail.Selected.Rows).Count != 0)
      row = this.gridDetail.Selected.Rows[0];
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key != null)
    {
      switch (key.Length)
      {
        case 4:
          if (key == "EXIT")
          {
            this.Close();
            return;
          }
          break;
        case 7:
          if (key == "REFRESH")
          {
            this.Search();
            return;
          }
          break;
        case 9:
          switch (key[0])
          {
            case 'E':
              switch (key)
              {
                case "ENTITYREC":
                  if (this.policyInquirySearchCriteria2.EntityGuid.Equals(Guid.Empty))
                  {
                    int num = (int) MessageBox.Show("You must specify an entity to search for.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                  }
                  if (this.policyInquirySearchCriteria2.GLCompanyId == 0)
                  {
                    int num = (int) MessageBox.Show("You must specify an office location to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                  }
                  this.LoadEntityReceivables();
                  return;
                case "ENTITYPAY":
                  if (this.policyInquirySearchCriteria2.EntityGuid.Equals(Guid.Empty))
                  {
                    int num = (int) MessageBox.Show("You must specify an entity to search for.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                  }
                  if (this.policyInquirySearchCriteria2.GLCompanyId == 0)
                  {
                    int num = (int) MessageBox.Show("You must specify an office location to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                  }
                  this.LoadEntityPayables();
                  return;
              }
              break;
            case 'L':
              if (key == "LOADQUERY")
              {
                using (FormSavedQueries formSavedQueries = new FormSavedQueries())
                {
                  if (formSavedQueries.ShowDialog() != DialogResult.OK)
                    return;
                  this.policyInquirySearchCriteria2.GLCompanyId = formSavedQueries.GLCompanyId;
                  this.policyInquirySearchCriteria2.InsuredAddress = formSavedQueries.InsuredAddress;
                  this.policyInquirySearchCriteria2.InsuredCity = formSavedQueries.InsuredCity;
                  this.policyInquirySearchCriteria2.InsuredState = formSavedQueries.InsuredState;
                  this.policyInquirySearchCriteria2.InsuredZip = formSavedQueries.InsuredZip;
                  this.policyInquirySearchCriteria2.PolicyNumber = formSavedQueries.PolicyNumber;
                  this.policyInquirySearchCriteria2.EffectiveDateFrom = formSavedQueries.EffectiveDateFrom;
                  this.policyInquirySearchCriteria2.EffectiveDateTo = formSavedQueries.EffectiveDateTo;
                  this.policyInquirySearchCriteria2.ExpirationDateFrom = formSavedQueries.ExpirationDateFrom;
                  this.policyInquirySearchCriteria2.ExpirationDateTo = formSavedQueries.ExpirationDateTo;
                  this.policyInquirySearchCriteria2.InvoiceDueDateFrom = formSavedQueries.InvoiceDueDateFrom;
                  this.policyInquirySearchCriteria2.InvoiceDueDateTo = formSavedQueries.InvoiceDueDateTo;
                  this.policyInquirySearchCriteria2.LineGuid = formSavedQueries.LineGuid;
                  this.policyInquirySearchCriteria2.InvoiceNumber = formSavedQueries.InvoiceNumber;
                  this.policyInquirySearchCriteria2.ControlNumber = formSavedQueries.ControlNumber;
                  this.policyInquirySearchCriteria2.PolicyStatusId = formSavedQueries.PolicyStatusId;
                  this.policyInquirySearchCriteria2.SetSelectedEntity(formSavedQueries.EntityGuid, formSavedQueries.EntityName);
                  return;
                }
              }
              break;
            case 'P':
              if (key == "POLICYREC")
              {
                if (row == null)
                  return;
                while (row.HasParent())
                  row = row.ParentRow;
                List<SelectedEntity> remitters = this.GetRemitters(row);
                if (remitters.Count != 1)
                  return;
                this.LoadTransactionBuilder(int.Parse(row.Cells["glcompanyid"].Value.ToString()), remitters[0].EntityName, formTransactionSearch.SearchTypes.Receivables, remitters[0].EntityGuid, int.Parse(row.Cells["Control Number"].Value.ToString()), 0);
                return;
              }
              break;
            case 'S':
              if (key == "SAVEQUERY")
              {
                using (FormSavedQueries formSavedQueries = new FormSavedQueries(this.policyInquirySearchCriteria2.GLCompanyId, this.policyInquirySearchCriteria2.InsuredAddress, this.policyInquirySearchCriteria2.InsuredCity, this.policyInquirySearchCriteria2.InsuredState, this.policyInquirySearchCriteria2.InsuredZip, this.policyInquirySearchCriteria2.EntityGuid, this.policyInquirySearchCriteria2.EntityName, this.policyInquirySearchCriteria2.PolicyNumber, this.policyInquirySearchCriteria2.EffectiveDateFrom, this.policyInquirySearchCriteria2.EffectiveDateTo, this.policyInquirySearchCriteria2.ExpirationDateFrom, this.policyInquirySearchCriteria2.ExpirationDateTo, this.policyInquirySearchCriteria2.InvoiceDueDateFrom, this.policyInquirySearchCriteria2.InvoiceDueDateTo, this.policyInquirySearchCriteria2.LineGuid, this.policyInquirySearchCriteria2.InvoiceNumber, this.policyInquirySearchCriteria2.ControlNumber, this.policyInquirySearchCriteria2.PolicyStatusId))
                {
                  int num = (int) formSavedQueries.ShowDialog();
                  return;
                }
              }
              break;
          }
          break;
        case 10:
          switch (key[0])
          {
            case 'C':
              if (key == "CLEARQUERY")
              {
                this.ClearQuery();
                return;
              }
              break;
            case 'I':
              if (key == "INVOICEREC")
              {
                if (row == null)
                  return;
                if (((GridItemBase) row).Band.Index != 1)
                {
                  int num = (int) MessageBox.Show("You must select an invoice row to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                List<SelectedEntity> remitters = this.GetRemitters(row);
                if (remitters.Count != 1)
                  return;
                this.LoadTransactionBuilder(int.Parse(row.ParentRow.Cells["glcompanyid"].Value.ToString()), remitters[0].EntityName, formTransactionSearch.SearchTypes.Receivables, remitters[0].EntityGuid, 0, int.Parse(row.Cells["Invoice Number"].Value.ToString()));
                return;
              }
              break;
          }
          break;
        case 11:
          if (key == "EXCELEXPORT")
          {
            try
            {
              this.Cursor = MgaCursors.WaitCursor;
              this.LoadAllChildren();
              this.ExportToExcel();
              return;
            }
            finally
            {
              this.Cursor = MgaCursors.Default;
            }
          }
          else
            break;
        case 12:
          switch (key[0])
          {
            case 'C':
              if (key == "CLEARRESULTS")
              {
                this.dsExtendedPolicyInquiry1.Clear();
                return;
              }
              break;
            case 'P':
              if (key == "PRINTRESULTS")
                return;
              break;
          }
          break;
        case 13:
          if (key == "POLICYINQUIRY")
          {
            if (row == null)
              return;
            while (row.HasParent())
              row = row.ParentRow;
            Utility.ShowPolicyInquiry(int.Parse(row.Cells["Control Number"].Value.ToString()), int.Parse(row.Cells["glcompanyid"].Value.ToString()));
            return;
          }
          break;
        case 17:
          if (key == "TRANSACTIONDETAIL")
          {
            if (((SparseCollectionBase) this.gridDetail.Selected.Rows).Count == 0 || ((GridItemBase) this.gridDetail.Selected.Rows[0]).Band.Index != 2)
            {
              int num = (int) MessageBox.Show("You must select a transaction row to continue.", "Transaction Row Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            formTransactionViewer transactionViewer = new formTransactionViewer(int.Parse(this.gridDetail.Selected.Rows[0].Cells["Transaction Number"].Value.ToString()), int.Parse(this.gridDetail.Selected.Rows[0].ParentRow.ParentRow.Cells["glcompanyid"].Value.ToString()));
            transactionViewer.MdiParent = MDIControls.Instance.MDIParent;
            transactionViewer.Show();
            return;
          }
          break;
      }
    }
    if (!((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.IsGuid())
      return;
    if (((ToolEventArgs) e).Tool.Owner is PopupMenuTool && ((KeyedSubObjectBase) (((ToolEventArgs) e).Tool.Owner as PopupMenuTool)).Key == "POLICYPAY")
      this.LoadTransactionBuilder(this.policyInquirySearchCriteria2.GLCompanyId, ((ToolPropsBase) ((ToolEventArgs) e).Tool.SharedProps).Caption, formTransactionSearch.SearchTypes.Payables, new Guid(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key), int.Parse(row.Cells["Control Number"].Value.ToString()), 0);
    if (!(((ToolEventArgs) e).Tool.Owner is PopupMenuTool) || !(((KeyedSubObjectBase) (((ToolEventArgs) e).Tool.Owner as PopupMenuTool)).Key == "INVOICEPAY"))
      return;
    this.LoadTransactionBuilder(this.policyInquirySearchCriteria2.GLCompanyId, ((ToolPropsBase) ((ToolEventArgs) e).Tool.SharedProps).Caption, formTransactionSearch.SearchTypes.Payables, new Guid(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key), 0, int.Parse(row.Cells["Invoice Number"].Value.ToString()));
  }

  protected void LoadTransactionBuilder(
    int glCompanyId,
    string entityName,
    formTransactionSearch.SearchTypes searchType,
    Guid entityGuid,
    int controlNumber,
    int invoiceNumber)
  {
    Form form = ObjectFactory.Instance.CreateForm(typeof (formTransactionBuilder));
    SearchCriteria sCrit = new SearchCriteria();
    sCrit.EntityGuid = entityGuid;
    sCrit.SearchForGuid = entityGuid;
    switch (searchType)
    {
      case formTransactionSearch.SearchTypes.Payables:
        sCrit.PayeeName = entityName;
        if (controlNumber != 0)
        {
          sCrit.PayableSearchType = Utility.PayablesSearchType.ControlNumber;
          sCrit.SearchForInteger = controlNumber;
          break;
        }
        if (invoiceNumber != 0)
        {
          sCrit.PayableSearchType = Utility.PayablesSearchType.InvoiceNumber;
          sCrit.SearchForInteger = invoiceNumber;
          break;
        }
        sCrit.PayableSearchType = Utility.PayablesSearchType.Payee;
        break;
      case formTransactionSearch.SearchTypes.PayablesReceivables:
        sCrit.PayeeName = entityName;
        if (controlNumber != 0)
        {
          sCrit.ReceivableSearchType = Utility.ReceivablesSearchType.ControlNumber;
          sCrit.PayableSearchType = Utility.PayablesSearchType.ControlNumber;
          sCrit.SearchForInteger = controlNumber;
          break;
        }
        if (invoiceNumber != 0)
        {
          sCrit.ReceivableSearchType = Utility.ReceivablesSearchType.InvoiceNumber;
          sCrit.PayableSearchType = Utility.PayablesSearchType.InvoiceNumber;
          sCrit.SearchForInteger = invoiceNumber;
          break;
        }
        sCrit.ReceivableSearchType = Utility.ReceivablesSearchType.Remitter;
        sCrit.PayableSearchType = Utility.PayablesSearchType.Payee;
        break;
      default:
        if (controlNumber != 0)
        {
          sCrit.ReceivableSearchType = Utility.ReceivablesSearchType.ControlNumber;
          sCrit.SearchForInteger = controlNumber;
          break;
        }
        if (invoiceNumber != 0)
        {
          sCrit.ReceivableSearchType = Utility.ReceivablesSearchType.InvoiceNumber;
          sCrit.SearchForInteger = invoiceNumber;
          break;
        }
        sCrit.ReceivableSearchType = Utility.ReceivablesSearchType.Remitter;
        break;
    }
    (form as formTransactionBuilder).IsEnhancedPolicySearch = true;
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
    (form as formTransactionBuilder).SetSearchType(sCrit, glCompanyId, entityName, searchType);
  }

  protected virtual void LoadEntityReceivables()
  {
    this.LoadTransactionBuilder(this.policyInquirySearchCriteria2.GLCompanyId, this.policyInquirySearchCriteria2.EntityName, formTransactionSearch.SearchTypes.Receivables, this.policyInquirySearchCriteria2.EntityGuid, 0, 0);
  }

  protected virtual void LoadEntityPayables()
  {
    this.LoadTransactionBuilder(this.policyInquirySearchCriteria2.GLCompanyId, this.policyInquirySearchCriteria2.EntityName, formTransactionSearch.SearchTypes.Payables, this.policyInquirySearchCriteria2.EntityGuid, 0, 0);
  }

  protected virtual void ClearQuery() => this.policyInquirySearchCriteria2.Clear();

  private List<SelectedEntity> GetRemitters(UltraGridRow row)
  {
    List<SelectedEntity> remitters = new List<SelectedEntity>();
    while (row.HasParent())
      row = row.ParentRow;
    if (!row.HasChild())
      this.LoadChildRows(row);
    List<string> stringList = new List<string>();
    foreach (UltraGridRow row1 in row.ChildBands[0].Rows)
    {
      if (!stringList.Contains(row1.Cells["Billing Type"].Value.ToString()))
        stringList.Add(row1.Cells["Billing Type"].Value.ToString());
    }
    foreach (string str in stringList)
    {
      switch (str)
      {
        case "Agency Bill":
          remitters.Add(new SelectedEntity(new Guid(row.Cells["ProducerLocationGuid"].Value.ToString()), row.Cells["Producer"].Value.ToString()));
          continue;
        case "Direct Bill (Company)":
          remitters.Add(new SelectedEntity(new Guid(row.Cells["CompanyLineGuid"].Value.ToString()), row.Cells["Company"].Value.ToString()));
          continue;
        case "Direct Bill (MGA)":
          remitters.Add(new SelectedEntity(new Guid(row.Cells["InsuredGuid"].Value.ToString()), row.Cells["Insured"].Value.ToString()));
          continue;
        default:
          continue;
      }
    }
    return remitters;
  }

  private List<SelectedEntity> GetPayees(UltraGridRow row) => new List<SelectedEntity>();

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (((SparseCollectionBase) this.gridDetail.Selected.Rows).Count == 0 && ((UltraGridBase) this.gridDetail).ActiveRow == null)
      return;
    if (((UltraGridBase) this.gridDetail).ActiveRow != null && ((SparseCollectionBase) this.gridDetail.Selected.Rows).Count == 0)
      ((GridItemBase) ((UltraGridBase) this.gridDetail).ActiveRow).Selected = true;
    if (!(((CancelableToolEventArgs) e).Tool is PopupMenuTool tool))
      return;
    ((ToolsCollectionBase) tool.Tools).Clear();
    UltraGridRow row1 = this.gridDetail.Selected.Rows[0];
    if (((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key == "POLICYPAY")
    {
      while (((GridItemBase) row1).Band.Index != 0)
        row1 = row1.ParentRow;
      if (!row1.HasChild())
        this.LoadChildRows(row1);
      DataRow[] dataRowArray = this.dsExtendedPolicyInquiry1.InvoicePayees.DefaultView.ToTable(true, "ControlNumber", "PayeeGuid", "PayeeName").Select($"ControlNumber = {row1.Cells["Control Number"].Value}");
      for (int index = 0; index < dataRowArray.Length; ++index)
      {
        ButtonTool buttonTool;
        if (((KeyedSubObjectsCollectionBase) this.ultraToolbarsManager1.Tools).Exists(dataRowArray[index]["PayeeGuid"].ToString()))
        {
          buttonTool = (ButtonTool) ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)[dataRowArray[index]["PayeeGuid"].ToString()];
        }
        else
        {
          buttonTool = new ButtonTool(dataRowArray[index]["PayeeGuid"].ToString());
          ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).Add((ToolBase) buttonTool);
        }
        ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = dataRowArray[index]["PayeeName"].ToString();
        tool.Tools.AddTool(dataRowArray[index]["PayeeGuid"].ToString(), false);
      }
    }
    if (!(((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key == "INVOICEPAY"))
      return;
    if (((GridItemBase) row1).Band.Index != 1)
    {
      int num = (int) MessageBox.Show("You must select an invoice row to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      foreach (UltraGridRow row2 in row1.ChildBands[1].Rows)
      {
        ButtonTool buttonTool;
        if (((KeyedSubObjectsCollectionBase) this.ultraToolbarsManager1.Tools).Exists(row2.Cells["PayeeGuid"].Value.ToString()))
        {
          buttonTool = (ButtonTool) ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)[row2.Cells["PayeeGuid"].Value.ToString()];
        }
        else
        {
          buttonTool = new ButtonTool(row2.Cells["PayeeGuid"].Value.ToString());
          ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).Add((ToolBase) buttonTool);
        }
        ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = row2.Cells["PayeeName"].Value.ToString();
        tool.Tools.AddTool(row2.Cells["PayeeGuid"].Value.ToString(), false);
      }
    }
  }

  private void LoadAllChildren()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridDetail).Rows)
    {
      row.ExpandAll();
      row.CollapseAll();
    }
  }

  private void ExportToExcel()
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.Filter = "Excel File (*.xls)|*.xls";
    if (saveFileDialog.ShowDialog() != DialogResult.OK)
      return;
    this.DoExport(3).Save(saveFileDialog.FileName);
    Process.Start(saveFileDialog.FileName);
  }

  public Workbook DoExport(int tableCount)
  {
    Workbook workbook = new Workbook();
    this.AddWorksheets((DataSet) this.dsExtendedPolicyInquiry1, workbook, tableCount);
    return workbook;
  }

  private void AddWorksheets(DataSet data, Workbook workbook, int tableCount)
  {
    workbook.Worksheets.Clear();
    for (int index = 0; index < tableCount; ++index)
    {
      Worksheet worksheet = workbook.Worksheets.Add(data.Tables[index].TableName);
      this.AddData(data.Tables[index], worksheet, true);
    }
  }

  private void AddData(DataTable dt, Worksheet worksheet, bool showFieldName)
  {
    if (dt.Rows.Count == 0)
      return;
    worksheet.Cells.ImportDataTable(dt, showFieldName, "A1");
  }

  private void FormPolicyInquiryDrillDown_Load(object sender, EventArgs e)
  {
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("PolicyHeader", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("QuoteId");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Control Number", -1, (object) null, 1835246541, 0, 0);
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Policy Number", -1, (object) null, 1835246541, 1, 0);
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Insured", -1, (object) null, 1835246541, 2, 0);
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Producer", -1, (object) null, 1835246541, 3, 0);
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Company", -1, (object) null, 1835246541, 4, 0);
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Line", -1, (object) null, 1835246541, 5, 0);
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Status", -1, (object) null, 1835246541, 6, 1);
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Effective Date", -1, (object) null, 1835246541, 7, 1);
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Expiration Date", -1, (object) null, 1835246541, 8, 1);
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Underwriter", -1, (object) null, 1835246541, 9, 1);
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Gross Premium", -1, (object) null, 1835246541, 10, 1);
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Fees", -1, (object) null, 1835246541, 11, 1);
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Outstanding AR", -1, (object) null, 1835246541, 12, 1);
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Outstanding AP", -1, (object) null, 1835246541, 13, 1);
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("InsuredGuid");
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ProducerGuid");
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ProducerLocationGuid");
    Appearance appearance23 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("CompanyLineGuid");
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("CompanyGuid");
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("GLCompanyId");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("PolicyInvoices_PolicyHeader");
    UltraGridGroup ultraGridGroup1 = new UltraGridGroup("NewGroup0", 1835246541);
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "Gross Premium", 11, true, "PolicyHeader", 0, (SummaryPosition) 3, "Gross Premium", 11, true);
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "Fees", 12, true, "PolicyHeader", 0, (SummaryPosition) 3, "Fees", 12, true);
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "Outstanding AR", 13, true, "PolicyHeader", 0, (SummaryPosition) 3, "Outstanding AR", 13, true);
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "Outstanding AP", 14, true, "PolicyHeader", 0, (SummaryPosition) 3, "Outstanding AP", 14, true);
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("PolicyInvoices_PolicyHeader", 0);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Control Number");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Invoice Number");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Premium");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Fees");
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("AR");
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("AR Rcvd");
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("AP");
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("AP PTD");
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Billing Type");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Failed");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("QuoteId");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("PolicyInvoices_InvoiceActivity");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("PolicyInvoices_InvoicePayees");
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 1, (string) null, "Premium", 3, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    SummarySettings summarySettings6 = new SummarySettings("", (SummaryType) 1, (string) null, "Fees", 4, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    SummarySettings summarySettings7 = new SummarySettings("", (SummaryType) 1, (string) null, "AR", 5, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    SummarySettings summarySettings8 = new SummarySettings("", (SummaryType) 1, (string) null, "AR Rcvd", 6, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    SummarySettings summarySettings9 = new SummarySettings("", (SummaryType) 1, (string) null, "AP", 7, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    SummarySettings summarySettings10 = new SummarySettings("", (SummaryType) 1, (string) null, "AP PTD", 8, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("PolicyInvoices_InvoiceActivity", 1);
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("Transaction Number");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("Transaction Type");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Transaction Date");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("User");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Cash Amount");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("AP Amount");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("AR Amount");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Un-Acct Amount");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("Exch Amount");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("Check Number");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("Comments");
    UltraGridBand ultraGridBand4 = new UltraGridBand("PolicyInvoices_InvoicePayees", 1);
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("ControlNumber");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("PayeeName");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("PayeeAmt");
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("Outstanding AP");
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance71 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("PolicyHeader", -1);
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("QuoteId");
    Appearance appearance72 = new Appearance();
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("Control Number", -1, (object) null, 644979832, 0, 0);
    Appearance appearance73 = new Appearance();
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("Policy Number", -1, (object) null, 644979832, 1, 0);
    Appearance appearance74 = new Appearance();
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("Insured", -1, (object) null, 644979832, 2, 0);
    Appearance appearance75 = new Appearance();
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("Producer", -1, (object) null, 644979832, 3, 0);
    Appearance appearance76 = new Appearance();
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("Company", -1, (object) null, 644979832, 4, 0);
    Appearance appearance77 = new Appearance();
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("Line", -1, (object) null, 644979832, 5, 0);
    Appearance appearance78 = new Appearance();
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("Status", -1, (object) null, 644979832, 6, 1);
    Appearance appearance79 = new Appearance();
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("Effective Date", -1, (object) null, 644979832, 7, 1);
    Appearance appearance80 = new Appearance();
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("Expiration Date", -1, (object) null, 644979832, 8, 1);
    Appearance appearance81 = new Appearance();
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("Underwriter", -1, (object) null, 644979832, 9, 1);
    Appearance appearance82 = new Appearance();
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("Gross Premium", -1, (object) null, 644979832, 10, 1);
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("Fees", -1, (object) null, 644979832, 11, 1);
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("Outstanding AR", -1, (object) null, 644979832, 12, 1);
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("Outstanding AP", -1, (object) null, 644979832, 13, 1);
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("InsuredGuid");
    Appearance appearance91 = new Appearance();
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("ProducerGuid");
    Appearance appearance92 = new Appearance();
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("ProducerLocationGuid");
    Appearance appearance93 = new Appearance();
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("CompanyLineGuid");
    Appearance appearance94 = new Appearance();
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance95 = new Appearance();
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("CompanyGuid");
    Appearance appearance96 = new Appearance();
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("GLCompanyId");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("PolicyInvoices_PolicyHeader");
    UltraGridGroup ultraGridGroup2 = new UltraGridGroup("NewGroup0", 644979832);
    SummarySettings summarySettings11 = new SummarySettings("", (SummaryType) 1, (string) null, "Gross Premium", 11, true, "PolicyHeader", 0, (SummaryPosition) 3, "Gross Premium", 11, true);
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    SummarySettings summarySettings12 = new SummarySettings("", (SummaryType) 1, (string) null, "Fees", 12, true, "PolicyHeader", 0, (SummaryPosition) 3, "Fees", 12, true);
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    SummarySettings summarySettings13 = new SummarySettings("", (SummaryType) 1, (string) null, "Outstanding AR", 13, true, "PolicyHeader", 0, (SummaryPosition) 3, "Outstanding AR", 13, true);
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    SummarySettings summarySettings14 = new SummarySettings("", (SummaryType) 1, (string) null, "Outstanding AP", 14, true, "PolicyHeader", 0, (SummaryPosition) 3, "Outstanding AP", 14, true);
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("PolicyInvoices_PolicyHeader", 0);
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("Control Number");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("Invoice Number");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("Premium");
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("Fees");
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("AR");
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    UltraGridColumn ultraGridColumn85 = new UltraGridColumn("AR Rcvd");
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    UltraGridColumn ultraGridColumn86 = new UltraGridColumn("AP");
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    UltraGridColumn ultraGridColumn87 = new UltraGridColumn("AP PTD");
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    UltraGridColumn ultraGridColumn88 = new UltraGridColumn("Billing Type");
    UltraGridColumn ultraGridColumn89 = new UltraGridColumn("Failed");
    UltraGridColumn ultraGridColumn90 = new UltraGridColumn("QuoteId");
    UltraGridColumn ultraGridColumn91 = new UltraGridColumn("PolicyInvoices_InvoiceActivity");
    SummarySettings summarySettings15 = new SummarySettings("", (SummaryType) 1, (string) null, "Premium", 3, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance117 = new Appearance();
    Appearance appearance118 = new Appearance();
    SummarySettings summarySettings16 = new SummarySettings("", (SummaryType) 1, (string) null, "Fees", 4, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance119 = new Appearance();
    Appearance appearance120 = new Appearance();
    SummarySettings summarySettings17 = new SummarySettings("", (SummaryType) 1, (string) null, "AR", 5, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    SummarySettings summarySettings18 = new SummarySettings("", (SummaryType) 1, (string) null, "AR Rcvd", 6, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance123 = new Appearance();
    Appearance appearance124 = new Appearance();
    SummarySettings summarySettings19 = new SummarySettings("", (SummaryType) 1, (string) null, "AP", 7, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance125 = new Appearance();
    Appearance appearance126 = new Appearance();
    SummarySettings summarySettings20 = new SummarySettings("", (SummaryType) 1, (string) null, "AP PTD", 8, true, "PolicyInvoices_PolicyHeader", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance127 = new Appearance();
    Appearance appearance128 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("PolicyInvoices_InvoiceActivity", 1);
    UltraGridColumn ultraGridColumn92 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn93 = new UltraGridColumn("Transaction Number");
    UltraGridColumn ultraGridColumn94 = new UltraGridColumn("Transaction Type");
    UltraGridColumn ultraGridColumn95 = new UltraGridColumn("Transaction Date");
    UltraGridColumn ultraGridColumn96 = new UltraGridColumn("User");
    UltraGridColumn ultraGridColumn97 = new UltraGridColumn("Cash Amount");
    UltraGridColumn ultraGridColumn98 = new UltraGridColumn("AP Amount");
    UltraGridColumn ultraGridColumn99 = new UltraGridColumn("AR Amount");
    UltraGridColumn ultraGridColumn100 = new UltraGridColumn("Un-Acct Amount");
    UltraGridColumn ultraGridColumn101 = new UltraGridColumn("Exch Amount");
    UltraGridColumn ultraGridColumn102 = new UltraGridColumn("Check Number");
    UltraGridColumn ultraGridColumn103 = new UltraGridColumn("Comments");
    Appearance appearance129 = new Appearance();
    Appearance appearance130 = new Appearance();
    Appearance appearance131 = new Appearance();
    Appearance appearance132 = new Appearance();
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    RibbonTab ribbonTab1 = new RibbonTab("FileOptions");
    RibbonGroup ribbonGroup1 = new RibbonGroup("FileOptionsGroup");
    ButtonTool buttonTool1 = new ButtonTool("SAVEQUERY");
    ButtonTool buttonTool2 = new ButtonTool("EXCELEXPORT");
    ButtonTool buttonTool3 = new ButtonTool("PRINTRESULTS");
    ButtonTool buttonTool4 = new ButtonTool("EXIT");
    RibbonGroup ribbonGroup2 = new RibbonGroup("QueryOptionsGroup");
    RibbonTab ribbonTab2 = new RibbonTab("queryOptionTab");
    RibbonGroup ribbonGroup3 = new RibbonGroup("ribbonGroup1");
    ButtonTool buttonTool5 = new ButtonTool("REFRESH");
    ButtonTool buttonTool6 = new ButtonTool("CLEARQUERY");
    ButtonTool buttonTool7 = new ButtonTool("CLEARRESULTS");
    UltraToolbar ultraToolbar1 = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool8 = new ButtonTool("SAVEQUERY");
    ButtonTool buttonTool9 = new ButtonTool("LOADQUERY");
    ButtonTool buttonTool10 = new ButtonTool("EXCELEXPORT");
    ButtonTool buttonTool11 = new ButtonTool("REFRESH");
    ButtonTool buttonTool12 = new ButtonTool("CLEARQUERY");
    ButtonTool buttonTool13 = new ButtonTool("CLEARRESULTS");
    UltraToolbar ultraToolbar2 = new UltraToolbar("ResultSetOptions");
    ButtonTool buttonTool14 = new ButtonTool("POLICYINQUIRY");
    ButtonTool buttonTool15 = new ButtonTool("TRANSACTIONDETAIL");
    ButtonTool buttonTool16 = new ButtonTool("ENTITYREC");
    ButtonTool buttonTool17 = new ButtonTool("POLICYREC");
    ButtonTool buttonTool18 = new ButtonTool("INVOICEREC");
    ButtonTool buttonTool19 = new ButtonTool("ENTITYPAY");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("POLICYPAY");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("INVOICEPAY");
    ButtonTool buttonTool20 = new ButtonTool("SAVEQUERY");
    Appearance appearance137 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormPolicyInquiryDrillDown));
    ButtonTool buttonTool21 = new ButtonTool("EXCELEXPORT");
    Appearance appearance138 = new Appearance();
    ButtonTool buttonTool22 = new ButtonTool("PRINTRESULTS");
    Appearance appearance139 = new Appearance();
    ButtonTool buttonTool23 = new ButtonTool("EXIT");
    ButtonTool buttonTool24 = new ButtonTool("REFRESH");
    Appearance appearance140 = new Appearance();
    ButtonTool buttonTool25 = new ButtonTool("CLEARQUERY");
    Appearance appearance141 = new Appearance();
    ButtonTool buttonTool26 = new ButtonTool("CLEARRESULTS");
    Appearance appearance142 = new Appearance();
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("QUERYOPTIONS");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("queryOptionContainer");
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("Receivables");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("Payables");
    ButtonTool buttonTool27 = new ButtonTool("ENTITYREC");
    Appearance appearance143 = new Appearance();
    ButtonTool buttonTool28 = new ButtonTool("POLICYREC");
    Appearance appearance144 = new Appearance();
    ButtonTool buttonTool29 = new ButtonTool("INVOICEREC");
    Appearance appearance145 = new Appearance();
    ButtonTool buttonTool30 = new ButtonTool("ENTITYPAY");
    Appearance appearance146 = new Appearance();
    ButtonTool buttonTool31 = new ButtonTool("POLICYINQUIRY");
    Appearance appearance147 = new Appearance();
    ButtonTool buttonTool32 = new ButtonTool("LOADQUERY");
    Appearance appearance148 = new Appearance();
    ButtonTool buttonTool33 = new ButtonTool("TRANSACTIONDETAIL");
    Appearance appearance149 = new Appearance();
    PopupMenuTool popupMenuTool5 = new PopupMenuTool("POLICYPAY");
    Appearance appearance150 = new Appearance();
    PopupMenuTool popupMenuTool6 = new PopupMenuTool("INVOICEPAY");
    Appearance appearance151 = new Appearance();
    this.FormPolicyInquiryDrillDown_Fill_Panel = new Panel();
    this.statusStrip1 = new StatusStrip();
    this.labelStatusStrip = new ToolStripStatusLabel();
    this.gridDetail = new UltraGrid();
    this.dsExtendedPolicyInquiry1 = new dsExtendedPolicyInquiry();
    this.panelQueryOptions = new Panel();
    this.policyInquirySearchCriteria2 = new PolicyInquirySearchCriteria();
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.ultraGridExcelExporter1 = new UltraGridExcelExporter(this.components);
    this.FormPolicyInquiryDrillDown_Fill_Panel.SuspendLayout();
    this.statusStrip1.SuspendLayout();
    ((ISupportInitialize) this.gridDetail).BeginInit();
    this.dsExtendedPolicyInquiry1.BeginInit();
    this.panelQueryOptions.SuspendLayout();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.FormPolicyInquiryDrillDown_Fill_Panel.BackColor = Color.Transparent;
    this.FormPolicyInquiryDrillDown_Fill_Panel.Controls.Add((Control) this.statusStrip1);
    this.FormPolicyInquiryDrillDown_Fill_Panel.Controls.Add((Control) this.gridDetail);
    this.FormPolicyInquiryDrillDown_Fill_Panel.Controls.Add((Control) this.panelQueryOptions);
    this.FormPolicyInquiryDrillDown_Fill_Panel.Cursor = Cursors.Default;
    this.FormPolicyInquiryDrillDown_Fill_Panel.Dock = DockStyle.Fill;
    this.FormPolicyInquiryDrillDown_Fill_Panel.Location = new Point(0, 54);
    this.FormPolicyInquiryDrillDown_Fill_Panel.Name = "FormPolicyInquiryDrillDown_Fill_Panel";
    this.FormPolicyInquiryDrillDown_Fill_Panel.Size = new Size(1037, 676);
    this.FormPolicyInquiryDrillDown_Fill_Panel.TabIndex = 0;
    this.statusStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.labelStatusStrip
    });
    this.statusStrip1.Location = new Point(0, 654);
    this.statusStrip1.Name = "statusStrip1";
    this.statusStrip1.Size = new Size(1037, 22);
    this.statusStrip1.TabIndex = 2;
    this.statusStrip1.Text = "statusStrip1";
    this.labelStatusStrip.Name = "labelStatusStrip";
    this.labelStatusStrip.Size = new Size(0, 17);
    ((UltraGridBase) this.gridDetail).DataSource = (object) this.dsExtendedPolicyInquiry1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridDetail).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridDetail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 75;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance3;
    ultraGridColumn2.Width = 103;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance4;
    ultraGridColumn3.Width = 151;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance5;
    ultraGridColumn4.Width = 206;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance6;
    ultraGridColumn5.Width = 206;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance7;
    ultraGridColumn6.Width = 206;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance8;
    ultraGridColumn7.Width = 144 /*0x90*/;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance9;
    ultraGridColumn8.Width = 144 /*0x90*/;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance10;
    ultraGridColumn9.Width = 112 /*0x70*/;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance11;
    ultraGridColumn10.Width = 115;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance12;
    ultraGridColumn11.Width = 172;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance14;
    ultraGridColumn12.Width = 115;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn13.Format = "c";
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance16;
    ultraGridColumn13.Width = 115;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance17;
    ultraGridColumn14.Format = "c";
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance18;
    ultraGridColumn14.Width = 115;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance19;
    ultraGridColumn15.Format = "c";
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance20;
    ultraGridColumn15.Width = 128 /*0x80*/;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 80 /*0x50*/;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 80 /*0x50*/;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 80 /*0x50*/;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 80 /*0x50*/;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 19;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 80 /*0x50*/;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 80 /*0x50*/;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 22;
    ultraGridBand1.Columns.AddRange(new object[23]
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
      (object) ultraGridColumn23
    });
    ultraGridBand1.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup1).Key = "NewGroup0";
    ultraGridBand1.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup1
    });
    ultraGridBand1.LevelCount = 2;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand1.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance27).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance27).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance27;
    summarySettings1.DisplayFormat = "{0:c}";
    summarySettings1.GroupBySummaryValueAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance29).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance29).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance29;
    summarySettings2.DisplayFormat = "{0:c}";
    summarySettings2.GroupBySummaryValueAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance31).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance31;
    summarySettings3.DisplayFormat = "{0:c}";
    summarySettings3.GroupBySummaryValueAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance33).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance33;
    summarySettings4.DisplayFormat = "{0:c}";
    summarySettings4.GroupBySummaryValueAppearance = (AppearanceBase) appearance34;
    ultraGridBand1.Summaries.AddRange(new SummarySettings[4]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3,
      summarySettings4
    });
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 0;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 84;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 1;
    ultraGridColumn25.Width = 93;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 2;
    ultraGridColumn26.Width = 150;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Right";
    ultraGridColumn27.CellAppearance = (AppearanceBase) appearance35;
    ultraGridColumn27.Format = "c";
    ((AppearanceBase) appearance36).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn27.Header).Appearance = (AppearanceBase) appearance36;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 3;
    ultraGridColumn27.Width = 88;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    ultraGridColumn28.CellAppearance = (AppearanceBase) appearance37;
    ultraGridColumn28.Format = "c";
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn28.Header).Appearance = (AppearanceBase) appearance38;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 4;
    ultraGridColumn28.Width = 90;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ultraGridColumn29.CellAppearance = (AppearanceBase) appearance39;
    ultraGridColumn29.Format = "c";
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn29.Header).Appearance = (AppearanceBase) appearance40;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 5;
    ultraGridColumn29.Width = 90;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Right";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance41;
    ultraGridColumn30.Format = "c";
    ((AppearanceBase) appearance42).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance42;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 6;
    ultraGridColumn30.Width = 97;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance43).TextHAlignAsString = "Right";
    ultraGridColumn31.CellAppearance = (AppearanceBase) appearance43;
    ultraGridColumn31.Format = "c";
    ((AppearanceBase) appearance44).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn31.Header).Appearance = (AppearanceBase) appearance44;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 7;
    ultraGridColumn31.Width = 100;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance45).TextHAlignAsString = "Right";
    ultraGridColumn32.CellAppearance = (AppearanceBase) appearance45;
    ultraGridColumn32.Format = "c";
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn32.Header).Appearance = (AppearanceBase) appearance46;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 8;
    ultraGridColumn32.Width = 102;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 9;
    ultraGridColumn33.Width = 128 /*0x80*/;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 10;
    ultraGridColumn34.Width = 59;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 11;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 55;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 12;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 13;
    ultraGridBand2.Columns.AddRange(new object[14]
    {
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37
    });
    ultraGridBand2.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance47).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance47).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance47;
    summarySettings5.DisplayFormat = "{0:c}";
    summarySettings5.GroupBySummaryValueAppearance = (AppearanceBase) appearance48;
    ((AppearanceBase) appearance49).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance49).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    summarySettings6.Appearance = (AppearanceBase) appearance49;
    summarySettings6.DisplayFormat = "{0:c}";
    summarySettings6.GroupBySummaryValueAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance51).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    summarySettings7.Appearance = (AppearanceBase) appearance51;
    summarySettings7.DisplayFormat = "{0:c}";
    summarySettings7.GroupBySummaryValueAppearance = (AppearanceBase) appearance52;
    ((AppearanceBase) appearance53).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance53).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    summarySettings8.Appearance = (AppearanceBase) appearance53;
    summarySettings8.DisplayFormat = "{0:c}";
    summarySettings8.GroupBySummaryValueAppearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance55).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    summarySettings9.Appearance = (AppearanceBase) appearance55;
    summarySettings9.DisplayFormat = "{0:c}";
    summarySettings9.GroupBySummaryValueAppearance = (AppearanceBase) appearance56;
    ((AppearanceBase) appearance57).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance57).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    summarySettings10.Appearance = (AppearanceBase) appearance57;
    summarySettings10.DisplayFormat = "{0:c}";
    summarySettings10.GroupBySummaryValueAppearance = (AppearanceBase) appearance58;
    ultraGridBand2.Summaries.AddRange(new SummarySettings[6]
    {
      summarySettings5,
      summarySettings6,
      summarySettings7,
      summarySettings8,
      summarySettings9,
      summarySettings10
    });
    ultraGridBand3.CardSettings.CaptionField = "Transaction Type";
    ultraGridBand3.CardView = true;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 0;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn38.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn38.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn38.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn38.Width = 68;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 1;
    ultraGridColumn39.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn39.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 19);
    ultraGridColumn39.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn39.RowLayoutColumnInfo.SpanY = 1;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 2;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn40.RowLayoutColumnInfo.OriginY = 2;
    ultraGridColumn40.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn40.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn40.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn40.Width = 98;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 3;
    ultraGridColumn41.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn41.RowLayoutColumnInfo.OriginY = 4;
    ultraGridColumn41.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn41.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn41.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn41.Width = 96 /*0x60*/;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).VisiblePosition = 4;
    ultraGridColumn42.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn42.RowLayoutColumnInfo.OriginY = 6;
    ultraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn42.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn42.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn42.Width = 94;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn43.Format = "c";
    ((HeaderBase) ultraGridColumn43.Header).VisiblePosition = 5;
    ultraGridColumn43.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn43.RowLayoutColumnInfo.OriginY = 8;
    ultraGridColumn43.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn43.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn43.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn44.Format = "c";
    ((HeaderBase) ultraGridColumn44.Header).VisiblePosition = 6;
    ultraGridColumn44.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn44.RowLayoutColumnInfo.OriginY = 12;
    ultraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn44.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn44.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn44.Width = 77;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn45.Format = "c";
    ((HeaderBase) ultraGridColumn45.Header).VisiblePosition = 7;
    ultraGridColumn45.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn45.RowLayoutColumnInfo.OriginY = 10;
    ultraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn45.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn45.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn45.Width = 77;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn46.Format = "c";
    ((HeaderBase) ultraGridColumn46.Header).VisiblePosition = 8;
    ultraGridColumn46.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn46.RowLayoutColumnInfo.OriginY = 14;
    ultraGridColumn46.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn46.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn46.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn46.Width = 94;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn47.Format = "c";
    ((HeaderBase) ultraGridColumn47.Header).VisiblePosition = 9;
    ultraGridColumn47.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn47.RowLayoutColumnInfo.OriginY = 16 /*0x10*/;
    ultraGridColumn47.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn47.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn47.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn47.Width = 78;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).VisiblePosition = 10;
    ultraGridColumn48.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn48.RowLayoutColumnInfo.OriginY = 18;
    ultraGridColumn48.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 19);
    ultraGridColumn48.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn48.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn48.Width = 94;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Caption = "";
    ((HeaderBase) ultraGridColumn49.Header).VisiblePosition = 11;
    ultraGridColumn49.RowLayoutColumnInfo.OriginX = 2;
    ultraGridColumn49.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn49.RowLayoutColumnInfo.PreferredCellSize = new Size(177, 170);
    ultraGridColumn49.RowLayoutColumnInfo.PreferredLabelSize = new Size(13, 0);
    ultraGridColumn49.RowLayoutColumnInfo.SpanX = 1;
    ultraGridColumn49.RowLayoutColumnInfo.SpanY = 20;
    ultraGridColumn49.Width = 94;
    ultraGridBand3.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49
    });
    ultraGridBand3.RowLayoutStyle = (RowLayoutStyle) 1;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn50.Header).VisiblePosition = 0;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 132;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn51.Header).VisiblePosition = 1;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 75;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn52.Header).VisiblePosition = 2;
    ultraGridColumn52.Hidden = true;
    ultraGridColumn52.Width = 438;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn53.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn53.Header).VisiblePosition = 3;
    ultraGridColumn53.Width = 637;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ultraGridColumn54.CellAppearance = (AppearanceBase) appearance59;
    ultraGridColumn54.Format = "c";
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn54.Header).Appearance = (AppearanceBase) appearance60;
    ((HeaderBase) ultraGridColumn54.Header).Caption = "Payee Amount";
    ((HeaderBase) ultraGridColumn54.Header).VisiblePosition = 4;
    ultraGridColumn54.Width = 232;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance61).TextHAlignAsString = "Right";
    ultraGridColumn55.CellAppearance = (AppearanceBase) appearance61;
    ultraGridColumn55.Format = "c";
    ((AppearanceBase) appearance62).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn55.Header).Appearance = (AppearanceBase) appearance62;
    ((HeaderBase) ultraGridColumn55.Header).VisiblePosition = 5;
    ultraGridColumn55.Width = 109;
    ultraGridBand4.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55
    });
    ((UltraGridBase) this.gridDetail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridDetail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridDetail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridDetail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.gridDetail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance63).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance63).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance63).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance64).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance65).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance65).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance65;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance66).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance66;
    ((AppearanceBase) appearance67).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance67;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance68).BackColor = Color.Transparent;
    ((AppearanceBase) appearance68).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDetail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance68;
    ((AppearanceBase) appearance69).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance69).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance69;
    ((AppearanceBase) appearance70).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance70;
    ((UltraGridBase) this.gridDetail).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridDetail).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance71).BackColor = Color.White;
    ((AppearanceBase) appearance71).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout.Appearance = (AppearanceBase) appearance71;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance72).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn56.Header).Appearance = (AppearanceBase) appearance72;
    ((HeaderBase) ultraGridColumn56.Header).VisiblePosition = 0;
    ultraGridColumn56.Hidden = true;
    ultraGridColumn56.Width = 75;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance73).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn57.Header).Appearance = (AppearanceBase) appearance73;
    ultraGridColumn57.Width = 108;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance74).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn58.Header).Appearance = (AppearanceBase) appearance74;
    ultraGridColumn58.Width = 155;
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance75).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn59.Header).Appearance = (AppearanceBase) appearance75;
    ultraGridColumn59.Width = 211;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance76).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn60.Header).Appearance = (AppearanceBase) appearance76;
    ultraGridColumn60.Width = 211;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance77).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn61.Header).Appearance = (AppearanceBase) appearance77;
    ultraGridColumn61.Width = 211;
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance78).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn62.Header).Appearance = (AppearanceBase) appearance78;
    ultraGridColumn62.Width = 139;
    ultraGridColumn63.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance79).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn63.Header).Appearance = (AppearanceBase) appearance79;
    ultraGridColumn63.Width = 146;
    ultraGridColumn64.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance80).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn64.Header).Appearance = (AppearanceBase) appearance80;
    ultraGridColumn64.Width = 116;
    ultraGridColumn65.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance81).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn65.Header).Appearance = (AppearanceBase) appearance81;
    ultraGridColumn65.Width = 119;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance82).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn66.Header).Appearance = (AppearanceBase) appearance82;
    ultraGridColumn66.Width = 177;
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance83).TextHAlignAsString = "Right";
    ultraGridColumn67.CellAppearance = (AppearanceBase) appearance83;
    ultraGridColumn67.Format = "c";
    ((AppearanceBase) appearance84).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn67.Header).Appearance = (AppearanceBase) appearance84;
    ultraGridColumn67.Width = 119;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance85).TextHAlignAsString = "Right";
    ultraGridColumn68.CellAppearance = (AppearanceBase) appearance85;
    ultraGridColumn68.Format = "c";
    ((AppearanceBase) appearance86).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn68.Header).Appearance = (AppearanceBase) appearance86;
    ultraGridColumn68.Width = 119;
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance87).TextHAlignAsString = "Right";
    ultraGridColumn69.CellAppearance = (AppearanceBase) appearance87;
    ultraGridColumn69.Format = "c";
    ((AppearanceBase) appearance88).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn69.Header).Appearance = (AppearanceBase) appearance88;
    ultraGridColumn69.Width = 119;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance89).TextHAlignAsString = "Right";
    ultraGridColumn70.CellAppearance = (AppearanceBase) appearance89;
    ultraGridColumn70.Format = "c";
    ((AppearanceBase) appearance90).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn70.Header).Appearance = (AppearanceBase) appearance90;
    ultraGridColumn70.Width = 120;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance91).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn71.Header).Appearance = (AppearanceBase) appearance91;
    ((HeaderBase) ultraGridColumn71.Header).VisiblePosition = 15;
    ultraGridColumn71.Hidden = true;
    ultraGridColumn71.Width = 80 /*0x50*/;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance92).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn72.Header).Appearance = (AppearanceBase) appearance92;
    ((HeaderBase) ultraGridColumn72.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn72.Hidden = true;
    ultraGridColumn72.Width = 80 /*0x50*/;
    ultraGridColumn73.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance93).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn73.Header).Appearance = (AppearanceBase) appearance93;
    ((HeaderBase) ultraGridColumn73.Header).VisiblePosition = 17;
    ultraGridColumn73.Hidden = true;
    ultraGridColumn73.Width = 80 /*0x50*/;
    ultraGridColumn74.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance94).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn74.Header).Appearance = (AppearanceBase) appearance94;
    ((HeaderBase) ultraGridColumn74.Header).VisiblePosition = 18;
    ultraGridColumn74.Hidden = true;
    ultraGridColumn74.Width = 80 /*0x50*/;
    ultraGridColumn75.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance95).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn75.Header).Appearance = (AppearanceBase) appearance95;
    ((HeaderBase) ultraGridColumn75.Header).VisiblePosition = 19;
    ultraGridColumn75.Hidden = true;
    ultraGridColumn75.Width = 80 /*0x50*/;
    ultraGridColumn76.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance96).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn76.Header).Appearance = (AppearanceBase) appearance96;
    ((HeaderBase) ultraGridColumn76.Header).VisiblePosition = 20;
    ultraGridColumn76.Hidden = true;
    ultraGridColumn76.Width = 80 /*0x50*/;
    ultraGridColumn77.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn77.Header).VisiblePosition = 21;
    ultraGridColumn77.Hidden = true;
    ultraGridColumn78.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn78.Header).VisiblePosition = 22;
    ultraGridBand5.Columns.AddRange(new object[23]
    {
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
      (object) ultraGridColumn78
    });
    ultraGridBand5.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup2).Key = "NewGroup0";
    ultraGridBand5.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup2
    });
    ultraGridBand5.LevelCount = 2;
    ultraGridBand5.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand5.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand5.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance97).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance97).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance97).TextHAlignAsString = "Right";
    summarySettings11.Appearance = (AppearanceBase) appearance97;
    summarySettings11.DisplayFormat = "{0:c}";
    summarySettings11.GroupBySummaryValueAppearance = (AppearanceBase) appearance98;
    ((AppearanceBase) appearance99).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance99).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance99).TextHAlignAsString = "Right";
    summarySettings12.Appearance = (AppearanceBase) appearance99;
    summarySettings12.DisplayFormat = "{0:c}";
    summarySettings12.GroupBySummaryValueAppearance = (AppearanceBase) appearance100;
    ((AppearanceBase) appearance101).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance101).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance101).TextHAlignAsString = "Right";
    summarySettings13.Appearance = (AppearanceBase) appearance101;
    summarySettings13.DisplayFormat = "{0:c}";
    summarySettings13.GroupBySummaryValueAppearance = (AppearanceBase) appearance102;
    ((AppearanceBase) appearance103).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance103).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance103).TextHAlignAsString = "Right";
    summarySettings14.Appearance = (AppearanceBase) appearance103;
    summarySettings14.DisplayFormat = "{0:c}";
    summarySettings14.GroupBySummaryValueAppearance = (AppearanceBase) appearance104;
    ultraGridBand5.Summaries.AddRange(new SummarySettings[4]
    {
      summarySettings11,
      summarySettings12,
      summarySettings13,
      summarySettings14
    });
    ultraGridColumn79.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn79.Header).VisiblePosition = 0;
    ultraGridColumn79.Hidden = true;
    ultraGridColumn79.Width = 84;
    ultraGridColumn80.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn80.Header).VisiblePosition = 1;
    ultraGridColumn80.Width = 94;
    ultraGridColumn81.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn81.Header).VisiblePosition = 2;
    ultraGridColumn81.Width = (int) sbyte.MaxValue;
    ultraGridColumn82.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance105).TextHAlignAsString = "Right";
    ultraGridColumn82.CellAppearance = (AppearanceBase) appearance105;
    ultraGridColumn82.Format = "c";
    ((AppearanceBase) appearance106).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn82.Header).Appearance = (AppearanceBase) appearance106;
    ((HeaderBase) ultraGridColumn82.Header).VisiblePosition = 3;
    ultraGridColumn82.Width = 77;
    ultraGridColumn83.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance107).TextHAlignAsString = "Right";
    ultraGridColumn83.CellAppearance = (AppearanceBase) appearance107;
    ultraGridColumn83.Format = "c";
    ((AppearanceBase) appearance108).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn83.Header).Appearance = (AppearanceBase) appearance108;
    ((HeaderBase) ultraGridColumn83.Header).VisiblePosition = 4;
    ultraGridColumn83.Width = 81;
    ultraGridColumn84.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance109).TextHAlignAsString = "Right";
    ultraGridColumn84.CellAppearance = (AppearanceBase) appearance109;
    ultraGridColumn84.Format = "c";
    ((AppearanceBase) appearance110).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn84.Header).Appearance = (AppearanceBase) appearance110;
    ((HeaderBase) ultraGridColumn84.Header).VisiblePosition = 5;
    ultraGridColumn84.Width = 81;
    ultraGridColumn85.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance111).TextHAlignAsString = "Right";
    ultraGridColumn85.CellAppearance = (AppearanceBase) appearance111;
    ultraGridColumn85.Format = "c";
    ((AppearanceBase) appearance112).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn85.Header).Appearance = (AppearanceBase) appearance112;
    ((HeaderBase) ultraGridColumn85.Header).VisiblePosition = 6;
    ultraGridColumn85.Width = 82;
    ultraGridColumn86.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance113).TextHAlignAsString = "Right";
    ultraGridColumn86.CellAppearance = (AppearanceBase) appearance113;
    ultraGridColumn86.Format = "c";
    ((AppearanceBase) appearance114).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn86.Header).Appearance = (AppearanceBase) appearance114;
    ((HeaderBase) ultraGridColumn86.Header).VisiblePosition = 7;
    ultraGridColumn86.Width = 89;
    ultraGridColumn87.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance115).TextHAlignAsString = "Right";
    ultraGridColumn87.CellAppearance = (AppearanceBase) appearance115;
    ultraGridColumn87.Format = "c";
    ((AppearanceBase) appearance116).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn87.Header).Appearance = (AppearanceBase) appearance116;
    ((HeaderBase) ultraGridColumn87.Header).VisiblePosition = 8;
    ultraGridColumn87.Width = 90;
    ultraGridColumn88.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn88.Header).VisiblePosition = 9;
    ultraGridColumn88.Width = 113;
    ultraGridColumn89.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn89.Header).VisiblePosition = 10;
    ultraGridColumn89.Width = 52;
    ultraGridColumn90.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn90.Header).VisiblePosition = 11;
    ultraGridColumn90.Hidden = true;
    ultraGridColumn90.Width = 55;
    ultraGridColumn91.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn91.Header).VisiblePosition = 12;
    ultraGridColumn91.Width = 149;
    ultraGridBand6.Columns.AddRange(new object[13]
    {
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82,
      (object) ultraGridColumn83,
      (object) ultraGridColumn84,
      (object) ultraGridColumn85,
      (object) ultraGridColumn86,
      (object) ultraGridColumn87,
      (object) ultraGridColumn88,
      (object) ultraGridColumn89,
      (object) ultraGridColumn90,
      (object) ultraGridColumn91
    });
    ultraGridBand6.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance117).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance117).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance117).TextHAlignAsString = "Right";
    summarySettings15.Appearance = (AppearanceBase) appearance117;
    summarySettings15.DisplayFormat = "{0:c}";
    summarySettings15.GroupBySummaryValueAppearance = (AppearanceBase) appearance118;
    ((AppearanceBase) appearance119).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance119).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance119).TextHAlignAsString = "Right";
    summarySettings16.Appearance = (AppearanceBase) appearance119;
    summarySettings16.DisplayFormat = "{0:c}";
    summarySettings16.GroupBySummaryValueAppearance = (AppearanceBase) appearance120;
    ((AppearanceBase) appearance121).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance121).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance121).TextHAlignAsString = "Right";
    summarySettings17.Appearance = (AppearanceBase) appearance121;
    summarySettings17.DisplayFormat = "{0:c}";
    summarySettings17.GroupBySummaryValueAppearance = (AppearanceBase) appearance122;
    ((AppearanceBase) appearance123).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance123).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance123).TextHAlignAsString = "Right";
    summarySettings18.Appearance = (AppearanceBase) appearance123;
    summarySettings18.DisplayFormat = "{0:c}";
    summarySettings18.GroupBySummaryValueAppearance = (AppearanceBase) appearance124;
    ((AppearanceBase) appearance125).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance125).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance125).TextHAlignAsString = "Right";
    summarySettings19.Appearance = (AppearanceBase) appearance125;
    summarySettings19.DisplayFormat = "{0:c}";
    summarySettings19.GroupBySummaryValueAppearance = (AppearanceBase) appearance126;
    ((AppearanceBase) appearance127).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance127).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance127).TextHAlignAsString = "Right";
    summarySettings20.Appearance = (AppearanceBase) appearance127;
    summarySettings20.DisplayFormat = "{0:c}";
    summarySettings20.GroupBySummaryValueAppearance = (AppearanceBase) appearance128;
    ultraGridBand6.Summaries.AddRange(new SummarySettings[6]
    {
      summarySettings15,
      summarySettings16,
      summarySettings17,
      summarySettings18,
      summarySettings19,
      summarySettings20
    });
    ultraGridBand7.CardSettings.CaptionField = "Transaction Type";
    ultraGridBand7.CardView = true;
    ultraGridColumn92.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn92.Header).VisiblePosition = 0;
    ultraGridColumn92.Hidden = true;
    ultraGridColumn92.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn92.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn92.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn92.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn92.Width = 68;
    ultraGridColumn93.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn93.Header).VisiblePosition = 1;
    ultraGridColumn93.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn93.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn93.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 19);
    ultraGridColumn93.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn93.RowLayoutColumnInfo.SpanY = 1;
    ultraGridColumn94.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn94.Header).VisiblePosition = 2;
    ultraGridColumn94.Hidden = true;
    ultraGridColumn94.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn94.RowLayoutColumnInfo.OriginY = 2;
    ultraGridColumn94.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn94.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn94.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn94.Width = 98;
    ultraGridColumn95.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn95.Header).VisiblePosition = 3;
    ultraGridColumn95.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn95.RowLayoutColumnInfo.OriginY = 4;
    ultraGridColumn95.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn95.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn95.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn95.Width = 96 /*0x60*/;
    ultraGridColumn96.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn96.Header).VisiblePosition = 4;
    ultraGridColumn96.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn96.RowLayoutColumnInfo.OriginY = 6;
    ultraGridColumn96.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn96.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn96.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn96.Width = 94;
    ultraGridColumn97.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn97.Format = "c";
    ((HeaderBase) ultraGridColumn97.Header).VisiblePosition = 5;
    ultraGridColumn97.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn97.RowLayoutColumnInfo.OriginY = 8;
    ultraGridColumn97.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn97.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn97.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn98.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn98.Format = "c";
    ((HeaderBase) ultraGridColumn98.Header).VisiblePosition = 6;
    ultraGridColumn98.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn98.RowLayoutColumnInfo.OriginY = 12;
    ultraGridColumn98.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn98.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn98.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn98.Width = 77;
    ultraGridColumn99.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn99.Format = "c";
    ((HeaderBase) ultraGridColumn99.Header).VisiblePosition = 7;
    ultraGridColumn99.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn99.RowLayoutColumnInfo.OriginY = 10;
    ultraGridColumn99.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn99.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn99.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn99.Width = 77;
    ultraGridColumn100.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn100.Format = "c";
    ((HeaderBase) ultraGridColumn100.Header).VisiblePosition = 8;
    ultraGridColumn100.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn100.RowLayoutColumnInfo.OriginY = 14;
    ultraGridColumn100.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn100.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn100.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn100.Width = 94;
    ultraGridColumn101.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn101.Format = "c";
    ((HeaderBase) ultraGridColumn101.Header).VisiblePosition = 9;
    ultraGridColumn101.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn101.RowLayoutColumnInfo.OriginY = 16 /*0x10*/;
    ultraGridColumn101.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 0);
    ultraGridColumn101.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn101.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn101.Width = 78;
    ultraGridColumn102.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn102.Header).VisiblePosition = 10;
    ultraGridColumn102.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn102.RowLayoutColumnInfo.OriginY = 18;
    ultraGridColumn102.RowLayoutColumnInfo.PreferredCellSize = new Size(126, 19);
    ultraGridColumn102.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn102.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn102.Width = 94;
    ultraGridColumn103.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn103.Header).Caption = "";
    ((HeaderBase) ultraGridColumn103.Header).VisiblePosition = 11;
    ultraGridColumn103.RowLayoutColumnInfo.OriginX = 2;
    ultraGridColumn103.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn103.RowLayoutColumnInfo.PreferredCellSize = new Size(177, 170);
    ultraGridColumn103.RowLayoutColumnInfo.PreferredLabelSize = new Size(13, 0);
    ultraGridColumn103.RowLayoutColumnInfo.SpanX = 1;
    ultraGridColumn103.RowLayoutColumnInfo.SpanY = 20;
    ultraGridColumn103.Width = 94;
    ultraGridBand7.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn92,
      (object) ultraGridColumn93,
      (object) ultraGridColumn94,
      (object) ultraGridColumn95,
      (object) ultraGridColumn96,
      (object) ultraGridColumn97,
      (object) ultraGridColumn98,
      (object) ultraGridColumn99,
      (object) ultraGridColumn100,
      (object) ultraGridColumn101,
      (object) ultraGridColumn102,
      (object) ultraGridColumn103
    });
    ultraGridBand7.RowLayoutStyle = (RowLayoutStyle) 1;
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand5);
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand6);
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand7);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "Layout1";
    ((AppearanceBase) appearance129).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance129).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance129).ForeColor = Color.Black;
    ultraGridLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance129;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance130).BorderColor = Color.LightGray;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance130;
    ultraGridLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance131).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance131).TextHAlignAsString = "Left";
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance131;
    ultraGridLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance132).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance132;
    ((AppearanceBase) appearance133).BorderColor = Color.LightGray;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance133;
    ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance134).BackColor = Color.Transparent;
    ((AppearanceBase) appearance134).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance134;
    ((AppearanceBase) appearance135).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance135).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance135;
    ((AppearanceBase) appearance136).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance136;
    ultraGridLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridDetail).Layouts.Add(ultraGridLayout);
    ((Control) this.gridDetail).Location = new Point(0, 122);
    ((Control) this.gridDetail).Name = "gridDetail";
    ((Control) this.gridDetail).Size = new Size(1037, 554);
    ((Control) this.gridDetail).TabIndex = 1;
    ((UltraControlBase) this.gridDetail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridDetail).UseOsThemes = (DefaultableBoolean) 2;
    this.gridDetail.InitializeRow += new InitializeRowEventHandler(this.gridDetail_InitializeRow);
    this.gridDetail.BeforeRowExpanded += new CancelableRowEventHandler(this.gridDetail_BeforeRowExpanded);
    this.dsExtendedPolicyInquiry1.DataSetName = "dsExtendedPolicyInquiry";
    this.dsExtendedPolicyInquiry1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelQueryOptions.Controls.Add((Control) this.policyInquirySearchCriteria2);
    this.panelQueryOptions.Dock = DockStyle.Top;
    this.panelQueryOptions.Location = new Point(0, 0);
    this.panelQueryOptions.Name = "panelQueryOptions";
    this.panelQueryOptions.Size = new Size(1037, 122);
    this.panelQueryOptions.TabIndex = 0;
    this.policyInquirySearchCriteria2.BackColor = Color.Transparent;
    this.policyInquirySearchCriteria2.ControlNumber = new int?();
    this.policyInquirySearchCriteria2.EffectiveDateFrom = new DateTime?();
    this.policyInquirySearchCriteria2.EffectiveDateTo = new DateTime?();
    this.policyInquirySearchCriteria2.ExpirationDateFrom = new DateTime?();
    this.policyInquirySearchCriteria2.ExpirationDateTo = new DateTime?();
    this.policyInquirySearchCriteria2.Font = new Font("Tahoma", 8.25f);
    this.policyInquirySearchCriteria2.GLCompanyId = -1;
    this.policyInquirySearchCriteria2.InsuredAddress = "";
    this.policyInquirySearchCriteria2.InsuredCity = "";
    this.policyInquirySearchCriteria2.InsuredState = "";
    this.policyInquirySearchCriteria2.InsuredZip = "";
    this.policyInquirySearchCriteria2.InvoiceDueDateFrom = new DateTime?();
    this.policyInquirySearchCriteria2.InvoiceDueDateTo = new DateTime?();
    this.policyInquirySearchCriteria2.InvoiceNumber = new int?();
    this.policyInquirySearchCriteria2.LineGuid = new Guid("00000000-0000-0000-0000-000000000000");
    this.policyInquirySearchCriteria2.Location = new Point(0, 0);
    this.policyInquirySearchCriteria2.Name = "policyInquirySearchCriteria2";
    this.policyInquirySearchCriteria2.PolicyNumber = "";
    this.policyInquirySearchCriteria2.PolicyStatusId = new int?();
    this.policyInquirySearchCriteria2.Size = new Size(954, 118);
    this.policyInquirySearchCriteria2.TabIndex = 0;
    this.policyInquirySearchCriteria2.SearchButtonClicked += new EventHandler(this.policyInquirySearchCriteria2_SearchButtonClicked);
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left).Location = new Point(0, 54);
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left).Name = "_FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left";
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left).Size = new Size(0, 676);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    ribbonTab1.Caption = "File Options";
    ribbonGroup1.Caption = "File Options";
    ((ToolsCollectionBase) ribbonGroup1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ribbonGroup2.Caption = "Query Options";
    ribbonTab1.Groups.AddRange(new RibbonGroup[2]
    {
      ribbonGroup1,
      ribbonGroup2
    });
    ribbonTab2.Caption = "Query Options";
    ribbonGroup3.Caption = "ribbonGroup1";
    ((ToolsCollectionBase) ribbonGroup3.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7
    });
    ribbonTab2.Groups.AddRange(new RibbonGroup[1]
    {
      ribbonGroup3
    });
    this.ultraToolbarsManager1.Ribbon.NonInheritedRibbonTabs.AddRange(new RibbonTab[2]
    {
      ribbonTab1,
      ribbonTab2
    });
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 0;
    ultraToolbar1.IsMainMenuBar = true;
    ((ToolBase) buttonTool10).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool11).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool12).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13
    });
    ultraToolbar1.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockTop = (DefaultableBoolean) 1;
    ultraToolbar1.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar1.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar1.Text = "UltraToolbar1";
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 1;
    ultraToolbar2.FloatingLocation = new Point(279, 209);
    ultraToolbar2.FloatingSize = new Size(381, 24);
    ((ToolBase) buttonTool16).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool19).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar2).NonInheritedTools.AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) popupMenuTool1,
      (ToolBase) popupMenuTool2
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
    ultraToolbar2.Text = "ResultSetOptions";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[2]
    {
      ultraToolbar1,
      ultraToolbar2
    });
    ((AppearanceBase) appearance137).Image = componentResourceManager.GetObject("appearance27.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance137;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).Caption = "Save Query";
    ((ToolBase) buttonTool20).SharedPropsInternal.Category = "File Options";
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance138).Image = componentResourceManager.GetObject("appearance11.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance138;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).Caption = "Excel Export";
    ((ToolBase) buttonTool21).SharedPropsInternal.Category = "File Options";
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance139).Image = componentResourceManager.GetObject("appearance26.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance139;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "Print Results";
    ((ToolBase) buttonTool22).SharedPropsInternal.Category = "File Options";
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).Caption = "Exit";
    ((ToolBase) buttonTool23).SharedPropsInternal.Category = "File Options";
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance140).Image = componentResourceManager.GetObject("appearance12.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance140;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Refresh";
    ((ToolBase) buttonTool24).SharedPropsInternal.Category = "Query Options";
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance141).Image = componentResourceManager.GetObject("appearance34.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance141;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "Clear Query";
    ((ToolBase) buttonTool25).SharedPropsInternal.Category = "Query Options";
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance142).Image = componentResourceManager.GetObject("appearance35.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance142;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Clear Results";
    ((ToolBase) buttonTool26).SharedPropsInternal.Category = "Query Options";
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) controlContainerTool1).SharedPropsInternal.Category = "Query Options";
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).SharedPropsInternal).Width = 652;
    ((ToolBase) controlContainerTool2).SharedPropsInternal.Category = "Query Options";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedPropsInternal).Width = 144 /*0x90*/;
    ((ToolPropsBase) ((ToolBase) popupMenuTool3).SharedPropsInternal).Caption = "Receivables";
    ((ToolPropsBase) ((ToolBase) popupMenuTool4).SharedPropsInternal).Caption = "Payables";
    ((AppearanceBase) appearance143).Image = componentResourceManager.GetObject("appearance28.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance143;
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).Caption = "Entity Receivables";
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance144).Image = componentResourceManager.GetObject("appearance30.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance144;
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).Caption = "Policy Receivables";
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance145).Image = componentResourceManager.GetObject("appearance32.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance145;
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).Caption = "Invoice Receivables";
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance146).Image = componentResourceManager.GetObject("appearance29.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance146;
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).Caption = "Entity Payables";
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance147).Image = componentResourceManager.GetObject("appearance13.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance147;
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).Caption = "Policy Inquiry";
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance148).Image = componentResourceManager.GetObject("appearance36.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance148;
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).Caption = "Load Query";
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance149).Image = componentResourceManager.GetObject("appearance1.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance149;
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).Caption = "Transaction Detail";
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance150).Image = componentResourceManager.GetObject("appearance14.Image");
    ((ToolPropsBase) ((ToolBase) popupMenuTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance150;
    ((ToolPropsBase) ((ToolBase) popupMenuTool5).SharedPropsInternal).Caption = "Policy Payables";
    ((ToolPropsBase) ((ToolBase) popupMenuTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance151).Image = componentResourceManager.GetObject("appearance15.Image");
    ((ToolPropsBase) ((ToolBase) popupMenuTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance151;
    ((ToolPropsBase) ((ToolBase) popupMenuTool6).SharedPropsInternal).Caption = "Invoice Payables";
    ((ToolPropsBase) ((ToolBase) popupMenuTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[20]
    {
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) controlContainerTool1,
      (ToolBase) controlContainerTool2,
      (ToolBase) popupMenuTool3,
      (ToolBase) popupMenuTool4,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30,
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33,
      (ToolBase) popupMenuTool5,
      (ToolBase) popupMenuTool6
    });
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right).Location = new Point(1037, 54);
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right).Name = "_FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right";
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right).Size = new Size(0, 676);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top).Name = "_FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top";
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top).Size = new Size(1037, 54);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom).Location = new Point(0, 730);
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom).Name = "_FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom).Size = new Size(1037, 0);
    this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1037, 730);
    this.Controls.Add((Control) this.FormPolicyInquiryDrillDown_Fill_Panel);
    this.Controls.Add((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormPolicyInquiryDrillDown_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormPolicyInquiryDrillDown);
    this.Text = "Policy Inquiry - Extended";
    this.Load += new EventHandler(this.FormPolicyInquiryDrillDown_Load);
    this.FormPolicyInquiryDrillDown_Fill_Panel.ResumeLayout(false);
    this.FormPolicyInquiryDrillDown_Fill_Panel.PerformLayout();
    this.statusStrip1.ResumeLayout(false);
    this.statusStrip1.PerformLayout();
    ((ISupportInitialize) this.gridDetail).EndInit();
    this.dsExtendedPolicyInquiry1.EndInit();
    this.panelQueryOptions.ResumeLayout(false);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
