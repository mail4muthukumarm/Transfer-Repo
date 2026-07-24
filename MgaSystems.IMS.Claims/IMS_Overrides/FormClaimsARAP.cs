// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.IMS_Overrides.FormClaimsARAP
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Claims.DataAccess.CheckRegister;
using MGASystems.IMS.Claims.DataAccess.GridClaimsArHeader;
using MGASystems.IMS.Claims.DataAccess.ReceiveTransactionExpense;
using MGASystems.IMS.Claims.DataAccess.RemitterJournal;
using MGASystems.IMS.Claims.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.IMS_Overrides;

[Override(typeof (formTransactionBuilder))]
public class FormClaimsARAP : formTransactionBuilder
{
  private BlockingRunner _tabLoadingRunner;
  private Decimal _claimARApplied;
  protected InsuranceTransaction trans;
  private const string _claimTabName = "CLAIMSAR";
  private IContainer components;
  private UltraTabPageControl ultraTabPageControl1;
  private BindingSource dsclaimsAR1BindingSource;
  private ToolTip toolTip1;
  public dsclaimsAR dsclaimsAR1;
  private UltraTabPageControl ultraTabPageControl2;
  public UltraGrid gridClaimsAR;

  public FormClaimsARAP()
  {
    this.InitializeComponent();
    ((Control) this).Text = "Transaction Builder (Claims Enabled)";
    FormClaimsARAP formClaimsArap = this;
    // ISSUE: virtual method pointer
    this.LoadWorksheetCompleted += new formTransactionBuilder.LoadWorksheetCompletedHandler((object) formClaimsArap, __vmethodptr(formClaimsArap, FormClaimsARAP_LoadWorksheetCompleted));
    this.GridClaimARImport = this.gridClaimsAR;
    this.DSClaimAR = (DataSet) this.dsclaimsAR1;
    this._tabLoadingRunner = new BlockingRunner()
    {
      EnterStateAction = (Action) (() => this.SetClaimsARTabText(Resources.RECEIVABLESTAB_LOADING)),
      ExitStateAction = (Action) (() => this.SetClaimsARTabText(Resources.RECEIVABLESTAB))
    };
  }

  protected virtual InsuranceTransaction CreateTransaction()
  {
    this.trans = base.CreateTransaction();
    this.CaptureDataInTransaction(this.trans);
    return this.trans;
  }

  public event FormClaimsARAP.AfterPostTransactionHandler AfterTransactionPosted;

  protected virtual void FormClaimsARAP_LoadWorksheetCompleted(int worksheetId)
  {
    object claimsWorksheet = (object) null;
    DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ((sender, args) =>
    {
      MemoryStream serializationStream = new MemoryStream();
      byte[] numArray = (byte[]) null;
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
      while (args.Reader.Read())
      {
        byte[] buffer = (byte[]) args.Reader["Worksheet"];
        serializationStream.Write(buffer, 0, buffer.Length);
        serializationStream.Position = 0L;
        AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(Utility.LoadComponentAssembly);
        claimsWorksheet = binaryFormatter.Deserialize((Stream) serializationStream);
        serializationStream.Close();
        AppDomain.CurrentDomain.AssemblyResolve -= new ResolveEventHandler(Utility.LoadComponentAssembly);
      }
      serializationStream.Dispose();
      numArray = (byte[]) null;
    }), "spClaims_GetClaimAccountingWorksheet", new object[2]
    {
      (object) "@entryid",
      (object) worksheetId
    });
    if (!(claimsWorksheet is ClaimAccountingWorksheet) || (claimsWorksheet as ClaimAccountingWorksheet).claimARValues.Count == 0)
      return;
    UltraGridBand band = ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Bands[0];
    ColumnFiltersCollection columnFilters = band.ColumnFilters;
    foreach (ClaimReceivableValue claimArValue in (CollectionBase) (claimsWorksheet as ClaimAccountingWorksheet).claimARValues)
    {
      columnFilters.ClearAllFilters();
      columnFilters[FormClaimsARAP.GridColumnKeys.ClaimId].FilterConditions.Add((FilterComparisionOperator) 0, (object) claimArValue.ClaimId);
      if (((KeyedSubObjectsCollectionBase) band.Columns).Exists(FormClaimsARAP.GridColumnKeys.UAExpenseId) && claimArValue.UAExpenseId != -1)
        columnFilters[FormClaimsARAP.GridColumnKeys.UAExpenseId].FilterConditions.Add((FilterComparisionOperator) 0, (object) claimArValue.UAExpenseId);
      if (((KeyedSubObjectsCollectionBase) band.Columns).Exists(FormClaimsARAP.GridColumnKeys.ResPayId) && claimArValue.ResPayId != -1)
        columnFilters[FormClaimsARAP.GridColumnKeys.ResPayId].FilterConditions.Add((FilterComparisionOperator) 0, (object) claimArValue.ResPayId);
      UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridClaimsAR).Rows.GetFilteredInNonGroupByRows();
      if (inNonGroupByRows.Length != 0)
        inNonGroupByRows[0].Cells[FormClaimsARAP.GridColumnKeys.ClaimARApplied].Value = (object) claimArValue.Amount;
    }
    columnFilters.ClearAllFilters();
  }

  protected virtual void DoLoadReceivables()
  {
    base.DoLoadReceivables();
    this.LoadClaimsAR();
  }

  protected void SetClaimsARTabText(string text)
  {
    if (((Control) this.tabTransactions).InvokeRequired)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).Invoke((Delegate) new FormClaimsARAP.DelegateSetTextSafe(this.SetClaimsARTabText), (object) text));
    }
    else
      ((UltraTabControlBase) this.tabTransactions).Tabs["CLAIMSAR"].Text = text;
  }

  protected void SetClaimsARTabVisible(bool visibility)
  {
    if (((Control) this.tabTransactions).InvokeRequired)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).Invoke((Delegate) new FormClaimsARAP.DelegateSetVisibleSafe(this.SetClaimsARTabVisible), (object) visibility));
    }
    else
      ((UltraTabControlBase) this.tabTransactions).Tabs["CLAIMSAR"].Visible = visibility;
  }

  protected virtual void LoadClaimsAR()
  {
    this.SetClaimsARTabText(Resources.RECEIVABLESTAB_LOADING);
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) =>
      {
        DefaultDatabase.LoadDataTable((DataTable) this.dsclaimsAR1.ClaimsAR, CommandType.StoredProcedure, "spClaims_GetClaimAR", 0, (CommandArgumentType) 0, new object[4]
        {
          (object) "@GlCompanyId",
          (object) this.GLCompanyId,
          (object) "@EntityGuid",
          (object) this.ProtectedEntityGuid
        });
        this.SetClaimsARTabText(Resources.RECEIVABLESTAB);
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        this.SetClaimsARTabVisible(((DisposableObjectCollectionBase) ((UltraGridBase) this.gridClaimsAR).Rows).Count > 0);
        this.FormatTopLevelBand(false);
        this.gridClaimsAR.ClickCellButton += new CellEventHandler(this.gridClaimsAR_ClickCellButton);
        this.gridClaimsAR.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridClaimsAR_BeforeCellUpdate);
        this.gridClaimsAR.AfterCellUpdate += new CellEventHandler(this.gridClaimsAR_AfterCellUpdate);
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  protected virtual void Post()
  {
    this.HasClaims = true;
    this.SetNumberOfClaimsReceived();
    this.Post_ShareCommand();
  }

  protected virtual void AfterPostTransaction(
    InsuranceTransaction transaction,
    SqlCommand sqlCommand)
  {
    base.AfterPostTransaction(transaction, sqlCommand);
    SqlTransaction transaction1 = sqlCommand.Transaction;
    FormClaimsARAP.InsertCapturedData(transaction, ((AccountingTransaction) transaction).TransactionNumber, transaction1);
    this.ClaimsOnLoadWorksheetCompleted(((AccountingTransaction) transaction).TransactionNumber);
  }

  protected virtual void CalculateAndDisplayTotal()
  {
    base.CalculateAndDisplayTotal();
    this._claimARApplied = this.GetClaimARApplied();
    if (this.radioCashReceipt.Checked)
      ((Control) this.txtBalance).Text = (Decimal.Parse(((Control) this.txtBalance).Text, NumberStyles.Any) - this._claimARApplied).ToString("c");
    else
      ((Control) this.txtPayAmount).Text = (Decimal.Parse(((Control) this.txtPayAmount).Text, NumberStyles.Any) - this._claimARApplied).ToString("c");
  }

  protected virtual void ToolBarClicked(object sender, ToolClickEventArgs e)
  {
    base.ToolBarClicked(sender, e);
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToUpper())
    {
      case "CLAIMS_PAYINFULL":
        if (((UltraGridBase) this.gridClaimsAR).ActiveRow == null)
          return;
        this.Claims_PayInFull(((UltraGridBase) this.gridClaimsAR).ActiveRow);
        break;
      case "CLAIMS_PAYALL":
        this.Claims_PayAllInFull();
        break;
      case "CLAIMS_CLEARAPPLIED":
        if (((UltraGridBase) this.gridClaimsAR).ActiveRow == null)
          return;
        this.Claims_ClearApplied(((UltraGridBase) this.gridClaimsAR).ActiveRow);
        break;
      case "CLAIMS_CLEARALLAPPLIED":
        this.Claims_ClearAllApplied();
        break;
    }
    base.CalculateAndDisplayTotal();
  }

  protected virtual void Clear()
  {
    base.Clear();
    this._claimARApplied = 0M;
    this.dsclaimsAR1.Clear();
  }

  protected virtual void gridClaimsAR_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == FormClaimsARAP.GridColumnKeys.ClaimARApplied))
      return;
    if (!string.IsNullOrEmpty(e.Cell.Value?.ToString()))
      this._claimARApplied -= (Decimal) e.Cell.Value;
    if (string.IsNullOrEmpty(e.NewValue?.ToString()))
      return;
    int num1 = Math.Sign((Decimal) e.Cell.Row.Cells[FormClaimsARAP.GridColumnKeys.Balance].Value);
    int num2 = Math.Sign((Decimal) e.NewValue);
    if (num2 != num1)
    {
      int num3 = (int) MessageBox.Show(Resources.ERROR_RECEIVABLEAMOUNT_SIGNMISMATCH, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (num2 <= num1)
        return;
      int num4 = (int) MessageBox.Show(Resources.ERROR_RECEIVABLEAMOUNT_EXCEEDSBALANCE, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
  }

  protected virtual void gridClaimsAR_AfterCellUpdate(object sender, CellEventArgs e)
  {
    base.CalculateAndDisplayTotal();
  }

  private Decimal GetClaimARApplied()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridClaimsAR).Rows).Count == 0)
      return 0M;
    UltraGridBand band = ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Bands[0];
    MemoryStream memoryStream = new MemoryStream();
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Save((Stream) memoryStream);
    memoryStream.Seek(0L, SeekOrigin.Begin);
    memoryStream.Position = 0L;
    try
    {
      Decimal claimArApplied = 0M;
      band.ColumnFilters.ClearAllFilters();
      band.ColumnFilters[FormClaimsARAP.GridColumnKeys.ClaimARApplied].FilterConditions.Add((FilterComparisionOperator) 1, (object) DBNull.Value);
      band.ColumnFilters[FormClaimsARAP.GridColumnKeys.ClaimARApplied].LogicalOperator = (FilterLogicalOperator) 0;
      band.ColumnFilters[FormClaimsARAP.GridColumnKeys.ClaimARApplied].FilterConditions.Add((FilterComparisionOperator) 1, (object) "$0.00");
      UltraGridRow[] inNonGroupByRows = band.Layout.Grid.Rows.GetFilteredInNonGroupByRows();
      if (inNonGroupByRows.Length == 0)
      {
        band.ColumnFilters.ClearAllFilters();
        return claimArApplied;
      }
      foreach (UltraGridRow ultraGridRow in inNonGroupByRows)
        claimArApplied += Decimal.Parse(ultraGridRow.Cells[FormClaimsARAP.GridColumnKeys.ClaimARApplied].Value.ToString());
      band.ColumnFilters.ClearAllFilters();
      memoryStream.Position = 0L;
      memoryStream.Seek(0L, SeekOrigin.Begin);
      ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Load((Stream) memoryStream);
      if (((KeyedSubObjectsCollectionBase) band.Columns).Exists(FormClaimsARAP.GridColumnKeys.ClaimNumber))
        ((HeaderBase) band.Columns[FormClaimsARAP.GridColumnKeys.ClaimNumber].Header).VisiblePosition = 0;
      return claimArApplied;
    }
    finally
    {
      memoryStream.Dispose();
    }
  }

  public void CaptureDataInTransaction(InsuranceTransaction transaction)
  {
    if (transaction == null)
      return;
    if (!(transaction is ClaimInsuranceTransaction insuranceTransaction))
      throw new InvalidOperationException("Cannot insert a non claim insurance transaction.");
    this.SetClaimsHeader(insuranceTransaction);
    this.SetGridClaimsEntries(insuranceTransaction);
  }

  protected virtual void SetClaimsHeader(
    ClaimInsuranceTransaction claimInsuranceTransaction)
  {
    this.SetExpenseHeaderDto(claimInsuranceTransaction);
    if (this.radioCashReceipt.Checked)
      this.SetRemitterJournalDto(claimInsuranceTransaction);
    else
      this.SetCheckRegisterDto(claimInsuranceTransaction);
  }

  public static void InsertCapturedData(
    InsuranceTransaction transaction,
    int transactionNumber,
    SqlTransaction sqlTransaction)
  {
    if (transaction == null)
      return;
    if (!(transaction is ClaimInsuranceTransaction insuranceTransaction))
      throw new InvalidOperationException("Cannot insert a non claim insurance transaction.");
    if (transactionNumber > -1)
    {
      if (insuranceTransaction.ReceiveTransactionExpenseDtos == null)
        return;
      ReceiveTransactionExpenseRepository.TransactionInsertBulk((IEnumerable<ReceiveTransactionExpenseDto>) insuranceTransaction.ReceiveTransactionExpenseDtos, transactionNumber, (DbTransaction) sqlTransaction);
    }
    else
    {
      int transactionNumber1 = JournalDataAccess.TransactionInsertClaimsExpense(insuranceTransaction.ReceiveExpenseHeaderDto, (DbTransaction) sqlTransaction);
      if (insuranceTransaction.RemitterJournalDto != null)
        RemitterJournalRepository.TransactionInsert(insuranceTransaction.RemitterJournalDto, transactionNumber1, (DbTransaction) sqlTransaction);
      else
        CheckRegisterRepository.TransactionInsert(insuranceTransaction.CheckRegisterDto, transactionNumber1, (DbTransaction) sqlTransaction);
      if (insuranceTransaction.ReceiveTransactionExpenseDtos == null)
        return;
      ReceiveTransactionExpenseRepository.TransactionInsertBulk((IEnumerable<ReceiveTransactionExpenseDto>) insuranceTransaction.ReceiveTransactionExpenseDtos, transactionNumber1, (DbTransaction) sqlTransaction);
    }
  }

  private void SetCheckRegisterDto(ClaimInsuranceTransaction insuranceTransaction)
  {
    insuranceTransaction.CheckRegisterDto = new CheckRegisterDto()
    {
      PaymentMethod = this.GetCharTransactionPaymentMethod(),
      CheckingAcountId = ((UltraCombo) this.comboBankAccount).Value,
      PayeeGuid = this.EntityGuid,
      CheckDate = ((UltraDateTimeEditor) this.dateTimeCheckDate).DateTime,
      Comments = ((AccountingTransaction) this.trans).CheckData.Comments,
      CheckMemo = ((AccountingTransaction) this.trans).CheckData.CheckMemo,
      PayeeName = ((AccountingTransaction) this.trans).CheckData.PayeeName,
      PayeeAddress1 = ((AccountingTransaction) this.trans).CheckData.PayeeAddress1,
      PayeeAddress2 = ((AccountingTransaction) this.trans).CheckData.PayeeAddress2,
      PayeeCity = ((AccountingTransaction) this.trans).CheckData.PayeeCity,
      PayeeState = ((AccountingTransaction) this.trans).CheckData.PayeeState,
      PayeeZip = ((AccountingTransaction) this.trans).CheckData.PayeeZip,
      PayeeZipPlus = ((AccountingTransaction) this.trans).CheckData.PayeeZipPlus,
      CheckName = this.EntityName
    };
  }

  protected virtual void SetRemitterJournalDto(ClaimInsuranceTransaction insuranceTransaction)
  {
    insuranceTransaction.RemitterJournalDto = new RemitterJournalDto()
    {
      ReceiveDate = ((UltraDateTimeEditor) this.dateTimeReceivedDate).DateTime,
      DepositDate = ((UltraDateTimeEditor) this.dateTimeDepositDate).DateTime,
      CheckNumber = ((Control) this.txtCheckNumber).Text,
      RemitterGuid = this.ProtectedEntityGuid,
      Amount = Decimal.Parse(((Control) this.txtCheckAmount).Text, NumberStyles.Any),
      Comments = ((Control) this.txtPostingMemo).Text,
      RemittedFrom = string.IsNullOrEmpty(((Control) this.txtCheckFrom).Text) ? (object) SqlString.Null : ((Control) this.txtCheckFrom).Tag
    };
  }

  protected virtual void SetExpenseHeaderDto(ClaimInsuranceTransaction insuranceTransaction)
  {
    insuranceTransaction.ReceiveExpenseHeaderDto = new ReceiveExpenseHeaderDto()
    {
      PostDate = ((UltraDateTimeEditor) this.dateTimeDepositDate).DateTime,
      Comments = ((Control) this.txtPostingMemo).Text,
      CurrentUserGuid = CurrentUser.Instance.UserGUID,
      GlCompanyId = this.GLCompanyId
    };
  }

  protected virtual void SetNumberOfClaimsReceived()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridClaimsAR).Rows).Count == 0)
    {
      this.NumberOfClaimsReceived = 0;
    }
    else
    {
      ColumnFiltersCollection columnFilters = ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Bands[0].ColumnFilters;
      try
      {
        columnFilters.ClearAllFilters();
        columnFilters[FormClaimsARAP.GridColumnKeys.ClaimARApplied].FilterConditions.Add((FilterComparisionOperator) 1, (SpecialFilterOperand) null);
        columnFilters[FormClaimsARAP.GridColumnKeys.ClaimARApplied].FilterConditions.Add((FilterComparisionOperator) 1, (object) 0M);
        columnFilters[FormClaimsARAP.GridColumnKeys.ClaimARApplied].LogicalOperator = (FilterLogicalOperator) 0;
        this.NumberOfClaimsReceived = ((UltraGridBase) this.gridClaimsAR).Rows.GetFilteredInNonGroupByRows().Length;
      }
      finally
      {
        columnFilters[FormClaimsARAP.GridColumnKeys.ClaimARApplied].FilterConditions.Clear();
      }
    }
  }

  protected virtual void SetGridClaimsEntries(ClaimInsuranceTransaction insuranceTransaction)
  {
    UltraGridBand band = ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Bands[0];
    band.ColumnFilters.ClearAllFilters();
    band.ColumnFilters["ClaimARApplied"].FilterConditions.Add((FilterComparisionOperator) 1, (SpecialFilterOperand) null);
    band.ColumnFilters["ClaimARApplied"].FilterConditions.Add((FilterComparisionOperator) 1, (object) 0M);
    band.ColumnFilters["ClaimARApplied"].LogicalOperator = (FilterLogicalOperator) 0;
    try
    {
      UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridClaimsAR).Rows.GetFilteredInNonGroupByRows();
      insuranceTransaction.ReceiveTransactionExpenseDtos = new List<ReceiveTransactionExpenseDto>();
      if (inNonGroupByRows.Length == 0)
        return;
      for (int index = 0; index < inNonGroupByRows.Length; ++index)
        insuranceTransaction.ReceiveTransactionExpenseDtos.Add(new ReceiveTransactionExpenseDto()
        {
          ClaimId = (int) inNonGroupByRows[index].Cells["ClaimId"].Value,
          UAExpenseId = (int) inNonGroupByRows[index].Cells["UAExpenseId"].Value,
          Amount = (Decimal) inNonGroupByRows[index].Cells["ClaimARApplied"].Value,
          BankAccount = ((UltraCombo) this.comboBankAccount).Value,
          EntityGuid = this.ProtectedEntityGuid,
          UserGuid = CurrentUser.Instance.UserGUID
        });
    }
    finally
    {
      band.ColumnFilters["ClaimARApplied"].FilterConditions.Clear();
    }
  }

  private void Claims_PayInFull(UltraGridRow row)
  {
    row.Cells[FormClaimsARAP.GridColumnKeys.ClaimARApplied].Value = row.Cells[FormClaimsARAP.GridColumnKeys.Balance].Value;
  }

  private void Claims_PayAllInFull()
  {
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridClaimsAR).Rows.GetFilteredInNonGroupByRows())
      filteredInNonGroupByRow.Cells[FormClaimsARAP.GridColumnKeys.ClaimARApplied].Value = filteredInNonGroupByRow.Cells[FormClaimsARAP.GridColumnKeys.Balance].Value;
  }

  private void Claims_ClearApplied(UltraGridRow row)
  {
    row.Cells[FormClaimsARAP.GridColumnKeys.ClaimARApplied].Value = (object) null;
  }

  private void Claims_ClearAllApplied()
  {
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridClaimsAR).Rows.GetFilteredInNonGroupByRows())
      this.Claims_ClearApplied(filteredInNonGroupByRow);
  }

  private void gridClaimsAR_ClickCellButton(object sender, CellEventArgs e)
  {
    ((ScrollRegionBase) ((UltraGridBase) (sender as UltraGrid)).DisplayLayout.RowScrollRegions[0]).Scrollbar = (Scrollbar) 3;
    try
    {
      if (!(((KeyedSubObjectBase) e.Cell.Column).Key == FormClaimsARAP.GridColumnKeys.ClaimARApplied))
        return;
      e.Cell.Row.Cells[FormClaimsARAP.GridColumnKeys.ClaimARApplied].Value = e.Cell.Row.Cells[FormClaimsARAP.GridColumnKeys.Balance].Value;
    }
    finally
    {
      ((ScrollRegionBase) ((UltraGridBase) (sender as UltraGrid)).DisplayLayout.RowScrollRegions[0]).Scrollbar = (Scrollbar) 2;
    }
  }

  protected virtual void ClaimsOnLoadWorksheetCompleted(int transactionNumber)
  {
    FormClaimsARAP.AfterPostTransactionHandler transactionPosted = this.AfterTransactionPosted;
    if (transactionPosted == null)
      return;
    transactionPosted(transactionNumber);
  }

  protected virtual void LoadClaimsAutomation_New()
  {
    this.SetClaimsARTabVisible(((DisposableObjectCollectionBase) ((UltraGridBase) this.gridClaimsAR).Rows).Count > 0);
    this.FormatTopLevelBand(true);
    this.SetClaimsARTabText(Resources.RECEIVABLESTAB);
  }

  protected virtual void LoadClaimsAutomation_NewBulk()
  {
    this._tabLoadingRunner.Run((Action) (() =>
    {
      this.SetClaimsARTabVisible(((DisposableObjectCollectionBase) ((UltraGridBase) this.gridClaimsAR).Rows).Count > 0);
      UltraGridBand band = ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Bands[0];
      this.FormatTopLevelBand(true);
    }));
  }

  private void FormatTopLevelBand(bool hideClaimNumber)
  {
    ColumnsCollection columns = ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Bands[0].Columns;
    if (((KeyedSubObjectsCollectionBase) columns).Exists(FormClaimsARAP.GridColumnKeys.ClaimNumber))
    {
      ((HeaderBase) columns[FormClaimsARAP.GridColumnKeys.ClaimNumber].Header).VisiblePosition = 0;
      columns[FormClaimsARAP.GridColumnKeys.ClaimNumber].CellActivation = (Activation) 3;
      ((HeaderBase) columns[FormClaimsARAP.GridColumnKeys.ClaimNumber].Header).Appearance.TextHAlign = (HAlign) 1;
    }
    if (((KeyedSubObjectsCollectionBase) columns).Exists(FormClaimsARAP.GridColumnKeys.TransferDate))
    {
      ((HeaderBase) columns[FormClaimsARAP.GridColumnKeys.TransferDate].Header).VisiblePosition = 1;
      columns[FormClaimsARAP.GridColumnKeys.TransferDate].CellActivation = (Activation) 3;
      ((HeaderBase) columns[FormClaimsARAP.GridColumnKeys.TransferDate].Header).Appearance.TextHAlign = (HAlign) 1;
    }
    if (((KeyedSubObjectsCollectionBase) columns).Exists(FormClaimsARAP.GridColumnKeys.ARDate))
    {
      ((HeaderBase) columns[FormClaimsARAP.GridColumnKeys.ARDate].Header).VisiblePosition = 2;
      ((HeaderBase) columns[FormClaimsARAP.GridColumnKeys.ARDate].Header).Caption = "Expense Date";
      columns[FormClaimsARAP.GridColumnKeys.ARDate].CellActivation = (Activation) 3;
      ((HeaderBase) columns[FormClaimsARAP.GridColumnKeys.ARDate].Header).Appearance.TextHAlign = (HAlign) 1;
    }
    if (!hideClaimNumber || !((KeyedSubObjectsCollectionBase) columns).Exists(FormClaimsARAP.GridColumnKeys.HiddenClaimNumber))
      return;
    columns[FormClaimsARAP.GridColumnKeys.HiddenClaimNumber].Hidden = true;
  }

  protected virtual void gridClaimsAR_InitializeRow(object sender, InitializeRowEventArgs e)
  {
  }

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("OpenPayables", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GLCompanyId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PolicyNumber", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormClaimsARAP));
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Payee");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Gross Payable");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("AmtPtd");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Net Payable");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Amt Rcvd");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Exch Balance");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("UnAcct Balance");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("APGL");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("PropAmt");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("payeePercentRate");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("mgaPercentrate");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("apapplied");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("CheckRequested");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Fees Due Date");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("TransactionDate");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Endorsement Effective");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("CurrencyCode_Functional");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("CurrencyCode_Reporting");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ConvRate_Functional");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("ConvRate_Reporting");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Producer");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("ClaimsGridToolbar");
    PopupMenuTool popupMenuTool = new PopupMenuTool("CLAIMSGRIDCONTEXT");
    ButtonTool buttonTool1 = new ButtonTool("CLAIMS_PAYINFULL");
    ButtonTool buttonTool2 = new ButtonTool("CLAIMS_CLEARAPPLIED");
    ButtonTool buttonTool3 = new ButtonTool("CLAIMS_PAYALL");
    ButtonTool buttonTool4 = new ButtonTool("CLAIMS_CLEARALLAPPLIED");
    ButtonTool buttonTool5 = new ButtonTool("CLAIMS_PAYINFULL");
    ButtonTool buttonTool6 = new ButtonTool("CLAIMS_PAYALL");
    ButtonTool buttonTool7 = new ButtonTool("CLAIMS_CLEARAPPLIED");
    ButtonTool buttonTool8 = new ButtonTool("CLAIMS_CLEARALLAPPLIED");
    UltraTab ultraTab = new UltraTab();
    Appearance appearance21 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("", -1);
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("", -1);
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("ClaimsAR", -1);
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("ClaimId");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("UAExpenseId");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("Description");
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("ARDate");
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("ARAmount");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("ARRcvd");
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("Balance");
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ClaimARApplied", 0);
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "ClaimARApplied", 0, false, "ClaimsAR", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance63 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "ARAmount", 5, true, "ClaimsAR", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance64 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "ARRcvd", 6, true, "ClaimsAR", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance65 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "Balance", 7, true, "ClaimsAR", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    this.ultraTabPageControl2 = new UltraTabPageControl();
    this.gridClaimsAR = new UltraGrid();
    this.dsclaimsAR1BindingSource = new BindingSource(this.components);
    this.dsclaimsAR1 = new dsclaimsAR();
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.toolTip1 = new ToolTip(this.components);
    this.pnlContainer.SuspendLayout();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.comboBankAccount).BeginInit();
    ((Control) this.tabPagePayable).SuspendLayout();
    ((ISupportInitialize) this.gridPayables).BeginInit();
    ((ISupportInitialize) this.toolbar).BeginInit();
    ((ISupportInitialize) this.tabTransactions).BeginInit();
    ((Control) this.tabTransactions).SuspendLayout();
    ((ISupportInitialize) this.comboPaymentMethods).BeginInit();
    ((ISupportInitialize) this.dateTimeCheckDate).BeginInit();
    ((ISupportInitialize) this.dateTimeReceivedDate).BeginInit();
    ((ISupportInitialize) this.dateTimeDepositDate).BeginInit();
    ((ISupportInitialize) this.txtPayAmount).BeginInit();
    ((ISupportInitialize) this.txtBalance).BeginInit();
    ((ISupportInitialize) this.txtCheckNumber).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount).BeginInit();
    ((ISupportInitialize) this.txtAppliedUnAccounted).BeginInit();
    ((ISupportInitialize) this.txtUnAccountedBalance).BeginInit();
    ((ISupportInitialize) this.gridReceivables).BeginInit();
    ((ISupportInitialize) this.txtEntityName).BeginInit();
    this.dsOpenReceivables.BeginInit();
    this.dsOpenPayables.BeginInit();
    ((ISupportInitialize) this.AdditionalOffsetToolManager).BeginInit();
    ((ISupportInitialize) this.btnCancelChanges).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.comboCostCenters).BeginInit();
    ((Control) this.tabAdditonalOffsets).SuspendLayout();
    ((ISupportInitialize) this.gridAdditionalOffsets).BeginInit();
    ((ISupportInitialize) this.txtPostingMemo).BeginInit();
    ((ISupportInitialize) this.comboUnAccountedCostCenter).BeginInit();
    ((ISupportInitialize) this.txtCheckFrom).BeginInit();
    ((ISupportInitialize) this.checkCreditCard).BeginInit();
    ((ISupportInitialize) this.buttonAppliedUnaccounted).BeginInit();
    ((ISupportInitialize) this.buttonCancelAppliedUnaccounted).BeginInit();
    ((ISupportInitialize) this.gridNonWorkingDeposit).BeginInit();
    ((ISupportInitialize) this.checkBankCurrency).BeginInit();
    ((Control) this.ultraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.gridClaimsAR).BeginInit();
    ((ISupportInitialize) this.dsclaimsAR1BindingSource).BeginInit();
    this.dsclaimsAR1.BeginInit();
    ((Control) this).SuspendLayout();
    this.panel1.Location = new Point(0, 45);
    this.panel1.Size = new Size(208 /*0xD0*/, 725);
    ((Control) this.tabPagePayable).Location = new Point(-10000, -10000);
    this.toolbar.SetContextMenuUltra((Component) this.gridPayables, "PaybleContextMenu");
    ((UltraGridBase) this.gridPayables).DataMember = "";
    ((UltraGridBase) this.gridPayables).DataSource = (object) null;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPayables).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridPayables).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 9;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 27;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 30;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 33;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 24;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance2.Image");
    ultraGridColumn6.CellButtonAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Style = (ColumnStyle) 2;
    ultraGridColumn6.Width = 52;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 34;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 8;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 28;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 9;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 28;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 10;
    ultraGridColumn10.Width = 50;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance3.Image");
    ultraGridColumn11.CellButtonAppearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 11;
    ultraGridColumn11.Style = (ColumnStyle) 2;
    ultraGridColumn11.Width = 71;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 12;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 30;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 13;
    ultraGridColumn13.Width = 61;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn14.Format = "c";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 14;
    ultraGridColumn14.Width = 55;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 15;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 25;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn16.Format = "c";
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn16.Width = 55;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 17;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 25;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 18;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 25;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 19;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 29;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 20;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 30;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 21;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 33;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 7;
    ultraGridColumn22.Width = 53;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 18;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 18;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 18;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn26.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn26.Format = "c";
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn26.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Prop Amt. Due";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 25;
    ultraGridColumn26.Width = 55;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 25;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 33;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn29.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 28;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 29;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance10).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance11).Image = componentResourceManager.GetObject("appearance11.Image");
    ultraGridColumn30.CellButtonAppearance = (AppearanceBase) appearance11;
    ultraGridColumn30.Format = "c";
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Ap Applied";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 29;
    ultraGridColumn30.Style = (ColumnStyle) 2;
    ultraGridColumn30.Width = 55;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 30;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 97;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 32 /*0x20*/;
    ultraGridColumn32.Width = 61;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 34;
    ultraGridColumn33.Width = 54;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 36;
    ultraGridColumn34.Width = 65;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 38;
    ultraGridColumn35.Width = 82;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 58;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 33;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 88;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 35;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 87;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 37;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 77;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 39;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 75;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 40;
    ultraGridColumn41.Width = 54;
    ultraGridBand1.Columns.AddRange(new object[41]
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
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPayables).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridPayables).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance14).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance15).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BackColor = Color.Transparent;
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance19).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridPayables).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((SettingsBase) this.toolbar.MenuSettings).ForceSerialization = true;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 1;
    ultraToolbar.Text = "ClaimsGridToolbar";
    ultraToolbar.Visible = false;
    this.toolbar.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((SettingsBase) this.toolbar.ToolbarSettings).ForceSerialization = true;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "ClaimGridContext";
    ((ToolBase) popupMenuTool).SharedPropsInternal.Category = "CLAIMS_CONTEXT";
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Pay In Full";
    ((ToolBase) buttonTool5).SharedPropsInternal.Category = "CLAIMS_CONTEXT";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Pay All In Full";
    ((ToolBase) buttonTool6).SharedPropsInternal.Category = "CLAIMS_CONTEXT";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Clear Applied Receivable";
    ((ToolBase) buttonTool7).SharedPropsInternal.Category = "CLAIMS_CONTEXT";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Clear All Applied Receivables";
    ((ToolBase) buttonTool8).SharedPropsInternal.Category = "CLAIMS_CONTEXT";
    ((ToolsCollectionBase) this.toolbar.Tools).AddRange(new ToolBase[5]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ((Control) this.tabTransactions).Controls.Add((Control) this.ultraTabPageControl2);
    ((Control) this.tabTransactions).Location = new Point(208 /*0xD0*/, 45);
    ((Control) this.tabTransactions).Size = new Size(844, 725);
    ((UltraTabControlBase) this.tabTransactions).TabPageMargins.ForceSerialization = true;
    ((KeyedSubObjectBase) ultraTab).Key = "CLAIMSAR";
    ultraTab.TabPage = this.ultraTabPageControl2;
    ultraTab.Text = "Claims Receivables";
    ((UltraTabControlBase) this.tabTransactions).Tabs.AddRange(new UltraTab[1]
    {
      ultraTab
    });
    ((Control) this.tabTransactions).Controls.SetChildIndex((Control) this.ultraTabPageControl2, 0);
    ((Control) this.tabTransactions).Controls.SetChildIndex((Control) this.tabAdditonalOffsets, 0);
    ((Control) this.tabTransactions).Controls.SetChildIndex((Control) this.tabPagePayable, 0);
    this.toolbar.SetContextMenuUltra((Component) this.gridReceivables, "ReceivableContextMenu");
    ((UltraGridBase) this.gridReceivables).DataMember = "";
    ((UltraGridBase) this.gridReceivables).DataSource = (object) null;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Appearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.GroupHeadersVisible = false;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance23).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance27).BackColor = Color.Transparent;
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance28).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((SettingsBase) this.AdditionalOffsetToolManager.MenuSettings).ForceSerialization = true;
    ((SettingsBase) this.AdditionalOffsetToolManager.ToolbarSettings).ForceSerialization = true;
    this.AdditionalOffsetToolManager.SetContextMenuUltra((Component) this.gridAdditionalOffsets, "ContextMenu");
    ((AppearanceBase) appearance30).BackColor = Color.White;
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Appearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance31).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance31).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance32).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance33).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance36).BackColor = Color.Transparent;
    ((AppearanceBase) appearance36).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance37).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((AppearanceBase) appearance39).BackColor = Color.White;
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Appearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance40).BackColor = Color.LightSteelBlue;
    ultraGridBand3.Override.SummaryFooterAppearance = (AppearanceBase) appearance40;
    ultraGridBand3.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance41).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance41).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance42).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance44).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance44;
    ((AppearanceBase) appearance45).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance45;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance46).BackColor = Color.Transparent;
    ((AppearanceBase) appearance46).ForeColor = Color.Black;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance46;
    ((AppearanceBase) appearance47).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance47).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.gridClaimsAR);
    ((Control) this.ultraTabPageControl2).Location = new Point(1, 20);
    ((Control) this.ultraTabPageControl2).Name = "ultraTabPageControl2";
    ((Control) this.ultraTabPageControl2).Size = new Size(842, 704);
    ((UltraGridBase) this.gridClaimsAR).DataSource = (object) this.dsclaimsAR1BindingSource;
    ((AppearanceBase) appearance49).BackColor = Color.White;
    ((AppearanceBase) appearance49).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Appearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn42.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn42.Header).VisiblePosition = 0;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 106;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn43.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn43.Header).VisiblePosition = 1;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 103;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn44.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn44.Header).VisiblePosition = 2;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 172;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn45.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance50).TextHAlignAsString = "Left";
    ultraGridColumn45.CellAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn45.Header).Appearance = (AppearanceBase) appearance51;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn45.Header).VisiblePosition = 3;
    ultraGridColumn45.Width = 306;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn46.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Left";
    ultraGridColumn46.CellAppearance = (AppearanceBase) appearance52;
    ((AppearanceBase) appearance53).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn46.Header).Appearance = (AppearanceBase) appearance53;
    ((HeaderBase) ultraGridColumn46.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn46.Header).VisiblePosition = 4;
    ultraGridColumn46.Width = 90;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn47.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ultraGridColumn47.CellAppearance = (AppearanceBase) appearance54;
    ultraGridColumn47.Format = "c";
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn47.Header).Appearance = (AppearanceBase) appearance55;
    ((HeaderBase) ultraGridColumn47.Header).Caption = "Rec. Amount";
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn47.Header).VisiblePosition = 5;
    ultraGridColumn47.Width = 107;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn48.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    ultraGridColumn48.CellAppearance = (AppearanceBase) appearance56;
    ultraGridColumn48.Format = "c";
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn48.Header).Appearance = (AppearanceBase) appearance57;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Amt. Rcvd";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn48.Header).VisiblePosition = 6;
    ultraGridColumn48.Width = 117;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn49.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ultraGridColumn49.CellAppearance = (AppearanceBase) appearance58;
    ultraGridColumn49.Format = "c";
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn49.Header).Appearance = (AppearanceBase) appearance59;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn49.Header).VisiblePosition = 7;
    ultraGridColumn49.Width = 110;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance60).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    ultraGridColumn50.CellAppearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance61).Image = (object) Resources.wrench_orange;
    ultraGridColumn50.CellButtonAppearance = (AppearanceBase) appearance61;
    ultraGridColumn50.DataType = typeof (Decimal);
    ultraGridColumn50.Format = "c";
    ((AppearanceBase) appearance62).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn50.Header).Appearance = (AppearanceBase) appearance62;
    ((HeaderBase) ultraGridColumn50.Header).Caption = "AR Applied";
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn50.Header).VisiblePosition = 8;
    ultraGridColumn50.Style = (ColumnStyle) 2;
    ultraGridColumn50.Width = 110;
    ultraGridBand4.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50
    });
    ((AppearanceBase) appearance63).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance63;
    summarySettings1.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance64).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance64;
    summarySettings2.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance65).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance65;
    summarySettings3.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance66).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance66;
    summarySettings4.DisplayFormat = "{0:c}";
    ultraGridBand4.Summaries.AddRange(new SummarySettings[4]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3,
      summarySettings4
    });
    ultraGridBand4.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance67).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance67).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance67).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance67;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((AppearanceBase) appearance68).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance68;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.FilterUIType = (FilterUIType) 1;
    ((AppearanceBase) appearance69).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance69;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance70).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance70;
    ((AppearanceBase) appearance71).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance71;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance72).BackColor = Color.Transparent;
    ((AppearanceBase) appearance72).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance72;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance73).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance73).BorderColor = Color.Silver;
    scrollBarLook5.ButtonAppearance = (AppearanceBase) appearance73;
    ((AppearanceBase) appearance74).BackColor = Color.White;
    scrollBarLook5.TrackAppearance = (AppearanceBase) appearance74;
    ((UltraGridBase) this.gridClaimsAR).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((Control) this.gridClaimsAR).Dock = DockStyle.Fill;
    ((Control) this.gridClaimsAR).Location = new Point(0, 0);
    ((Control) this.gridClaimsAR).Name = "gridClaimsAR";
    ((Control) this.gridClaimsAR).Size = new Size(842, 704);
    ((Control) this.gridClaimsAR).TabIndex = 1;
    ((UltraControlBase) this.gridClaimsAR).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimsAR).UseOsThemes = (DefaultableBoolean) 2;
    this.gridClaimsAR.InitializeRow += new InitializeRowEventHandler(this.gridClaimsAR_InitializeRow);
    this.dsclaimsAR1BindingSource.DataSource = (object) this.dsclaimsAR1;
    this.dsclaimsAR1BindingSource.Position = 0;
    this.dsclaimsAR1.DataSetName = "dsclaimsAR";
    this.dsclaimsAR1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ultraTabPageControl1).Location = new Point(1, 23);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(840, 718);
    ((Form) this).ClientSize = new Size(1052, 770);
    this.GLCompanyId = -1;
    ((Control) this).Name = nameof (FormClaimsARAP);
    this.pnlContainer.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.comboBankAccount).EndInit();
    ((Control) this.tabPagePayable).ResumeLayout(false);
    ((ISupportInitialize) this.gridPayables).EndInit();
    ((ISupportInitialize) this.toolbar).EndInit();
    ((ISupportInitialize) this.tabTransactions).EndInit();
    ((Control) this.tabTransactions).ResumeLayout(false);
    ((ISupportInitialize) this.comboPaymentMethods).EndInit();
    ((ISupportInitialize) this.dateTimeCheckDate).EndInit();
    ((ISupportInitialize) this.dateTimeReceivedDate).EndInit();
    ((ISupportInitialize) this.dateTimeDepositDate).EndInit();
    ((ISupportInitialize) this.txtPayAmount).EndInit();
    ((ISupportInitialize) this.txtBalance).EndInit();
    ((ISupportInitialize) this.txtCheckNumber).EndInit();
    ((ISupportInitialize) this.txtCheckAmount).EndInit();
    ((ISupportInitialize) this.txtAppliedUnAccounted).EndInit();
    ((ISupportInitialize) this.txtUnAccountedBalance).EndInit();
    ((ISupportInitialize) this.gridReceivables).EndInit();
    ((ISupportInitialize) this.txtEntityName).EndInit();
    this.dsOpenReceivables.EndInit();
    this.dsOpenPayables.EndInit();
    ((ISupportInitialize) this.AdditionalOffsetToolManager).EndInit();
    ((ISupportInitialize) this.btnCancelChanges).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.comboCostCenters).EndInit();
    ((Control) this.tabAdditonalOffsets).ResumeLayout(false);
    ((Control) this.tabAdditonalOffsets).PerformLayout();
    ((ISupportInitialize) this.gridAdditionalOffsets).EndInit();
    ((ISupportInitialize) this.txtPostingMemo).EndInit();
    ((ISupportInitialize) this.comboUnAccountedCostCenter).EndInit();
    ((ISupportInitialize) this.txtCheckFrom).EndInit();
    ((ISupportInitialize) this.checkCreditCard).EndInit();
    ((ISupportInitialize) this.buttonAppliedUnaccounted).EndInit();
    ((ISupportInitialize) this.buttonCancelAppliedUnaccounted).EndInit();
    ((ISupportInitialize) this.gridNonWorkingDeposit).EndInit();
    ((ISupportInitialize) this.checkBankCurrency).EndInit();
    ((Control) this.ultraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridClaimsAR).EndInit();
    ((ISupportInitialize) this.dsclaimsAR1BindingSource).EndInit();
    this.dsclaimsAR1.EndInit();
    ((Control) this).ResumeLayout(false);
  }

  public delegate void AfterPostTransactionHandler(int transactionNumber);

  private delegate void DelegateSetTextSafe(string text);

  private delegate void DelegateSetVisibleSafe(bool visibility);

  protected static class GridColumnKeys
  {
    public static string ClaimId = nameof (ClaimId);
    public static string UAExpenseId = nameof (UAExpenseId);
    public static string ResPayId = nameof (ResPayId);
    public static string ClaimARApplied = nameof (ClaimARApplied);
    public static string Balance = nameof (Balance);
    public static string ClaimNumber = "Claim Number";
    public static string HiddenClaimNumber = nameof (ClaimNumber);
    public static string TransferDate = "Transfer Date";
    public static string ARDate = nameof (ARDate);
  }
}
