// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim_Location_Settings.LocationSettingsRepository`1
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claim_Location_Settings;

public abstract class LocationSettingsRepository<TLocationSettingsDto> : 
  ReadWriteRepositoryBase<TLocationSettingsDto, Guid>,
  ILocationSettingsRepository<TLocationSettingsDto>,
  ILocationSettingsRepository,
  IReadWriteRepository<LocationSettingsDto, Guid>,
  IGetByIdRepository<LocationSettingsDto, Guid>,
  IGetByIdRepository,
  IExecuteTransaction,
  IGetAllRepository<LocationSettingsDto, Guid>,
  IGetAllRepository,
  ICreateReadRepository<LocationSettingsDto, Guid>,
  ICreateReadRepository,
  ICreateRepository,
  ICreateRepository<LocationSettingsDto, Guid>,
  IUpdateReadRepository<LocationSettingsDto, Guid>,
  IUpdateReadRepository,
  IUpdateRepository,
  IUpdateRepository<LocationSettingsDto, Guid>,
  IDeleteRepository<LocationSettingsDto, Guid>,
  IDeleteRepository,
  IReadWriteRepository
  where TLocationSettingsDto : LocationSettingsDto, new()
{
  public LocationSettingsRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  protected virtual string DeleteProcedureName => "dbo.spClaims_DeleteLocationSetting";

  protected virtual string UpdateProcedureName => base.InsertProcedureName;

  protected virtual string InsertProcedureName => "dbo.spClaims_InsertLocationSetting";

  protected virtual string GetByIdProcedureName => "dbo.spClaims_GetLocationSettingById";

  protected virtual string GetAllProcedureName => "dbo.spClaims_GetLocationSettings";

  protected virtual string InsertResultColumn => (string) null;

  protected virtual object[] GetInsertParams(TLocationSettingsDto dto)
  {
    return new object[6]
    {
      (object) "@QuotingOfficeId",
      (object) dto.QuotingOfficeId,
      (object) "@GLAcctId",
      (object) dto.GLAcctId,
      (object) "@UserGuid",
      (object) dto.LastModifiedByUserGuid
    };
  }

  protected virtual object[] GetUpdateParams(TLocationSettingsDto dto) => base.GetInsertParams(dto);

  protected virtual object[] GetDeleteParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@QuotingOfficeGuid",
      (object) identifier
    };
  }

  protected virtual object[] GetGetByIdParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@QuotingOfficeGuid",
      (object) identifier
    };
  }

  protected virtual void ValidateId(Guid identifier)
  {
    ((BaseDataAccess<TLocationSettingsDto, Guid>) this).ValidateGuidId(identifier);
  }

  public Guid Insert(LocationSettingsDto dto) => this.BaseInsert((TLocationSettingsDto) dto);

  public void Update(LocationSettingsDto dto)
  {
    ((EditRepositoryBase<TLocationSettingsDto, Guid>) this).BaseUpdate((TLocationSettingsDto) dto);
  }

  public void Delete(LocationSettingsDto dto)
  {
    this.BaseDelete(((UniqueObject<Guid>) dto).UniqueIdentifier);
  }

  LocationSettingsDto[] IGetAllRepository<LocationSettingsDto, Guid>.GetAll()
  {
    return (LocationSettingsDto[]) ((GetAllOnlyRepositoryBase<TLocationSettingsDto, Guid>) this).BaseGetAll();
  }

  LocationSettingsDto IGetByIdRepository<LocationSettingsDto, Guid>.GetById(Guid identifier)
  {
    return (LocationSettingsDto) ((ReadOnlyRepositoryBase<TLocationSettingsDto, Guid>) this).GetById(identifier);
  }
}
