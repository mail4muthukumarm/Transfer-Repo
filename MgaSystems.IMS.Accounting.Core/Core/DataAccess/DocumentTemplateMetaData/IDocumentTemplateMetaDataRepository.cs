// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.DocumentTemplateMetaData.IDocumentTemplateMetaDataRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.Repository.Interface;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.DocumentTemplateMetaData;

public interface IDocumentTemplateMetaDataRepository : 
  IReadRepository<DocumentTemplateMetaDataDto, int>,
  IGetAllRepository<DocumentTemplateMetaDataDto, int>,
  IGetAllRepository,
  IExecuteTransaction,
  IGetByIdRepository<DocumentTemplateMetaDataDto, int>,
  IGetByIdRepository
{
}
