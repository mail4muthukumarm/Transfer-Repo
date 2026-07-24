// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims_Entities.DataAccess.IClaimsEntityRepository
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claims_Entities.DataAccess;

public interface IClaimsEntityRepository : 
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
{
}
