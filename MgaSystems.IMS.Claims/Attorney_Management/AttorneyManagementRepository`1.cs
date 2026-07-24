// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.AttorneyManagementRepository`1
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Attorney_Management;

public abstract class AttorneyManagementRepository<TAttorneyManagementDto> : 
  ReadWriteRepositoryBase<TAttorneyManagementDto, Guid>,
  IAttorneyManagementRepository<TAttorneyManagementDto>,
  IAttorneyManagementRepository,
  IReadWriteRepository<AttorneyManagementDto, Guid>,
  IGetByIdRepository<AttorneyManagementDto, Guid>,
  IGetByIdRepository,
  IExecuteTransaction,
  IGetAllRepository<AttorneyManagementDto, Guid>,
  IGetAllRepository,
  ICreateReadRepository<AttorneyManagementDto, Guid>,
  ICreateReadRepository,
  ICreateRepository,
  ICreateRepository<AttorneyManagementDto, Guid>,
  IUpdateReadRepository<AttorneyManagementDto, Guid>,
  IUpdateReadRepository,
  IUpdateRepository,
  IUpdateRepository<AttorneyManagementDto, Guid>,
  IDeleteRepository<AttorneyManagementDto, Guid>,
  IDeleteRepository,
  IReadWriteRepository
  where TAttorneyManagementDto : AttorneyManagementDto, new()
{
  public AttorneyManagementRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  protected virtual string DeleteProcedureName => "dbo.spClaims_DeleteAttorney";

  protected virtual string UpdateProcedureName => "dbo.spClaims_UpdateAttorney";

  protected virtual string InsertProcedureName => "dbo.spClaims_InsertAttorney";

  protected virtual string GetByIdProcedureName => "dbo.spClaims_GetAttorneyById";

  protected virtual string GetAllProcedureName => "dbo.spClaims_GetAttorneyList";

  protected virtual string InsertResultColumn => (string) null;

  protected virtual object[] GetInsertParams(TAttorneyManagementDto dto)
  {
    return new object[36]
    {
      (object) "@AttorneyGuid",
      (object) dto.AttorneyGuid,
      (object) "@LawFirm",
      (object) dto.LawFirm,
      (object) "@AttorneyName",
      (object) dto.AttorneyName,
      (object) "@AttorneyType",
      (object) dto.AttorneyType,
      (object) "@FEINSSN",
      (object) dto.FEINSSN,
      (object) "@AttorneyEntityType",
      (object) dto.AttorneyEntityType,
      (object) "@Address1",
      (object) dto.Address1,
      (object) "@Address2",
      (object) dto.Address2,
      (object) "@City",
      (object) dto.City,
      (object) "@County",
      (object) dto.County,
      (object) "@State",
      (object) dto.State,
      (object) "@ZipCode",
      (object) dto.ZipCode,
      (object) "@ZipPlus",
      (object) dto.ZipCodeExtension,
      (object) "@County",
      (object) dto.County,
      (object) "@ISOCountryCode",
      (object) dto.ISOCountryCode,
      (object) "@PhoneNumber",
      (object) dto.PhoneNumber,
      (object) "@FaxNumber",
      (object) dto.FaxNumber,
      (object) "@UserGuid",
      (object) dto.LastModifiedByUserGuid
    };
  }

  protected virtual object[] GetUpdateParams(TAttorneyManagementDto dto)
  {
    return base.GetInsertParams(dto);
  }

  protected virtual object[] GetDeleteParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@AttorneyGuid",
      (object) identifier
    };
  }

  protected virtual object[] GetGetByIdParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@AttorneyGuid",
      (object) identifier
    };
  }

  protected virtual void ValidateId(Guid identifier)
  {
    ((BaseDataAccess<TAttorneyManagementDto, Guid>) this).ValidateGuidId(identifier);
  }

  public Guid Insert(AttorneyManagementDto dto) => this.BaseInsert((TAttorneyManagementDto) dto);

  public void Update(AttorneyManagementDto dto)
  {
    ((EditRepositoryBase<TAttorneyManagementDto, Guid>) this).BaseUpdate((TAttorneyManagementDto) dto);
  }

  public void Delete(AttorneyManagementDto dto)
  {
    this.BaseDelete(((UniqueObject<Guid>) dto).UniqueIdentifier);
  }

  AttorneyManagementDto[] IGetAllRepository<AttorneyManagementDto, Guid>.GetAll()
  {
    return (AttorneyManagementDto[]) ((GetAllOnlyRepositoryBase<TAttorneyManagementDto, Guid>) this).BaseGetAll();
  }

  AttorneyManagementDto IGetByIdRepository<AttorneyManagementDto, Guid>.GetById(Guid identifier)
  {
    return (AttorneyManagementDto) ((ReadOnlyRepositoryBase<TAttorneyManagementDto, Guid>) this).GetById(identifier);
  }
}
