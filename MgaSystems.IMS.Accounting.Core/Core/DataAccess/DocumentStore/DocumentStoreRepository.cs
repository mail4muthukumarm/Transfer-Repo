// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.DocumentStore.DocumentStoreRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.DocumentStore;

public class DocumentStoreRepository : 
  GetByIdOnlyRepositoryBase<DocumentStoreDto, Guid>,
  IDocumentStoreRepository,
  IGetByIdRepository<DocumentStoreDto, Guid>,
  IGetByIdRepository,
  IExecuteTransaction
{
  public DocumentStoreRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  protected override string GetByIdProcedureName => "[dbo].[spFin_tblDocumentStore_GetById]";

  protected override object[] GetGetByIdParams(Guid identifier)
  {
    return new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) identifier
    };
  }

  protected override void ValidateId(Guid identifier)
  {
    ((BaseDataAccess<DocumentStoreDto, Guid>) this).ValidateGuidId(identifier);
  }
}
