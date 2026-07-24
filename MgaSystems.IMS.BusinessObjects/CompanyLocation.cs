// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.CompanyLocation
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblCompanyLocations")]
public class CompanyLocation : BaseDataObject
{
  private Guid _companyLocationGuid;

  public CompanyLocation(Guid companyLocationGuid)
  {
    this.CompanyLocationGuid = companyLocationGuid;
  }

  [DataKey]
  public Guid CompanyLocationGuid
  {
    get => this._companyLocationGuid;
    protected set
    {
      this._companyLocationGuid = this._companyLocationGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified CompanyLocation {this._companyLocationGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int CompanyLocationCode
  {
    get => this.GetField<int>(nameof (CompanyLocationCode), nameof (CompanyLocationCode));
  }

  [TableFieldMapping]
  public string LocationCode => this.GetField<string>(nameof (LocationCode), nameof (LocationCode));

  public int CompanyLocationID => this.CompanyLocationCode;

  [TableFieldMapping]
  public Guid CompanyGuid => this.GetField<Guid>(nameof (CompanyGuid), nameof (CompanyGuid));

  [TableFieldMapping]
  public Guid? IntermediaryGuid
  {
    get => this.GetField<Guid?>(nameof (IntermediaryGuid), nameof (IntermediaryGuid));
  }

  public bool UsingIntermediary => this.IntermediaryGuid.HasValue;

  public int IntermediaryID
  {
    get
    {
      int num = this.CacheManualValue<int?>(nameof (IntermediaryID), (Func<int?>) ([SpecialName] () =>
      {
        int? intermediaryId;
        if (this.UsingIntermediary)
          intermediaryId = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT IntermediaryID FROM dbo.tblIntermediaries WITH(NOLOCK) WHERE IntermediaryGuid=@IntermediaryGuid", new object[2]
          {
            (object) "@IntermediaryGuid",
            (object) this.IntermediaryGuid
          });
        else
          intermediaryId = new int?();
        return intermediaryId;
      })) ?? -1;
      int intermediaryId1;
      return intermediaryId1;
    }
  }

  public bool HasNetRateCode => !string.IsNullOrEmpty(this.NetRate_Code);

  [TableFieldMapping]
  public string NetRate_Code => this.GetField<string>(nameof (NetRate_Code), nameof (NetRate_Code));

  [TableFieldMapping]
  public string LocationName => this.GetField<string>(nameof (LocationName), nameof (LocationName));

  [TableFieldMapping]
  public bool DisallowBinding
  {
    get => this.GetField<bool>(nameof (DisallowBinding), nameof (DisallowBinding));
  }

  public int CompanyID
  {
    get
    {
      return this.CacheManualValue<int?>(nameof (CompanyID), (Func<int?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT CompanyID FROM dbo.tblCompanies WHERE CompanyGUID = @CompanyGuid", new object[2]
      {
        (object) "@CompanyGuid",
        (object) this.CompanyGuid
      }))) ?? -1;
    }
  }

  [TableFieldMapping]
  public string NetRateCompanyName
  {
    get => this.GetField<string>(nameof (NetRateCompanyName), nameof (NetRateCompanyName));
  }

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone));

  [TableFieldMapping]
  public string Fax => this.GetField<string>(nameof (Fax), nameof (Fax));

  [TableFieldMapping]
  public string Email => this.GetField<string>(nameof (Email), nameof (Email));

  [TableFieldMapping]
  public string ClaimFax => this.GetField<string>(nameof (ClaimFax), nameof (ClaimFax));

  [TableFieldMapping]
  public string ClaimPhone => this.GetField<string>(nameof (ClaimPhone), nameof (ClaimPhone));

  public string Address1
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (Address1), nameof (Address1));
    }
  }

  public string Address2
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (Address2), nameof (Address2));
    }
  }

  public string City
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (City), nameof (City));
    }
  }

  public string State
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (State), nameof (State));
    }
  }

  public string ZipCode
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (ZipCode), nameof (ZipCode));
    }
  }

  public string ZipPlus
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (ZipPlus), nameof (ZipPlus));
    }
  }

  public string County
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (County), nameof (County));
    }
  }

  public string Region
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (Region), nameof (Region));
    }
  }

  private bool GetAddressFields()
  {
    return this.RetrieveFields("Address1", "Address2", "ZipCode", "ZipPlus", "City", "State", "County", "Region");
  }
}
