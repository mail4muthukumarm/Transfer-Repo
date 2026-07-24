// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.W9.IW9Repository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.W9;

public interface IW9Repository : 
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
{
}
