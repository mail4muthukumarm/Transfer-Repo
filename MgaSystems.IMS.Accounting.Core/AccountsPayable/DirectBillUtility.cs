// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillUtility
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillUtility
{
  protected int glCompanyId;
  protected DateTime cutOffDate;
  protected bool showProducers;
  protected bool showCompanies;
  protected bool showOthers;
  protected int bankGlAccountNumber;
  protected DateTime checkDate;
  protected Guid _companyGuid;
  protected Guid _companyGroupGuid;
  protected DirectBillInvoiceCollection invoices;
  protected DirectBillPayeeCollection payees;
  protected Thread CreateChecksThread;
  protected UltraGrid UserSelectionsGrid;
  private DataTable _directBillInvoiceTable;

  public DirectBillUtility(int GlCompanyId, DateTime CutOffDate, int BankGlAccountNumber)
  {
    this.glCompanyId = GlCompanyId;
    this.cutOffDate = CutOffDate;
    this.showProducers = true;
    this.showCompanies = false;
    this.showOthers = false;
    this.bankGlAccountNumber = BankGlAccountNumber;
    this.checkDate = DateTime.Now;
    this._companyGuid = Guid.Empty;
    this._companyGroupGuid = Guid.Empty;
  }

  public DirectBillUtility(
    int GlCompanyId,
    DateTime CutOffDate,
    bool ShowProducers,
    bool ShowCompanies,
    bool ShowOthers,
    int BankGlAccountNumber,
    DateTime CheckDate)
  {
    this.glCompanyId = GlCompanyId;
    this.cutOffDate = CutOffDate;
    this.showProducers = ShowProducers;
    this.showOthers = ShowOthers;
    this.showCompanies = ShowCompanies;
    this.bankGlAccountNumber = BankGlAccountNumber;
    this.checkDate = CheckDate;
    this._companyGuid = Guid.Empty;
    this._companyGroupGuid = Guid.Empty;
  }

  public DirectBillUtility(
    int GlCompanyId,
    DateTime CutOffDate,
    bool ShowProducers,
    bool ShowCompanies,
    bool ShowOthers,
    int BankGlAccountNumber,
    DateTime CheckDate,
    Guid companyGuid)
  {
    this.glCompanyId = GlCompanyId;
    this.cutOffDate = CutOffDate;
    this.showProducers = ShowProducers;
    this.showOthers = ShowOthers;
    this.showCompanies = ShowCompanies;
    this.bankGlAccountNumber = BankGlAccountNumber;
    this.checkDate = CheckDate;
    this._companyGuid = companyGuid;
    this._companyGroupGuid = Guid.Empty;
  }

  public DirectBillUtility(
    int GlCompanyId,
    DateTime CutOffDate,
    bool ShowProducers,
    bool ShowCompanies,
    bool ShowOthers,
    int BankGlAccountNumber,
    DateTime CheckDate,
    Guid companyGuid,
    Guid companyGroupGuid)
  {
    this.glCompanyId = GlCompanyId;
    this.cutOffDate = CutOffDate;
    this.showProducers = ShowProducers;
    this.showOthers = ShowOthers;
    this.showCompanies = ShowCompanies;
    this.bankGlAccountNumber = BankGlAccountNumber;
    this.checkDate = CheckDate;
    this._companyGuid = companyGuid;
    this._companyGroupGuid = companyGroupGuid;
  }

  public event DirectBillUtility.CheckCreatedHandler CheckCreated;

  public event DirectBillUtility.CheckCreationCompletedHandler CheckCreationComplete;

  public event DirectBillUtility.CheckCreationErrorHandler CheckCreationError;

  public event DirectBillUtility.CheckCreationInvalidHandler CheckCreationInvalid;

  public event DirectBillUtility.BeforeLoadDirectBillInvoicesHandler BeforeLoadDirectBillInvoices;

  protected void OnCheckCreated(int CheckNumber, string PayeeName, Decimal CheckAmount)
  {
    lock (this)
    {
      if (this.CheckCreated == null)
        return;
      this.CheckCreated((object) this, new DirectBillCheckCreatedEventArgs(CheckNumber, PayeeName, CheckAmount));
    }
  }

  protected void OnCheckCreationComplete()
  {
    lock (this)
    {
      if (this.CheckCreationComplete == null)
        return;
      this.CheckCreationComplete((object) this, new EventArgs());
    }
  }

  protected void OnCheckCreationError()
  {
    if (this.CheckCreationError == null)
      return;
    this.CheckCreationError((object) this, new EventArgs());
  }

  protected void OnCheckInvalid(string Msg)
  {
    if (this.CheckCreationInvalid == null)
      return;
    this.CheckCreationInvalid((object) this, new DirectBillCheckInvalidEventArgs(Msg));
  }

  protected void OnBeforeLoadDirectBillInvoices()
  {
    DirectBillUtility.BeforeLoadDirectBillInvoicesHandler directBillInvoices = this.BeforeLoadDirectBillInvoices;
    if (directBillInvoices == null)
      return;
    directBillInvoices((object) this, new EventArgs());
  }

  public int GlCompanyId => this.glCompanyId;

  public DateTime CutOffDate => this.cutOffDate;

  public DirectBillInvoiceCollection Invoices
  {
    get
    {
      if (this.invoices == null)
        this.invoices = new DirectBillInvoiceCollection();
      return this.invoices;
    }
  }

  public DirectBillPayeeCollection Payees
  {
    get
    {
      if (this.payees == null)
        this.payees = new DirectBillPayeeCollection();
      return this.payees;
    }
  }

  public bool ShowProducers => this.showProducers;

  public bool ShowCompanies => this.showCompanies;

  public bool ShowOthers => this.showOthers;

  public int BankGlAccountNumber => this.bankGlAccountNumber;

  public DateTime CheckDate => this.checkDate;

  public Guid CompanyGuid => this._companyGuid;

  protected DataTable DirectBillInvoiceTable
  {
    get => this._directBillInvoiceTable;
    set => this._directBillInvoiceTable = value;
  }

  public virtual void LoadDirectBillInvoices()
  {
    this.OnBeforeLoadDirectBillInvoices();
    using (DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spFin_DirectBillPayables_GetInvoices", 0, (CommandArgumentType) 0, new object[14]
    {
      (object) "@glcompanyid",
      (object) this.GlCompanyId,
      (object) "@showproducers",
      (object) this.ShowProducers,
      (object) "@showcompanies",
      (object) this.ShowCompanies,
      (object) "@showothers",
      (object) this.ShowOthers,
      (object) "@companyGuid",
      (object) this._companyGuid,
      (object) "@asofdate",
      (object) this.cutOffDate,
      (object) "@companyGroupGuid",
      (object) this._companyGroupGuid
    }))
    {
      if (dataTable == null || dataTable.Rows.Count == 0)
        throw new DirectBillInvoicesNotFoundException(MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager.GetString("DIRECTBILL_INVOICES_NOTFOUND_EXCEPTION"));
      this._directBillInvoiceTable = dataTable;
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
        this.Invoices.Add(new DirectBillInvoice(int.Parse(row["invoicenum"].ToString()), int.Parse(row["officeinvoicenum"].ToString()), new Guid(row["payeeGuid"].ToString()), int.Parse(row["chargecode"].ToString()), new Guid(row["companylineguid"].ToString()), int.Parse(row["entityApAccount"].ToString()), Decimal.Parse(row["grossPayable"].ToString()), row["insuredName"].ToString(), Decimal.Parse(row["proportionalAmountDue"].ToString()), row["payeeName"].ToString()));
    }
  }

  protected void LoadDirectBillInvoices(string procedureName)
  {
    this.OnBeforeLoadDirectBillInvoices();
    using (DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, procedureName, 0, (CommandArgumentType) 0, new object[14]
    {
      (object) "@glcompanyid",
      (object) this.GlCompanyId,
      (object) "@showproducers",
      (object) this.ShowProducers,
      (object) "@showcompanies",
      (object) this.ShowCompanies,
      (object) "@showothers",
      (object) this.ShowOthers,
      (object) "@companyGuid",
      (object) this._companyGuid,
      (object) "@asofdate",
      (object) this.cutOffDate,
      (object) "@companyGroupGuid",
      (object) this._companyGroupGuid
    }))
    {
      if (dataTable == null || dataTable.Rows.Count == 0)
        throw new DirectBillInvoicesNotFoundException(MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager.GetString("DIRECTBILL_INVOICES_NOTFOUND_EXCEPTION"));
      this._directBillInvoiceTable = dataTable;
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
        this.Invoices.Add(new DirectBillInvoice(int.Parse(row["invoicenum"].ToString()), int.Parse(row["officeinvoicenum"].ToString()), new Guid(row["payeeGuid"].ToString()), int.Parse(row["chargecode"].ToString()), new Guid(row["companylineguid"].ToString()), int.Parse(row["entityApAccount"].ToString()), Decimal.Parse(row["grossPayable"].ToString()), row["insuredName"].ToString(), Decimal.Parse(row["proportionalAmountDue"].ToString()), row["payeeName"].ToString()));
    }
  }

  public void CalculateAmountDue()
  {
    foreach (DirectBillInvoice invoice in (CollectionBase) this.Invoices)
      invoice.CalculateProportionalAmountDue();
  }

  public virtual void CreatePayeeCollection()
  {
    foreach (DirectBillInvoice invoice in (CollectionBase) this.Invoices)
    {
      if (!this.Payees.Exists(invoice.PayeeGuid))
        this.Payees.Add(new DirectBillPayee(invoice.PayeeGuid, invoice.PayeeName));
    }
  }

  public virtual DataSet CreateDisplaySet()
  {
    dsDirectBillPayables displaySet = new dsDirectBillPayables();
    foreach (DirectBillPayee payee in (CollectionBase) this.Payees)
      displaySet.Payees.AddPayeesRow(payee.PayeeGuid.ToString(), payee.PayeeName, this.Invoices.GetPayeeTotalGrossPayable(payee.PayeeGuid), this.Invoices.GetPayeeTotalProportionalAmount(payee.PayeeGuid), true);
    foreach (DirectBillInvoice invoice in (CollectionBase) this.invoices)
    {
      dsDirectBillPayables.InvoicesDataTable invoices = displaySet.Invoices;
      dsDirectBillPayables.PayeesDataTable payees = displaySet.Payees;
      Guid guid = invoice.PayeeGuid;
      string PayeeGuid = guid.ToString();
      dsDirectBillPayables.PayeesRow byPayeeGuid = payees.FindByPayeeGuid(PayeeGuid);
      int invoiceNum = invoice.InvoiceNum;
      int officeInvoiceNum = invoice.OfficeInvoiceNum;
      Decimal grossPayable = invoice.GrossPayable;
      Decimal proportionalAmountDue = invoice.ProportionalAmountDue;
      string insuredName = invoice.InsuredName;
      guid = invoice.CompanyLineGuid;
      string CompanyLineGuid = guid.ToString();
      int chargeCode = invoice.ChargeCode;
      int payeeApAccount = invoice.PayeeAPAccount;
      invoices.AddInvoicesRow(byPayeeGuid, invoiceNum, officeInvoiceNum, grossPayable, proportionalAmountDue, insuredName, CompanyLineGuid, chargeCode, payeeApAccount);
    }
    return (DataSet) displaySet;
  }

  public void CreateChecks(UltraGrid Grid)
  {
    this.UserSelectionsGrid = Grid;
    new Thread((ThreadStart) (() => this.DoCreateChecks(string.Empty))).Start();
  }

  public void CreateChecks(UltraGrid grid, string checkMemo)
  {
    this.UserSelectionsGrid = grid;
    new Thread((ThreadStart) (() => this.DoCreateChecks(checkMemo))).Start();
  }

  protected virtual void DoCreateChecks() => this.DoCreateChecks(string.Empty);

  protected virtual void DoCreateChecks(string checkMemo)
  {
    using (SqlCommand cmd = new SqlCommand())
    {
      cmd.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
      cmd.Connection.Open();
      try
      {
        UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.UserSelectionsGrid).Rows.GetFilteredInNonGroupByRows();
        for (int index = 0; index < inNonGroupByRows.Length; ++index)
        {
          Decimal num = 0.0M;
          if (((GridItemBase) inNonGroupByRows[index]).Band.Index == 0 && (inNonGroupByRows[index].Cells["SelectPayee"].Value == null || inNonGroupByRows[index].Cells["SelectPayee"].Value == DBNull.Value || bool.Parse(inNonGroupByRows[index].Cells["SelectPayee"].Value.ToString())))
          {
            PayableTransaction payableTransaction = new PayableTransaction(CurrentUser.Instance.UserGUID);
            payableTransaction.CheckDate = this.CheckDate;
            bool flag = (bool) inNonGroupByRows[index].Cells["CreateCheck"].Value;
            foreach (UltraGridRow row in inNonGroupByRows[index].ChildBands[0].Rows)
            {
              if (Convert.ToBoolean(row.Cells["SelectInvoice"].Value))
              {
                Decimal transactionAmount = Decimal.Parse(row.Cells["ProportionalAmount"].Value.ToString());
                num += transactionAmount;
                TransactionDetail transactionDetail1 = new TransactionDetail(int.Parse(row.Cells["invoicenum"].Value.ToString()), int.Parse(row.Cells["chargecode"].Value.ToString()), -1, -1, -1, -1, new GLAccount(int.Parse(row.Cells["EntityAPAccount"].Value.ToString()), cmd), new Guid(row.Cells["CompanyLineGuid"].Value.ToString()), new Guid(row.ParentRow.Cells["PayeeGuid"].Value.ToString()), transactionAmount, new Guid(row.ParentRow.Cells["PayeeGuid"].Value.ToString()), new CostCenterAllocationCollection());
                transactionDetail1.CostCenterAllocations.Add(new CostCenterAllocation(Utility.GetInvoiceCostCenterId(transactionDetail1.InvoiceNumber), transactionDetail1.Amount), transactionDetail1.TransactionTotal);
                payableTransaction.Debits.Add(transactionDetail1);
                TransactionDetail transactionDetail2 = new TransactionDetail(int.Parse(row.Cells["invoicenum"].Value.ToString()), int.Parse(row.Cells["chargecode"].Value.ToString()), -1, -1, -1, -1, new GLAccount(this.BankGlAccountNumber, cmd), new Guid(row.Cells["CompanyLineGuid"].Value.ToString()), new Guid(row.ParentRow.Cells["PayeeGuid"].Value.ToString()), transactionAmount, new Guid(row.ParentRow.Cells["PayeeGuid"].Value.ToString()), new CostCenterAllocationCollection());
                transactionDetail2.CostCenterAllocations.Add(new CostCenterAllocation(Utility.GetInvoiceCostCenterId(transactionDetail2.InvoiceNumber), transactionDetail2.Amount), transactionDetail2.TransactionTotal);
                payableTransaction.Credits.Add(transactionDetail2);
              }
            }
            if (cmd.Transaction == null)
              cmd.Transaction = cmd.Connection.BeginTransaction();
            if (num < 0M)
              this.OnCheckInvalid($"* The check for {inNonGroupByRows[index].Cells["payeeName"].Value.ToString()} could not be created. This would result in a negative check in the amount of {num.ToString("c")}");
            else if (num == 0M)
            {
              this.OnCheckInvalid($"* The check for {inNonGroupByRows[index].Cells["payeeName"].Value.ToString()} could not be created. This would result in a zero check");
            }
            else
            {
              if (flag)
                payableTransaction.CheckData = new CheckInformation(Utility.PaymentMethod.Check, new Guid(inNonGroupByRows[index].Cells["payeeguid"].Value.ToString()), this.CheckDate, new GLAccount(this.BankGlAccountNumber, cmd), string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, checkMemo);
              else
                payableTransaction.CheckData = new CheckInformation(Utility.PaymentMethod.Offset, new Guid(inNonGroupByRows[index].Cells["payeeguid"].Value.ToString()), this.CheckDate, new GLAccount(this.BankGlAccountNumber, cmd));
              this.OnCheckCreated(payableTransaction.Save(cmd, this.GlCompanyId), inNonGroupByRows[index].Cells["payeeName"].Value.ToString(), payableTransaction.Debits.TransactionsTotal());
            }
          }
        }
        if (cmd.Transaction != null)
          cmd.Transaction.Commit();
        this.OnCheckCreationComplete();
      }
      catch
      {
        if (cmd.Transaction != null)
          cmd.Transaction.Rollback();
        this.OnCheckCreationError();
        throw;
      }
    }
  }

  public delegate void CheckCreatedHandler(object sender, DirectBillCheckCreatedEventArgs e);

  public delegate void CheckCreationCompletedHandler(object sender, EventArgs e);

  public delegate void CheckCreationErrorHandler(object sender, EventArgs e);

  public delegate void CheckCreationInvalidHandler(object sender, DirectBillCheckInvalidEventArgs e);

  public delegate void BeforeLoadDirectBillInvoicesHandler(object sender, EventArgs e);
}
