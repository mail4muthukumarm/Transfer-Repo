// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Controller.PendingApprovalSettlementGridController
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Data.Repository.ToDataTable;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Model;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettingsOptions;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Controller;
using MGASystems.IMS.Accounting.Services.Forms.Utility;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.PopupMenu;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using MGASystems.IMS.Accounting.SharedForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.SettlementApproval.Controller;

[Override(typeof (IPendingApprovalSettlementGridController))]
public class PendingApprovalSettlementGridController : 
  WrappedUltraGridDatabaseBulkEditController<IPendingApprovalSettlementModel, PendingApprovalSettlementGridModel>,
  IPendingApprovalSettlementGridController,
  ISaveDataController,
  IMvcController,
  IWrappedUltraGridController<IPendingApprovalSettlementModel>,
  IWrappedUltraGridController,
  ITopControlController,
  IRequestParentSize
{
  private CheckboxToolbarControl _needsReviewButton;
  private CheckboxToolbarControl _approvedButton;
  private CheckboxToolbarControl _rejectedButton;

  protected override string ResetActionVerb { get; } = "Refreshing";

  protected CheckBoxColumn<IPendingApprovalSettlementModel> ApproveColumn { get; private set; }

  protected CheckBoxColumn<IPendingApprovalSettlementModel> RejectColumn { get; private set; }

  protected virtual IExcelExporter ExcelExporter { get; } = (IExcelExporter) new MGASystems.IMS.Accounting.Services.Forms.Utility.ExcelExporter<IPendingApprovalSettlementModel>((IEnumerable<IDataTableColumnMapping<IPendingApprovalSettlementModel>>) new List<IDataTableColumnMapping<IPendingApprovalSettlementModel>>()
  {
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, string>("Payee Name", (Func<IPendingApprovalSettlementModel, string>) (pendingApproval => pendingApproval.PayeeName)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, string>("Payment Method", (Func<IPendingApprovalSettlementModel, string>) (pendingApproval => pendingApproval.PaymentMethodName)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, string>("Payee Bank", (Func<IPendingApprovalSettlementModel, string>) (pendingApproval => pendingApproval.PayeeBank)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, string>("Routing #", (Func<IPendingApprovalSettlementModel, string>) (pendingApproval => pendingApproval.RoutingNumber)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, int>("Transaction #", (Func<IPendingApprovalSettlementModel, int>) (pendingApproval => pendingApproval.TransactionNumber)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, int>("# Invoices", (Func<IPendingApprovalSettlementModel, int>) (pendingApproval => pendingApproval.InvoiceIncludedCount)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, string>("Created By", (Func<IPendingApprovalSettlementModel, string>) (pendingApproval => pendingApproval.CreateByUserName)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, DateTime>("Create Date", (Func<IPendingApprovalSettlementModel, DateTime>) (pendingApproval => pendingApproval.CreateDate)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, string>("Status", (Func<IPendingApprovalSettlementModel, string>) (pendingApproval =>
    {
      if (pendingApproval.IsApproved)
        return "Approved";
      return !pendingApproval.IsRejected ? "Pending Approval" : "Rejected";
    })),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, string>("Status By", (Func<IPendingApprovalSettlementModel, string>) (pendingApproval => pendingApproval.ApproveRejectedBy)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, DateTime>("Status Date", (Func<IPendingApprovalSettlementModel, DateTime>) (pendingApproval => pendingApproval.StatusDate)),
    (IDataTableColumnMapping<IPendingApprovalSettlementModel>) new DataTableColumnMapping<IPendingApprovalSettlementModel, double>("Amount", (Func<IPendingApprovalSettlementModel, double>) (pendingApproval => pendingApproval.PaymentAmount))
  });

  protected Func<IPendingApprovalSettlementModel, Color> ColumnColorFunc { get; } = (Func<IPendingApprovalSettlementModel, Color>) (s =>
  {
    if (s.IsApproved)
      return Color.Green;
    return s.IsRejected ? Color.Red : Color.Black;
  });

  public void ViewSelectedTransaction()
  {
    if (this.GetSelected() is IPendingApprovalSettlementModel selected)
      this.ViewTransaction(selected);
    else
      this.View.DisplayOkMessageBox("You must select a row in order to view transaction details.", "Cannot Display Transaction Viewer", MessageBoxIcon.Hand);
  }

  public void SetFilter()
  {
    this.SetTopLevelFilter((Func<IPendingApprovalSettlementModel, bool>) (model =>
    {
      if (model.IsApproved && this._approvedButton.IsChecked || model.IsRejected && this._rejectedButton.IsChecked)
        return true;
      return !model.IsRejected && !model.IsApproved && this._needsReviewButton.IsChecked;
    }));
  }

  public void Export()
  {
    this.ExcelExporter.Export((IEnumerable<object>) this.VisibleDisplayItems, true);
  }

  public void ApproveAll()
  {
    foreach (IPendingApprovalSettlementModel visibleDisplayItem in this.VisibleDisplayItems)
    {
      if (!visibleDisplayItem.IsApproved && !visibleDisplayItem.IsRejected && !visibleDisplayItem.UserApprove && this.ApproveColumn.IsCellEnabledFunc(visibleDisplayItem))
        this.ApproveColumn.UserSetValue(visibleDisplayItem, true);
    }
  }

  public void RejectAll()
  {
    foreach (IPendingApprovalSettlementModel visibleDisplayItem in this.VisibleDisplayItems)
    {
      if (!visibleDisplayItem.IsApproved && !visibleDisplayItem.IsRejected && !visibleDisplayItem.UserReject)
        this.RejectColumn.UserSetValue(visibleDisplayItem, true);
    }
  }

  public virtual IToolbarItem[] GetToolBarItems()
  {
    this._needsReviewButton = new CheckboxToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.ShowPendingCheckBox, "Show Pending Approval", new Action(this.SetFilter), (object) Resources.book_edit, true);
    this._approvedButton = new CheckboxToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.ShowApprovedCheckBox, "Show Approved", new Action(this.SetFilter), (object) Resources.money_add);
    this._rejectedButton = new CheckboxToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.ShowRejectedCheckBox, "Show Rejected", new Action(this.SetFilter), (object) Resources.money_delete);
    return new IToolbarItem[4]
    {
      (IToolbarItem) new ToolbarGroup(new IToolbarControl[3]
      {
        (IToolbarControl) new ButtonToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.SaveButton, "Save", new Action(((WrappedUltraGridDatabaseBulkEditController<IPendingApprovalSettlementModel, PendingApprovalSettlementGridModel>) this).RequestSave), (object) Resources.disk),
        (IToolbarControl) new ButtonToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.ResetButton, "Refresh", new Action(((WrappedUltraGridDatabaseBulkEditController<IPendingApprovalSettlementModel, PendingApprovalSettlementGridModel>) this).RequestReset), (object) Resources.arrow_refresh),
        (IToolbarControl) new ButtonToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.ExportButton, "Export", new Action(this.Export), (object) Resources.table_go)
      }),
      (IToolbarItem) new ToolbarGroup(new IToolbarControl[3]
      {
        (IToolbarControl) this._needsReviewButton,
        (IToolbarControl) this._approvedButton,
        (IToolbarControl) this._rejectedButton
      }),
      (IToolbarItem) new ToolbarGroup(new IToolbarControl[2]
      {
        (IToolbarControl) new ButtonToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.ApproveAllButton, "Approve All", new Action(this.ApproveAll), (object) Resources.book_add),
        (IToolbarControl) new ButtonToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.RejectAllButton, "Reject All", new Action(this.RejectAll), (object) Resources.book_delete)
      }),
      (IToolbarItem) new ToolbarGroup(new IToolbarControl[1]
      {
        (IToolbarControl) new ButtonToolbarControl(PendingApprovalSettlementGridController.ToolbarKeys.ViewTransactionButton, "View Transaction", new Action(this.ViewSelectedTransaction), (object) Resources.table_go)
      })
    };
  }

  public virtual IParentFormSettings ParentFormSettings
  {
    get
    {
      return (IParentFormSettings) new MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ParentFormSettings()
      {
        Width = 1200,
        Height = 600,
        Name = "Settlement Approval",
        Maximizeable = true,
        BorderStyle = FormBorderStyle.Sizable,
        ShortcutActions = new ShortcutAction[3]
        {
          ShortcutAction.CreateSave(new Action(((WrappedUltraGridDatabaseBulkEditController<IPendingApprovalSettlementModel, PendingApprovalSettlementGridModel>) this).RequestSave)),
          ShortcutAction.CreateReset(new Action(((WrappedUltraGridDatabaseBulkEditController<IPendingApprovalSettlementModel, PendingApprovalSettlementGridModel>) this).RequestReset)),
          ShortcutAction.CreateCancel((Action) (() => this.View.RequestCloseForm(DialogResult.Abort)))
        }
      };
    }
  }

  public ISizeSettings ParentSizeSettings
  {
    get => (ISizeSettings) new PlaceholderSizeSettings(this.ParentFormSettings);
  }

  protected override IUltraGridAdapter<IPendingApprovalSettlementModel> ChildCreateGridAdapter()
  {
    this.ApproveColumn = new CheckBoxColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.ApproveCheckBox, "Approve", 100, (Func<IPendingApprovalSettlementModel, bool>) (s => s.UserApprove), (Action<IPendingApprovalSettlementModel, bool>) ((s, v) => s.UserApprove = v));
    this.RejectColumn = new CheckBoxColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.RejectCheckBox, "Reject", 100, (Func<IPendingApprovalSettlementModel, bool>) (s => s.UserReject), (Action<IPendingApprovalSettlementModel, bool>) ((s, v) => s.UserReject = v));
    UltraGridTableSettings<IPendingApprovalSettlementModel> topLevelTable = new UltraGridTableSettings<IPendingApprovalSettlementModel>(new IUltraGridColumnSettings<IPendingApprovalSettlementModel>[14]
    {
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.PayeeNameText, "Payee Name", 200, (Func<IPendingApprovalSettlementModel, object>) (settlement => (object) settlement.PayeeName ?? (object) string.Empty), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.PaymentMethodText, "Payment Method", 100, (Func<IPendingApprovalSettlementModel, object>) (s => (object) s.PaymentMethodName ?? (object) string.Empty), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.PayeeBankText, "Payee Bank", 100, (Func<IPendingApprovalSettlementModel, object>) (settlement => (object) settlement.PayeeBank ?? (object) "N/A"), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.RoutingNumberText, "Routing #", 100, (Func<IPendingApprovalSettlementModel, object>) (settlement => (object) settlement.RoutingNumber ?? (object) "N/A"), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyButtonColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.TransactionNumberText, "Transaction #", 100, (Func<IPendingApprovalSettlementModel, string>) (settlement => settlement.TransactionNumber.ToString()), (object) Resources.table_go, new Action<IPendingApprovalSettlementModel>(this.ViewTransaction), false, this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.InvoiceCountText, "# Invoices", 100, (Func<IPendingApprovalSettlementModel, object>) (settlement => (object) settlement.InvoiceIncludedCount), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.CreatedByText, "Created By", 100, (Func<IPendingApprovalSettlementModel, object>) (settlement => (object) settlement.CreateByUserName), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new DateReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.CreateDateText, "Create Date", 200, (Func<IPendingApprovalSettlementModel, DateTime?>) (settlement => new DateTime?(settlement.CreateDate)), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) this.ApproveColumn,
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) this.RejectColumn,
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.StatusText, "Status", 200, (Func<IPendingApprovalSettlementModel, object>) (s =>
      {
        if (s.IsApproved)
          return (object) "Approved";
        return s.IsRejected ? (object) "Rejected" : (object) "Pending Approval";
      }), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new TextReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.StatusByText, "Status By", 100, (Func<IPendingApprovalSettlementModel, object>) (settlement => (object) settlement.ApproveRejectedBy), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new DateReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.StatusDateText, "Status Date", 100, (Func<IPendingApprovalSettlementModel, DateTime?>) (settlement => new DateTime?(settlement.StatusDate)), this.ColumnColorFunc),
      (IUltraGridColumnSettings<IPendingApprovalSettlementModel>) new CurrencyReadOnlyColumn<IPendingApprovalSettlementModel>(PendingApprovalSettlementGridController.SettlementGridColumnKeys.AmountText, "Amount", 100, (Func<IPendingApprovalSettlementModel, double>) (settlement => settlement.PaymentAmount), this.ColumnColorFunc)
      {
        ShowSumSummary = true
      }
    })
    {
      RightClickMenuSettings = this.GetRightClickMenuSettings()
    };
    topLevelTable.RowEnabledFunc = (Func<IPendingApprovalSettlementModel, bool>) (row => !row.IsApproved && !row.IsRejected);
    topLevelTable.FilterAdapter = new UltraGridFilterAdapter<IPendingApprovalSettlementModel>((FilterLogicalOperator) 0, false);
    return (IUltraGridAdapter<IPendingApprovalSettlementModel>) new UltraGridSettingsAdapter<IPendingApprovalSettlementModel>((IUltraGridTableSettings<IPendingApprovalSettlementModel>) topLevelTable);
  }

  protected virtual RightClickMenu GetRightClickMenuSettings()
  {
    return new RightClickMenu((IToolbarControl) this.ViewTransactionRightClickOption);
  }

  protected ButtonToolbarControl ViewTransactionRightClickOption
  {
    get
    {
      return new ButtonToolbarControl(PendingApprovalSettlementGridController.SettlementGridColumnKeys.ViewTransactionButton, "View Transaction", new Action(this.ViewSelectedTransaction), (object) Resources.table_go);
    }
  }

  private void ViewTransaction(IPendingApprovalSettlementModel model)
  {
    int num = (int) ObjectFactory.Instance.CreateForm(typeof (formTransactionViewer), new object[2]
    {
      (object) model.TransactionNumber,
      (object) 0
    }).ShowDialog();
  }

  protected static class SettlementGridColumnKeys
  {
    public static readonly string ApproveCheckBox = nameof (ApproveCheckBox);
    public static readonly string ApproveCheck = nameof (ApproveCheckBox);
    public static readonly string RejectCheckBox = nameof (RejectCheckBox);
    public static readonly string PayeeNameText = nameof (PayeeNameText);
    public static readonly string PaymentMethodText = nameof (PaymentMethodText);
    public static readonly string PayeeBankText = nameof (PayeeBankText);
    public static readonly string RoutingNumberText = nameof (RoutingNumberText);
    public static readonly string TransactionNumberText = nameof (TransactionNumberText);
    public static readonly string InvoiceCountText = nameof (InvoiceCountText);
    public static readonly string CreatedByText = nameof (CreatedByText);
    public static readonly string CreateDateText = nameof (CreateDateText);
    public static readonly string StatusText = nameof (StatusText);
    public static readonly string StatusByText = nameof (StatusByText);
    public static readonly string StatusDateText = nameof (StatusDateText);
    public static readonly string AmountText = nameof (AmountText);
    public static readonly string ViewTransactionButton = nameof (ViewTransactionButton);
  }

  protected static class ToolbarKeys
  {
    public static readonly string ShowPendingCheckBox = nameof (ShowPendingCheckBox);
    public static readonly string ShowApprovedCheckBox = nameof (ShowApprovedCheckBox);
    public static readonly string ShowRejectedCheckBox = nameof (ShowRejectedCheckBox);
    public static readonly string ResetButton = nameof (ResetButton);
    public static readonly string SaveButton = nameof (SaveButton);
    public static readonly string ExportButton = nameof (ExportButton);
    public static readonly string ApproveAllButton = nameof (ApproveAllButton);
    public static readonly string RejectAllButton = nameof (RejectAllButton);
    public static readonly string ViewTransactionButton = nameof (ViewTransactionButton);
  }
}
