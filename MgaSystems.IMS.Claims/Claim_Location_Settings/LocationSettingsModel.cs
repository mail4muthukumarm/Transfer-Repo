// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim_Location_Settings.LocationSettingsModel
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Utility.LastEdit;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claim_Location_Settings;

[Override(typeof (ILocationSettingsModel))]
public class LocationSettingsModel : 
  DatabaseSaveModel<ILocationSettingsRepository, LocationSettingsDto, Guid>,
  ILocationSettingsModel,
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
  private int _quotingOfficeId;
  private string _quotingOfficeName;
  private int _claimsOfficeId;
  private string _claimsOfficeName;
  private int _glAcctId;
  private string _glAcctName;

  public Guid QuotingOfficeGuid { get; set; }

  public int QuotingOfficeId
  {
    get => this._quotingOfficeId;
    set
    {
      this._quotingOfficeId = value;
      this.NotifyObservers();
    }
  }

  public string QuotingOfficeName
  {
    get => this._quotingOfficeName;
    set
    {
      this._quotingOfficeName = value;
      this.NotifyObservers();
    }
  }

  public int ClaimsOfficeId
  {
    get => this._claimsOfficeId;
    set
    {
      this._claimsOfficeId = value;
      this.NotifyObservers();
    }
  }

  public string ClaimsOfficeName
  {
    get => this._claimsOfficeName;
    set
    {
      this._claimsOfficeName = value;
      this.NotifyObservers();
    }
  }

  public int GLAcctId
  {
    get => this._glAcctId;
    set
    {
      this._glAcctId = value;
      this.NotifyObservers();
    }
  }

  public string GLAcctName
  {
    get => this._glAcctName;
    set
    {
      this._glAcctName = value;
      this.NotifyObservers();
    }
  }

  public ILastEditData ModificationData { get; private set; }

  public LocationSettingsModel(ILocationSettingsRepository repository)
    : base(repository)
  {
    this.ChildSetPropertiesFromDto(this.GetDefaultDto());
  }

  public LocationSettingsModel(LocationSettingsDto dto, ILocationSettingsRepository repository)
    : base(repository)
  {
    this.SetPropertiesFromDto(dto);
  }

  public override bool HasIdentifier() => true;

  protected override LocationSettingsDto GetDefaultDto()
  {
    return new LocationSettingsDto()
    {
      QuotingOfficeGuid = Guid.NewGuid()
    };
  }

  protected override void ChildSetPropertiesFromDto(LocationSettingsDto dto)
  {
    this.UniqueIdentifier = dto.QuotingOfficeGuid;
    this.QuotingOfficeGuid = dto.QuotingOfficeGuid;
    this.QuotingOfficeId = dto.QuotingOfficeId;
    this.QuotingOfficeName = dto.QuotingOfficeName;
    this.ClaimsOfficeId = dto.ClaimsOfficeId;
    this.ClaimsOfficeName = dto.ClaimsOfficeName;
    this.GLAcctId = dto.GLAcctId;
    this.GLAcctName = dto.GLAcctName;
    this.SetModificationData(dto);
  }

  private void SetModificationData(LocationSettingsDto dto)
  {
    if (this.IsNew)
      this.ModificationData = (ILastEditData) new LastEditData();
    else
      this.ModificationData = (ILastEditData) new LastEditData(new DateTime?(dto.LastModifiedDate), dto.LastModifiedByUserGuid, dto.LastModifiedUserName);
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    if (this.QuotingOfficeId == -1)
      validationResult.ValidateHasSelection(false, "QuotingOfficeId", true);
    if (this.ClaimsOfficeId == -1)
      validationResult.ValidateHasSelection(false, "ClaimsOfficeId", true);
    if (this.GLAcctId != -1)
      return;
    validationResult.ValidateHasSelection(false, "GLAcctId", true);
  }

  protected override LocationSettingsDto GetDto()
  {
    return new LocationSettingsDto()
    {
      QuotingOfficeGuid = this.UpdatedId,
      QuotingOfficeId = this.QuotingOfficeId,
      QuotingOfficeName = this.QuotingOfficeName,
      ClaimsOfficeId = this.ClaimsOfficeId,
      ClaimsOfficeName = this.ClaimsOfficeName,
      GLAcctId = this.GLAcctId,
      GLAcctName = this.GLAcctName,
      LastModifiedByUserGuid = this.ModificationData.GetCurrentUserGuid()
    };
  }
}
