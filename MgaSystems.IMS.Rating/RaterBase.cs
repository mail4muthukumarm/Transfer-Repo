// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.RaterBase
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public abstract class RaterBase : IRater, IRaterEndorsementOptions
{
  private Guid _quoteGuid;
  private bool _reflectionInfoInitialized;
  private int _raterId;
  private string _raterName;
  private Guid _lineGuid;
  private string _lineName;
  private string _stateId;
  private int _chargeCode;
  private int _controlNumber;
  private string _namedInsured;
  private string _policyNumber;
  private Quote _quote;
  protected DatabaseRaterElements dbConditions;
  private RaterSettings _settings;
  private bool disposedValue;

  protected RaterBase()
  {
    this._quoteGuid = Guid.Empty;
    this._raterId = -1;
    this._lineGuid = Guid.Empty;
    this._lineName = string.Empty;
    this._chargeCode = -1;
    this._controlNumber = -1;
    this._namedInsured = string.Empty;
    this._policyNumber = string.Empty;
  }

  public event EventHandler UIClosed;

  public abstract string GetOptionDescription(Guid quoteOptionGuid);

  protected int QuoteOptionId
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>("GetBoundQuoteOptionID", new object[4]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid,
        (object) "@LineGuid",
        (object) this.LineGuid
      });
    }
  }

  protected RaterSettings Settings
  {
    get
    {
      if (this._settings == null)
      {
        try
        {
          this._settings = ObjectFactory.Instance.CreateObjectAs<RaterSettings>((object) this);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this._settings = new RaterSettings(this);
          ProjectData.ClearProjectError();
        }
      }
      return this._settings;
    }
  }

  public string LineName
  {
    get
    {
      if (this._lineName.Length == 0)
        this._lineName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT LineName FROM lstLines WHERE LineGuid=@LG", new object[2]
        {
          (object) "@LG",
          (object) this.LineGuid
        }) ?? string.Empty;
      return this._lineName;
    }
  }

  public Guid LineGuid => this._lineGuid;

  public virtual bool IsReadyForBind => true;

  public virtual List<string> NotReadyToBindReason
  {
    get
    {
      throw new InvalidOperationException("Must override NotReadyToBindReason when IsReadyForBind is False");
    }
  }

  public virtual bool IsReadyForPolicyIssuance => true;

  public virtual List<string> NotReadyForPolicyIssuanceReasons
  {
    get
    {
      throw new InvalidOperationException("Must override NotReadyForPolicyIssuranceReason when IsReadyForPolicyIssurance is False");
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public virtual bool HasUI => false;

  public Guid QuoteGuid => this._quoteGuid;

  public Quote Quote
  {
    get
    {
      if (this._quote == null)
        this._quote = new Quote(this.QuoteGuid);
      return this._quote;
    }
  }

  public string PolicyNumber
  {
    get
    {
      if (string.IsNullOrEmpty(this._policyNumber))
        this._policyNumber = this.Quote.PolicyNumber ?? string.Empty;
      return this._policyNumber;
    }
  }

  public string NamedInsured
  {
    get
    {
      if (string.IsNullOrEmpty(this._namedInsured))
        this._namedInsured = this.Quote.InsuredPolicyName;
      return this._namedInsured;
    }
  }

  public int ControlNumber
  {
    get
    {
      if (this._controlNumber == -1)
        this._controlNumber = this.Quote.ControlNo;
      return this._controlNumber;
    }
  }

  public string RaterName
  {
    get
    {
      this.InitReflectionInfo();
      return this._raterName;
    }
  }

  public int RaterID
  {
    get
    {
      this.InitReflectionInfo();
      return this._raterId;
    }
  }

  public string EntityName
  {
    get => $"Policy: {this.PolicyNumber} / {this.NamedInsured} / Control: {this.ControlNumber}";
  }

  public string StateID
  {
    get
    {
      if (this._stateId == null || this._stateId.Length == 0)
        this._stateId = this.Quote.StateID;
      return this._stateId;
    }
  }

  public int ChargeCode
  {
    get
    {
      if (this._chargeCode == -1)
        this._chargeCode = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT ChargeCode FROM tblFin_PolicyCharges WHERE ChargeType ='P' AND StateID = @StateID", new object[2]
        {
          (object) "@StateID",
          (object) this.StateID
        });
      return this._chargeCode;
    }
  }

  public virtual bool SupportsUnderwritingLocations => false;

  public virtual void SetModificationCodes(DataTable table)
  {
    this.SetModificationCodes(table, this.Quote.IsEndorsement);
  }

  private static void CheckRowState(DataRow row)
  {
    switch (row.RowState)
    {
      case DataRowState.Unchanged:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(row["ModificationCode"]), "N", false) != 0)
          break;
        row["ModificationCode"] = (object) "U";
        break;
      case DataRowState.Added:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(row["ModificationCode"]), "N", false) == 0)
          break;
        row["ModificationCode"] = (object) "N";
        break;
      case DataRowState.Deleted:
        row.RejectChanges();
        row["ModificationCode"] = (object) "D";
        break;
      case DataRowState.Modified:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(row["ModificationCode"]), "M", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(row["ModificationCode"]), "D", false) == 0)
          break;
        row["ModificationCode"] = (object) "M";
        break;
    }
  }

  public virtual void SetModificationCodes(DataTable table, bool isEndorsement)
  {
    if (table == null)
      throw new ArgumentNullException(nameof (table));
    if (!table.Columns.Contains("ModificationCode"))
      return;
    DataTable changes = table.GetChanges(DataRowState.Detached | DataRowState.Unchanged | DataRowState.Added | DataRowState.Deleted | DataRowState.Modified);
    if (changes == null)
      return;
    if (changes.Rows.Count <= 0)
      return;
    try
    {
      foreach (DataRow row in table.Rows)
      {
        if (isEndorsement)
          RaterBase.CheckRowState(row);
        else if (row.RowState != DataRowState.Deleted && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(row["ModificationCode"]), "N", false) != 0)
          row["ModificationCode"] = (object) "N";
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public virtual void SetModificationCodes(DataSet ds)
  {
    this.SetModificationCodes(ds, this.Quote.IsEndorsement);
  }

  public virtual void SetModificationCodes(DataSet ds, bool isEndorsement)
  {
    if (ds == null)
      throw new ArgumentNullException(nameof (ds));
    if (!ds.HasChanges())
      return;
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) ds.Tables)
        this.SetModificationCodes(table, isEndorsement);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public void DeletePremium(Guid quoteOptionGuid)
  {
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, new EventHandler<ExecuteTransactionEventArgs>(this.DeleteOptionPremiumTransaction), (object) quoteOptionGuid);
  }

  public void DeletePremium(Guid quoteOptionGuid, int chargeCode, int officeId)
  {
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, new EventHandler<ExecuteTransactionEventArgs>(this.DeletePremiumTransaction), (object) new object[3]
    {
      (object) quoteOptionGuid,
      (object) chargeCode,
      (object) officeId
    });
  }

  private void DeleteOptionPremiumTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    Guid context = (Guid) e.Context;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPolicyCommissions WHERE PremiumID IN (SELECT PremiumID FROM tblQuoteOptionPremiums WITH(NOLOCK) WHERE QuoteOptionGuid = @QuoteOptionGuid)", new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) context
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteOptionPremiums WHERE QuoteOptionGuid = @QuoteOptionGuid", new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) context
    });
    e.Transaction.Commit();
  }

  private void DeletePremiumTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    object[] context = (object[]) e.Context;
    Guid guid = (Guid) context[0];
    int num1 = (int) context[1];
    int num2 = (int) context[2];
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPolicyCommissions WHERE PremiumID IN (SELECT PremiumID FROM tblQuoteOptionPremiums WITH(NOLOCK) WHERE QuoteOptionGuid = @QuoteOptionGuid AND ChargeCode = @ChargeCode AND OfficeID = @OfficeID)", new object[6]
    {
      (object) "@QuoteOptionGuid",
      (object) guid,
      (object) "@ChargeCode",
      (object) num1,
      (object) "@OfficeID",
      (object) num2
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteOptionPremiums WHERE QuoteOptionGuid = @QuoteOptionGuid AND ChargeCode = @ChargeCode AND OfficeID = @OfficeID", new object[6]
    {
      (object) "@QuoteOptionGuid",
      (object) guid,
      (object) "@ChargeCode",
      (object) num1,
      (object) "@OfficeID",
      (object) num2
    });
    e.Transaction.Commit();
  }

  public void UpdatePremiumBasic(Guid quoteOptionGuid, Decimal premium, int chargeCode)
  {
    this.UpdatePremiumBasic(quoteOptionGuid, premium, chargeCode, -1);
  }

  public void UpdatePremiumBasic(
    Guid quoteOptionGuid,
    Decimal premium,
    int chargeCode,
    int officeId)
  {
    QuoteOption qo = new QuoteOption(quoteOptionGuid);
    Decimal premiumWithCents = qo.PremiumWithCents;
    DefaultDatabase.ExecuteNonQuery(nameof (UpdatePremiumBasic), new object[8]
    {
      (object) "@QuoteOptionGuid",
      (object) quoteOptionGuid,
      (object) "@Premium",
      (object) premium,
      (object) "@ChargeCode",
      (object) chargeCode,
      (object) "@OfficeID",
      (object) officeId
    });
    this.AfterPremiumUpdate(qo, premiumWithCents, qo.PremiumWithCents);
  }

  public void UpdatePremium(Guid qoGuid, Decimal premium)
  {
    QuoteOption qo = new QuoteOption(qoGuid);
    Decimal premiumWithCents = qo.PremiumWithCents;
    DefaultDatabase.ExecuteNonQuery(nameof (UpdatePremium), new object[4]
    {
      (object) "@QuoteOptionGuid",
      (object) qoGuid,
      (object) "@Premium",
      (object) premium
    });
    this.AfterPremiumUpdate(qo, premiumWithCents, qo.PremiumWithCents);
  }

  public void UpdatePremium(Guid qoGuid, Decimal premium, Decimal proRataPremium)
  {
    QuoteOption qo = new QuoteOption(qoGuid);
    Decimal premiumWithCents = qo.PremiumWithCents;
    DefaultDatabase.ExecuteNonQuery(nameof (UpdatePremium), new object[6]
    {
      (object) "@QuoteOptionGuid",
      (object) qoGuid,
      (object) "@Premium",
      (object) premium,
      (object) "@ProrataPremium",
      (object) proRataPremium
    });
    this.AfterPremiumUpdate(qo, premiumWithCents, qo.PremiumWithCents);
  }

  public void UpdatePremium(Guid qoGuid, Decimal premium, int officeId, int chargeCode)
  {
    QuoteOption qo = new QuoteOption(qoGuid);
    Decimal premiumWithCents = qo.PremiumWithCents;
    DefaultDatabase.ExecuteNonQuery(nameof (UpdatePremium), new object[8]
    {
      (object) "@QuoteOptionGuid",
      (object) qoGuid,
      (object) "@Premium",
      (object) premium,
      (object) "@OfficeID",
      (object) officeId,
      (object) "@ChargeCode",
      (object) chargeCode
    });
    this.AfterPremiumUpdate(qo, premiumWithCents, qo.PremiumWithCents);
  }

  public void UpdatePremium(
    Guid qoGuid,
    Decimal premium,
    Decimal proRataPremium,
    int officeId,
    int chargeCode)
  {
    QuoteOption qo = new QuoteOption(qoGuid);
    Decimal premiumWithCents = qo.PremiumWithCents;
    DefaultDatabase.ExecuteNonQuery(nameof (UpdatePremium), new object[10]
    {
      (object) "@QuoteOptionGuid",
      (object) qoGuid,
      (object) "@Premium",
      (object) premium,
      (object) "@ProrataPremium",
      (object) proRataPremium,
      (object) "@OfficeID",
      (object) officeId,
      (object) "@ChargeCode",
      (object) chargeCode
    });
    this.AfterPremiumUpdate(qo, premiumWithCents, qo.PremiumWithCents);
  }

  public void UpdatePremium(Guid qoGuid, Decimal premium, int chargeCode)
  {
    QuoteOption qo = new QuoteOption(qoGuid);
    Decimal premiumWithCents = qo.PremiumWithCents;
    DefaultDatabase.ExecuteNonQuery(nameof (UpdatePremium), new object[6]
    {
      (object) "@QuoteOptionGuid",
      (object) qoGuid,
      (object) "@Premium",
      (object) premium,
      (object) "@ChargeCode",
      (object) chargeCode
    });
    this.AfterPremiumUpdate(qo, premiumWithCents, qo.PremiumWithCents);
  }

  public void UpdatePremium(Guid qoGuid, Decimal premium, Decimal proRataPremium, int chargeCode)
  {
    QuoteOption qo = new QuoteOption(qoGuid);
    Decimal premiumWithCents = qo.PremiumWithCents;
    DefaultDatabase.ExecuteNonQuery(nameof (UpdatePremium), new object[8]
    {
      (object) "@QuoteOptionGuid",
      (object) qoGuid,
      (object) "@Premium",
      (object) premium,
      (object) "@ProrataPremium",
      (object) proRataPremium,
      (object) "@ChargeCode",
      (object) chargeCode
    });
    this.AfterPremiumUpdate(qo, premiumWithCents, qo.PremiumWithCents);
  }

  private void AfterPremiumUpdate(QuoteOption qo, Decimal priorPremium, Decimal newPremium)
  {
    RaterBase.LogPremiumChanges(qo, priorPremium, Convert.ToDouble(qo.PremiumWithCents));
    Messaging.SendBroadcastMessage(BroadcastMessages.PremiumChanged, (object) new object[2]
    {
      (object) qo.QuoteGuid,
      (object) newPremium
    });
  }

  public static void LogPremiumChanges(QuoteOption qo, Decimal priorPremium, double newPremium)
  {
    if (Decimal.Compare(priorPremium, qo.PremiumWithCents) == 0)
      return;
    CurrentUser.Instance.LogAction($"Control # {qo.Quote.ControlNo}. Change Premium from {priorPremium:c} to {qo.PremiumWithCents:c}", qo.QuoteGuid);
  }

  public static void LogPremiumChanges(
    QuoteOption qo,
    Decimal priorPremium,
    double newPremium,
    string carrierName)
  {
    if (Decimal.Compare(priorPremium, qo.PremiumWithCents) == 0)
      return;
    CurrentUser.Instance.LogAction($"Control # {qo.Quote.ControlNo}. Change Premium from {priorPremium:c} to {qo.PremiumWithCents:c} on {carrierName}", qo.QuoteGuid);
  }

  public virtual void PreBind()
  {
  }

  public virtual void DoNonUIWork()
  {
  }

  public virtual void OnRateOption(Guid quoteOptionGuid)
  {
  }

  public void OptionDeleted(Guid quoteOptionGuid) => this.RaiseOptionRated(quoteOptionGuid);

  public void RateOption(Guid quoteOptionGuid)
  {
    RaterBase raterBase = this;
    Guid quoteOptionGuid1 = quoteOptionGuid;
    Cursor.Current = MgaCursors.WaitCursor;
    this.ResetPolicyForms(this.Quote);
    if (DefaultDatabase.HasTransaction)
      this.OnRateOption(quoteOptionGuid1);
    else
      DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, (EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, etea) =>
      {
        raterBase.OnRateOption(quoteOptionGuid1);
        etea.Transaction.Commit();
      }));
    this.OnOptionRated(quoteOptionGuid1);
    Quote quote = this.Quote;
    this.Settings?.ProcessFilingProducers(quote);
    if (this is IRaterExtendedData iExtended)
    {
      this.SetRaterExtendedData(quoteOptionGuid1, iExtended);
      this.SetVehicleCount(quoteOptionGuid1, iExtended);
    }
    quote.AutoApplyFees(quoteOptionGuid1);
    Cursor.Current = MgaCursors.Default;
    this.RaiseOptionRated(quoteOptionGuid1);
  }

  protected virtual void OnOptionRated(Guid quoteOptionGuid)
  {
  }

  protected void RaiseOptionRated(Guid quoteOptionGuid)
  {
    this.RaiseOptionRated(new OptionRatedEventArgs(quoteOptionGuid));
  }

  protected void RaiseOptionRated(OptionRatedEventArgs optRatedArgs)
  {
    // ISSUE: reference to a compiler-generated field
    OptionRatedEventHandler optionRatedEvent = this.OptionRatedEvent;
    if (optionRatedEvent == null)
      return;
    optionRatedEvent((object) this, optRatedArgs);
  }

  private void SetRaterExtendedData(Guid quoteOptionGuid, IRaterExtendedData iExtended)
  {
    if (iExtended == null)
      throw new InvalidOperationException("In SetRaterExtendedData(...) Rater must implement IRaterExtendedData");
    iExtended.SetRaterExtendedData(quoteOptionGuid);
  }

  private void SetVehicleCount(Guid quoteOptionGuid, IRaterExtendedData iExtended)
  {
    VehicleStateCount[] vehicleStateCountArray = iExtended != null ? iExtended.GetVehicleCount(quoteOptionGuid) : throw new InvalidOperationException("In SetVehicleCount(...) Rater must implement IRaterExtendedData");
    int index = 0;
    while (index < vehicleStateCountArray.Length)
    {
      VehicleStateCount vehicleStateCount = vehicleStateCountArray[index];
      DefaultDatabase.ExecuteNonQuery("spSetRaterVehicleCount", new object[6]
      {
        (object) "@QuoteOptionGuid",
        (object) quoteOptionGuid,
        (object) "@VehicleCount",
        (object) vehicleStateCount.VehicleCount,
        (object) "@StateID",
        (object) vehicleStateCount.StateID
      });
      checked { ++index; }
    }
  }

  protected virtual bool ClientResetPolicyForms => false;

  protected virtual string RaterConditionalCountsProcedure => "dbo.spRaterConditionalFormsCount";

  protected void ResetPolicyForms(Quote q)
  {
    Lazy<int> lazy = new Lazy<int>((Func<int>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int>(this.RaterConditionalCountsProcedure, new object[4]
    {
      (object) "@raterID",
      (object) this.RaterID,
      (object) "@quoteGuid",
      (object) this.Quote.QuoteGuid
    })));
    if (!this.ClientResetPolicyForms && lazy.Value <= 0)
      return;
    q.ResetPolicyForms();
  }

  public void CopyQuoteData(Guid originalQuoteGuid, Guid newQuoteGuid, SqlTransaction t)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    RaterBase._Closure\u0024__96\u002D0 closure960 = new RaterBase._Closure\u0024__96\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure960.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure960.\u0024VB\u0024Local_originalQuoteGuid = originalQuoteGuid;
    // ISSUE: reference to a compiler-generated field
    closure960.\u0024VB\u0024Local_newQuoteGuid = newQuoteGuid;
    // ISSUE: reference to a compiler-generated field
    closure960.\u0024VB\u0024Local_t = t;
    if (!DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      if (closure960.\u0024VB\u0024Local_t == null)
        throw new ArgumentNullException(nameof (t), "SqlTransaction Required");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure960.\u0024VB\u0024Local_t, new ExecuteHandler((object) closure960, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      using (SqlCommand cmd = new SqlCommand(string.Empty, closure960.\u0024VB\u0024Local_t.Connection))
      {
        // ISSUE: reference to a compiler-generated field
        cmd.Transaction = closure960.\u0024VB\u0024Local_t;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.OnCopyQuoteData(cmd, new OnCopyQuoteDataArgs(closure960.\u0024VB\u0024Local_originalQuoteGuid, closure960.\u0024VB\u0024Local_newQuoteGuid));
      }
    }
  }

  public void CopyBoundOptions(Guid originalQuoteGuid, Guid newQuoteGuid, SqlTransaction t)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    RaterBase._Closure\u0024__97\u002D0 closure970 = new RaterBase._Closure\u0024__97\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure970.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure970.\u0024VB\u0024Local_originalQuoteGuid = originalQuoteGuid;
    // ISSUE: reference to a compiler-generated field
    closure970.\u0024VB\u0024Local_newQuoteGuid = newQuoteGuid;
    // ISSUE: reference to a compiler-generated field
    closure970.\u0024VB\u0024Local_t = t;
    if (!DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      if (closure970.\u0024VB\u0024Local_t == null)
        throw new ArgumentNullException(nameof (t), "SqlTransaction Required");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure970.\u0024VB\u0024Local_t, new ExecuteHandler((object) closure970, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      if (this.RaterID == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      Quote quote = new Quote(closure970.\u0024VB\u0024Local_originalQuoteGuid);
      // ISSUE: reference to a compiler-generated field
      if (quote.HasBoundOptions(closure970.\u0024VB\u0024Local_t))
      {
        Guid[] guidArray = !quote.IsPackagePolicy || !MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("CopyBoundOptions.PackagePolicy.ExcludeLineGuidFilter", false) ? quote.GetBoundOptionGuids(this.LineGuid) : quote.GetBoundOptionGuids();
        if (guidArray.Length > 1 && !quote.IsMultiCompanyPolicy && !quote.IsPackagePolicy)
          throw new InvalidOperationException("Too many bound options detected for one or more lines.");
        if (guidArray.Length <= 0)
          return;
        // ISSUE: reference to a compiler-generated field
        DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TOP 1 QuoteOptionGuid, QuoteOptionID FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
        {
          (object) "@QuoteGuid",
          (object) closure970.\u0024VB\u0024Local_newQuoteGuid
        });
        if (row == null || row.IsNull(0) || row.IsNull(1))
          return;
        Guid newOptionGuid = row.Field<Guid>(0);
        int newOptionId = row.Field<int>(1);
        // ISSUE: reference to a compiler-generated field
        using (SqlCommand cmd = new SqlCommand(string.Empty, closure970.\u0024VB\u0024Local_t.Connection))
        {
          // ISSUE: reference to a compiler-generated field
          cmd.Transaction = closure970.\u0024VB\u0024Local_t;
          // ISSUE: reference to a compiler-generated field
          cmd.Parameters.AddWithValue("@QuoteGuid", (object) closure970.\u0024VB\u0024Local_newQuoteGuid);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          this.OnCopyBoundOption(cmd, new OnCopyBoundOptionArgs(closure970.\u0024VB\u0024Local_originalQuoteGuid, guidArray[0], closure970.\u0024VB\u0024Local_newQuoteGuid, newOptionGuid, newOptionId));
        }
      }
      else if (quote.PolicyType != PolicyTypes.BrokerOnRecord && !quote.IsNonMonetaryEndorsement)
        throw new RaterNoBoundOptionException();
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public virtual void ShowUI()
  {
    if (!this.HasUI)
      throw new InvalidOperationException("This rater has no UI, please check the HASUI property before attempting to show the UI");
  }

  public void Initialize(Guid quoteGuid, Guid companyLineGuid)
  {
    this._quote = (Quote) null;
    this._quoteGuid = quoteGuid;
    this._lineGuid = new CompanyLine(companyLineGuid).LineGuid;
    this.dbConditions = (DatabaseRaterElements) null;
    this.OnInitializeState();
  }

  public void Initialize(Quote quote, Guid companyLineGuid)
  {
    this._quote = quote;
    this._quoteGuid = quote.QuoteGuid;
    this._lineGuid = new CompanyLine(companyLineGuid).LineGuid;
    this.dbConditions = (DatabaseRaterElements) null;
    this.OnInitializeState();
  }

  public void CalculateAllOptions()
  {
    if (this.Quote.IsBound)
      return;
    DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(this.CalculateOptions_QuerySet));
  }

  private void CalculateOptions_QuerySet(object sender, ExecuteTransactionEventArgs e)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid FROM tblQuoteOptions WHERE QuoteGUID = @QuoteGUID", new object[2]
    {
      (object) "@QuoteGUID",
      (object) this._quoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this.RateOption(row.Field<Guid>("QuoteOptionGuid"));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    e.Transaction.Commit();
  }

  public virtual void Refresh()
  {
  }

  public void InitializeQuoteOptionsRow(DataRow row)
  {
    if (row == null)
      throw new ArgumentNullException(nameof (row));
    row["DateCreated"] = (object) DateAndTime.Now;
    row["Bound"] = (object) false;
    row["Quote"] = (object) false;
    row["QuoteGuid"] = (object) this.QuoteGuid;
    row["QuoteOptionGuid"] = (object) Guid.NewGuid();
    row["Premium"] = (object) 0;
    row["LineGuid"] = (object) this.LineGuid;
  }

  public static void RefreshMiscPremiums(int quoteOptionId)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spRefreshMiscPremiums", new object[2]
    {
      (object) "@quoteOptionID",
      (object) quoteOptionId
    });
  }

  private void InitReflectionInfo()
  {
    if (this._reflectionInfoInitialized)
      return;
    RaterInformationAttribute attribute = (RaterInformationAttribute) TypeDescriptor.GetAttributes(this.GetType())[typeof (RaterInformationAttribute)];
    if (attribute != null)
    {
      this._raterId = attribute.RaterID;
      this._raterName = attribute.RaterName;
      this._reflectionInfoInitialized = true;
    }
    else if (!this.ManualInitReflectionInfo(ref this._raterId, ref this._raterName))
      throw new InvalidOperationException("You must use the RaterInformationAttribute on this rater!");
  }

  protected virtual bool ManualInitReflectionInfo(ref int raterId, ref string raterName) => false;

  public bool EvaluateEndorsementRowForModification(
    DataRow currentRow,
    DataRow previousRow,
    params string[] columnsToCheck)
  {
    return this.EvaluateEndorsementRowForModification(currentRow, previousRow, (RaterBase.EndorsementChangeFoundhandler) null, columnsToCheck);
  }

  public bool EvaluateEndorsementRowForModification(
    DataRow currentRow,
    DataRow previousRow,
    RaterBase.EndorsementChangeFoundhandler changefoundHandler,
    params string[] columnsToCheck)
  {
    if (currentRow == null)
      throw new InvalidOperationException("Must have a current row in order to process endorsement for exposure.");
    if (previousRow == null)
      throw new InvalidOperationException("Must have a previous row in order to process endorsement for exposure.");
    if (!currentRow.Table.Columns.Contains("ModificationCode") || !previousRow.Table.Columns.Contains("ModificationCode"))
      throw new InvalidOperationException("Both rows to be compared must contain the field ModificationCode");
    string[] strArray = columnsToCheck;
    int index = 0;
    while (index < strArray.Length)
    {
      string str = strArray[index];
      if (!currentRow.Table.Columns.Contains(str) || !previousRow.Table.Columns.Contains(str))
        throw new InvalidOperationException($"Both rows must contain the column {str} in order to be compared");
      if (!currentRow[str].Equals(RuntimeHelpers.GetObjectValue(previousRow[str])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(currentRow["ModificationCode"]), "M", false) != 0)
      {
        currentRow["ModificationCode"] = (object) "M";
        if (changefoundHandler != null)
        {
          EndorsementChangeFoundArgs e = new EndorsementChangeFoundArgs(RaterBase.ModificationCode.Modified, currentRow, previousRow);
          changefoundHandler((object) this, e);
        }
      }
      checked { ++index; }
    }
    currentRow["ModificationCode"] = (object) "U";
    return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(currentRow["ModificationCode"]), "U", false) != 0;
  }

  [Obsolete("Do not use the cmd object. Use DefaultDatabase instead, as we have already enlisted in the transaction at this point.")]
  protected virtual void OnCopyQuoteData(SqlCommand cmd, OnCopyQuoteDataArgs e)
  {
  }

  [Obsolete("Do not use the cmd object. Use DefaultDatabase instead, as we have already enlisted in the transaction at this point.")]
  protected virtual void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
    throw new RaterOnCopyBoundOptionNotImplementedException();
  }

  protected void OnUIClosed()
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler uiClosedEvent = this.UIClosedEvent;
    if (uiClosedEvent == null)
      return;
    uiClosedEvent((object) this, EventArgs.Empty);
  }

  protected virtual void OnInitializeState()
  {
  }

  public event OptionRatedEventHandler OptionRated;

  protected virtual void Dispose(bool disposing)
  {
    if (!this.disposedValue)
    {
      int num = disposing ? 1 : 0;
    }
    this.disposedValue = true;
  }

  virtual void IDisposable.Dispose()
  {
    this.Dispose(true);
    GC.SuppressFinalize((object) this);
  }

  public List<RaterConditionalElement> BaseRaterConditionalElements(string LineCode)
  {
    if (this.dbConditions == null)
      this.dbConditions = new DatabaseRaterElements(this.RaterID, LineCode);
    try
    {
      List<RaterConditionalElement> conditionalElementList = this.RaterConditionalElements(LineCode);
      if (conditionalElementList != null)
      {
        try
        {
          foreach (RaterConditionalElement condition in conditionalElementList)
            this.dbConditions.Add(condition);
        }
        finally
        {
          List<RaterConditionalElement>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      ex2.Data.Add((object) "Rater", (object) this.GetType().FullName);
      ex2.Data.Add((object) nameof (LineCode), (object) LineCode);
      ex2.Data.Add((object) "LineGUID", (object) this._lineGuid.ToString());
      ex2.Data.Add((object) "QuoteGUID", (object) this._quoteGuid.ToString());
      ErrorHandler.SilentHandleError(ex2);
      ProjectData.ClearProjectError();
    }
    return this.dbConditions?.ConditionalElements;
  }

  public virtual List<RaterConditionalElement> RaterConditionalElements(string LineCode)
  {
    return (List<RaterConditionalElement>) null;
  }

  public bool BaseDoesConditionApply(
    int conditionalID,
    ConditionalOperators conditions,
    object amount)
  {
    RaterConditionalElement condition = this.FindCondition(conditionalID);
    bool flag;
    try
    {
      flag = condition == null || !condition.IsDatabaseConditional ? this.DoesConditionApply(conditionalID, conditions, RuntimeHelpers.GetObjectValue(amount)) : this.DatabaseConditionApplies((DatabaseConditionalElement) condition, conditions, RuntimeHelpers.GetObjectValue(amount));
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      ex2.Data.Add((object) "RaterID", (object) this.RaterID);
      ex2.Data.Add((object) "ConditionalID", (object) conditionalID);
      ex2.Data.Add((object) "Conditions", (object) conditions);
      ex2.Data.Add((object) "Amount", RuntimeHelpers.GetObjectValue(amount));
      ErrorHandler.SilentLogError(ex2);
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public virtual bool DatabaseConditionApplies(
    DatabaseConditionalElement dbElement,
    ConditionalOperators conditions,
    object amount)
  {
    bool flag;
    if (dbElement != null)
    {
      if (!string.IsNullOrEmpty(dbElement.StoredProcedure))
      {
        try
        {
          flag = DefaultDatabase.ExecuteScalar<bool>(dbElement.StoredProcedure, new object[8]
          {
            (object) "@QuoteGuid",
            (object) this.QuoteGuid,
            (object) "@ConditionalID",
            (object) dbElement.ConditionalID,
            (object) "@Conditions",
            (object) conditions,
            (object) "@Amount",
            amount
          });
          goto label_6;
        }
        catch (Exception ex1)
        {
          ProjectData.SetProjectError(ex1);
          Exception ex2 = ex1;
          ex2.Data.Add((object) "StoredProcedure", (object) dbElement.StoredProcedure);
          ex2.Data.Add((object) "RaterID", (object) dbElement.RaterID);
          ex2.Data.Add((object) "Condition", (object) dbElement.Condition);
          ex2.Data.Add((object) "ConditionalID", (object) dbElement.ConditionalID);
          ex2.Data.Add((object) "ConditionCompare", (object) conditions.ToString());
          ex2.Data.Add((object) "Amount", (object) amount.ToString());
          ErrorHandler.SilentHandleError(ex2);
          ProjectData.ClearProjectError();
        }
        flag = false;
        goto label_6;
      }
    }
    flag = false;
label_6:
    return flag;
  }

  public virtual bool DoesConditionApply(
    int conditionalID,
    ConditionalOperators conditions,
    object amount)
  {
    return false;
  }

  public virtual RaterConditionalElement FindCondition(int ConditionalID)
  {
    return this.dbConditions?.Find(ConditionalID);
  }

  public virtual CreateEndorsementOptions GetCreateEndorsementOptions()
  {
    return new CreateEndorsementOptions();
  }

  private class ModificationCodes
  {
    internal const string ColumnName = "ModificationCode";
    internal const string New = "N";
    internal const string Modified = "M";
    internal const string Deleted = "D";
    internal const string Unchanged = "U";

    private ModificationCodes()
    {
    }
  }

  public delegate void EndorsementChangeFoundhandler(object sender, EndorsementChangeFoundArgs e);

  public enum ModificationCode
  {
    Deleted,
    Modified,
    New,
    Unchanged,
  }
}
