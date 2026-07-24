// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.InsuredLocation
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.Attributes;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Concurrent;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblInsuredLocations")]
[OfacEntity("Insured")]
public class InsuredLocation : OfacEntity
{
  private Guid _insuredLocationGuid;
  private Insured _insured;
  private readonly ConcurrentDictionary<string, InsuredContact> _SystemDefinedContacts;

  public InsuredLocation(Guid insuredLocationGuid)
  {
    this._SystemDefinedContacts = new ConcurrentDictionary<string, InsuredContact>();
    this._insuredLocationGuid = insuredLocationGuid;
  }

  [DataKey]
  public Guid InsuredLocationGuid
  {
    get => this._insuredLocationGuid;
    protected set
    {
      this._insuredLocationGuid = this._insuredLocationGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified InsuredLocation {this._insuredLocationGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public Guid InsuredGuid => this.GetField<Guid>(nameof (InsuredGuid), nameof (InsuredGuid));

  [TableFieldMapping]
  public string Name => this.GetField<string>(nameof (Name), nameof (Name));

  public string LocationName => this.Name;

  [TableFieldMapping]
  public string Address1 => this.GetField<string>(nameof (Address1), nameof (Address1));

  [TableFieldMapping]
  public string Address2 => this.GetField<string>(nameof (Address2), nameof (Address2));

  [TableFieldMapping]
  public string City => this.GetField<string>(nameof (City), nameof (City));

  [TableFieldMapping]
  public string State => this.GetField<string>(nameof (State), nameof (State));

  [TableFieldMapping]
  public string ZipCode => this.GetField<string>(nameof (ZipCode), nameof (ZipCode));

  [TableFieldMapping]
  public string ZipPlus => this.GetField<string>(nameof (ZipPlus), nameof (ZipPlus));

  [TableFieldMapping]
  public string County => this.GetField<string>(nameof (County), nameof (County));

  public string FullAddress
  {
    get
    {
      return this.GetLazyField<string>(nameof (FullAddress), "dbo.FormatAddress(Address1,Address2,City,State,ZipCode,ZipPlus)");
    }
  }

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone));

  [TableFieldMapping]
  public string Fax => this.GetField<string>(nameof (Fax), nameof (Fax));

  [TableFieldMapping]
  public string MobileNumber => this.GetField<string>(nameof (MobileNumber), nameof (MobileNumber));

  [TableFieldMapping]
  public string Email => this.GetField<string>(nameof (Email), nameof (Email));

  [TableFieldMapping]
  public string ISOCountryCode
  {
    get => this.GetField<string>(nameof (ISOCountryCode), nameof (ISOCountryCode));
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

  public Insured Insured
  {
    get
    {
      if (this._insured == null)
        this._insured = ObjectFactory.Instance.CreateObjectAs<Insured>((object) this.InsuredGuid);
      return this._insured;
    }
  }

  public InsuredContact InspectionContact
  {
    get
    {
      return this.CacheManualValue<InsuredContact>(nameof (InspectionContact), (Func<InsuredContact>) ([SpecialName] () =>
      {
        InsuredContact inspectionContact;
        try
        {
          inspectionContact = this.GetContact("INSPC");
          goto label_3;
        }
        catch (SystemDefinedInsuredContactNotFoundException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ErrorHandler.SilentHandleError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        inspectionContact = (InsuredContact) null;
label_3:
        return inspectionContact;
      }));
    }
  }

  public bool HasInspectionContact => this.InspectionContact != null;

  public InsuredContact GetContact(string systemDefinedCode)
  {
    return this._SystemDefinedContacts.GetOrAdd(systemDefinedCode, (System.Func<string, InsuredContact>) ([SpecialName] (code) =>
    {
      InsuredContact contact;
      TargetInvocationException invocationException;
      try
      {
        contact = ObjectFactory.Instance.CreateObjectAs<InsuredContact>((object) this.InsuredLocationGuid, (object) code);
      }
      catch (TargetInvocationException ex) when (
      {
        // ISSUE: unable to correctly present filter
        ProjectData.SetProjectError((Exception) ex);
        invocationException = ex;
        if (invocationException.InnerException != null)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        throw invocationException.InnerException;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentHandleError(ex);
        contact = new InsuredContact(this.InsuredLocationGuid, code);
        ProjectData.ClearProjectError();
      }
      return contact;
    }));
  }

  public override Guid EntityGuid => this.InsuredGuid;

  public override Guid? ParentEntityGuid => new Guid?();

  public override OfacSystem.OfacCriteria GetSearchCriteria(IOfacSetting setting)
  {
    OfacSystem.OfacCriteria searchCriteria = this.Insured.GetSearchCriteria(setting);
    if (!(setting is IntelligentSearch))
    {
      searchCriteria.Address = this.Address1;
      searchCriteria.Address2 = this.Address2;
      searchCriteria.City = this.City;
      searchCriteria.State = this.State;
      searchCriteria.ZipCode = this.ZipCode;
      if (!string.IsNullOrEmpty(this.ISOCountryCode))
      {
        searchCriteria.IsoCountryCode = this.ISOCountryCode;
        if (setting is PublicWebServices && !string.IsNullOrEmpty(this.CountryName))
          searchCriteria.IsoCountryCode = this.CountryName;
      }
    }
    return searchCriteria;
  }
}
