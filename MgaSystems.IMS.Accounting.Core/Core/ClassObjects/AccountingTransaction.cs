// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.AccountingTransaction
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public abstract class AccountingTransaction : IDisposable
{
  private bool _hasClaims;
  private int _transactionNumber;
  private Utility.AccountingTransactionType _transactionType;
  private DateTime _postDate;
  private bool _isPosted;
  private Guid _userGuid;
  private int _numberOfClaimsReceived;
  private string _userName;
  private string _transactionComments;
  private bool _isVoided;
  private int _voidingTransactionNumber;
  private string _transactionDescriptionId;
  private Utility.AccountingJournalEntryType _journalEntryType;
  private TransactionDetailCollection _debits;
  private TransactionDetailCollection _credits;
  private CheckInformation _checkData;
  private int _glCompanyId;
  protected const int CommandTimeout = 300;

  public AccountingTransaction()
  {
  }

  public AccountingTransaction(
    Guid UserGuid,
    Utility.AccountingTransactionType TransactionType,
    Utility.AccountingJournalEntryType JournalEntryType)
  {
    this._userGuid = UserGuid;
    this._userName = Utility.GetEntityName(UserGuid);
    this._transactionType = TransactionType;
    this._journalEntryType = JournalEntryType;
  }

  public AccountingTransaction(Guid UserGuid, Utility.AccountingTransactionType TransactionType)
  {
    this._userGuid = UserGuid;
    this._userName = Utility.GetEntityName(UserGuid);
    this._transactionType = TransactionType;
  }

  public AccountingTransaction(
    Guid UserGuid,
    Utility.AccountingTransactionType TransactionType,
    Utility.AccountingJournalEntryType JournalEntryType,
    int glCompanyId)
  {
    this._userGuid = UserGuid;
    this._userName = Utility.GetEntityName(UserGuid);
    this._transactionType = TransactionType;
    this._journalEntryType = JournalEntryType;
    this._glCompanyId = glCompanyId;
  }

  public AccountingTransaction(
    Guid UserGuid,
    Utility.AccountingTransactionType TransactionType,
    int glCompanyId)
  {
    this._userGuid = UserGuid;
    this._userName = Utility.GetEntityName(UserGuid);
    this._transactionType = TransactionType;
    this._glCompanyId = glCompanyId;
  }

  public AccountingTransaction(int TransactionNumber) => this.LoadTransaction(TransactionNumber);

  public void Dispose()
  {
  }

  public int TransactionNumber => this._transactionNumber;

  protected int TransNumber
  {
    set => this._transactionNumber = value;
  }

  public Utility.AccountingTransactionType TransactionType
  {
    get => this._transactionType;
    set => this._transactionType = value;
  }

  public DateTime PostDate
  {
    get => this._postDate;
    set => this._postDate = value;
  }

  public bool IsPosted => this._isPosted;

  public bool IsVoided => this._isVoided;

  public int VoidingTransactionNumber => this._voidingTransactionNumber;

  public Guid UserGuid => this._userGuid;

  public string UserName => this._userName;

  public TransactionDetailCollection Debits
  {
    get
    {
      if (this._debits == null)
        this._debits = new TransactionDetailCollection();
      return this._debits;
    }
  }

  public TransactionDetailCollection Credits
  {
    get
    {
      if (this._credits == null)
        this._credits = new TransactionDetailCollection();
      return this._credits;
    }
  }

  public string TransactionDescriptionId => this._transactionDescriptionId;

  public Utility.AccountingJournalEntryType JournalEnryType => this._journalEntryType;

  public string TransactionComments
  {
    get => this._transactionComments;
    set => this._transactionComments = value;
  }

  public CheckInformation CheckData
  {
    get => this._checkData;
    set => this._checkData = value;
  }

  public int GlCompanyId => this._glCompanyId;

  public bool HasClaims
  {
    get => this._hasClaims;
    set => this._hasClaims = value;
  }

  public int NumberOfClaimsReceived
  {
    get => this._numberOfClaimsReceived;
    set => this._numberOfClaimsReceived = value;
  }

  public bool IsBalanced() => this.Debits.TransactionsTotal() == this.Credits.TransactionsTotal();

  private void LoadTransaction(int TransactionNumber)
  {
    this._transactionNumber = TransactionNumber;
  }

  protected void SetTransactionNumber(int transactionNumber)
  {
    this._transactionNumber = transactionNumber;
  }

  private void LoadTransactionHeader()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetAccountingTransaction_Journal", new object[2]
    {
      (object) "@transactnum",
      (object) this.TransactionNumber
    });
    if (dataTable == null || dataTable.Rows.Count == 0)
      throw new AccountingTransactionNotFound(StringResourceManager.GetString("ACCOUNTING_TRANSACTION_NOTFOUND"));
    DataRow row = dataTable.Rows[0];
    if (row["postDate"] != null)
    {
      this._postDate = Convert.ToDateTime(row["postDate"]);
      this._isPosted = true;
    }
    else
      this._isPosted = false;
    if (row["voidedby"] != null)
    {
      this._voidingTransactionNumber = int.Parse(row["voidedBy"].ToString());
      this._isVoided = true;
    }
    else
      this._isVoided = false;
    this._userGuid = new Guid(row["userGuid"].ToString());
    this._transactionDescriptionId = row["transDescId"].ToString();
    switch (row["journalEntryType"].ToString())
    {
      case "I":
        this._journalEntryType = Utility.AccountingJournalEntryType.Invoicing;
        break;
      case "O":
        this._journalEntryType = Utility.AccountingJournalEntryType.Operating;
        break;
      default:
        this._journalEntryType = Utility.AccountingJournalEntryType.Invoicing;
        break;
    }
    if (row["comments"] != null)
      this._transactionComments = row["comments"].ToString();
    else
      this._transactionComments = string.Empty;
  }

  [Obsolete("This method is deprecated, please use the method that does not require the SqlCommand object instead.")]
  protected int CreateCheckPosting(
    SqlCommand cmd,
    int TransactionNumber,
    CheckInformation CheckData)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "dbo.spFin_InsertCheckRegister";
    cmd.Parameters.Clear();
    char paymentMethod = this.GetPaymentMethod(CheckData);
    cmd.Parameters.AddWithValue("@TransactNum", (object) TransactionNumber);
    cmd.Parameters.AddWithValue("@PaymentMethodId", (object) paymentMethod);
    cmd.Parameters.AddWithValue("@CheckingAccountId", (object) CheckData.BankGlAccount.GLAccountID);
    cmd.Parameters.AddWithValue("@PayeeGuid", (object) CheckData.PayeeGuid);
    cmd.Parameters.AddWithValue("@CheckDate", (object) CheckData.CheckDate);
    if (CheckData.AchSettingsAccountID > 0)
      cmd.Parameters.AddWithValue("@ACHSettingsAccountID", (object) CheckData.AchSettingsAccountID);
    if (CheckData.Comments != null && CheckData.Comments.Length != 0)
      cmd.Parameters.AddWithValue("@Comments", (object) CheckData.Comments);
    if (CheckData.CheckMemo != null && CheckData.CheckMemo.Length != 0)
      cmd.Parameters.AddWithValue("@CheckMemo", (object) CheckData.CheckMemo);
    if (CheckData.PayeeName != null && CheckData.PayeeName.Length != 0)
      cmd.Parameters.AddWithValue("@PayeeName", (object) CheckData.PayeeName);
    if (CheckData.PayeeAddress1 != null && CheckData.PayeeAddress1.Length != 0)
      cmd.Parameters.AddWithValue("@PayeeAddress1", (object) CheckData.PayeeAddress1);
    if (CheckData.PayeeAddress2 != null && CheckData.PayeeAddress2.Length != 0)
      cmd.Parameters.AddWithValue("@PayeeAddress2", (object) CheckData.PayeeAddress2);
    if (CheckData.PayeeCity != null && CheckData.PayeeCity.Length != 0)
      cmd.Parameters.AddWithValue("@PayeeCity", (object) CheckData.PayeeCity);
    if (CheckData.PayeeState != null && CheckData.PayeeState.Length != 0)
      cmd.Parameters.AddWithValue("@PayeeState", (object) CheckData.PayeeState);
    if (CheckData.PayeeZip != null && CheckData.PayeeZip.Length != 0)
      cmd.Parameters.AddWithValue("@PayeeZip", (object) CheckData.PayeeZip);
    if (CheckData.PayeeZipPlus != null && CheckData.PayeeZipPlus.Length != 0)
      cmd.Parameters.AddWithValue("@PayeeZipPlus", (object) CheckData.PayeeZipPlus);
    if (CheckData.CheckName != null && CheckData.CheckName.Length != 0)
      cmd.Parameters.AddWithValue("@CheckName", (object) CheckData.CheckName);
    return int.Parse(cmd.ExecuteScalar().ToString());
  }

  protected int CreateCheckPosting(
    int transactionNumber,
    CheckInformation checkData,
    int commandTimeout = 30)
  {
    char paymentMethod = this.GetPaymentMethod(checkData);
    List<object> parameters = new List<object>()
    {
      (object) "@TransactNum",
      (object) transactionNumber,
      (object) "@PaymentMethodId",
      (object) paymentMethod,
      (object) "@CheckingAccountId",
      (object) checkData.BankGlAccount.GLAccountID,
      (object) "@PayeeGuid",
      (object) checkData.PayeeGuid,
      (object) "@CheckDate",
      (object) checkData.CheckDate
    };
    Dictionary<string, string> values = new Dictionary<string, string>()
    {
      {
        "@Comments",
        checkData.Comments
      },
      {
        "@CheckMemo",
        checkData.CheckMemo
      },
      {
        "@PayeeName",
        checkData.PayeeName
      },
      {
        "@PayeeAddress1",
        checkData.PayeeAddress1
      },
      {
        "@PayeeAddress2",
        checkData.PayeeAddress2
      },
      {
        "@PayeeCity",
        checkData.PayeeCity
      },
      {
        "@PayeeState",
        checkData.PayeeState
      },
      {
        "@PayeeZip",
        checkData.PayeeZip
      },
      {
        "@PayeeZipPlus",
        checkData.PayeeZipPlus
      },
      {
        "@CheckName",
        checkData.CheckName
      }
    };
    AccountingTransaction.AddParametersIfNotEmpty((ICollection<object>) parameters, values);
    if (this.CheckData.AchSettingsAccountID > 0)
    {
      parameters.Add((object) "@ACHSettingsAccountID");
      parameters.Add((object) this.CheckData.AchSettingsAccountID);
    }
    return DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "dbo.spFin_InsertCheckRegister", commandTimeout, (CommandArgumentType) 0, parameters.ToArray());
  }

  protected virtual char GetPaymentMethod(CheckInformation checkData)
  {
    char paymentMethod = checkData.CharPayMethod;
    if (paymentMethod == char.MinValue)
    {
      switch (this.CheckData.PayMethod)
      {
        case Utility.PaymentMethod.AutoEFT:
          paymentMethod = 'A';
          break;
        case Utility.PaymentMethod.Check:
          paymentMethod = 'C';
          break;
        case Utility.PaymentMethod.ManualTransfer:
          paymentMethod = 'M';
          break;
        case Utility.PaymentMethod.Offset:
          paymentMethod = 'O';
          break;
        case Utility.PaymentMethod.ACH:
          paymentMethod = 'D';
          break;
        default:
          throw new PaymentMethodNotSupportedException(StringResourceManager.GetString("UNSUPPORTED_PAYMENTMETHOD_EXCEPTION"));
      }
    }
    return paymentMethod;
  }

  public bool SaveBulk(Dictionary<string, object> parameters = null)
  {
    bool result = false;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((obj, eventArgs) =>
    {
      try
      {
        if (this.Save(eventArgs.Transaction, parameters))
        {
          eventArgs.Transaction.Commit();
          result = true;
        }
        else
          eventArgs.Transaction.Rollback();
      }
      catch
      {
        eventArgs.Transaction.Rollback();
        throw;
      }
    }));
    return result;
  }

  public bool Save(DbTransaction activeTransaction, Dictionary<string, object> parameters = null)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    AccountingTransaction.\u003C\u003Ec__DisplayClass75_0 cDisplayClass750 = new AccountingTransaction.\u003C\u003Ec__DisplayClass75_0();
    // ISSUE: reference to a compiler-generated field
    cDisplayClass750.\u003C\u003E4__this = this;
    // ISSUE: reference to a compiler-generated field
    cDisplayClass750.parameters = parameters;
    // ISSUE: reference to a compiler-generated field
    cDisplayClass750.result = false;
    // ISSUE: reference to a compiler-generated field
    if (cDisplayClass750.parameters == null)
    {
      // ISSUE: reference to a compiler-generated field
      cDisplayClass750.parameters = new Dictionary<string, object>();
    }
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction(activeTransaction, new ExecuteHandler((object) cDisplayClass750, __methodptr(\u003CSave\u003Eb__0)));
    // ISSUE: reference to a compiler-generated field
    if (cDisplayClass750.result)
    {
      // ISSUE: reference to a compiler-generated field
      this.OnSaveSucceeded(cDisplayClass750.parameters);
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      this.OnSaveFailed(cDisplayClass750.parameters);
    }
    // ISSUE: reference to a compiler-generated field
    return cDisplayClass750.result;
  }

  protected virtual void OnSaveFailed(Dictionary<string, object> parameters)
  {
  }

  protected virtual void OnSaveSucceeded(Dictionary<string, object> parameters)
  {
  }

  private static void AddParametersIfNotEmpty(
    ICollection<object> parameters,
    Dictionary<string, string> values)
  {
    foreach (KeyValuePair<string, string> keyValuePair in values.Where<KeyValuePair<string, string>>((System.Func<KeyValuePair<string, string>, bool>) (value => !string.IsNullOrEmpty(value.Value))))
    {
      parameters.Add((object) keyValuePair.Key);
      parameters.Add((object) keyValuePair.Value);
    }
  }

  protected abstract bool ChildSave(Dictionary<string, object> parameters);

  public abstract void Save();

  public abstract void Save(SqlCommand cmd);
}
