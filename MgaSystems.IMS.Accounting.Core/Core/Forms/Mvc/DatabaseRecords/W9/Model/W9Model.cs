// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Model.W9Model
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Core.DataAccess.W9;
using MGASystems.IMS.Accounting.Services.Forms.MVC.Address.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataDrivenComboOtherEdit.Model;
using MGASystems.IMS.Accounting.Services.Utility.EntityTypes;
using MGASystems.IMS.Accounting.Services.Utility.LastEdit;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.DatabaseRecords.W9.Model;

[Override(typeof (IW9Model))]
public class W9Model : 
  DatabaseSaveModel<IW9Repository, W9Dto, Guid>,
  IW9Model,
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
  IUniqueObject<Guid>,
  INamedValue<Guid>,
  INamedValue
{
  private string _businessName;
  private string _tinEin;
  private string _taxingEntity;
  private DateTime? _w9Date;
  private IAddressModel _addressModel;
  private AccountingEntityType _accountingType;
  private INamedValue<int>[] _w9Types;

  public string Name => this.BusinessName;

  public IAddressModel Address
  {
    get => this._addressModel;
    set
    {
      this._addressModel = value;
      this.NotifyObservers();
    }
  }

  public ILastEditData ModificationData { get; private set; }

  public ISelectableValueWithOtherModel<INamedValue<int>, int> EntityType { get; private set; }

  public W9Model(INamedValue<int>[] w9Types, IW9Repository w9Repository)
    : base(w9Repository)
  {
    this._w9Types = w9Types ?? throw new ArgumentNullException(nameof (w9Types));
    this.ChildSetPropertiesFromDto(this.GetDefaultDto());
  }

  public W9Model(W9Dto dto, INamedValue<int>[] w9Types, IW9Repository w9Repository)
    : base(w9Repository)
  {
    this._w9Types = w9Types ?? throw new ArgumentNullException(nameof (w9Types));
    this.SetPropertiesFromDto(dto);
  }

  public DateTime? W9Date
  {
    get => this._w9Date;
    set
    {
      this._w9Date = value;
      this.NotifyObservers();
    }
  }

  public string TaxingEntity
  {
    get => this._taxingEntity;
    set
    {
      this._taxingEntity = value;
      this.NotifyObservers();
    }
  }

  public string BusinessName
  {
    get => this._businessName;
    set
    {
      this._businessName = value;
      this.NotifyObservers();
    }
  }

  public string TinEin
  {
    get => this._tinEin;
    set
    {
      this._tinEin = value;
      this.NotifyObservers();
    }
  }

  public AccountingEntityType AccountingType
  {
    get => this._accountingType;
    set
    {
      this._accountingType = value;
      this.NotifyObservers();
    }
  }

  public override string ToString() => this.BusinessName;

  public override bool HasIdentifier() => true;

  protected override W9Dto GetDefaultDto()
  {
    W9Dto objectAs = ObjectFactory.Instance.CreateObjectAs<W9Dto>();
    objectAs.EntityGuid = Guid.Empty;
    return objectAs;
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
    validationResult.ValidateIsNotNullOrEmpty(this.TaxingEntity, "Taxing Entity");
    validationResult.ValidateIsNotNullOrEmpty(this.BusinessName, "Business Name");
    validationResult.ValidateIsExactLength(this.TinEin, 9, "Tin/Ein");
    this.Address.ValidateData(validationResult);
    this.EntityType.ValidateData(validationResult);
  }

  protected override W9Dto GetDto()
  {
    W9Dto objectAs = ObjectFactory.Instance.CreateObjectAs<W9Dto>();
    objectAs.EntityGuid = this.UpdatedId;
    objectAs.TaxingEntity = this.TaxingEntity;
    objectAs.BusinessName = this.BusinessName;
    objectAs.TinEin = this.TinEin;
    objectAs.W9Date = this.W9Date;
    objectAs.Address1 = this.Address.Address1;
    objectAs.Address2 = this.Address.Address2;
    objectAs.City = this.Address.City;
    objectAs.State = this.Address.State;
    objectAs.ZipCode = this.Address.ZipCode;
    objectAs.ZipCodeExtension = this.Address.ZipCodeExtension;
    objectAs.EntityTypeId = this.EntityType.SelectedValue;
    objectAs.EntityTypeOther = this.EntityType.OtherText;
    objectAs.LastModifiedByUserGuid = this.ModificationData.GetCurrentUserGuid();
    objectAs.AccountingEntityType = this.AccountingType.Code;
    return objectAs;
  }

  protected override void ChildSetPropertiesFromDto(W9Dto dto)
  {
    this.UniqueIdentifier = dto.EntityGuid;
    this._taxingEntity = dto.TaxingEntity;
    this._businessName = dto.BusinessName;
    this._tinEin = dto.TinEin;
    this._w9Date = dto.W9Date;
    this.SetAddressFromDto(dto);
    this.SetEntityType(dto);
    this.SetModificationData(dto);
    this._accountingType = ObjectFactory.Instance.CreateObjectAs<AccountingEntityTypeProvider>().GetByCode(dto.AccountingEntityType);
  }

  private void SetModificationData(W9Dto dto)
  {
    if (this.IsNew)
      this.ModificationData = (ILastEditData) new LastEditData();
    else
      this.ModificationData = (ILastEditData) new LastEditData(new DateTime?(dto.LastModifiedDate), dto.LastModifiedByUserGuid, dto.LastModifiedUserName);
  }

  private void SetEntityType(W9Dto dto)
  {
    if (this.EntityType == null)
      this.EntityType = (ISelectableValueWithOtherModel<INamedValue<int>, int>) new SelectableValueWithOtherModel<INamedValue<int>, int>(string.Empty, (IEnumerable<INamedValue<int>>) this._w9Types, "Other", -1, -1, "Entity Type", true);
    this.EntityType.SelectedValue = dto.EntityTypeId;
    this.EntityType.OtherText = dto.EntityTypeOther;
  }

  private void SetAddressFromDto(W9Dto dto)
  {
    string address1 = dto.Address1;
    string address2 = dto.Address2;
    string city = dto.City;
    string state = dto.State;
    string zipCode = dto.ZipCode;
    string zipCodeExtension = dto.ZipCodeExtension;
    if (this.Address == null)
    {
      this._addressModel = (IAddressModel) new W9AddressModel(address1, address2, city, state, zipCode, zipCodeExtension);
    }
    else
    {
      this.Address.Address1 = address1;
      this.Address.Address2 = address2;
      this.Address.City = city;
      this.Address.State = state;
      this.Address.ZipCode = zipCode;
      this.Address.ZipCodeExtension = zipCodeExtension;
    }
  }
}
