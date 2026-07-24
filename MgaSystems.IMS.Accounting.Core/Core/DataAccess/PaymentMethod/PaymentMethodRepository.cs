// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.PaymentMethod.PaymentMethodRepository
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.Repository.Concrete;
using MGASystems.Data.Repository.Interface;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.PaymentMethod;

[Override(typeof (IPaymentMethodRepository))]
public class PaymentMethodRepository : 
  ReadOnlyRepositoryBase<PaymentMethodDto, char>,
  IPaymentMethodRepository,
  IGetByIdRepository<PaymentMethodDto, char>,
  IGetByIdRepository,
  IExecuteTransaction,
  IGetAllRepository<PaymentMethodDto, char>,
  IGetAllRepository
{
  protected override string GetByIdProcedureName => "[dbo].[spFin_PaymentMethodsGetById]";

  protected override string GetAllProcedureName => "[dbo].[spFin_PaymentMethodsGetAll]";

  protected virtual string GetAllActiveProcedureName => "[dbo].[spFin_PaymentMethodsGetAllActive]";

  protected virtual string GetEntityPaymentMethodProcedureName
  {
    get => "[dbo].[spFin_GetEntityPaymentMethods]";
  }

  public PaymentMethodRepository()
    : base((Action<string>) (s => CurrentUser.Instance.LogAction(s)))
  {
  }

  public IEnumerable<PaymentMethodDto> GetEntityPaymentMethods(
    Guid entityGuid,
    int glCompanyId,
    int bankGlAcctId)
  {
    return (IEnumerable<PaymentMethodDto>) ((BaseDataAccess<PaymentMethodDto, char>) this).MapToDto(((BaseDataAccess<PaymentMethodDto, char>) this).DataAccess.Execute(this.GetEntityPaymentMethodProcedureName, this.GetEntityPaymentMethodsParams(entityGuid, glCompanyId, bankGlAcctId)));
  }

  public IEnumerable<PaymentMethodDto> GetAllActive()
  {
    return (IEnumerable<PaymentMethodDto>) ((BaseDataAccess<PaymentMethodDto, char>) this).MapQueryMultiResult(this.GetAllActiveProcedureName);
  }

  protected override object[] GetGetByIdParams(char identifier)
  {
    return new object[2]
    {
      (object) "@payMethodId",
      (object) identifier
    };
  }

  protected object[] GetEntityPaymentMethodsParams(
    Guid entityGuid,
    int glCompanyId,
    int bankGlAcctId)
  {
    return new object[6]
    {
      (object) "@entityGuid",
      (object) entityGuid,
      (object) "@glCompanyId",
      (object) glCompanyId,
      (object) "@bankGlAcctId",
      (object) bankGlAcctId
    };
  }

  protected override void ValidateId(char identifier)
  {
  }
}
