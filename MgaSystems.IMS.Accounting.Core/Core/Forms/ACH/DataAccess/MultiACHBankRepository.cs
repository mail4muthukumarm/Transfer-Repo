// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.DataAccess.MultiACHBankRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.ColumnAttribute;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH.DataAccess;

[Override(typeof (IMultiACHBankRepository))]
public class MultiACHBankRepository : BaseRepository<ACHBankDto, int>, IMultiACHBankRepository
{
  private static readonly string _getApprovedForEntityGuidProcedureName = "dbo.spFin_GetActiveBanksForEntityGuid";
  private static readonly string _getForEntityGuid = "dbo.spFin_GetBanksForEntityGuid";

  public MultiACHBankRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  public MultiACHBankRepository(
    DataNamesMapper<ACHBankDto> dataNamesMapper,
    IDatabaseAccess databaseAccess)
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)), dataNamesMapper, databaseAccess)
  {
  }

  public ACHBankDto[] GetApprovedForEntityGuid(Guid entityGuid)
  {
    return ((BaseDataAccess<ACHBankDto, int>) this).MapQueryMultiResult(MultiACHBankRepository._getApprovedForEntityGuidProcedureName, new object[2]
    {
      (object) "@EntityGuid",
      (object) entityGuid
    });
  }

  public ACHBankDto[] GetByEntityGuid(Guid entityGuid)
  {
    return ((BaseDataAccess<ACHBankDto, int>) this).MapQueryMultiResult(MultiACHBankRepository._getForEntityGuid, new object[2]
    {
      (object) "@EntityGuid",
      (object) entityGuid
    });
  }

  protected override void ValidateId(int identifier)
  {
    ((BaseDataAccess<ACHBankDto, int>) this).ValidateIntegerId(identifier);
  }
}
