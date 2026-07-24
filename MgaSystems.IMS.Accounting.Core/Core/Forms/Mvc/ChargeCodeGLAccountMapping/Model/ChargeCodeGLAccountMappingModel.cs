// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model.ChargeCodeGLAccountMappingModel
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.Model.Validation;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.Interface;
using MGASystems.IMS.Accounting.Core.DataAccess.ChargeCode;
using MGASystems.IMS.Accounting.Core.DataAccess.ClientOffice;
using MGASystems.IMS.Accounting.Core.DataAccess.GLAccount;
using MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Data;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.Mvc.ChargeCodeGLAccountMapping.Model;

[Override(typeof (IChargeCodeGLAccountMappingModel))]
public class ChargeCodeGLAccountMappingModel : 
  ValidateModelBase,
  IChargeCodeGLAccountMappingModel,
  IUpdateDatabaseModel,
  ITrackChanges,
  IValidateModel,
  IMvcModel,
  IValidate,
  ISaveModel,
  ISave,
  IUniqueObject
{
  private readonly IChargeCodeGLAccountMappingRepository _repository;
  private readonly ChargeCodeDto _chargeCodeDto;
  private bool _hasChanges;

  public IEnumerable<OfficeGlMapping> OfficeGlMappings { get; }

  public string Name => this._chargeCodeDto.ChargeName;

  public string Description => this._chargeCodeDto.Description;

  public string State => this._chargeCodeDto.StateID;

  public object UniqueIdentifier => (object) Guid.NewGuid();

  public ChargeCodeGLAccountMappingModel(
    IChargeCodeGLAccountMappingRepository repository,
    ChargeCodeDto chargeCodeDto,
    IEnumerable<ChargeCodeGLAccountMappingDto> existingMappings,
    IEnumerable<ClientOfficeDto> clientOffices,
    IEnumerable<GLAccountDto> glAccounts)
  {
    ChargeCodeGLAccountMappingModel accountMappingModel = this;
    this._repository = repository ?? throw new ArgumentNullException(nameof (repository));
    this._chargeCodeDto = chargeCodeDto ?? throw new ArgumentNullException(nameof (chargeCodeDto));
    if (existingMappings.Any<ChargeCodeGLAccountMappingDto>((Func<ChargeCodeGLAccountMappingDto, bool>) (map => map.ChargeCode != accountMappingModel._chargeCodeDto.ChargeCode)))
      throw new InvalidOperationException("Existing Mappings need to have a matching charge code!");
    this.OfficeGlMappings = (IEnumerable<OfficeGlMapping>) clientOffices.Select<ClientOfficeDto, OfficeGlMapping>((Func<ClientOfficeDto, OfficeGlMapping>) (clientOffice => new OfficeGlMapping(clientOffice, existingMappings.FirstOrDefault<ChargeCodeGLAccountMappingDto>((Func<ChargeCodeGLAccountMappingDto, bool>) (mapping => mapping.OfficeId == clientOffice.OfficeId)), glAccounts.Where<GLAccountDto>((Func<GLAccountDto, bool>) (account =>
    {
      int? glCompanyId = account.GLCompanyId;
      int officeId = clientOffice.OfficeId;
      return glCompanyId.GetValueOrDefault() == officeId & glCompanyId.HasValue;
    }))))).ToList<OfficeGlMapping>();
  }

  public bool HasChanges()
  {
    return this._hasChanges || this.OfficeGlMappings.Any<OfficeGlMapping>((Func<OfficeGlMapping, bool>) (map => map.HasChanges()));
  }

  public void MarkChanged() => this._hasChanges = true;

  public void ResetChanges()
  {
    this._hasChanges = false;
    foreach (OfficeGlMapping officeGlMapping in this.OfficeGlMappings)
    {
      if (officeGlMapping.HasChanges())
      {
        if (officeGlMapping.HasExistingMapping())
        {
          officeGlMapping.SetGLAccountToDatabaseValue();
        }
        else
        {
          officeGlMapping.GlAccount = (GLAccountDto) null;
          officeGlMapping.ResetChanges();
        }
      }
    }
  }

  public void SaveChanges()
  {
    foreach (OfficeGlMapping officeGlMapping in this.OfficeGlMappings)
    {
      if (officeGlMapping.HasDirtyData())
      {
        ChargeCodeGLAccountMappingDto byId = ((IGetByIdRepository<ChargeCodeGLAccountMappingDto, int>) this._repository).GetById(!officeGlMapping.HasExistingMapping() ? this.ExecuteDatabaseInsertCommand(officeGlMapping) : this.UpdateDatabase(officeGlMapping));
        officeGlMapping.UpdateDatabaseRecord(byId);
      }
    }
  }

  protected override void ChildValidateData(DataValidationResultGroup validationResult)
  {
  }

  private int ExecuteDatabaseInsertCommand(OfficeGlMapping mapping)
  {
    return ((ICreateRepository<ChargeCodeGLAccountMappingDto, int>) this._repository).Insert(new ChargeCodeGLAccountMappingDto()
    {
      ChargeCode = this._chargeCodeDto.ChargeCode,
      OfficeId = mapping.ClientOfficeId,
      GlAccountId = ((UniqueObject<int>) mapping.GlAccount)?.UniqueIdentifier,
      LastModifiedUser = CurrentUser.Instance.UserGUID
    });
  }

  private int UpdateDatabase(OfficeGlMapping mapping)
  {
    ((IUpdateRepository<ChargeCodeGLAccountMappingDto, int>) this._repository).Update(new ChargeCodeGLAccountMappingDto()
    {
      ChargeCode = this._chargeCodeDto.ChargeCode,
      OfficeId = mapping.ClientOfficeId,
      GlAccountId = ((UniqueObject<int>) mapping.GlAccount)?.UniqueIdentifier,
      LastModifiedUser = CurrentUser.Instance.UserGUID,
      Id = mapping.DatabaseId
    });
    return mapping.DatabaseId;
  }
}
