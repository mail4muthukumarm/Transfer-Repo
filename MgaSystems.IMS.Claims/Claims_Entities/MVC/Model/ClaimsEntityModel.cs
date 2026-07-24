// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.MVC.Model.ClaimsEntityModel
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;
using MGASystems.IMS.Accounting.Services.Utility.LastEdit;
using MGASystems.IMS.Claims.Claims_Entities.DataAccess;
using System;
using System.Data;
using System.Windows;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities.MVC.Model;

[Override(typeof (IClaimsEntityModel))]
public class ClaimsEntityModel : 
  DatabaseSaveModel<IClaimsEntityRepository, ClaimsEntityDto, Guid>,
  IClaimsEntityModel,
  IDatabaseSaveModel<Guid>,
  IDatabaseSaveModel,
  IUpdateDatabaseModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISaveModel,
  ISave,
  IUniqueObject,
  IUpdateDatabaseModel<Guid>,
  IUniqueObject<Guid>
{
  private int _entityTypeId;
  private string _entityTypeDesc;
  private string _entityName;
  private string _dba;
  private string _firstName;
  private string _middleName;
  private string _lastName;
  private string _feinssn;
  private string _contactName;
  private string _phoneNumber;
  private string _faxNumber;
  private DataTable _entityTypes;
  private const string DefaultISO = "USA";
  private const string DefaultZipCode = "00000";

  public Guid EntityGuid { get; set; }

  public int EntityTypeId
  {
    get => this._entityTypeId;
    set
    {
      this._entityTypeId = value;
      this.NotifyObservers();
    }
  }

  public string EntityTypeDesc
  {
    get => this._entityTypeDesc;
    set
    {
      this._entityTypeDesc = value;
      this.NotifyObservers();
    }
  }

  public string EntityName
  {
    get => this._entityName;
    set
    {
      this._entityName = value;
      this.NotifyObservers();
    }
  }

  public string DBA
  {
    get => this._dba;
    set
    {
      this._dba = value;
      this.NotifyObservers();
    }
  }

  public string FirstName
  {
    get => this._firstName;
    set
    {
      this._firstName = value;
      this.NotifyObservers();
    }
  }

  public string MiddleName
  {
    get => this._middleName;
    set
    {
      this._middleName = value;
      this.NotifyObservers();
    }
  }

  public string LastName
  {
    get => this._lastName;
    set
    {
      this._lastName = value;
      this.NotifyObservers();
    }
  }

  public IAddressModel Address { get; private set; }

  public string FEINSSN
  {
    get => this._feinssn;
    set
    {
      this._feinssn = value;
      this.NotifyObservers();
    }
  }

  public string ContactName
  {
    get => this._contactName;
    set
    {
      this._contactName = value;
      this.NotifyObservers();
    }
  }

  public string PhoneNumber
  {
    get => this._phoneNumber;
    set
    {
      this._phoneNumber = value;
      this.NotifyObservers();
    }
  }

  public string FaxNumber
  {
    get => this._faxNumber;
    set
    {
      this._faxNumber = value;
      this.NotifyObservers();
    }
  }

  public DataTable EntityTypes
  {
    get => this._entityTypes;
    private set => this._entityTypes = value;
  }

  public ILastEditData ModificationData { get; private set; }

  public ClaimsEntityModel(IClaimsEntityRepository repository)
    : base(repository)
  {
    this.ChildSetPropertiesFromDto(this.GetDefaultDto());
  }

  public ClaimsEntityModel(ClaimsEntityDto dto, IClaimsEntityRepository repository)
    : base(repository)
  {
    this.SetPropertiesFromDto(dto);
  }

  private void SetAddressFromDto(ClaimsEntityDto dto)
  {
    string address1 = dto.Address1;
    string address2 = dto.Address2;
    string city = dto.City;
    string state = dto.State;
    string zipCode = dto.ZipCode;
    string zipCodeExtension = dto.ZipCodeExtension;
    string isoCountryCode = dto.ISOCountryCode;
    if (this.Address == null)
    {
      this.Address = (IAddressModel) new W9AddressModel(address1, address2, city, state, zipCode, zipCodeExtension, isoCountryCode);
    }
    else
    {
      this.Address.Address1 = address1;
      this.Address.Address2 = address2;
      this.Address.City = city;
      this.Address.State = state;
      this.Address.ZipCode = zipCode;
      this.Address.ZipCodeExtension = zipCodeExtension;
      this.Address.CountryCode = isoCountryCode;
    }
  }

  public override bool HasIdentifier() => true;

  protected override ClaimsEntityDto GetDefaultDto()
  {
    return new ClaimsEntityDto()
    {
      EntityGuid = Guid.NewGuid()
    };
  }

  protected override void ChildSetPropertiesFromDto(ClaimsEntityDto dto)
  {
    this.UniqueIdentifier = dto.EntityGuid;
    this.EntityGuid = dto.EntityGuid;
    this.EntityTypeId = dto.EntityTypeId;
    this.EntityName = dto.EntityName;
    this.DBA = dto.DBA;
    this.FirstName = dto.FirstName;
    this.MiddleName = dto.MiddleName;
    this.LastName = dto.LastName;
    this.SetAddressFromDto(dto);
    this.FEINSSN = dto.FEINSSN;
    this.ContactName = dto.ContactName;
    this.PhoneNumber = dto.PhoneNumber;
    this.FaxNumber = dto.FaxNumber;
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    if (this.EntityTypeId == -1)
    {
      validationResult.ValidateHasSelection(false, "Entity Type", true);
    }
    else
    {
      if (this.EntityTypeDesc != "Individual")
      {
        if (string.IsNullOrEmpty(this.EntityName))
        {
          validationResult.ValidateIsNotNullOrEmpty(string.Empty, "Entity Name", true);
          return;
        }
      }
      else if (string.IsNullOrEmpty(this.FirstName) || string.IsNullOrEmpty(this.LastName))
      {
        validationResult.ValidateIsNotNullOrEmpty(string.Empty, "First and Last Name");
        return;
      }
      if (string.IsNullOrEmpty(this.Address.Address1))
        validationResult.ValidateIsNotNullOrEmpty(string.Empty, "Address", true);
      else if (string.IsNullOrEmpty(this.Address.City))
        validationResult.ValidateIsNotNullOrEmpty(string.Empty, "City");
      else if (string.IsNullOrEmpty(this.Address.State))
        validationResult.ValidateIsNotNullOrEmpty(string.Empty, "State");
      else if (this.Address.CountryCode == "USA")
      {
        validationResult.ValidateIsNotNullOrEmpty(this.Address.ZipCode, "Zip Code");
      }
      else
      {
        if (!string.IsNullOrEmpty(this.Address.ZipCode))
          return;
        this.Address.ZipCode = "00000";
      }
    }
  }

  public override bool CanDelete()
  {
    if (MGASystems.Data.Utility.IsNull<bool>(DefaultDatabase.ExecuteScalar(CommandType.Text, "select case when exists(select * from [dbo].tblClaims_ReservePayments where PayeeGuid = @EntityGuid) then cast(0 as bit) else cast(1 as bit) end", new object[2]
    {
      (object) "@EntityGuid",
      (object) this.EntityGuid
    }), false))
      return base.CanDelete();
    int num = (int) MessageBox.Show("System has detected payments where this entity is a payee.", "Cannot Delete Entity", MessageBoxButton.OK, MessageBoxImage.Exclamation);
    return false;
  }

  protected override ClaimsEntityDto GetDto()
  {
    return new ClaimsEntityDto()
    {
      EntityGuid = this.UpdatedId,
      EntityTypeId = this.EntityTypeId,
      EntityName = this.EntityName,
      DBA = this.DBA,
      FirstName = this.FirstName,
      MiddleName = this.MiddleName,
      LastName = this.LastName,
      Address1 = this.Address.Address1,
      Address2 = this.Address.Address2,
      City = this.Address.City,
      State = this.Address.State,
      ZipCode = this.Address.ZipCode,
      ZipCodeExtension = this.Address.ZipCodeExtension,
      ISOCountryCode = this.Address.CountryCode,
      FEINSSN = this.FEINSSN,
      ContactName = this.ContactName,
      PhoneNumber = this.PhoneNumber,
      FaxNumber = this.FaxNumber
    };
  }
}
