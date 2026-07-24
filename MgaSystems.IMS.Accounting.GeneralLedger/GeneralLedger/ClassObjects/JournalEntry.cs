// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.JournalEntry
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.GeneralLedger.Exceptions;
using MGASystems.IMS.Accounting.Shared;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

public class JournalEntry : IDisposable
{
  private SharedMembers.JournalEntryType journalEntryType;
  private int glcompanyid;
  private string comments;
  private DateTime postDate = DateTime.Now;
  private LedgerEntriesCollection debitsCol;
  private LedgerEntriesCollection creditsCol;
  private Utilities.InvoiceCorrectionType correctionType;
  private Guid invoiceCorrection_PayeeGuid;
  private bool isYearEnd;
  private int costCenterId;
  private string transactionDescriptionId;

  public JournalEntry() => this.isYearEnd = false;

  public void Dispose()
  {
    if (this.debitsCol != null)
      this.debitsCol.ListChanged -= new ListChangedEventHandler(this.LedgerEntriesListChanged);
    if (this.creditsCol == null)
      return;
    this.creditsCol.ListChanged -= new ListChangedEventHandler(this.LedgerEntriesListChanged);
  }

  public bool IsYearEnd
  {
    get => this.isYearEnd;
    set => this.isYearEnd = value;
  }

  public SharedMembers.JournalEntryType JournalEntryType
  {
    get => this.journalEntryType;
    set => this.journalEntryType = value;
  }

  public int GlCompanyId
  {
    get => this.glcompanyid;
    set => this.glcompanyid = value;
  }

  public int CostCenterId
  {
    get => this.costCenterId;
    set => this.costCenterId = value;
  }

  public DateTime PostDate
  {
    get => this.postDate;
    set => this.postDate = value;
  }

  public string Comments
  {
    get => this.comments;
    set => this.comments = value;
  }

  public LedgerEntriesCollection DebitsCol
  {
    get
    {
      if (this.debitsCol == null)
      {
        this.debitsCol = new LedgerEntriesCollection();
        this.debitsCol.ListChanged += new ListChangedEventHandler(this.LedgerEntriesListChanged);
      }
      return this.debitsCol;
    }
  }

  public LedgerEntriesCollection CreditsCol
  {
    get
    {
      if (this.creditsCol == null)
      {
        this.creditsCol = new LedgerEntriesCollection();
        this.creditsCol.ListChanged += new ListChangedEventHandler(this.LedgerEntriesListChanged);
      }
      return this.creditsCol;
    }
  }

  public Utilities.InvoiceCorrectionType CorrectionType
  {
    get => this.correctionType;
    set => this.correctionType = value;
  }

  public Guid InvoiceCorrection_PayeeGuid
  {
    get => this.invoiceCorrection_PayeeGuid;
    set => this.invoiceCorrection_PayeeGuid = value;
  }

  public string TransactionDescriptionId
  {
    get => this.transactionDescriptionId;
    set => this.transactionDescriptionId = value;
  }

  public event JournalEntry.LedgerEntryAddedHandler LedgerEntryAdded;

  public event JournalEntry.EntriesStatusChangedHandler EntriesStatusChanged;

  protected virtual void OnLedgerEntryAdded(LedgerEntry newEntry)
  {
    if (this.LedgerEntryAdded == null)
      return;
    this.LedgerEntryAdded((object) newEntry, new EventArgs());
  }

  protected virtual void OnEntriesStatusChanged()
  {
    if (this.EntriesStatusChanged == null)
      return;
    this.EntriesStatusChanged((object) this, new EventArgs());
  }

  private void EntryRemoved() => this.OnEntriesStatusChanged();

  private void LedgerEntriesListChanged(object sender, ListChangedEventArgs e)
  {
    this.OnEntriesStatusChanged();
  }

  private void SaveTransactionCostCenter(SqlCommand cmd, int TransactionNumber)
  {
    if (this.CostCenterId == 0)
      throw new ArgumentException("The journal entry object requires a cost center.");
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) TransactionNumber);
    cmd.Parameters.AddWithValue("@CostCenterId", (object) this.costCenterId);
    cmd.CommandText = "spFin_InsertTransactionCostCenterId";
    cmd.ExecuteNonQuery();
  }

  public void Save()
  {
    if (this.debitsCol == null || this.creditsCol == null)
      return;
    if (this.debitsCol.Total() != this.creditsCol.Total())
      throw new JournalEntryUnbalancedException(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("JournalEntryNotInBalance"));
    SqlCommand cmd = new SqlCommand("", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      cmd.Connection.Open();
      cmd.Transaction = cmd.Connection.BeginTransaction();
      int num = this.SaveDetails(cmd, this.SaveHeader(cmd));
      cmd.Transaction.Commit();
      CurrentUser.Instance.LogAction($"Posted transaction #{num.ToString()}", "Accounting Logs");
    }
    catch (SqlException ex)
    {
      cmd.Transaction.Rollback();
      throw new JournalEntrySQLException($"{MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("ErrorAddingJournalEntry")} {ex.Errors[0].Message}");
    }
    catch (Exception ex)
    {
      cmd.Transaction.Rollback();
      throw new JournalEntryException($"{MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("ErrorAddingJournalEntry")} {ex.Message}");
    }
    finally
    {
      if (cmd != null)
      {
        if (cmd.Connection != null)
        {
          if (cmd.Connection.State != ConnectionState.Closed)
            cmd.Connection.Close();
          cmd.Connection.Dispose();
          cmd.Connection = (SqlConnection) null;
        }
        cmd.Dispose();
      }
    }
  }

  private int SaveHeader(SqlCommand cmd)
  {
    if (!this.IsYearEnd)
      cmd.CommandText = "spFin_PostJournalEntry_Header";
    else
      cmd.CommandText = "spFin_PostYearEnd_Header";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@postDate", (object) this.postDate);
    cmd.Parameters.AddWithValue("@comments", (object) this.comments);
    cmd.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
    if (this.TransactionDescriptionId != null && !this.TransactionDescriptionId.Equals(string.Empty))
      cmd.Parameters.AddWithValue("@transdescid", (object) this.TransactionDescriptionId);
    return (int) cmd.ExecuteScalar();
  }

  private int SaveDetails(SqlCommand cmd, int TransactionNumber)
  {
    cmd.CommandText = "spFin_PostJournalEntry_Detail";
    cmd.CommandType = CommandType.StoredProcedure;
    switch (this.JournalEntryType)
    {
      case SharedMembers.JournalEntryType.AccountAdjustment:
        for (int index = 0; index < this.debitsCol.Count; ++index)
        {
          cmd.Parameters.Clear();
          cmd.CommandText = "spFin_PostJournalEntry_Detail";
          cmd.Parameters.AddWithValue("@transactNum", (object) TransactionNumber);
          cmd.Parameters.AddWithValue("@glAcctId", (object) this.debitsCol[index].LedgerAccount);
          cmd.Parameters.AddWithValue("@amount", (object) this.debitsCol[index].Amount);
          cmd.Parameters.AddWithValue("@comment", (object) this.debitsCol[index].Comments);
          int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
          if (this.debitsCol[index].CostCenterAllocation != null)
          {
            foreach (CostCenterAllocation centerAllocation in (CollectionBase) this.debitsCol[index].CostCenterAllocation)
            {
              centerAllocation.Save(cmd, PostingNumber, false);
              cmd.Parameters.Clear();
            }
          }
        }
        for (int index = 0; index < this.creditsCol.Count; ++index)
        {
          cmd.Parameters.Clear();
          cmd.CommandText = "spFin_PostJournalEntry_Detail";
          cmd.Parameters.AddWithValue("@transactNum", (object) TransactionNumber);
          cmd.Parameters.AddWithValue("@glAcctId", (object) this.creditsCol[index].LedgerAccount);
          cmd.Parameters.AddWithValue("@amount", (object) (this.creditsCol[index].Amount * -1M));
          int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
          if (this.creditsCol[index].CostCenterAllocation != null)
          {
            foreach (CostCenterAllocation centerAllocation in (CollectionBase) this.creditsCol[index].CostCenterAllocation)
            {
              centerAllocation.Save(cmd, PostingNumber, true);
              cmd.Parameters.Clear();
            }
          }
        }
        break;
      case SharedMembers.JournalEntryType.InvoiceCorrection:
        cmd.CommandText = "dbo.spFin_InvoiceCorrection_InsertInvoiceDetail";
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@invoiceNum", (object) this.creditsCol[0].InvoiceNumber);
        cmd.Parameters.AddWithValue("@chargeCode", (object) this.creditsCol[0].ChargeCode);
        cmd.Parameters.AddWithValue("@companyLineGuid", (object) this.creditsCol[0].CompanyLineGuid);
        cmd.Parameters.AddWithValue("@date", (object) this.PostDate);
        if (!this.InvoiceCorrection_PayeeGuid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@payeeGuid", (object) this.InvoiceCorrection_PayeeGuid.ToString());
        switch (this.CorrectionType)
        {
          case Utilities.InvoiceCorrectionType.APDecrease:
          case Utilities.InvoiceCorrectionType.ARDecrease:
            cmd.Parameters.AddWithValue("@amount", (object) -this.creditsCol[0].Amount);
            break;
          case Utilities.InvoiceCorrectionType.APIncrease:
          case Utilities.InvoiceCorrectionType.ARIncrease:
            cmd.Parameters.AddWithValue("@amount", (object) this.creditsCol[0].Amount);
            break;
        }
        cmd.ExecuteNonQuery();
        break;
      case SharedMembers.JournalEntryType.InvoiceLedgerEntry:
        for (int index = 0; index < this.debitsCol.Count; ++index)
        {
          cmd.Parameters.Clear();
          cmd.CommandText = "spFin_PostJournalEntry_Detail";
          cmd.Parameters.AddWithValue("@transactNum", (object) TransactionNumber);
          cmd.Parameters.AddWithValue("@glAcctId", (object) this.debitsCol[index].LedgerAccount);
          cmd.Parameters.AddWithValue("@amount", (object) this.debitsCol[index].Amount);
          cmd.Parameters.AddWithValue("@comment", (object) this.debitsCol[index].Comments);
          cmd.Parameters.AddWithValue("@invoiceNum", (object) this.debitsCol[index].InvoiceNumber);
          cmd.Parameters.AddWithValue("@chargeCode", (object) this.debitsCol[index].ChargeCode);
          cmd.Parameters.AddWithValue("@companyLineGuid", (object) this.debitsCol[index].CompanyLineGuid);
          int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
          if (this.debitsCol[index].CostCenterAllocation != null)
          {
            foreach (CostCenterAllocation centerAllocation in (CollectionBase) this.debitsCol[index].CostCenterAllocation)
            {
              centerAllocation.Save(cmd, PostingNumber, false);
              cmd.Parameters.Clear();
            }
          }
        }
        for (int index = 0; index < this.creditsCol.Count; ++index)
        {
          cmd.Parameters.Clear();
          cmd.CommandText = "spFin_PostJournalEntry_Detail";
          cmd.Parameters.AddWithValue("@transactNum", (object) TransactionNumber);
          cmd.Parameters.AddWithValue("@glAcctId", (object) this.creditsCol[index].LedgerAccount);
          cmd.Parameters.AddWithValue("@amount", (object) (this.creditsCol[index].Amount * -1M));
          cmd.Parameters.AddWithValue("@invoiceNum", (object) this.creditsCol[index].InvoiceNumber);
          cmd.Parameters.AddWithValue("@chargeCode", (object) this.creditsCol[index].ChargeCode);
          cmd.Parameters.AddWithValue("@companyLineGuid", (object) this.creditsCol[index].CompanyLineGuid);
          int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
          if (this.creditsCol[index].CostCenterAllocation != null)
          {
            foreach (CostCenterAllocation centerAllocation in (CollectionBase) this.creditsCol[index].CostCenterAllocation)
            {
              centerAllocation.Save(cmd, PostingNumber, true);
              cmd.Parameters.Clear();
            }
          }
        }
        break;
    }
    return TransactionNumber;
  }

  public bool HasLedgerEntries()
  {
    if (this.debitsCol != null && this.debitsCol.Count != 0)
      return true;
    return this.creditsCol != null && this.creditsCol.Count != 0;
  }

  public bool ViolatesClosedDate()
  {
    DateTime now = DateTime.Now;
    string empty = string.Empty;
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand($"Select dbo.GetGlCompanyClosedDate({this.GlCompanyId})", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection.Open();
        string s = sqlCommand.ExecuteScalar().ToString();
        return !(s == string.Empty) && this.PostDate <= DateTime.Parse(s);
      }
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public delegate void LedgerEntryAddedHandler(object sender, EventArgs e);

  [EditorBrowsable(EditorBrowsableState.Never)]
  public delegate void EntriesStatusChangedHandler(object sender, EventArgs e);
}
