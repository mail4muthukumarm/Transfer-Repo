// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.W9EntityType.IW9EntityTypeRepositoryReadOnly
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.Repository.Interface;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.W9EntityType;

public interface IW9EntityTypeRepositoryReadOnly : 
  IGetAllRepository<W9EntityTypeDto, int>,
  IGetAllRepository,
  IExecuteTransaction
{
}
