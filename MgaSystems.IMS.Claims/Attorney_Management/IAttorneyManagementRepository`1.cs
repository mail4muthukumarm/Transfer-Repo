// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Attorney_Management.IAttorneyManagementRepository`1
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Attorney_Management;

public interface IAttorneyManagementRepository<TAttorneyManagementDto> : 
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
  where TAttorneyManagementDto : AttorneyManagementDto
{
}
