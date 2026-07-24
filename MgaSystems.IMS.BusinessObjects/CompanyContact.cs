// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.CompanyContact
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Data.DataMapping;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblCompanyContacts")]
public class CompanyContact : BaseDataObject
{
  private Guid _companyContactGuid;
  private CompanyLocation _companyLocation;

  public CompanyContact(Guid companyContactGuid) => this._companyContactGuid = companyContactGuid;

  public CompanyContact(Guid companyContactGuid, CompanyLocation companyLocation)
    : this(companyContactGuid)
  {
    this._companyLocation = companyLocation;
  }

  [DataKey]
  public Guid CompanyContactGuid
  {
    get => this._companyContactGuid;
    protected set
    {
      this._companyContactGuid = this._companyContactGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified CompanyContact {this._companyContactGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public Guid CompanyLocationGuid
  {
    get => this.GetField<Guid>(nameof (CompanyLocationGuid), nameof (CompanyLocationGuid));
  }

  public CompanyLocation CompanyLocation
  {
    get
    {
      if (this._companyLocation == null)
        this._companyLocation = ObjectFactory.Instance.CreateObjectAs<CompanyLocation>((object) this.CompanyLocationGuid);
      return this._companyLocation;
    }
    set
    {
      if (this._companyLocation != null || value == null || !this.CompanyLocationGuid.Equals(value.CompanyLocationGuid))
        return;
      this._companyLocation = value;
    }
  }

  [TableFieldMapping]
  public string Salutation => this.GetField<string>(nameof (Salutation), nameof (Salutation));

  [TableFieldMapping]
  public string FName => this.GetField<string>(nameof (FName), nameof (FName));

  [TableFieldMapping]
  public string LName => this.GetField<string>(nameof (LName), nameof (LName));

  [TableFieldMapping]
  public string Title => this.GetField<string>(nameof (Title), nameof (Title));

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone));

  [TableFieldMapping]
  public string Extension => this.GetField<string>(nameof (Extension), nameof (Extension));

  [TableFieldMapping]
  public string Cell => this.GetField<string>(nameof (Cell), nameof (Cell));

  [TableFieldMapping]
  public string Fax => this.GetField<string>(nameof (Fax), nameof (Fax));

  [TableFieldMapping]
  public string Email => this.GetField<string>(nameof (Email), nameof (Email));

  [TableFieldMapping]
  public byte StatusID => this.GetField<byte>(nameof (StatusID), nameof (StatusID));

  [TableFieldMapping]
  public byte? DeliveryMethodID
  {
    get => this.GetField<byte?>(nameof (DeliveryMethodID), nameof (DeliveryMethodID));
  }

  public DeliveryMethods DeliveryMethod
  {
    get
    {
      byte? deliveryMethodId;
      return !(deliveryMethodId = this.DeliveryMethodID).HasValue ? DeliveryMethods.None : (DeliveryMethods) deliveryMethodId.GetValueOrDefault();
    }
  }

  public static CompanyContact FromContactGuid(Guid companyContactGuid)
  {
    return ObjectFactory.Instance.CreateObjectAs<CompanyContact>((object) companyContactGuid);
  }
}
