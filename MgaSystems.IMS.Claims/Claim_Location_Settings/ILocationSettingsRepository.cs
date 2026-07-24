// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claim_Location_Settings.ILocationSettingsRepository
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.Claim_Location_Settings;

public interface ILocationSettingsRepository : 
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
{
}
