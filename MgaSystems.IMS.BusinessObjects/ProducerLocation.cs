// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.ProducerLocation
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblProducerLocations")]
public class ProducerLocation : BaseDataObject
{
  private Guid _producerLocationGuid;
  private static readonly ConcurrentDictionary<int, Guid> _producerLocationIDToGuidCache = new ConcurrentDictionary<int, Guid>();
  private Producer _producer;

  public ProducerLocation(Guid producerLocationGuid)
  {
    this._producerLocationGuid = producerLocationGuid;
  }

  public ProducerLocation(int producerLocationId)
  {
    ConcurrentDictionary<int, Guid> locationIdToGuidCache = ProducerLocation._producerLocationIDToGuidCache;
    int key1 = producerLocationId;
    System.Func<int, Guid> valueFactory;
    // ISSUE: reference to a compiler-generated field
    if (ProducerLocation._Closure\u0024__.\u0024I5\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      valueFactory = ProducerLocation._Closure\u0024__.\u0024I5\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ProducerLocation._Closure\u0024__.\u0024I5\u002D0 = valueFactory = (System.Func<int, Guid>) ([SpecialName] (key) => DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT ProducerLocationGuid FROM dbo.tblProducerLocations WITH(NOLOCK) WHERE ProducerLocationID = @PLID", new object[2]
      {
        (object) "@PLID",
        (object) key
      }) ?? Guid.Empty);
    }
    this._producerLocationGuid = locationIdToGuidCache.GetOrAdd(key1, valueFactory);
    if (this._producerLocationGuid.Equals(Guid.Empty))
      throw new InvalidOperationException($"Specified ProducerLocation (ID {producerLocationId}) not found");
  }

  [DataKey]
  public Guid ProducerLocationGuid
  {
    get => this._producerLocationGuid;
    protected set
    {
      this._producerLocationGuid = this._producerLocationGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified ProducerLocation {this._producerLocationGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int ProducerLocationID
  {
    get => this.GetField<int>(nameof (ProducerLocationID), nameof (ProducerLocationID));
  }

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone)) ?? string.Empty;

  [TableFieldMapping]
  public string Fax => this.GetField<string>(nameof (Fax), nameof (Fax)) ?? string.Empty;

  [TableFieldMapping]
  public string Email => this.GetField<string>(nameof (Email), nameof (Email)) ?? string.Empty;

  [TableFieldMapping]
  public Guid ProducerGuid => this.GetField<Guid>(nameof (ProducerGuid), nameof (ProducerGuid));

  [TableFieldMapping]
  public string Name => this.GetField<string>(nameof (Name), nameof (Name));

  public string LocationName => this.Name;

  [TableFieldMapping]
  public byte DeliveryMethodID
  {
    get => this.GetField<byte>(nameof (DeliveryMethodID), nameof (DeliveryMethodID));
  }

  public DeliveryMethods DeliveryMethod => (DeliveryMethods) this.DeliveryMethodID;

  [TableFieldMapping]
  public int StatusID => (int) this.GetField<byte>(nameof (StatusID), nameof (StatusID));

  public bool HasContacts
  {
    get
    {
      return Convert.ToBoolean(DefaultDatabase.ExecuteScalar<int>("dbo.ProducerLocationHasContacts", new object[2]
      {
        (object) "@producerLocationGuid",
        (object) this.ProducerLocationGuid
      }));
    }
  }

  public bool HasLines
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<bool>("dbo.ProducerHasLines", new object[2]
      {
        (object) "@producerLocationGuid",
        (object) this.ProducerLocationGuid
      });
    }
  }

  [TableFieldMapping]
  public string City => this.GetField<string>(nameof (City), nameof (City)) ?? string.Empty;

  [TableFieldMapping]
  public string County => this.GetField<string>(nameof (County), nameof (County)) ?? string.Empty;

  [TableFieldMapping]
  public string State => this.GetField<string>(nameof (State), nameof (State)) ?? string.Empty;

  [TableFieldMapping("ZipCode")]
  public string Zip => this.GetField<string>("ZipCode", nameof (Zip)) ?? string.Empty;

  [TableFieldMapping]
  public string ZipPlus
  {
    get => this.GetField<string>(nameof (ZipPlus), nameof (ZipPlus)) ?? string.Empty;
  }

  [TableFieldMapping("ISOCountryCode")]
  public string CountryCode
  {
    get => this.GetField<string>("ISOCountryCode", nameof (CountryCode)) ?? string.Empty;
  }

  public string CountryName
  {
    get
    {
      return this.CacheManualValue<string>(nameof (CountryName), (Func<string>) ([SpecialName] () =>
      {
        string countryName;
        if (!string.IsNullOrEmpty(this.CountryCode))
          countryName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Country FROM dbo.tblAddressResolver_Countries WITH(NOLOCK) WHERE ISOCode = @ISO", new object[2]
          {
            (object) "@ISO",
            (object) this.CountryCode
          });
        else
          countryName = (string) null;
        return countryName;
      }));
    }
  }

  [TableFieldMapping]
  public string Address1
  {
    get => this.GetField<string>(nameof (Address1), nameof (Address1)) ?? string.Empty;
  }

  [TableFieldMapping]
  public string Address2
  {
    get => this.GetField<string>(nameof (Address2), nameof (Address2)) ?? string.Empty;
  }

  public Producer Producer
  {
    get
    {
      if (this._producer == null)
        this._producer = ObjectFactory.Instance.CreateObjectAs<Producer>((object) this.ProducerGuid);
      return this._producer;
    }
  }

  public Decimal GetCommission(Guid companyLineGuid, bool renewal, DateTime effectiveDate)
  {
    return this.GetCommission(companyLineGuid, renewal, effectiveDate, (SqlTransaction) null);
  }

  public Decimal GetCommission(
    Guid companyLineGuid,
    bool renewal,
    DateTime effectiveDate,
    SqlTransaction trans)
  {
    return this.GetCommission(companyLineGuid, renewal, effectiveDate, trans, (object) null);
  }

  public Decimal GetCommission(
    Guid companyLineGuid,
    bool renewal,
    DateTime effectiveDate,
    SqlTransaction trans,
    object policyTypeID)
  {
    return this.GetCommission(companyLineGuid, renewal, effectiveDate, trans, RuntimeHelpers.GetObjectValue(policyTypeID), (object) null);
  }

  public Decimal GetCommission(
    Guid companyLineGuid,
    bool renewal,
    DateTime effectiveDate,
    SqlTransaction trans,
    object policyTypeID,
    object programID)
  {
    return this.GetCommission(companyLineGuid, renewal, effectiveDate, trans, RuntimeHelpers.GetObjectValue(policyTypeID), RuntimeHelpers.GetObjectValue(programID), Guid.Empty);
  }

  public Decimal GetCommission(
    Guid companyLineGuid,
    bool renewal,
    DateTime effectiveDate,
    SqlTransaction trans,
    object policyTypeID,
    object programID,
    Guid quotingOfficeGuid)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    ProducerLocation._Closure\u0024__58\u002D1 closure581 = new ProducerLocation._Closure\u0024__58\u002D1();
    // ISSUE: reference to a compiler-generated field
    closure581.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure581.\u0024VB\u0024Local_companyLineGuid = companyLineGuid;
    // ISSUE: reference to a compiler-generated field
    closure581.\u0024VB\u0024Local_renewal = renewal;
    // ISSUE: reference to a compiler-generated field
    closure581.\u0024VB\u0024Local_effectiveDate = effectiveDate;
    // ISSUE: reference to a compiler-generated field
    closure581.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    closure581.\u0024VB\u0024Local_policyTypeID = policyTypeID;
    // ISSUE: reference to a compiler-generated field
    closure581.\u0024VB\u0024Local_programID = programID;
    // ISSUE: reference to a compiler-generated field
    closure581.\u0024VB\u0024Local_quotingOfficeGuid = quotingOfficeGuid;
    Decimal commission;
    // ISSUE: reference to a compiler-generated field
    if (closure581.\u0024VB\u0024Local_trans != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ProducerLocation._Closure\u0024__58\u002D0 closure580 = new ProducerLocation._Closure\u0024__58\u002D0();
      // ISSUE: reference to a compiler-generated field
      closure580.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure581;
      // ISSUE: reference to a compiler-generated field
      closure580.\u0024VB\u0024Local_commissionVal = 0M;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure580.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure580, __methodptr(_Lambda\u0024__0)));
      // ISSUE: reference to a compiler-generated field
      commission = closure580.\u0024VB\u0024Local_commissionVal;
    }
    else
    {
      Dictionary<string, DbParameter> dictionary = DefaultDatabase.DiscoverParameters("dbo.spGetProducerCommission");
      dictionary["@ProducerLocationGuid"].Value = (object) this.ProducerLocationGuid;
      // ISSUE: reference to a compiler-generated field
      dictionary["@CompanyLineGuid"].Value = (object) closure581.\u0024VB\u0024Local_companyLineGuid;
      // ISSUE: reference to a compiler-generated field
      dictionary["@Renewal"].Value = (object) closure581.\u0024VB\u0024Local_renewal;
      // ISSUE: reference to a compiler-generated field
      dictionary["@QuoteEffectiveDate"].Value = (object) closure581.\u0024VB\u0024Local_effectiveDate;
      // ISSUE: reference to a compiler-generated field
      dictionary["@PolicyTypeID"].Value = RuntimeHelpers.GetObjectValue(closure581.\u0024VB\u0024Local_policyTypeID);
      // ISSUE: reference to a compiler-generated field
      dictionary["@ProgramID"].Value = RuntimeHelpers.GetObjectValue(closure581.\u0024VB\u0024Local_programID);
      // ISSUE: reference to a compiler-generated field
      if (!closure581.\u0024VB\u0024Local_quotingOfficeGuid.Equals(Guid.Empty))
      {
        // ISSUE: reference to a compiler-generated field
        dictionary["@QuotingOfficeGuid"].Value = (object) closure581.\u0024VB\u0024Local_quotingOfficeGuid;
      }
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spGetProducerCommission", 180, (CommandArgumentType) 2, new object[1]
      {
        (object) dictionary
      });
      DbParameter dbParameter = dictionary["@Commission"];
      commission = !Utility.IsNull(RuntimeHelpers.GetObjectValue(dbParameter.Value)) ? Conversions.ToDecimal(dbParameter.Value) : throw new InvalidOperationException("The system was unable to determine the producer commission");
    }
    return commission;
  }

  public virtual bool IsAuthorizedForCompanyLine(Guid companyLineGuid) => true;

  public enum ProducerStatus : byte
  {
    Active = 1,
    Inactive = 2,
    Closed = 3,
  }
}
