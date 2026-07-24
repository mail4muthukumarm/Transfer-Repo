// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.ProducerLine
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblProducerLines")]
public class ProducerLine : BaseDataObject
{
  private readonly Guid _producerLocationGuid;
  private readonly DateTime _effective;
  private readonly Guid _companyLineGuid;
  private readonly Guid _quotingOfficeGuid;
  private int? _producerLineID;
  private static readonly Lazy<string> ProducerLineQuery = new Lazy<string>((Func<string>) ([SpecialName] () =>
  {
    Dictionary<string, DbParameter> dictionary = DefaultDatabase.DiscoverParameters("dbo.GetProducerLineIDQuotingLocation");
    string str = "SELECT dbo.GetProducerLineIDQuotingLocation(@PLG, @CLG, @EFF, @QLG)";
    if (!dictionary.ContainsKey("@QuotingLocationGuid"))
      str = str.Replace(", @QLG", "");
    return str;
  }));

  public ProducerLine(Quote q)
    : this(q.ProducerLocationGuid, q.CompanyLineGuid.Value, q.EffectiveDate, q.QuotingLocationGuid)
  {
  }

  public ProducerLine(Guid producerLocationGuid, Guid companyLineGuid)
    : this(producerLocationGuid, companyLineGuid, DateAndTime.Now)
  {
  }

  public ProducerLine(Guid producerLocationGuid, Guid companyLineGuid, DateTime effective)
  {
    this._producerLocationGuid = producerLocationGuid;
    this._companyLineGuid = companyLineGuid;
    this._effective = effective;
  }

  public ProducerLine(
    Guid producerLocationGuid,
    Guid companyLineGuid,
    DateTime effective,
    Guid quotingOfficeGuid)
    : this(producerLocationGuid, companyLineGuid, effective)
  {
    this._quotingOfficeGuid = quotingOfficeGuid;
  }

  public ProducerLine(int producerLineId) => this._producerLineID = new int?(producerLineId);

  public Guid QuotingOfficeGuid => this._quotingOfficeGuid;

  public Guid CompanyLineGuid => this._companyLineGuid;

  public Guid ProducerLocationGuid => this._producerLocationGuid;

  [DataKey]
  public int ProducerLineID
  {
    get
    {
      if (!this._producerLineID.HasValue)
      {
        try
        {
          this._producerLineID = new int?(DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, ProducerLine.ProducerLineQuery.Value, new object[8]
          {
            (object) "@PLG",
            (object) this._producerLocationGuid,
            (object) "@CLG",
            (object) this._companyLineGuid,
            (object) "@EFF",
            (object) this._effective,
            (object) "@QLG",
            this.QuotingOfficeGuid.Equals(Guid.Empty) ? (object) DBNull.Value : (object) this.QuotingOfficeGuid
          }) ?? -1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentLogError(ex);
          this._producerLineID = new int?(-1);
          ProjectData.ClearProjectError();
        }
      }
      return (this._producerLineID ?? -1) != -1 ? this._producerLineID.Value : throw new NoProducerLineException(string.Empty, (Exception) null);
    }
    protected set
    {
      int? producerLineId;
      if (((producerLineId = this._producerLineID).HasValue ? producerLineId.GetValueOrDefault() : -1) != -1)
        throw new InvalidOperationException($"Specified ProducerLine ({this._producerLineID}) has already been initialized");
      this._producerLineID = new int?(value);
    }
  }

  [TableFieldMapping("Blocked")]
  public bool IsBlocked => this.GetField<bool>("Blocked", nameof (IsBlocked));

  [TableFieldMapping]
  public int DaysDue
  {
    get
    {
      return (int) (this.GetField<short?>(nameof (DaysDue), nameof (DaysDue)) ?? throw new InvalidOperationException("Producer/line does not specify a days due for endorsements.  Check HasDaysDue property prior to calling DaysDueEndorsement.")).Value;
    }
  }

  [TableFieldMapping]
  public int DaysDueEndorsement
  {
    get
    {
      return (int) (this.GetField<short?>(nameof (DaysDueEndorsement), nameof (DaysDueEndorsement)) ?? throw new InvalidOperationException("Producer/line does not specify a days due for endorsements.  Check HasDaysDueEndorsement property prior to calling DaysDueEndorsement.")).Value;
    }
  }

  public bool HasDaysDue => this.GetField<short?>("DaysDue", nameof (HasDaysDue)).HasValue;

  public bool HasDaysDueEndorsement
  {
    get => this.GetField<short?>("DaysDueEndorsement", nameof (HasDaysDueEndorsement)).HasValue;
  }

  [TableFieldMapping]
  public int StatusID => (int) this.GetField<byte>(nameof (StatusID), nameof (StatusID));

  public bool Disabled
  {
    get
    {
      return this.CacheManualValue<bool>(nameof (Disabled), (Func<bool>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT Disable FROM dbo.lstStatus WITH(NOLOCK) WHERE StatusID = @SID", new object[2]
      {
        (object) "@SID",
        (object) this.StatusID
      })));
    }
  }

  [TableFieldMapping("AccountCurrent")]
  public bool IsAccountCurrent => this.GetField<bool>("AccountCurrent", nameof (IsAccountCurrent));

  [TableFieldMapping]
  public bool GAAP => this.GetField<bool>(nameof (GAAP), nameof (GAAP));

  [TableFieldMapping]
  public int EndOfMonthEffDatePlusDays
  {
    get
    {
      return this.GetField<int?>(nameof (EndOfMonthEffDatePlusDays), nameof (EndOfMonthEffDatePlusDays)).GetValueOrDefault();
    }
  }

  [TableFieldMapping]
  public int EffectiveDatePlusDays
  {
    get
    {
      return this.GetField<int?>(nameof (EffectiveDatePlusDays), nameof (EffectiveDatePlusDays)).GetValueOrDefault();
    }
  }

  [TableFieldMapping]
  public DateTime Effective => this.GetField<DateTime>(nameof (Effective), nameof (Effective));

  [TableFieldMapping]
  public bool UseEndOfMonthEffDatePlusDays
  {
    get
    {
      return this.GetField<bool>(nameof (UseEndOfMonthEffDatePlusDays), nameof (UseEndOfMonthEffDatePlusDays));
    }
  }

  public bool Exists
  {
    get
    {
      bool exists;
      try
      {
        exists = this.ProducerLineID > 0;
      }
      catch (NoProducerLineException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        exists = false;
        ProjectData.ClearProjectError();
      }
      return exists;
    }
  }

  protected override Exception BaseDataObjectException(string errorMessage)
  {
    return (Exception) new NoProducerLineException(errorMessage);
  }
}
