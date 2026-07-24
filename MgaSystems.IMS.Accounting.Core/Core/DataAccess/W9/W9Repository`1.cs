// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.W9.W9Repository`1
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.W9;

public abstract class W9Repository<TW9Dto> : 
  ReadWriteRepositoryBase<TW9Dto, Guid>,
  IW9Repository<TW9Dto>,
  IW9Repository,
  IReadWriteRepository<W9Dto, Guid>,
  IGetByIdRepository<W9Dto, Guid>,
  IGetByIdRepository,
  IExecuteTransaction,
  IGetAllRepository<W9Dto, Guid>,
  IGetAllRepository,
  ICreateReadRepository<W9Dto, Guid>,
  ICreateReadRepository,
  ICreateRepository,
  ICreateRepository<W9Dto, Guid>,
  IUpdateReadRepository<W9Dto, Guid>,
  IUpdateReadRepository,
  IUpdateRepository,
  IUpdateRepository<W9Dto, Guid>,
  IDeleteRepository<W9Dto, Guid>,
  IDeleteRepository,
  IReadWriteRepository
  where TW9Dto : W9Dto, new()
{
  public W9Repository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  protected override string DeleteProcedureName => "[dbo].[spFin_W9DeleteById]";

  protected override string UpdateProcedureName => "[dbo].[spFin_W9Update]";

  protected override string InsertProcedureName => "[dbo].[spFin_W9Insert]";

  protected override string GetByIdProcedureName => "[dbo].[spFin_W9GetById]";

  protected override string GetAllProcedureName => "[dbo].[spFin_GetAllW9Data]";

  protected override string InsertResultColumn => (string) null;

  protected override object[] GetInsertParams(TW9Dto dto)
  {
    return new object[28]
    {
      (object) "@EntityGuid",
      (object) dto.EntityGuid,
      (object) "@TaxingEntity",
      (object) dto.TaxingEntity,
      (object) "@BusinessName",
      (object) dto.BusinessName,
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
      (object) "@TinEin",
      (object) dto.TinEin,
      (object) "@W9Date",
      (object) dto.W9Date,
      (object) "@EntityTypeId",
      (object) dto.EntityTypeId,
      (object) "@EntityTypeOther",
      (object) dto.EntityTypeOther,
      (object) "@UserGuid",
      (object) dto.LastModifiedByUserGuid
    };
  }

  protected override object[] GetDeleteParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@EntityGuid",
      (object) identifier
    };
  }

  protected override object[] GetGetByIdParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@EntityGuid",
      (object) identifier
    };
  }

  protected override object[] GetUpdateParams(TW9Dto dto) => base.GetInsertParams(dto);

  protected override void ValidateId(Guid identifier)
  {
    ((BaseDataAccess<TW9Dto, Guid>) this).ValidateGuidId(identifier);
  }

  public Guid Insert(W9Dto dto) => this.BaseInsert((TW9Dto) dto);

  public void Update(W9Dto dto)
  {
    ((EditRepositoryBase<TW9Dto, Guid>) this).BaseUpdate((TW9Dto) dto);
  }

  public void Delete(W9Dto dto) => this.BaseDelete(((UniqueObject<Guid>) dto).UniqueIdentifier);

  W9Dto[] IGetAllRepository<W9Dto, Guid>.GetAll()
  {
    return (W9Dto[]) ((GetAllOnlyRepositoryBase<TW9Dto, Guid>) this).BaseGetAll();
  }

  W9Dto IGetByIdRepository<W9Dto, Guid>.GetById(Guid identifier)
  {
    return (W9Dto) ((ReadOnlyRepositoryBase<TW9Dto, Guid>) this).GetById(identifier);
  }
}
