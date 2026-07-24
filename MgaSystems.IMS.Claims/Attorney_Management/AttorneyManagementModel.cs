// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.AttorneyManagementModel
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
using System;
using System.Data;
using System.Windows;

#nullable disable
namespace MGASystems.IMS.Claims.Attorney_Management;

[Override(typeof (IAttorneyManagementModel))]
public class AttorneyManagementModel : 
  DatabaseSaveModel<IAttorneyManagementRepository, AttorneyManagementDto, Guid>,
  IAttorneyManagementModel,
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
  private string _attorneyType;
  private string _attorneyName;
  private string _attorneyEntityType;
  private string _lawFirm;
  private string _feinssn;
  private string _phoneNumber;
  private string _faxNumber;
  private const string DefaultISO = "USA";
  private const string DefaultZipCode = "00000";

  public Guid AttorneyGuid { get; set; }

  public string AttorneyType
  {
    get => this._attorneyType;
    set
    {
      this._attorneyType = value;
      this.NotifyObservers();
    }
  }

  public string AttorneyName
  {
    get => this._attorneyName;
    set
    {
      this._attorneyName = value;
      this.NotifyObservers();
    }
  }

  public string AttorneyEntityType
  {
    get => this._attorneyEntityType;
    set
    {
      this._attorneyEntityType = value;
      this.NotifyObservers();
    }
  }

  public string LawFirm
  {
    get => this._lawFirm;
    set
    {
      this._lawFirm = value;
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

  public ILastEditData ModificationData { get; private set; }

  public AttorneyManagementModel(IAttorneyManagementRepository repository)
    : base(repository)
  {
    this.ChildSetPropertiesFromDto(this.GetDefaultDto());
  }

  public AttorneyManagementModel(
    AttorneyManagementDto dto,
    IAttorneyManagementRepository repository)
    : base(repository)
  {
    this.SetPropertiesFromDto(dto);
  }

  private void SetAddressFromDto(AttorneyManagementDto dto)
  {
    if (this.Address == null)
    {
      this.Address = (IAddressModel) new W9AddressModel(dto.Address1, dto.Address2, dto.City, dto.State, dto.ZipCode, dto.ZipCodeExtension, dto.ISOCountryCode);
    }
    else
    {
      this.Address.Address1 = dto.Address1;
      this.Address.Address2 = dto.Address2;
      this.Address.City = dto.City;
      this.Address.State = dto.State;
      this.Address.ZipCode = dto.ZipCode;
      this.Address.ZipCodeExtension = dto.ZipCodeExtension;
      this.Address.CountryCode = dto.ISOCountryCode;
    }
  }

  public override bool HasIdentifier() => true;

  protected override AttorneyManagementDto GetDefaultDto()
  {
    return new AttorneyManagementDto()
    {
      AttorneyGuid = Guid.NewGuid()
    };
  }

  protected override void ChildSetPropertiesFromDto(AttorneyManagementDto dto)
  {
    this.UniqueIdentifier = dto.AttorneyGuid;
    this.AttorneyGuid = dto.AttorneyGuid;
    this.AttorneyType = dto.AttorneyType;
    this.AttorneyName = dto.AttorneyName;
    this.LawFirm = dto.LawFirm;
    this.AttorneyEntityType = dto.AttorneyEntityType;
    this.SetAddressFromDto(dto);
    this.FEINSSN = dto.FEINSSN;
    this.PhoneNumber = dto.PhoneNumber;
    this.FaxNumber = dto.FaxNumber;
    this.SetModificationData(dto);
  }

  private void SetModificationData(AttorneyManagementDto dto)
  {
    if (this.IsNew)
      this.ModificationData = (ILastEditData) new LastEditData();
    else
      this.ModificationData = (ILastEditData) new LastEditData(new DateTime?(dto.LastModifiedDate), dto.LastModifiedByUserGuid, dto.LastModifiedUserName);
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    if (this.AttorneyType.Length == 0)
      validationResult.ValidateIsNotNullOrEmpty(string.Empty, "Attorney Type", true);
    if (this.AttorneyEntityType != "I")
    {
      if (string.IsNullOrEmpty(this.LawFirm))
        validationResult.ValidateIsNotNullOrEmpty(string.Empty, "Law Firm", true);
    }
    else if (string.IsNullOrEmpty(this.AttorneyName))
      validationResult.ValidateIsNotNullOrEmpty(string.Empty, "Attorney Name");
    if (string.IsNullOrEmpty(this.Address.Address1))
      validationResult.ValidateIsNotNullOrEmpty(string.Empty, "Address", true);
    if (string.IsNullOrEmpty(this.Address.City))
      validationResult.ValidateIsNotNullOrEmpty(string.Empty, "City");
    if (string.IsNullOrEmpty(this.Address.State))
      validationResult.ValidateIsNotNullOrEmpty(string.Empty, "State");
    if (this.Address.CountryCode == "USA")
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

  public override bool CanDelete()
  {
    if (MGASystems.Data.Utility.IsNull<bool>(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CASE WHEN EXISTS (SELECT 1 FROM [dbo].tblClaims_ClaimantLegal WHERE DefenseAttorneyGuid = @AttorneyGuid OR ClaimantAttorneyGuid = @AttorneyGuid) THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) end", new object[2]
    {
      (object) "@EntityGuid",
      (object) this.AttorneyGuid
    }), false))
      return base.CanDelete();
    int num = (int) MessageBox.Show("System has detected claimants where this attorney was used.", "Cannot Delete Attorney", MessageBoxButton.OK, MessageBoxImage.Exclamation);
    return false;
  }

  protected override AttorneyManagementDto GetDto()
  {
    return new AttorneyManagementDto()
    {
      AttorneyGuid = this.UpdatedId,
      AttorneyType = this.AttorneyType,
      AttorneyName = this.AttorneyName,
      LawFirm = this.LawFirm,
      AttorneyEntityType = this.AttorneyEntityType,
      Address1 = this.Address.Address1,
      Address2 = this.Address.Address2,
      City = this.Address.City,
      State = this.Address.State,
      ZipCode = this.Address.ZipCode,
      ZipCodeExtension = this.Address.ZipCodeExtension,
      ISOCountryCode = this.Address.CountryCode,
      FEINSSN = this.FEINSSN,
      PhoneNumber = this.PhoneNumber,
      FaxNumber = this.FaxNumber,
      LastModifiedByUserGuid = this.ModificationData.GetCurrentUserGuid()
    };
  }
}
