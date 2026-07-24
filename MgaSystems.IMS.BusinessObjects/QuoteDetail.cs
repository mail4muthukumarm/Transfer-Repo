// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.QuoteDetail
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblQuoteDetails")]
public class QuoteDetail : BaseDataObject
{
  private int _quoteDetailId;
  private Quote _quote;
  private CompanyLine _companyLine;

  public QuoteDetail(int quoteDetailIid) => this.QuoteDetailID = quoteDetailIid;

  public QuoteDetail(Guid quoteGuid, Guid companyLineGuid)
  {
    this.QuoteDetailID = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT QuoteDetailID FROM dbo.tblQuoteDetails WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid AND CompanyLineGuid=@CompanyLineGuid", new object[4]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@CompanyLineGuid",
      (object) companyLineGuid
    }) ?? -1;
    if (this.QuoteDetailID == -1)
      throw new InvalidOperationException("Specified QuoteDetail record not found");
  }

  [DataKey]
  public int QuoteDetailID
  {
    get => this._quoteDetailId;
    set
    {
      this._quoteDetailId = this._quoteDetailId <= 0 ? value : throw new InvalidOperationException($"Specified QuoteDetail {this._quoteDetailId} has already been initialized");
    }
  }

  [TableFieldMapping]
  public Guid QuoteGuid => this.GetField<Guid>(nameof (QuoteGuid), nameof (QuoteGuid));

  public Quote Quote
  {
    get
    {
      if (this._quote == null)
        this._quote = ObjectFactory.Instance.CreateObjectAs<Quote>((object) this.QuoteGuid);
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
  public Guid CompanyLineGuid
  {
    get => this.GetField<Guid>(nameof (CompanyLineGuid), nameof (CompanyLineGuid));
  }

  public CompanyLine CompanyLine
  {
    get
    {
      if (this._companyLine == null)
        this._companyLine = ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) this.CompanyLineGuid);
      return this._companyLine;
    }
  }

  public bool UsingNetRate
  {
    get
    {
      int? raterId;
      return ((raterId = this.RaterID).HasValue ? raterId.GetValueOrDefault() : -1) == 100;
    }
  }

  [TableFieldMapping]
  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Setting value makes DB calls, and results of those calls are irrelevant.")]
  public int? RaterID
  {
    get => this.GetField<int?>(nameof (RaterID), nameof (RaterID));
    set
    {
      if (this.ObjectDataStore == null)
        this.RefreshData();
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteDetails SET RaterID=@RaterID WHERE QuoteDetailID = @QDID", new object[4]
      {
        (object) "@QDID",
        (object) this.QuoteDetailID,
        (object) "@RaterID",
        (object) value
      });
      this.ObjectDataStore.SetField<int?>(nameof (RaterID), value);
    }
  }

  [TableFieldMapping]
  public int? PolicyNumberRuleID
  {
    get
    {
      short? field = this.GetField<short?>(nameof (PolicyNumberRuleID), nameof (PolicyNumberRuleID));
      return !field.HasValue ? new int?() : new int?((int) field.GetValueOrDefault());
    }
  }

  public int? CalculatedPolicyNumberRuleID
  {
    get
    {
      return this.CacheManualValue<int?>(nameof (CalculatedPolicyNumberRuleID), (Func<int?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int?>("dbo.GetPolicyNumberRule", new object[4]
      {
        (object) "@quoteGuid",
        (object) this.QuoteGuid,
        (object) "@companyLineGuid",
        (object) this.CompanyLineGuid
      })));
    }
  }

  public int? ResolvedPolicyNumberRuleID
  {
    get
    {
      int? policyNumberRuleId;
      return !(policyNumberRuleId = this.PolicyNumberRuleID).HasValue ? this.CalculatedPolicyNumberRuleID : policyNumberRuleId;
    }
  }

  public bool IsPolicyRuleAssigned() => this.DetailIsManualPolicyNumberEntry;

  public bool IsRaterAssigned() => this.RaterID.HasValue;

  public bool HasPolicyNumberRule => this.PolicyNumberRuleID.HasValue;

  public bool DetailIsManualPolicyNumberEntry
  {
    get
    {
      return this.GetLazyField<bool>(nameof (DetailIsManualPolicyNumberEntry), $"dbo.IsPolicyRuleAssigned({"QuoteGuid"}, {"CompanyLineGuid"})");
    }
  }

  public bool IsManualPolicyNumberEntry()
  {
    return this.CacheManualValue<bool>(nameof (IsManualPolicyNumberEntry), (Func<bool>) ([SpecialName] () => this.IsManualPolicyNumberEntry(this.ResolvedPolicyNumberRuleID)));
  }

  public bool IsManualPolicyNumberEntry(int? RuleID)
  {
    bool flag;
    if (RuleID.HasValue)
      flag = DefaultDatabase.ExecuteScalar<bool?>(CommandType.Text, "SELECT Manual FROM dbo.tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @RuleID", new object[2]
      {
        (object) "@RuleID",
        (object) RuleID
      }) ?? true;
    else
      flag = this.DetailIsManualPolicyNumberEntry;
    return flag;
  }

  [TableFieldMapping]
  public string PolicyNumber => this.GetField<string>(nameof (PolicyNumber), nameof (PolicyNumber));
}
