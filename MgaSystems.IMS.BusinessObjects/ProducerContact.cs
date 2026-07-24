// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.ProducerContact
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblProducerContacts")]
public class ProducerContact : OfacEntity
{
  private Guid _producerContactGuid;
  private bool _addressRetrieved;

  public ProducerContact(Guid producerContactGuid)
  {
    this._producerContactGuid = producerContactGuid;
  }

  public ProducerContact(int producerContactId)
  {
    object[] objArray = new object[2]
    {
      (object) "@PID",
      (object) producerContactId
    };
    Guid? nullable;
    this._producerContactGuid = (nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT ProducerContactGuid FROM dbo.tblProducerContacts WITH(NOLOCK) WHERE ProducerContactID = @PID", objArray)).HasValue ? nullable.GetValueOrDefault() : Guid.Empty;
    if (this._producerContactGuid.Equals(Guid.Empty))
      throw new InvalidOperationException("Specified ProducerContact does not exist");
  }

  [DataKey]
  public Guid ProducerContactGuid
  {
    get => this._producerContactGuid;
    protected set
    {
      this._producerContactGuid = this._producerContactGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified ProducerContact {this._producerContactGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int ProducerContactID
  {
    get => this.GetField<int>(nameof (ProducerContactID), nameof (ProducerContactID));
  }

  [TableFieldMapping]
  public Guid ProducerLocationGuid
  {
    get => this.GetField<Guid>(nameof (ProducerLocationGuid), nameof (ProducerLocationGuid));
  }

  [TableFieldMapping]
  public string Salutation => this.GetField<string>(nameof (Salutation), nameof (Salutation));

  [TableFieldMapping]
  public string FName => this.GetField<string>(nameof (FName), nameof (FName));

  [TableFieldMapping]
  public string LName => this.GetField<string>(nameof (LName), nameof (LName));

  public string FullName
  {
    get => !string.IsNullOrWhiteSpace(this.FName) ? $"{this.FName} {this.LName}" : this.LName;
  }

  [TableFieldMapping]
  public string Title => this.GetField<string>(nameof (Title), nameof (Title));

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone));

  [TableFieldMapping]
  public string Fax => this.GetField<string>(nameof (Fax), nameof (Fax));

  [TableFieldMapping]
  public string Cell => this.GetField<string>(nameof (Cell), nameof (Cell));

  [TableFieldMapping]
  public string Email => this.GetField<string>(nameof (Email), nameof (Email));

  [TableFieldMapping]
  public string Comment => this.GetField<string>(nameof (Comment), nameof (Comment));

  [TableFieldMapping]
  public DateTime? DOB => this.GetField<DateTime?>(nameof (DOB), nameof (DOB));

  [TableFieldMapping]
  public string NPNNo => this.GetField<string>(nameof (NPNNo), nameof (NPNNo));

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

  public string StateID
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (StateID), nameof (StateID));
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

  public string ISOCountryCode
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (ISOCountryCode), nameof (ISOCountryCode));
    }
  }

  public string CountryName
  {
    get
    {
      return this.CacheManualValue<string>(nameof (CountryName), (Func<string>) ([SpecialName] () =>
      {
        string countryName;
        if (!string.IsNullOrEmpty(this.ISOCountryCode))
          countryName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Country FROM dbo.tblAddressResolver_Countries WITH(NOLOCK) WHERE ISOCode = @ISO", new object[2]
          {
            (object) "@ISO",
            (object) this.ISOCountryCode
          });
        else
          countryName = (string) null;
        return countryName;
      }));
    }
  }

  private bool GetAddressFields()
  {
    if (!this._addressRetrieved)
      this._addressRetrieved = this.RetrieveFields("Address1", "Address2", "City", "StateID", "ZipCode", "ZipPlus", "County", "ISOCountryCode");
    return this._addressRetrieved;
  }

  public override Guid EntityGuid => this.ProducerContactGuid;

  public override Guid? ParentEntityGuid => new Guid?(this.ProducerLocationGuid);

  public override OfacSystem.OfacCriteria GetSearchCriteria(IOfacSetting setting)
  {
    OfacSystem.OfacCriteria searchCriteria = this.AsOfacCriteria(nameof (ProducerContact), "MGASystems.IMS.InsuredsProducersCompanies.Producers.frmProducers");
    if (!(setting is IntelligentSearch))
    {
      searchCriteria.Address = this.Address1;
      searchCriteria.Address2 = this.Address2;
      searchCriteria.City = this.City;
      searchCriteria.State = this.StateID;
      searchCriteria.ZipCode = this.ZipCode;
      DateTime? dob = this.DOB;
      if (dob.HasValue)
      {
        OfacSystem.OfacCriteria ofacCriteria = searchCriteria;
        dob = this.DOB;
        string shortDateString = dob.Value.ToShortDateString();
        ofacCriteria.DateOfBirth = shortDateString;
      }
      if (!string.IsNullOrEmpty(this.ISOCountryCode))
      {
        searchCriteria.IsoCountryCode = this.ISOCountryCode;
        if (setting is PublicWebServices && !string.IsNullOrEmpty(this.CountryName))
          searchCriteria.IsoCountryCode = this.CountryName;
      }
    }
    else
      searchCriteria.LastName = this.FullName;
    return searchCriteria;
  }
}
