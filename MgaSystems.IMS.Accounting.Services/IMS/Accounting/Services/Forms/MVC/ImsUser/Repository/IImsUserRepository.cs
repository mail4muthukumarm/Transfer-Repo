// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.Repository.IImsUserRepository
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ImsUser.Repository;

public interface IImsUserRepository : 
  IGetAllRepository<ImsUserDto, Guid>,
  IGetAllRepository,
  IExecuteTransaction,
  IGetByIdRepository<ImsUserDto, Guid>,
  IGetByIdRepository
{
}
