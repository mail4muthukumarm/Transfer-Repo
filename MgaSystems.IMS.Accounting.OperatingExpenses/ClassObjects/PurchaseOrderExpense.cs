// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.PurchaseOrderExpense
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class PurchaseOrderExpense : Component, IDisposable
{
  private int poNumber;
  private Guid payeeGuid;
  private DateTime poDate;
  private DateTime receivedDate;
  private DateTime paymentDueDate;
  private string paymentTerms;
  private string payeeInvoiceNumber;
  private Guid userGuid;
  private string poComments;
  private bool isPosted;
  private DateTime postDate;
  private Guid requesterGuid;
  private PurchaseOrderExpense.PoExpenseType poType;
  private bool isFailed;
  private int glCompanyId;
  private int bankGlAccountId;
  private Utilities.PurchaseOrderPaymentType paymentType;
  private PurchaseOrderExpenseDetailCollection expenseDetails;
  private ExpenseSchedule schedule;
  private CheckInformation checkData;
  private bool prepaid;
  private bool prepaidReconciled;
  private int glOffset;

  public PurchaseOrderExpense()
  {
    this.isFailed = false;
    this.isPosted = false;
    this.userGuid = CurrentUser.Instance.UserGUID;
    this.paymentType = Utilities.PurchaseOrderPaymentType.PayNow;
  }

  public PurchaseOrderExpense(int PurchaseOrderId)
  {
    this.poNumber = PurchaseOrderId;
    this.userGuid = CurrentUser.Instance.UserGUID;
    this.paymentType = Utilities.PurchaseOrderPaymentType.PayNow;
  }

  public int PoNumber => this.poNumber;

  public Guid PayeeGuid
  {
    get => this.payeeGuid;
    set => this.payeeGuid = value;
  }

  public DateTime PurchaseOrderDate
  {
    get => this.poDate;
    set => this.poDate = value;
  }

  public DateTime ReceivedDate
  {
    get => this.receivedDate;
    set => this.receivedDate = value;
  }

  public DateTime PaymentDueDate
  {
    get => this.paymentDueDate;
    set => this.paymentDueDate = value;
  }

  public string PaymentTerms
  {
    get => this.paymentTerms;
    set => this.paymentTerms = value;
  }

  public string PayeeInvoiceNumber
  {
    get => this.payeeInvoiceNumber;
    set => this.payeeInvoiceNumber = value;
  }

  public Guid UserGuid => this.userGuid;

  public string PurchaseOrderComments
  {
    get => this.poComments;
    set => this.poComments = value;
  }

  public bool IsPosted => this.isPosted;

  public DateTime PostDate
  {
    get => this.postDate;
    set => this.postDate = value;
  }

  public Guid RequesterGuid
  {
    get => this.requesterGuid;
    set => this.requesterGuid = value;
  }

  public PurchaseOrderExpense.PoExpenseType PoType
  {
    get => this.poType;
    set => this.poType = value;
  }

  public bool IsFailed => this.isFailed;

  public int GlCompanyId
  {
    get => this.glCompanyId;
    set => this.glCompanyId = value;
  }

  [Bindable(true)]
  public PurchaseOrderExpenseDetailCollection ExpenseDetails
  {
    get
    {
      if (this.expenseDetails == null)
      {
        this.expenseDetails = new PurchaseOrderExpenseDetailCollection();
        this.expenseDetails.ListChanged += new ListChangedEventHandler(this.ExpenseDetailsCollection_ListChanged);
      }
      return this.expenseDetails;
    }
  }

  public int BankGlAccountId
  {
    get => this.bankGlAccountId;
    set => this.bankGlAccountId = value;
  }

  public Utilities.PurchaseOrderPaymentType PaymentType
  {
    get => this.paymentType;
    set => this.paymentType = value;
  }

  public string PayeeName
  {
    get
    {
      return this.payeeGuid.Equals(Guid.Empty) ? MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("EmptyString") : Database.Instance.QueryText.PerformScalarQueryString($"select dbo.GetEntityName('{this.payeeGuid.ToString()}')");
    }
  }

  public ExpenseSchedule Schedule
  {
    get => this.schedule;
    set => this.schedule = value;
  }

  public CheckInformation CheckData
  {
    get => this.checkData == null ? (CheckInformation) null : this.checkData;
    set => this.checkData = value;
  }

  public bool Prepaid
  {
    get => this.prepaid;
    set => this.prepaid = value;
  }

  public bool PrepaidReconciled
  {
    get => this.prepaidReconciled;
    set => this.prepaidReconciled = value;
  }

  public int GlOffset
  {
    get => this.glOffset;
    set => this.glOffset = value;
  }

  public PurchaseOrderExpenseDetail CreateNewDetailItem(int ExpenseCode)
  {
    return new PurchaseOrderExpenseDetail(ExpenseCode, this.glCompanyId, this);
  }

  public PurchaseOrderExpenseDetail CreateNewDetailItem(
    int ExpenseCode,
    Decimal ExpenseAmount,
    Decimal DiscountAmount,
    bool IsDiscountPercentage,
    DateTime ExpenseDate,
    Guid ExpenseFor,
    int GlAccountId)
  {
    return new PurchaseOrderExpenseDetail(ExpenseCode, ExpenseAmount, DiscountAmount, IsDiscountPercentage, ExpenseDate, ExpenseFor, GlAccountId, this);
  }

  private void Validate()
  {
    if (this.payeeGuid.Equals(Guid.Empty))
      throw new PurchaseOrderValidationFailedException(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("PAYEEGUID_NOTSET_EXCEPTION"));
    if (this.expenseDetails.Count == 0)
      throw new PurchaseOrderValidationFailedException(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("NO_EXPENSES_DEFINED"));
    foreach (PurchaseOrderExpenseDetail expenseDetail in (CollectionBase) this.expenseDetails)
    {
      if (expenseDetail.State != PurchaseOrderExpenseDetail.DetailObjectState.Complete)
        throw new PurchaseOrderValidationFailedException(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("EXPENSE_DETAILS_OBJECTS_INCOMPLETE"));
    }
  }

  public Decimal GetExpenseTotal()
  {
    Decimal expenseTotal = 0M;
    foreach (PurchaseOrderExpenseDetail expenseDetail in (CollectionBase) this.ExpenseDetails)
      expenseTotal += expenseDetail.ExpenseTotal;
    return expenseTotal;
  }

  protected virtual void OnExpenseDetailsChanged()
  {
    if (this.ExpenseDetailsChanged == null)
      return;
    this.ExpenseDetailsChanged((object) this, new EventArgs());
  }

  public event PurchaseOrderExpense.ExpenseDetailsChangedHandler ExpenseDetailsChanged;

  private void ExpenseDetailsCollection_ListChanged(object sender, ListChangedEventArgs e)
  {
    this.OnExpenseDetailsChanged();
  }

  public void Save()
  {
    if (this.PoNumber != 0)
      return;
    using (SqlCommand cmd = new SqlCommand("spFin_InsertPO", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      try
      {
        cmd.Connection.Open();
        cmd.Transaction = cmd.Connection.BeginTransaction();
        this.SaveNew(cmd);
        foreach (AccountingTransaction transaction in (CollectionBase) OperatingExpenseServices.CreateTransactionSet(this))
          transaction.Save(cmd);
        cmd.Transaction.Commit();
        CurrentUser.Instance.LogAction($"Added purchase order/expense #{this.PoNumber}", "Accounting Logs");
      }
      catch (ExpenseAutomationAccountNotFound ex)
      {
        if (cmd.Transaction != null)
          cmd.Transaction.Rollback();
        int num = (int) MessageBox.Show(ex.Message, "Required Setting Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      catch (Exception ex)
      {
        if (cmd.Transaction != null)
          cmd.Transaction.Rollback();
        throw ex;
      }
    }
  }

  private void SaveNew(SqlCommand cmd)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.AddWithValue("@PONUM", (object) SqlDbType.Int);
    cmd.Parameters["@PONUM"].Direction = ParameterDirection.Output;
    cmd.Parameters.AddWithValue("@PODATE", (object) this.PurchaseOrderDate);
    cmd.Parameters.AddWithValue("@RECEIVEDDATE", (object) this.ReceivedDate);
    cmd.Parameters.AddWithValue("@PAYMENTDUEDATE", (object) this.PaymentDueDate);
    cmd.Parameters.AddWithValue("@PAYMENTTERMS", (object) this.PaymentTerms);
    cmd.Parameters.AddWithValue("@PAYEEINVNUM", (object) this.PayeeInvoiceNumber);
    cmd.Parameters.AddWithValue("@USERGUID", (object) this.UserGuid);
    cmd.Parameters.AddWithValue("@PAYEEGUID", (object) this.PayeeGuid);
    cmd.Parameters.AddWithValue("@COMMENTS", (object) this.PurchaseOrderComments);
    cmd.Parameters.AddWithValue("@GLCOMPANYID", (object) this.GlCompanyId);
    cmd.Parameters.AddWithValue("@POTYPE", this.PoType == PurchaseOrderExpense.PoExpenseType.PurchaseOrder ? (object) "P" : (object) "X");
    cmd.Parameters.AddWithValue("@PREPAID", (object) this.Prepaid);
    cmd.ExecuteNonQuery();
    this.poNumber = int.Parse(cmd.Parameters["@PONUM"].Value.ToString());
    foreach (PurchaseOrderExpenseDetail expenseDetail in (CollectionBase) this.ExpenseDetails)
      expenseDetail.Save(cmd, this.PoNumber);
    if (this.Schedule == null)
      return;
    this.Schedule.SaveSchedule(this.PoNumber, cmd);
  }

  private void UpdateExisting()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public delegate void ExpenseDetailsChangedHandler(object sender, EventArgs e);

  public enum PoExpenseType
  {
    PurchaseOrder,
    Expense,
  }
}
