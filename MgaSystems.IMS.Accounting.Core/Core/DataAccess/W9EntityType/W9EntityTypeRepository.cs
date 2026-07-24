// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.W9EntityType.W9EntityTypeRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.W9EntityType;

[Override(typeof (IW9EntityTypeRepositoryReadOnly))]
public class W9EntityTypeRepository : 
  GetAllOnlyRepositoryBase<W9EntityTypeDto, int>,
  IW9EntityTypeRepositoryReadOnly,
  IGetAllRepository<W9EntityTypeDto, int>,
  IGetAllRepository,
  IExecuteTransaction
{
  public W9EntityTypeRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  protected override string GetAllProcedureName => "[dbo].[spFin_W9EntityTypeGetAll]";

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<W9EntityTypeDto, int>) this).ValidateIntegerId(identifier);
  }
}
