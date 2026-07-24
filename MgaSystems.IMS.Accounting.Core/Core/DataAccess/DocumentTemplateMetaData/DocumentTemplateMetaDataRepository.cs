// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.DocumentTemplateMetaData.DocumentTemplateMetaDataRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.DocumentTemplateMetaData;

[Override(typeof (IDocumentTemplateMetaDataRepository))]
public class DocumentTemplateMetaDataRepository : 
  ReadOnlyRepositoryBase<DocumentTemplateMetaDataDto, int>,
  IDocumentTemplateMetaDataRepository,
  IReadRepository<DocumentTemplateMetaDataDto, int>,
  IGetAllRepository<DocumentTemplateMetaDataDto, int>,
  IGetAllRepository,
  IExecuteTransaction,
  IGetByIdRepository<DocumentTemplateMetaDataDto, int>,
  IGetByIdRepository
{
  public DocumentTemplateMetaDataRepository()
    : base(new Action<string>(CurrentUser.Instance.LogAction))
  {
  }

  public DocumentTemplateMetaDataRepository(
    Action<string> logAction,
    DataNamesMapper<DocumentTemplateMetaDataDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string GetAllProcedureName => "[dbo].[spFin_DocumentTemplateMetaData_GetAll]";

  protected override string GetByIdProcedureName
  {
    get => "[dbo].[spFin_DocumentTemplateMetaData_GetById]";
  }

  protected override object[] GetGetByIdParams(int identifier)
  {
    return new object[2]
    {
      (object) "@Id",
      (object) identifier
    };
  }

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<DocumentTemplateMetaDataDto, int>) this).ValidateIntegerId(identifier);
  }
}
