// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.InsuranceTransaction
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountsReceivable;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class InsuranceTransaction : AccountingTransaction
{
  private bool _isReturnPremium;
  private bool _isCreditCard;
  private Guid _remitterGuid = Guid.Empty;
  private Guid _payeeGuid = Guid.Empty;
  private Guid _receivedFromGuid = Guid.Empty;
  private DateTime _receivedDate = DateTime.MinValue;
  private DateTime _depositDate = DateTime.MinValue;
  private DateTime _checkDate = DateTime.MinValue;
  private string _checkNumber;
  private Utility.PaymentMethod _payMethod;
  private char _paymentMethodChar;
  private Decimal _checkAmount;
  private readonly char _offset = 'O';
  private readonly char _eft = 'E';
  private readonly char _ach = 'H';
  internal FinancedReturnCollection financedReceivables;
  private ArrayList transactionsCreated;

  public InsuranceTransaction()
  {
  }

  public InsuranceTransaction(Guid UserGuid, Utility.AccountingTransactionType TransactionType)
    : base(UserGuid, TransactionType)
  {
  }

  public InsuranceTransaction(
    Guid UserGuid,
    Utility.AccountingTransactionType TransactionType,
    int glCompanyId)
    : base(UserGuid, TransactionType, glCompanyId)
  {
  }

  public string BulkAPPostTableName { get; set; }

  public char PaymentMethodChar
  {
    get => this._paymentMethodChar;
    set => this._paymentMethodChar = value;
  }

  public bool IsCreditCard
  {
    get => this._isCreditCard;
    set => this._isCreditCard = value;
  }

  public bool IsReturnPremium
  {
    get => this._isReturnPremium;
    set => this._isReturnPremium = value;
  }

  public Guid RemitterGuid
  {
    get => this._remitterGuid;
    set => this._remitterGuid = value;
  }

  public Guid PayeeGuid
  {
    get => this._payeeGuid;
    set => this._payeeGuid = value;
  }

  public Guid ReceivedFromGuid
  {
    get => this._receivedFromGuid;
    set => this._receivedFromGuid = value;
  }

  public DateTime ReceivedDate
  {
    get => this._receivedDate;
    set => this._receivedDate = value;
  }

  public DateTime DepositDate
  {
    get => this._depositDate;
    set => this._depositDate = value;
  }

  public DateTime CheckDate
  {
    get => this._checkDate;
    set => this._checkDate = value;
  }

  public string CheckNumber
  {
    get => this._checkNumber;
    set => this._checkNumber = value;
  }

  public Decimal CheckAmount
  {
    get => this._checkAmount;
    set => this._checkAmount = value;
  }

  public Utility.PaymentMethod PayMethod
  {
    get => this._payMethod;
    set => this._payMethod = value;
  }

  public int BankGLAccountId { get; set; }

  public FinancedReturnCollection FinancedReceivables
  {
    get
    {
      if (this.financedReceivables == null)
        this.financedReceivables = new FinancedReturnCollection();
      return this.financedReceivables;
    }
    set => this.financedReceivables = value;
  }

  public ArrayList TransactionsCreated
  {
    get
    {
      if (this.transactionsCreated == null)
        this.transactionsCreated = new ArrayList();
      return this.transactionsCreated;
    }
  }

  protected Decimal DebitSum()
  {
    if (this.Debits.Count == 0)
      return 0M;
    Decimal num = 0M;
    foreach (TransactionDetail debit in (CollectionBase) this.Debits)
      num += debit.Amount;
    return num;
  }

  protected Decimal CreditSum()
  {
    if (this.Credits.Count == 0)
      return 0M;
    Decimal num = 0M;
    foreach (TransactionDetail credit in (CollectionBase) this.Credits)
      num += credit.Amount;
    return num;
  }

  protected bool VerifyTransaction()
  {
    if (this.GlCompanyId == 0)
      throw new GLCompanyMissingException("You must specify a GL Company ID.");
    if (!this.HasClaims)
    {
      if (this.Debits.Count == 0 && this.FinancedReceivables.Count == 0)
        throw new TransactionDetailCollectionEmptyException("There are no debits in the collection.");
      if (this.Credits.Count == 0 && this.FinancedReceivables.Count == 0)
        throw new TransactionDetailCollectionEmptyException("There are no credits in the collection.");
    }
    if (Math.Abs(this.Credits.TransactionsTotal()) != Math.Abs(this.Debits.TransactionsTotal()))
    {
      Decimal num = this.Debits.TransactionsTotal();
      string str1 = num.ToString("c");
      num = this.Credits.TransactionsTotal();
      string str2 = num.ToString("c");
      throw new TransactionOutOfBalanceException($"The debits and credits are out of balance. The debits = {str1} and the credits = {str2}.");
    }
    if (this.TransactionType == Utility.AccountingTransactionType.None)
      throw new TransactionTypeNotSetException("The transaction type has not been set.");
    if (this.TransactionType == Utility.AccountingTransactionType.Receivable || this.TransactionType == Utility.AccountingTransactionType.PayableReturnPremium)
    {
      if (this.RemitterGuid.Equals(Guid.Empty))
        throw new EntityNotDefinedException("No RemitterGUID specified for this remittance transaction.");
      if (this.CheckNumber == string.Empty)
        throw new CheckNumberNotDefinedException("No check number has been specified for this remittance transaction.");
      if (this.DepositDate.Equals(DateTime.MinValue))
        throw new DepositDateNotDefinedException("No deposit date has been defined for the remitance transacation");
      if (this.ReceivedDate.Equals(DateTime.MinValue))
        throw new ReceivedDateNotDefinedException("No received date has been defined for the remitance transacation");
    }
    if (this.TransactionType == Utility.AccountingTransactionType.Payable || this.TransactionType == Utility.AccountingTransactionType.ReceivableReturnPremium)
    {
      if (this.PayeeGuid.Equals(Guid.Empty))
        throw new EntityNotDefinedException("No PayeeGUID specified for this payable transaction.");
      if (this.PayMethod == Utility.PaymentMethod.None && this.PaymentMethodChar == char.MinValue)
        throw new PaymentMethodNotSupportedException("You have not selected a valid payment method.");
      if (this.PayMethod != Utility.PaymentMethod.Offset && (int) this.PaymentMethodChar != (int) this._offset && this.CheckAmount == 0M)
        throw new ZeroCheckException("You can not create a check with a zero payment amount. Please select offset to create a zero payables transaction.");
      if ((this.PayMethod != Utility.PaymentMethod.Offset && (int) this.PaymentMethodChar != (int) this._offset || this.PayMethod != Utility.PaymentMethod.AutoEFT && (int) this.PaymentMethodChar != (int) this._eft || this.PayMethod != Utility.PaymentMethod.ACH && (int) this.PaymentMethodChar != (int) this._ach) && this.CheckData == null)
        throw new CheckInformationMissingException("You must supply a check information object when specifying a payment method other than offset.");
    }
    return true;
  }

  public override void Save()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand cmd = new SqlCommand("", connection))
      {
        cmd.CommandTimeout = 0;
        try
        {
          if (!this.VerifyTransaction())
            return;
          cmd.Connection.Open();
          cmd.Transaction = cmd.Connection.BeginTransaction();
          if (this.FinancedReceivables.HasSelectedReturns())
          {
            foreach (FinancedReturn financedReceivable in (CollectionBase) this.FinancedReceivables)
            {
              if (financedReceivable.HasSelectedDetails())
                this.TransactionsCreated.Add((object) financedReceivable.Save(cmd, this.TransactionNumber, this.CheckData.CheckMemo, financedReceivable.FinanceCompanyGuid, this.CheckData.BankGlAccount.GLAccountID, this.PaymentMethodChar));
            }
          }
          this.SaveHeader(cmd);
          if (!string.IsNullOrEmpty(this.BulkAPPostTableName))
          {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DROP TABLE {this.BulkAPPostTableName}";
            cmd.Parameters.Clear();
            cmd.ExecuteNonQuery();
          }
          cmd.Transaction.Commit();
          CurrentUser.Instance.LogAction($"Posted transaction #{this.TransactionNumber}", "Accounting Logs");
          if (this.TransactionType != Utility.AccountingTransactionType.Receivable)
            return;
          Guid empty = Guid.Empty;
          List<Guid> guidList = new List<Guid>();
          Messaging.SendBroadcastMessage(Utility.ReceivablePosted, (object) this.Debits.PostedInvoiceList().ToArray(typeof (int)));
          for (int index = 0; index < this.Debits.PostedInvoiceList().Count; ++index)
          {
            Guid context = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "Select dbo.GetQuoteGuidFromInvoiceNumber(@invoiceNumber)", new object[2]
            {
              (object) "@invoiceNumber",
              this.Debits.PostedInvoiceList()[index]
            });
            if (!guidList.Contains(context))
            {
              Messaging.SendBroadcastMessage(Utility.RemittancePosted, (object) context);
              guidList.Add(context);
            }
          }
        }
        catch (Exception ex)
        {
          if (cmd != null && cmd.Transaction != null)
            cmd.Transaction.Rollback();
          this.transactionsCreated = (ArrayList) null;
          throw ex;
        }
      }
    }
  }

  public override void Save(SqlCommand cmd)
  {
    cmd.CommandTimeout = 300;
    try
    {
      if (!this.VerifyTransaction())
        return;
      try
      {
        this.SaveHeader(cmd);
      }
      catch (Exception ex)
      {
        throw ex;
      }
      finally
      {
        if (!string.IsNullOrEmpty(this.BulkAPPostTableName))
        {
          cmd.CommandType = CommandType.Text;
          cmd.CommandText = $"DROP TABLE {this.BulkAPPostTableName}";
          cmd.Parameters.Clear();
          cmd.ExecuteNonQuery();
        }
      }
      if (this.FinancedReceivables.HasSelectedReturns())
      {
        foreach (FinancedReturn financedReceivable in (CollectionBase) this.FinancedReceivables)
        {
          if (financedReceivable.HasSelectedDetails())
            this.TransactionsCreated.Add((object) financedReceivable.Save(cmd, this.TransactionNumber, this.CheckData.CheckMemo, financedReceivable.FinanceCompanyGuid, this.CheckData.BankGlAccount.GLAccountID, this.PaymentMethodChar));
        }
      }
      if (this.TransactionType != Utility.AccountingTransactionType.Receivable)
        return;
      Messaging.SendBroadcastMessage(Utility.RemittancePosted, (object) this.Debits.PostedInvoiceList().ToArray(typeof (int)));
    }
    catch (Exception ex)
    {
      this.transactionsCreated = (ArrayList) null;
      throw;
    }
  }

  private void SaveHeader(SqlCommand cmd)
  {
    if (this.Debits.Count == 0 && this.Credits.Count == 0 && !this.HasClaims && this.NumberOfClaimsReceived == 0)
      return;
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "dbo.spFin_PostJournalHeader";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@postdate", (object) this.PostDate);
    cmd.Parameters.AddWithValue("@journalentrytype", (object) "I");
    cmd.Parameters.AddWithValue("@comments", (object) this.TransactionComments);
    cmd.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
    cmd.Parameters.AddWithValue("@glCompanyId", (object) this.GlCompanyId);
    switch (this.TransactionType)
    {
      case Utility.AccountingTransactionType.Payable:
        cmd.Parameters.AddWithValue("@transdescid", (object) "D");
        break;
      case Utility.AccountingTransactionType.PayableReturnPremium:
        cmd.Parameters.AddWithValue("@transdescid", (object) "F");
        break;
      case Utility.AccountingTransactionType.Receivable:
        cmd.Parameters.AddWithValue("@transdescid", (object) "R");
        break;
      case Utility.AccountingTransactionType.ReceivableReturnPremium:
        cmd.Parameters.AddWithValue("@transdescid", (object) "B");
        break;
    }
    if ((!(this.DebitSum() != 0M) || !(this.CreditSum() != 0M)) && (!this.HasClaims || this.NumberOfClaimsReceived <= 0))
      return;
    this.TransNumber = int.Parse(cmd.ExecuteScalar().ToString());
    if (this.Debits.Count != 0 && this.Credits.Count != 0 || this.HasClaims)
      this.TransactionsCreated.Add((object) this.TransactionNumber);
    if (string.IsNullOrEmpty(this.BulkAPPostTableName))
    {
      this.SaveDebits(cmd, this.TransactionNumber);
      this.SaveCredits(cmd, this.TransactionNumber);
    }
    else
    {
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.CommandText = "dbo.spFin_PostAPBulk";
      cmd.Parameters.Clear();
      cmd.Parameters.AddWithValue("@tableName", (object) this.BulkAPPostTableName);
      cmd.Parameters.AddWithValue("@transactnum", (object) this.TransactionNumber);
      cmd.Parameters.AddWithValue("@bankgl", (object) this.BankGLAccountId);
      cmd.ExecuteNonQuery();
      this.SaveNonInvoiceDebits(cmd, this.TransactionNumber);
      this.SaveNonInvoiceCredits(cmd, this.TransactionNumber);
    }
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_ExecutePropIncome";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) this.TransactionNumber);
    cmd.Parameters.AddWithValue("@rollupto", this.TransactionType == Utility.AccountingTransactionType.Payable || this.TransactionType == Utility.AccountingTransactionType.PayableReturnPremium ? (object) "A/P" : (object) "A/R");
    cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GlCompanyId);
    cmd.ExecuteNonQuery();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_PostCommissionableFees";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) this.TransactionNumber);
    cmd.Parameters.AddWithValue("@transtype", this.TransactionType == Utility.AccountingTransactionType.Payable || this.TransactionType == Utility.AccountingTransactionType.PayableReturnPremium ? (object) "AP" : (object) "AR");
    cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GlCompanyId);
    cmd.ExecuteNonQuery();
    if (this.Debits.Count != 0 && this.Credits.Count != 0 || this.HasClaims || this.NumberOfClaimsReceived != 0)
    {
      switch (this.TransactionType)
      {
        case Utility.AccountingTransactionType.Payable:
        case Utility.AccountingTransactionType.ReceivableReturnPremium:
          this.CreateCheckPosting(cmd, this.TransactionNumber, this.CheckData);
          break;
        case Utility.AccountingTransactionType.PayableReturnPremium:
        case Utility.AccountingTransactionType.Receivable:
          this.SaveRemittanceEntry(cmd, this.TransactionNumber);
          break;
      }
    }
    cmd.CommandType = CommandType.Text;
    cmd.CommandText = $"Select dbo.CheckDistributionBalance({this.TransactionNumber})";
    cmd.Parameters.Clear();
    if (int.Parse(cmd.ExecuteScalar().ToString()) != 1)
      throw new TransactionOutOfBalanceException("An error has occurred while trying to post this receivables transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.");
  }

  [Obsolete("This method is deprecated, please use the method that does not require the SqlCommand object instead.")]
  private void SaveRemittanceEntry(SqlCommand cmd, int transactionNumber)
  {
    cmd.CommandText = "spFin_InsertRemitterJournal";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactNum", (object) transactionNumber);
    cmd.Parameters.AddWithValue("@receivedDate", (object) this.ReceivedDate);
    cmd.Parameters.AddWithValue("@depositDate", (object) this.DepositDate);
    cmd.Parameters.AddWithValue("@checkNumber", (object) this.CheckNumber);
    cmd.Parameters.AddWithValue("@remitterGuid", (object) this.RemitterGuid);
    cmd.Parameters.AddWithValue("@amount", (object) this.CheckAmount);
    cmd.Parameters.AddWithValue("@comments", (object) this.TransactionComments);
    cmd.Parameters.AddWithValue("@isCreditCard", (object) this.IsCreditCard);
    if (!this.ReceivedFromGuid.Equals(Guid.Empty))
      cmd.Parameters.AddWithValue("@remittedFrom", (object) this.ReceivedFromGuid);
    cmd.ExecuteNonQuery();
  }

  private void SaveRemittanceEntry(int transactionNumber)
  {
    List<object> objectList = new List<object>()
    {
      (object) "@transactNum",
      (object) transactionNumber,
      (object) "@receivedDate",
      (object) this.ReceivedDate,
      (object) "@depositDate",
      (object) this.DepositDate,
      (object) "@checkNumber",
      (object) this.CheckNumber,
      (object) "@remitterGuid",
      (object) this.RemitterGuid,
      (object) "@amount",
      (object) this.CheckAmount,
      (object) "@comments",
      (object) this.TransactionComments,
      (object) "@isCreditCard",
      (object) this.IsCreditCard
    };
    if (this.ReceivedFromGuid != Guid.Empty)
    {
      objectList.Add((object) "@remittedFrom");
      objectList.Add((object) this.ReceivedFromGuid);
    }
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_InsertRemitterJournal", 300, (CommandArgumentType) 0, objectList.ToArray());
  }

  protected virtual void SaveDebits(SqlCommand cmd, int transactionNumber)
  {
    foreach (TransactionDetail debit in (CollectionBase) this.Debits)
    {
      if (!(debit.Amount == 0M))
      {
        cmd.Parameters.Clear();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spfin_PostJournalDetail";
        cmd.Parameters.AddWithValue("@transactnum", (object) transactionNumber);
        cmd.Parameters.AddWithValue("@glacctid", (object) (debit.GLAccount == null ? debit.GLAccountId : debit.GLAccount.GLAccountID));
        Guid guid;
        if (debit.InvoiceNumber == 0 && debit.ChargeCode == 0)
        {
          guid = debit.CompanyLineGuid;
          if (guid.Equals(Guid.Empty))
          {
            cmd.Parameters.AddWithValue("@sourcedoctype", (object) "J");
            goto label_7;
          }
        }
        cmd.Parameters.AddWithValue("@sourcedoctype", this.IsReturnPremium ? (object) "N" : (object) "I");
label_7:
        if (debit.InvoiceNumber != 0)
          cmd.Parameters.AddWithValue("@invoicenum", (object) debit.InvoiceNumber);
        if (debit.ChargeCode != 0)
          cmd.Parameters.AddWithValue("@chargeCode", (object) debit.ChargeCode);
        guid = debit.CompanyLineGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@companylineguid", (object) debit.CompanyLineGuid);
        cmd.Parameters.AddWithValue("@amount", (object) debit.Amount);
        guid = debit.PayeeGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@payeeguid", (object) debit.PayeeGuid);
        if (debit.AppliedFrom > 0)
          cmd.Parameters.AddWithValue("@appliedFrom", (object) debit.AppliedFrom);
        if (debit.Comments != null && !debit.Equals((object) string.Empty))
          cmd.Parameters.AddWithValue("@comment", (object) debit.Comments);
        SqlParameterCollection parameters = cmd.Parameters;
        guid = debit.EntityGuid;
        // ISSUE: variable of a boxed type
        __Boxed<SqlGuid> local = (System.ValueType) (guid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) debit.EntityGuid);
        parameters.AddWithValue("@entityGuid", (object) local);
        int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
        if (debit != null && debit.CostCenterAllocations != null)
        {
          foreach (CostCenterAllocation centerAllocation in (CollectionBase) debit.CostCenterAllocations)
            centerAllocation.Save(cmd, PostingNumber, false);
        }
      }
    }
  }

  protected virtual void SaveNonInvoiceDebits(SqlCommand cmd, int transactionNumber)
  {
    foreach (TransactionDetail transactionDetail in this.Debits.Where<TransactionDetail>((System.Func<TransactionDetail, bool>) (debit => debit.InvoiceNumber == 0)))
    {
      if (!(transactionDetail.Amount == 0M))
      {
        cmd.Parameters.Clear();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spfin_PostJournalDetail";
        cmd.Parameters.AddWithValue("@transactnum", (object) transactionNumber);
        cmd.Parameters.AddWithValue("@glacctid", (object) (transactionDetail.GLAccount == null ? transactionDetail.GLAccountId : transactionDetail.GLAccount.GLAccountID));
        Guid guid;
        if (transactionDetail.InvoiceNumber == 0 && transactionDetail.ChargeCode == 0)
        {
          guid = transactionDetail.CompanyLineGuid;
          if (guid.Equals(Guid.Empty))
          {
            cmd.Parameters.AddWithValue("@sourcedoctype", (object) "J");
            goto label_7;
          }
        }
        cmd.Parameters.AddWithValue("@sourcedoctype", this.IsReturnPremium ? (object) "N" : (object) "I");
label_7:
        if (transactionDetail.InvoiceNumber != 0)
          cmd.Parameters.AddWithValue("@invoicenum", (object) transactionDetail.InvoiceNumber);
        if (transactionDetail.ChargeCode != 0)
          cmd.Parameters.AddWithValue("@chargeCode", (object) transactionDetail.ChargeCode);
        guid = transactionDetail.CompanyLineGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@companylineguid", (object) transactionDetail.CompanyLineGuid);
        cmd.Parameters.AddWithValue("@amount", (object) transactionDetail.Amount);
        guid = transactionDetail.PayeeGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@payeeguid", (object) transactionDetail.PayeeGuid);
        if (transactionDetail.AppliedFrom > 0)
          cmd.Parameters.AddWithValue("@appliedFrom", (object) transactionDetail.AppliedFrom);
        if (transactionDetail.Comments != null && !transactionDetail.Equals((object) string.Empty))
          cmd.Parameters.AddWithValue("@comment", (object) transactionDetail.Comments);
        SqlParameterCollection parameters = cmd.Parameters;
        guid = transactionDetail.EntityGuid;
        // ISSUE: variable of a boxed type
        __Boxed<SqlGuid> local = (System.ValueType) (guid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) transactionDetail.EntityGuid);
        parameters.AddWithValue("@entityGuid", (object) local);
        int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
        if (transactionDetail != null && transactionDetail.CostCenterAllocations != null)
        {
          foreach (CostCenterAllocation centerAllocation in (CollectionBase) transactionDetail.CostCenterAllocations)
            centerAllocation.Save(cmd, PostingNumber, false);
        }
      }
    }
  }

  protected virtual void SaveCredits(SqlCommand cmd, int transactionNumber)
  {
    foreach (TransactionDetail credit in (CollectionBase) this.Credits)
    {
      if (!(credit.Amount == 0M))
      {
        cmd.Parameters.Clear();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spfin_PostJournalDetail";
        cmd.Parameters.AddWithValue("@transactnum", (object) transactionNumber);
        cmd.Parameters.AddWithValue("@glacctid", (object) (credit.GLAccount == null ? credit.GLAccountId : credit.GLAccount.GLAccountID));
        Guid guid;
        if (credit.InvoiceNumber == 0 && credit.ChargeCode == 0)
        {
          guid = credit.CompanyLineGuid;
          if (guid.Equals(Guid.Empty))
          {
            cmd.Parameters.AddWithValue("@sourcedoctype", (object) "J");
            goto label_7;
          }
        }
        cmd.Parameters.AddWithValue("@sourcedoctype", this.IsReturnPremium ? (object) "N" : (object) "I");
label_7:
        if (credit.InvoiceNumber != 0)
          cmd.Parameters.AddWithValue("@invoicenum", (object) credit.InvoiceNumber);
        if (credit.ChargeCode != 0)
          cmd.Parameters.AddWithValue("@chargeCode", (object) credit.ChargeCode);
        guid = credit.CompanyLineGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@companylineguid", (object) credit.CompanyLineGuid);
        cmd.Parameters.AddWithValue("@amount", (object) -credit.Amount);
        guid = credit.PayeeGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@payeeguid", (object) credit.PayeeGuid);
        if (credit.Comments != null && !credit.Equals((object) string.Empty))
          cmd.Parameters.AddWithValue("@comment", (object) credit.Comments);
        SqlParameterCollection parameters = cmd.Parameters;
        guid = credit.EntityGuid;
        // ISSUE: variable of a boxed type
        __Boxed<SqlGuid> local = (System.ValueType) (guid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) credit.EntityGuid);
        parameters.AddWithValue("@entityGuid", (object) local);
        int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
        if (credit != null && credit.CostCenterAllocations != null)
        {
          foreach (CostCenterAllocation centerAllocation in (CollectionBase) credit.CostCenterAllocations)
            centerAllocation.Save(cmd, PostingNumber, true);
        }
      }
    }
  }

  protected virtual void SaveNonInvoiceCredits(SqlCommand cmd, int transactionNumber)
  {
    foreach (TransactionDetail transactionDetail in this.Credits.Where<TransactionDetail>((System.Func<TransactionDetail, bool>) (credit => credit.InvoiceNumber == 0)))
    {
      if (!(transactionDetail.Amount == 0M))
      {
        cmd.Parameters.Clear();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spfin_PostJournalDetail";
        cmd.Parameters.AddWithValue("@transactnum", (object) transactionNumber);
        cmd.Parameters.AddWithValue("@glacctid", (object) (transactionDetail.GLAccount == null ? transactionDetail.GLAccountId : transactionDetail.GLAccount.GLAccountID));
        Guid guid;
        if (transactionDetail.InvoiceNumber == 0 && transactionDetail.ChargeCode == 0)
        {
          guid = transactionDetail.CompanyLineGuid;
          if (guid.Equals(Guid.Empty))
          {
            cmd.Parameters.AddWithValue("@sourcedoctype", (object) "J");
            goto label_7;
          }
        }
        cmd.Parameters.AddWithValue("@sourcedoctype", this.IsReturnPremium ? (object) "N" : (object) "I");
label_7:
        if (transactionDetail.InvoiceNumber != 0)
          cmd.Parameters.AddWithValue("@invoicenum", (object) transactionDetail.InvoiceNumber);
        if (transactionDetail.ChargeCode != 0)
          cmd.Parameters.AddWithValue("@chargeCode", (object) transactionDetail.ChargeCode);
        guid = transactionDetail.CompanyLineGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@companylineguid", (object) transactionDetail.CompanyLineGuid);
        cmd.Parameters.AddWithValue("@amount", (object) -transactionDetail.Amount);
        guid = transactionDetail.PayeeGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@payeeguid", (object) transactionDetail.PayeeGuid);
        if (transactionDetail.Comments != null && !transactionDetail.Equals((object) string.Empty))
          cmd.Parameters.AddWithValue("@comment", (object) transactionDetail.Comments);
        SqlParameterCollection parameters = cmd.Parameters;
        guid = transactionDetail.EntityGuid;
        // ISSUE: variable of a boxed type
        __Boxed<SqlGuid> local = (System.ValueType) (guid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) transactionDetail.EntityGuid);
        parameters.AddWithValue("@entityGuid", (object) local);
        int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
        if (transactionDetail != null && transactionDetail.CostCenterAllocations != null)
        {
          foreach (CostCenterAllocation centerAllocation in (CollectionBase) transactionDetail.CostCenterAllocations)
            centerAllocation.Save(cmd, PostingNumber, true);
        }
      }
    }
  }

  protected override bool ChildSave(Dictionary<string, object> parameters)
  {
    if (!this.VerifyTransaction())
      return false;
    this.SaveHeader();
    this.SaveTransaction();
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_ExecutePropIncome", 300, (CommandArgumentType) 0, new object[6]
    {
      (object) "@transactnum",
      (object) this.TransactionNumber,
      (object) "@glcompanyid",
      (object) this.GlCompanyId,
      (object) "@rollupto",
      this.TransactionType == Utility.AccountingTransactionType.Payable || this.TransactionType == Utility.AccountingTransactionType.PayableReturnPremium ? (object) "A/P" : (object) "A/R"
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_PostCommissionableFees", 300, (CommandArgumentType) 0, new object[6]
    {
      (object) "@transactnum",
      (object) this.TransactionNumber,
      (object) "@glcompanyid",
      (object) this.GlCompanyId,
      (object) "@transtype",
      this.TransactionType == Utility.AccountingTransactionType.Payable || this.TransactionType == Utility.AccountingTransactionType.PayableReturnPremium ? (object) "AP" : (object) "AR"
    });
    if (this.Debits.Count != 0 && this.Credits.Count != 0 || this.HasClaims || this.NumberOfClaimsReceived != 0)
    {
      switch (this.TransactionType)
      {
        case Utility.AccountingTransactionType.Payable:
        case Utility.AccountingTransactionType.ReceivableReturnPremium:
          this.CreateCheckPosting(this.TransactionNumber, this.CheckData, 300);
          break;
        case Utility.AccountingTransactionType.PayableReturnPremium:
        case Utility.AccountingTransactionType.Receivable:
          this.SaveRemittanceEntry(this.TransactionNumber);
          break;
      }
    }
    if (this.FinancedReceivables.HasSelectedReturns())
      this.SaveFinancedReceivables();
    return true;
  }

  protected override void OnSaveSucceeded(Dictionary<string, object> parameters)
  {
    CurrentUser.Instance.LogAction($"Posted transaction #{this.TransactionNumber}", "Accounting Logs");
    if (this.TransactionType != Utility.AccountingTransactionType.Receivable)
      return;
    Array array = this.Debits.PostedInvoiceList().ToArray(typeof (int));
    Messaging.SendBroadcastMessage(Utility.ReceivablePosted, (object) array);
    DataTable dataTable1 = new DataTable();
    dataTable1.Columns.Add("Item", typeof (int));
    foreach (object obj in array)
      dataTable1.Rows.Add(obj);
    object[] objArray = new object[1];
    List<DbParameter> dbParameterList = new List<DbParameter>();
    SqlParameter sqlParameter = new SqlParameter("@Invoices", SqlDbType.Structured);
    sqlParameter.TypeName = "dbo.IntList";
    sqlParameter.Value = (object) dataTable1;
    dbParameterList.Add((DbParameter) sqlParameter);
    objArray[0] = (object) dbParameterList;
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.spFin_GetQuoteGuidsFromInvoiceNumbers", 300, (CommandArgumentType) 2, objArray);
    if (dataTable2 == null || dataTable2.Rows.Count <= 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      Messaging.SendBroadcastMessage(Utility.RemittancePosted, (object) row.Field<Guid>("QuoteGuid"));
  }

  private void SaveHeader()
  {
    if ((this.Debits.Count == 0 && this.Credits.Count == 0 || this.DebitSum() == 0M && this.CreditSum() == 0M) && !this.HasClaims && this.NumberOfClaimsReceived == 0)
      return;
    List<object> objectList = new List<object>()
    {
      (object) "@postdate",
      (object) this.PostDate,
      (object) "@journalentrytype",
      (object) "I",
      (object) "@userguid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@glCompanyId",
      (object) this.GlCompanyId
    };
    if (!string.IsNullOrWhiteSpace(this.TransactionComments))
    {
      objectList.Add((object) "@comments");
      objectList.Add((object) this.TransactionComments);
    }
    char ch = char.MinValue;
    switch (this.TransactionType)
    {
      case Utility.AccountingTransactionType.Payable:
        ch = 'D';
        break;
      case Utility.AccountingTransactionType.PayableReturnPremium:
        ch = 'F';
        break;
      case Utility.AccountingTransactionType.Receivable:
        ch = 'R';
        break;
      case Utility.AccountingTransactionType.ReceivableReturnPremium:
        ch = 'B';
        break;
    }
    if (ch != char.MinValue)
    {
      objectList.Add((object) "@transdescid");
      objectList.Add((object) ch);
    }
    this.TransNumber = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "dbo.spFin_PostJournalHeader", 300, (CommandArgumentType) 0, objectList.ToArray());
    this.TransactionsCreated.Add((object) this.TransactionNumber);
  }

  private void SaveTransaction()
  {
    DataSet bulkDataSet1 = this.CreateBulkDataSet();
    DataSet bulkDataSet2 = this.CreateBulkDataSet();
    string name1 = InsuranceTransaction.BulkDataSetConstants.Tables.JournalTableName(bulkDataSet1.DataSetName);
    string name2 = InsuranceTransaction.BulkDataSetConstants.Tables.JournalTableName(bulkDataSet2.DataSetName);
    this.AddDetailsToDataSet(bulkDataSet1, this.Debits, false);
    this.AddDetailsToDataSet(bulkDataSet2, this.Credits, true);
    if (bulkDataSet1.Tables[name1].Rows.Count == 0 && bulkDataSet2.Tables[name2].Rows.Count == 0)
    {
      if (!this.HasClaims)
        return;
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_SetJournalGLCompanyId", 300, (CommandArgumentType) 0, new object[4]
      {
        (object) "@TransactNum",
        (object) this.TransactionNumber,
        (object) "@GLAcctId",
        (object) this.BankGLAccountId
      });
    }
    else
    {
      this.SaveDataTable(bulkDataSet1.Tables[name1]);
      this.SaveDataTable(bulkDataSet2.Tables[name2]);
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_BulkPostInvoices", 300, (CommandArgumentType) 0, new object[6]
      {
        (object) "@DebitJournalTableName",
        (object) name1,
        (object) "@CreditJournalTableName",
        (object) name2,
        (object) "@TransactionNumber",
        (object) this.TransactionNumber
      });
    }
  }

  protected void SaveFinancedReceivables()
  {
    foreach (FinancedReturn financedReceivable in (CollectionBase) this.FinancedReceivables)
    {
      if (financedReceivable.HasSelectedDetails())
        this.transactionsCreated.Add((object) financedReceivable.Save(this.CheckData.CheckMemo, financedReceivable.FinanceCompanyGuid, this.CheckData.BankGlAccount.GLAccountID));
    }
  }

  private DataSet CreateBulkDataSet()
  {
    DataSet bulkDataSet = new DataSet($"BulkPost_{Guid.NewGuid():N}");
    DataTable journalDataTable = this.CreateJournalDataTable(bulkDataSet.DataSetName);
    bulkDataSet.Tables.Add(journalDataTable);
    return bulkDataSet;
  }

  private DataTable CreateJournalDataTable(string name)
  {
    return new DataTable(InsuranceTransaction.BulkDataSetConstants.Tables.JournalTableName(name))
    {
      Columns = {
        {
          "Amount",
          typeof (Decimal)
        },
        {
          "AppliedFrom",
          typeof (int)
        },
        {
          "ChargeCode",
          typeof (int)
        },
        {
          "Comments",
          typeof (string)
        },
        {
          "CompanyLineGuid",
          typeof (Guid)
        },
        {
          "EntityGuid",
          typeof (Guid)
        },
        {
          "GLAcctId",
          typeof (int)
        },
        {
          "InvoiceNum",
          typeof (int)
        },
        {
          "PayeeGuid",
          typeof (Guid)
        },
        {
          "SourceDocType",
          typeof (string)
        }
      }
    };
  }

  private void AddDetailsToDataSet(
    DataSet dataSet,
    TransactionDetailCollection details,
    bool isCredit)
  {
    foreach (TransactionDetail detail in (CollectionBase) details)
    {
      if (!(detail.Amount == 0M))
      {
        string name = InsuranceTransaction.BulkDataSetConstants.Tables.JournalTableName(dataSet.DataSetName);
        DataRow row = dataSet.Tables[name].NewRow();
        DataRow dataRow = row;
        GLAccount glAccount = detail.GLAccount;
        // ISSUE: variable of a boxed type
        __Boxed<int> local = (System.ValueType) (glAccount != null ? glAccount.GLAccountID : detail.GLAccountId);
        dataRow["GLAcctId"] = (object) local;
        row["Amount"] = (object) (isCredit ? -detail.Amount : detail.Amount);
        row["EntityGuid"] = !(detail.EntityGuid == Guid.Empty) ? (object) detail.EntityGuid : (object) DBNull.Value;
        row["SourceDocType"] = detail.InvoiceNumber != 0 || detail.ChargeCode != 0 || !(detail.CompanyLineGuid != Guid.Empty) ? (this.IsReturnPremium ? (object) "N" : (object) "I") : (object) "J";
        if (detail.InvoiceNumber != 0)
          row["InvoiceNum"] = (object) detail.InvoiceNumber;
        if (detail.ChargeCode != 0)
          row["ChargeCode"] = (object) detail.ChargeCode;
        if (detail.CompanyLineGuid != Guid.Empty)
          row["CompanyLineGuid"] = (object) detail.CompanyLineGuid;
        if (detail.PayeeGuid != Guid.Empty)
          row["PayeeGuid"] = (object) detail.PayeeGuid;
        if (!isCredit && detail.AppliedFrom > 0)
          row["AppliedFrom"] = (object) detail.AppliedFrom;
        if (!string.IsNullOrWhiteSpace(detail.Comments))
          row["Comments"] = (object) detail.Comments;
        dataSet.Tables[name].Rows.Add(row);
      }
    }
  }

  private void SaveDataTable(DataTable dataTable)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, Utility.CreateBulkInsertTable(dataTable.TableName, dataTable));
    DefaultDatabase.ExecuteBulkInsert(new int?(300), dataTable, (SqlRowsCopiedEventHandler) null, SqlBulkCopyOptions.TableLock, dataTable.TableName);
  }

  private static class BulkDataSetConstants
  {
    public static class Tables
    {
      public const string Journal = "Journal";

      public static string JournalTableName(string dataSetName) => dataSetName + "_Journal";
    }

    public static class JournalColumns
    {
      public const string Amount = "Amount";
      public const string AppliedFrom = "AppliedFrom";
      public const string ChargeCode = "ChargeCode";
      public const string Comments = "Comments";
      public const string CompanyLineGuid = "CompanyLineGuid";
      public const string EntityGuid = "EntityGuid";
      public const string GLAcctId = "GLAcctId";
      public const string InvoiceNum = "InvoiceNum";
      public const string PayeeGuid = "PayeeGuid";
      public const string SourceDocType = "SourceDocType";
    }
  }
}
