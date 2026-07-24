// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Insured
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblInsureds")]
public class Insured : OfacEntity
{
  private Guid _insuredGuid;
  internal static readonly ConcurrentDictionary<byte, bool> IndividualBusinessTypes = new ConcurrentDictionary<byte, bool>();

  public Insured(Guid insuredGuid) => this._insuredGuid = insuredGuid;

  public Insured(int insuredID)
  {
    this._insuredGuid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT InsuredGuid FROM tblInsureds WHERE InsuredID=@InsuredID", new object[2]
    {
      (object) "@InsuredID",
      (object) insuredID
    }) ?? Guid.Empty;
    if (this._insuredGuid.Equals(Guid.Empty))
      throw new InvalidOperationException($"Specified Insured (ID {insuredID}) does not exist");
  }

  [DataKey]
  public Guid InsuredGuid
  {
    get => this._insuredGuid;
    protected set
    {
      this._insuredGuid = this._insuredGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified Insured {this._insuredGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public string FEIN => this.GetField<string>(nameof (FEIN), nameof (FEIN));

  [TableFieldMapping]
  public string SSN => this.GetField<string>(nameof (SSN), nameof (SSN));

  [TableFieldMapping]
  public string DBA => this.GetField<string>(nameof (DBA), nameof (DBA));

  [TableFieldMapping]
  public string CorporationName
  {
    get => this.GetField<string>(nameof (CorporationName), nameof (CorporationName));
  }

  [TableFieldMapping("dbo.GetInsuredName(InsuredGuid) Name")]
  public string Name => this.GetField<string>(nameof (Name), nameof (Name));

  [TableFieldMapping("StatusID")]
  public byte Status => this.GetField<byte>("StatusID", nameof (Status));

  [TableFieldMapping]
  public byte BusinessTypeID
  {
    get => this.GetField<byte>(nameof (BusinessTypeID), nameof (BusinessTypeID));
  }

  [TableFieldMapping]
  public string RiskID => this.GetField<string>(nameof (RiskID), nameof (RiskID)) ?? string.Empty;

  [TableFieldMapping]
  public string CarrierID => this.GetField<string>(nameof (CarrierID), nameof (CarrierID));

  [TableFieldMapping]
  public string FirstName => this.GetField<string>(nameof (FirstName), nameof (FirstName));

  [TableFieldMapping]
  public string LastName => this.GetField<string>(nameof (LastName), nameof (LastName));

  [TableFieldMapping]
  public string PolicyName => this.GetField<string>(nameof (PolicyName), nameof (PolicyName));

  [TableFieldMapping]
  public DateTime? DOB => this.GetField<DateTime?>(nameof (DOB), nameof (DOB));

  public InsuredLocation PrimaryLocation
  {
    get
    {
      return BaseDataObject.SelectMany<InsuredLocation>($"{"InsuredGuid"} = @InsuredGuid AND LocationTypeID = 1", (object) "@InsuredGuid", (object) this.InsuredGuid).FirstOrDefault<InsuredLocation>();
    }
  }

  public List<InsuredLocation> Locations
  {
    get
    {
      return BaseDataObject.SelectMany<InsuredLocation>($"{"InsuredGuid"} = @InsuredGuid", (object) "@InsuredGuid", (object) this.InsuredGuid);
    }
  }

  public bool IsIndividual
  {
    get
    {
      ConcurrentDictionary<byte, bool> individualBusinessTypes = Insured.IndividualBusinessTypes;
      int businessTypeId = (int) this.BusinessTypeID;
      System.Func<byte, bool> valueFactory;
      if (Insured._Closure\u0024__.\u0024I40\u002D0 != null)
        valueFactory = Insured._Closure\u0024__.\u0024I40\u002D0;
      else
        Insured._Closure\u0024__.\u0024I40\u002D0 = valueFactory = (System.Func<byte, bool>) ([SpecialName] (btid) => DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT Individual FROM dbo.lstBusinessTypes WHERE BusinessTypeID = @ID", new object[2]
        {
          (object) "@ID",
          (object) btid
        }));
      return individualBusinessTypes.GetOrAdd((byte) businessTypeId, valueFactory);
    }
  }

  public override Guid EntityGuid => this.InsuredGuid;

  public override Guid? ParentEntityGuid => new Guid?();

  public override OfacSystem.OfacCriteria GetSearchCriteria(IOfacSetting setting)
  {
    OfacSystem.OfacCriteria searchCriteria = this.AsOfacCriteria(nameof (Insured), "MGASystems.IMS.InsuredsProducersCompanies.Insureds.frmInsureds");
    searchCriteria.LastName = this.Name;
    if (!(setting is IntelligentSearch))
    {
      if (this.IsIndividual && string.IsNullOrWhiteSpace(this.CorporationName) && !string.IsNullOrEmpty(this.LastName))
      {
        searchCriteria.LastName = this.LastName;
        searchCriteria.FirstName = this.FirstName;
      }
      if (this.DOB.HasValue)
        searchCriteria.DateOfBirth = this.DOB.Value.ToShortDateString();
      if (setting is LexisNexis)
        searchCriteria.Data["SearchEntityType"] = this.IsIndividual ? "Individual" : "Business";
    }
    return searchCriteria;
  }

  public enum InsuredStatus : short
  {
    Active = 1,
    Inactive = 2,
    Closed = 3,
  }
}
