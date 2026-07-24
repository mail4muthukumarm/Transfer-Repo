// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericOfacEntity
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.LexisNexis;
using MGASystems.Data.DataMapping;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.ViewEntityOfacInformation")]
public class GenericOfacEntity : OfacEntity
{
  private Guid _ofacEntityGuid;
  private readonly Guid? _parentOfacEntityGuid;

  public GenericOfacEntity(Guid ofacEntityGuid) => this._ofacEntityGuid = ofacEntityGuid;

  public GenericOfacEntity(Guid ofacEntityGuid, Guid? parentOfacGuid)
    : this(ofacEntityGuid)
  {
    this._parentOfacEntityGuid = parentOfacGuid;
  }

  [TableFieldMapping("EntityGuid")]
  [DataKey]
  public Guid OfacEntityGuid
  {
    get => this._ofacEntityGuid;
    set
    {
      this._ofacEntityGuid = this._ofacEntityGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified {this.EntityType} {this._ofacEntityGuid} has already been initialized");
    }
  }

  [TableFieldMapping("ParentEntityGuid")]
  public Guid? ParentOfacEntityGuid
  {
    get
    {
      Guid? parentOfacEntityGuid;
      return !(parentOfacEntityGuid = this._parentOfacEntityGuid).HasValue ? this.GetField<Guid?>("ParentEntityGuid", nameof (ParentOfacEntityGuid)) : parentOfacEntityGuid;
    }
  }

  [TableFieldMapping]
  public string EntityType => this.GetField<string>(nameof (EntityType), nameof (EntityType));

  [TableFieldMapping]
  public string RecreateTypeName
  {
    get => this.GetField<string>(nameof (RecreateTypeName), nameof (RecreateTypeName));
  }

  [TableFieldMapping]
  public bool CanSearch => this.GetFieldAs<bool>(nameof (CanSearch), nameof (CanSearch));

  [TableFieldMapping]
  public bool Individual => this.GetFieldAs<bool>(nameof (Individual), nameof (Individual));

  [TableFieldMapping]
  public string FirstName => this.GetField<string>(nameof (FirstName), nameof (FirstName));

  [TableFieldMapping]
  public string LastName => this.GetField<string>(nameof (LastName), nameof (LastName));

  [TableFieldMapping]
  public DateTime? DateOfBirth
  {
    get => this.GetField<DateTime?>(nameof (DateOfBirth), nameof (DateOfBirth));
  }

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
  public string ISOCountryCode
  {
    get => this.GetField<string>(nameof (ISOCountryCode), nameof (ISOCountryCode));
  }

  [TableFieldMapping]
  public string CountryName => this.GetField<string>(nameof (CountryName), nameof (CountryName));

  public override Guid EntityGuid => this._ofacEntityGuid;

  public override Guid? ParentEntityGuid => this.ParentOfacEntityGuid;

  public override OfacSystem.OfacCriteria GetSearchCriteria(IOfacSetting setting)
  {
    OfacSystem.OfacCriteria searchCriteria = this.AsOfacCriteria(this.EntityType, this.RecreateTypeName);
    if (setting is IntelligentSearch)
    {
      searchCriteria.LastName = this.Individual ? $"{this.FirstName} {this.LastName}" : this.LastName;
    }
    else
    {
      searchCriteria.FirstName = this.FirstName;
      searchCriteria.LastName = this.LastName;
      searchCriteria.DateOfBirth = this.DateOfBirth?.ToShortDateString();
      searchCriteria.Address = this.Address1;
      searchCriteria.Address2 = this.Address2;
      searchCriteria.City = this.City;
      searchCriteria.State = this.State;
      searchCriteria.ZipCode = this.ZipCode;
      if (!string.IsNullOrEmpty(this.ISOCountryCode))
        searchCriteria.IsoCountryCode = !(setting is PublicWebServices) || string.IsNullOrEmpty(this.CountryName) ? this.ISOCountryCode : this.CountryName;
      if (setting is MGASystems.BusinessObjects.LexisNexis)
        searchCriteria.Data["SearchEntityType"] = (this.Individual ? InputEntityEntityType.Individual : InputEntityEntityType.Business).ToString();
    }
    return searchCriteria;
  }
}
