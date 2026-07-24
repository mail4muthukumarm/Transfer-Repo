// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics.FormActionDurationRepository
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics;

[Override(typeof (IFormActionDurationRepository))]
public class FormActionDurationRepository : 
  CreateOnlyRepositoryBase<FormActionDurationDto, int>,
  IFormActionDurationRepository,
  ICreateRepository<FormActionDurationDto, int>,
  ICreateRepository,
  IExecuteTransaction
{
  protected override string InsertResultColumn => "InsertedId";

  public FormActionDurationRepository()
    : base((Action<string>) (_ => { }))
  {
  }

  public FormActionDurationRepository(
    Action<string> logAction,
    DataNamesMapper<FormActionDurationDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base(logAction, dataNamesMapper, databaseAccess)
  {
  }

  protected override string InsertProcedureName => "FormActionDurationStatics_Insert";

  protected override object[] GetInsertParams(FormActionDurationDto dto)
  {
    return new object[10]
    {
      (object) "@FormName",
      (object) dto.FormName,
      (object) "@ActionName",
      (object) dto.ActionName,
      (object) "@TimeMs",
      (object) dto.TimeMs,
      (object) "@IsDebug",
      (object) dto.IsDebug,
      (object) "@UserGuid",
      (object) dto.UserGuid
    };
  }

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<FormActionDurationDto, int>) this).ValidateIntegerId(identifier);
  }

  protected override int ConvertToTypedId(object insertResultColumnValue)
  {
    return ((BaseRepository<FormActionDurationDto, int>) this).ConvertToInt(insertResultColumnValue);
  }
}
