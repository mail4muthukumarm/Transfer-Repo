// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.QuoteOption
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblQuoteOptions")]
public class QuoteOption : BaseDataObject, IQuoteOption
{
  private Guid _quoteOptionGuid;
  private Quote _quote;
  private static readonly Dictionary<int, Guid> _quoteOptionIDToGuidCache = new Dictionary<int, Guid>();

  public QuoteOption(int quoteOptionID)
  {
    Dictionary<int, Guid> optionIdToGuidCache = QuoteOption._quoteOptionIDToGuidCache;
    int key = quoteOptionID;
    Guid quoteOptionGuid = this.QuoteOptionGuid;
    ref Guid local = ref quoteOptionGuid;
    int num = optionIdToGuidCache.TryGetValue(key, out local) ? 1 : 0;
    this.QuoteOptionGuid = quoteOptionGuid;
    if (num != 0)
      return;
    this.QuoteOptionGuid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT QuoteOptionGuid FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteOptionID=@QuoteOptionID", new object[2]
    {
      (object) "@QuoteOptionID",
      (object) quoteOptionID
    }) ?? Guid.Empty;
    QuoteOption._quoteOptionIDToGuidCache[quoteOptionID] = !this.QuoteOptionGuid.Equals(Guid.Empty) ? this.QuoteOptionGuid : throw new QuoteOptionIDNotFoundException(quoteOptionID);
  }

  public QuoteOption(Guid quoteOptionGuid) => this.QuoteOptionGuid = quoteOptionGuid;

  public QuoteOption(Guid quoteOptionGuid, Quote quote)
    : this(quoteOptionGuid)
  {
    this._quote = quote;
  }

  [DataKey]
  public Guid QuoteOptionGuid
  {
    get => this._quoteOptionGuid;
    set
    {
      this._quoteOptionGuid = this._quoteOptionGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified QuoteOption {this._quoteOptionGuid} has already been initialized");
    }
  }

  public Guid CompanyLineGuid
  {
    get
    {
      return this.GetLazyField<Guid>(nameof (CompanyLineGuid), "dbo.GetQuoteOptionCompanyLineGuid(QuoteOptionID)");
    }
  }

  [TableFieldMapping]
  public int CompanyInstallmentID
  {
    get => this.GetField<int?>(nameof (CompanyInstallmentID), nameof (CompanyInstallmentID)) ?? -1;
  }

  public bool IsCompanyInstallmentIDNull => this.CompanyInstallmentID == -1;

  [TableFieldMapping]
  public int Premium => Convert.ToInt32(this.PremiumWithCents);

  public Decimal PremiumWithCents => this.GetField<Decimal>("Premium", nameof (PremiumWithCents));

  [TableFieldMapping]
  public Decimal TotalFees => this.GetField<Decimal>(nameof (TotalFees), nameof (TotalFees));

  public Quote Quote
  {
    get
    {
      if (this._quote == null)
        this._quote = Quote.CreateNew(this.QuoteGuid);
      return this._quote;
    }
    set
    {
      if (value == null || !this.QuoteGuid.Equals(value.QuoteGuid))
        return;
      this._quote = value;
    }
  }

  [TableFieldMapping]
  public Guid QuoteGuid => this.GetField<Guid>(nameof (QuoteGuid), nameof (QuoteGuid));

  [TableFieldMapping]
  public int QuoteOptionID => this.GetField<int>(nameof (QuoteOptionID), nameof (QuoteOptionID));

  [TableFieldMapping]
  public Guid LineGuid => this.GetField<Guid>(nameof (LineGuid), nameof (LineGuid));

  public bool HasPreviousQuoteOptionGuid => this.OriginalQuoteOptionGuid.HasValue;

  [TableFieldMapping]
  public Guid? OriginalQuoteOptionGuid
  {
    get => this.GetField<Guid?>(nameof (OriginalQuoteOptionGuid), nameof (OriginalQuoteOptionGuid));
  }

  public Guid PreviousQuoteOptionGuid => this.OriginalQuoteOptionGuid.Value;

  public int? RaterID
  {
    get => this.GetLazyField<int?>(nameof (RaterID), "dbo.GetRaterIDUsedOnOption(QuoteOptionGuid)");
  }

  [TableFieldMapping("Quote")]
  public bool Quoted
  {
    get => this.GetField<bool>("Quote", nameof (Quoted));
    set
    {
      if (this.Quote.IsTransactionBound)
        throw new InvalidOperationException("Specified Quote is already bound.");
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET Quote = @bool WHERE QuoteOptionGUID = @QOG", new object[4]
      {
        (object) "@bool",
        (object) value,
        (object) "@QOG",
        (object) this.QuoteOptionGuid
      });
      this.ObjectDataStore.SetField<bool>("Quote", value);
    }
  }

  [TableFieldMapping]
  public bool Bound
  {
    get => this.GetField<bool>(nameof (Bound), nameof (Bound));
    set
    {
      if (this.Quote.IsTransactionBound)
        throw new InvalidOperationException("Specified Quote is already bound.");
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET Bound = @bool WHERE QuoteOptionGUID = @QOG", new object[4]
      {
        (object) "@bool",
        (object) value,
        (object) "@QOG",
        (object) this.QuoteOptionGuid
      });
      this.ObjectDataStore.SetField<bool>(nameof (Bound), value);
    }
  }

  public void MarkAsBound() => this.Bound = true;

  public void Delete()
  {
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, new EventHandler<ExecuteTransactionEventArgs>(this.DeleteTransaction), (object) this.QuoteOptionGuid);
    this.ObjectDataStore = (DataRow) null;
  }

  private void DeleteTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spDeleteQuoteOption", new object[2]
    {
      (object) "@quoteOptionGuid",
      e.Context
    });
    e.Transaction.Commit();
  }

  public Decimal CalculateFactor(EndorsementCalcTypes calcType, DateTime effectiveDate)
  {
    string str;
    switch (calcType)
    {
      case EndorsementCalcTypes.ProRata:
        str = "P";
        break;
      case EndorsementCalcTypes.ShortRate:
        str = "S";
        break;
      case EndorsementCalcTypes.Flat:
        str = "F";
        break;
      case EndorsementCalcTypes.MinimumEarned:
        str = "M";
        break;
      default:
        throw new InvalidOperationException($"Unexpected {nameof (calcType)}");
    }
    return DefaultDatabase.ExecuteScalar<Decimal>(MGASystems.Common.Settings.SystemSettings.GetSetting<string>("Rating.CalculateFactorStoredProc", "dbo.CalculateQuoteProRata_Wrapper"), new object[6]
    {
      (object) "@quoteGuid",
      (object) this.QuoteGuid,
      (object) "@precision",
      (object) 4,
      (object) "@endorsementCalculationType",
      (object) str
    });
  }

  public virtual void SetupDefaultInstallmentBilling()
  {
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, new EventHandler<ExecuteTransactionEventArgs>(this.SetupDefaultInstallmentBillingTransaction), (object) this.QuoteOptionID);
  }

  private void SetupDefaultInstallmentBillingTransaction(
    object sender,
    ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.SetupDefaultInstallmentBilling", new object[2]
    {
      (object) "@quoteOptionID",
      e.Context
    });
    e.Transaction.Commit();
  }

  public virtual void AutoApplyCommissions()
  {
    DataTable dataTable1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT PremiumID FROM tblQuoteOptionPremiums WHERE QuoteOptionGuid=@qog", new object[2]
    {
      (object) "@qog",
      (object) this.QuoteOptionGuid
    });
    try
    {
      foreach (DataRow row in dataTable1.Rows)
        this.AutoApplyPremiumCommissions((int) row[0]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT OptionFeeID FROM tblQuoteOptionCharges WHERE QuoteOptionGuid=@qog", new object[2]
    {
      (object) "@qog",
      (object) this.QuoteOptionGuid
    });
    try
    {
      foreach (DataRow row in dataTable2.Rows)
        this.AutoApplyFeeCommissions((int) row[0]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void AutoApplyFeeCommissions(int optionFeeID)
  {
    this.AutoApplyFeeCommissions(optionFeeID, (SqlTransaction) null);
  }

  private void AutoApplyFeeCommissions(int optionFeeID, SqlTransaction trans)
  {
    this.AutoApplyCommissions(optionFeeID, "F", trans);
  }

  private void AutoApplyPremiumCommissions(int premiumID)
  {
    this.AutoApplyPremiumCommissions(premiumID, (SqlTransaction) null);
  }

  private void AutoApplyPremiumCommissions(int premiumID, SqlTransaction trans)
  {
    this.AutoApplyCommissions(premiumID, "P", trans);
  }

  private void AutoApplyCommissions(int ID, string chargeType, SqlTransaction trans)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    QuoteOption._Closure\u0024__56\u002D0 closure560 = new QuoteOption._Closure\u0024__56\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure560.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure560.\u0024VB\u0024Local_ID = ID;
    // ISSUE: reference to a compiler-generated field
    closure560.\u0024VB\u0024Local_chargeType = chargeType;
    // ISSUE: reference to a compiler-generated field
    closure560.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    if (closure560.\u0024VB\u0024Local_trans != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure560.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure560, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      if (this.Quote.IsBound)
        return;
      // ISSUE: reference to a compiler-generated field
      string vbLocalChargeType = closure560.\u0024VB\u0024Local_chargeType;
      string str;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(vbLocalChargeType, "P", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(vbLocalChargeType, "F", false) != 0)
          throw new ArgumentException("ChargeType must be either F or P.");
        str = "@OptionFeeID";
      }
      else
        str = "@PremiumID";
      // ISSUE: reference to a compiler-generated field
      DefaultDatabase.ExecuteNonQuery(MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("AutoApplyCommissions_Stored_Proc", "dbo.spAutoApplyCommissions"), new object[4]
      {
        (object) "@QuoteOptionGuid",
        (object) this.QuoteOptionGuid,
        (object) str,
        (object) closure560.\u0024VB\u0024Local_ID
      });
    }
  }

  public static QuoteOption Create(Guid quoteGuid, Guid lineGuid)
  {
    return ObjectFactory.Instance.CreateObjectAs<QuoteOption>((object) Convert.ToInt32(DefaultDatabase.ExecuteScalar<Decimal>("dbo.spCreateQuoteOption", new object[4]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@LineGuid",
      (object) lineGuid
    })));
  }

  public static bool QuoteOptionExists(Guid quoteOptionGuid)
  {
    return Convert.ToBoolean(DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT 1 FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteOptionGuid = @QOG", new object[2]
    {
      (object) "@QOG",
      (object) quoteOptionGuid
    }) ?? 0);
  }
}
