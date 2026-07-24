// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.DataAccess.ClaimsEntityRepository`1
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities.DataAccess;

public abstract class ClaimsEntityRepository<TClaimsEntityDto> : 
  ReadWriteRepositoryBase<TClaimsEntityDto, Guid>,
  IClaimsEntityRepository<TClaimsEntityDto>,
  IClaimsEntityRepository,
  IReadWriteRepository<ClaimsEntityDto, Guid>,
  IGetByIdRepository<ClaimsEntityDto, Guid>,
  IGetByIdRepository,
  IExecuteTransaction,
  IGetAllRepository<ClaimsEntityDto, Guid>,
  IGetAllRepository,
  ICreateReadRepository<ClaimsEntityDto, Guid>,
  ICreateReadRepository,
  ICreateRepository,
  ICreateRepository<ClaimsEntityDto, Guid>,
  IUpdateReadRepository<ClaimsEntityDto, Guid>,
  IUpdateReadRepository,
  IUpdateRepository,
  IUpdateRepository<ClaimsEntityDto, Guid>,
  IDeleteRepository<ClaimsEntityDto, Guid>,
  IDeleteRepository,
  IReadWriteRepository
  where TClaimsEntityDto : ClaimsEntityDto, new()
{
  public ClaimsEntityRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  protected virtual string DeleteProcedureName => "spClaims_DeleteClaimEntity";

  protected virtual string UpdateProcedureName => "spClaims_UpdateClaimEntity";

  protected virtual string InsertProcedureName => "spClaims_InsertClaimEntity";

  protected virtual string GetByIdProcedureName => "spClaims_GetClaimEntityById";

  protected virtual string GetAllProcedureName => "spClaims_GetClaimEntities";

  protected virtual string InsertResultColumn => (string) null;

  protected virtual object[] GetInsertParams(TClaimsEntityDto dto)
  {
    return new object[40]
    {
      (object) "@EntityGuid",
      (object) dto.EntityGuid,
      (object) "@EntityTypeId",
      (object) dto.EntityTypeId,
      (object) "@EntityName",
      (object) dto.EntityName,
      (object) "@DBA",
      (object) dto.DBA,
      (object) "@FirstName",
      (object) dto.FirstName,
      (object) "@MiddleName",
      (object) dto.MiddleName,
      (object) "@LastName",
      (object) dto.LastName,
      (object) "@Address1",
      (object) dto.Address1,
      (object) "@Address2",
      (object) dto.Address2,
      (object) "@City",
      (object) dto.City,
      (object) "@State",
      (object) dto.State,
      (object) "@ZipCode",
      (object) dto.ZipCode,
      (object) "@ZipExt",
      (object) dto.ZipCodeExtension,
      (object) "@County",
      (object) dto.County,
      (object) "@ISOCountryCode",
      (object) dto.ISOCountryCode,
      (object) "@FEINSSN",
      (object) dto.FEINSSN,
      (object) "@ContactName",
      (object) dto.ContactName,
      (object) "@PhoneNumber",
      (object) dto.PhoneNumber,
      (object) "@FaxNumber",
      (object) dto.FaxNumber,
      (object) "@UserGuid",
      (object) dto.LastModifiedByUserGuid
    };
  }

  protected virtual object[] GetUpdateParams(TClaimsEntityDto dto) => base.GetInsertParams(dto);

  protected virtual object[] GetDeleteParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@EntityGuid",
      (object) identifier
    };
  }

  protected virtual object[] GetGetByIdParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@EntityGuid",
      (object) identifier
    };
  }

  protected virtual void ValidateId(Guid identifier)
  {
    ((BaseDataAccess<TClaimsEntityDto, Guid>) this).ValidateGuidId(identifier);
  }

  public Guid Insert(ClaimsEntityDto dto) => this.BaseInsert((TClaimsEntityDto) dto);

  public void Update(ClaimsEntityDto dto)
  {
    ((EditRepositoryBase<TClaimsEntityDto, Guid>) this).BaseUpdate((TClaimsEntityDto) dto);
  }

  public void Delete(ClaimsEntityDto dto)
  {
    this.BaseDelete(((UniqueObject<Guid>) dto).UniqueIdentifier);
  }

  ClaimsEntityDto[] IGetAllRepository<ClaimsEntityDto, Guid>.GetAll()
  {
    return (ClaimsEntityDto[]) ((GetAllOnlyRepositoryBase<TClaimsEntityDto, Guid>) this).BaseGetAll();
  }

  ClaimsEntityDto IGetByIdRepository<ClaimsEntityDto, Guid>.GetById(Guid identifier)
  {
    return (ClaimsEntityDto) ((ReadOnlyRepositoryBase<TClaimsEntityDto, Guid>) this).GetById(identifier);
  }
}
