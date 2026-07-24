// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.PaymentMethod.PaymentMethodRepositoryCache
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.CommonInterface;
using MGASystems.Data.Repository.Interface;
using MGASystems.Data.Repository.RecordCache;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.PaymentMethod;

[Override(typeof (IPaymentMethodRepositoryCache))]
public class PaymentMethodRepositoryCache : 
  DatabaseCacheAllBase<IPaymentMethodRepository, PaymentMethodDto, char>,
  IPaymentMethodRepositoryCache,
  IDatabaseCache<IPaymentMethodRepository>,
  IExecuteTransaction,
  IPaymentMethodRepository,
  IGetByIdRepository<PaymentMethodDto, char>,
  IGetByIdRepository,
  IGetAllRepository<PaymentMethodDto, char>,
  IGetAllRepository
{
  public override IPaymentMethodRepository Repository { get; }

  public PaymentMethodRepositoryCache(IPaymentMethodRepository paymentMethodRepository)
  {
    this.Repository = paymentMethodRepository ?? ObjectFactory.Instance.CreateObjectAs<IPaymentMethodRepository>();
  }

  public PaymentMethodRepositoryCache()
    : this(ObjectFactory.Instance.CreateObjectAs<IPaymentMethodRepository>())
  {
  }

  public IEnumerable<PaymentMethodDto> GetAllActive()
  {
    return ((IEnumerable<PaymentMethodDto>) this.AllData).Where<PaymentMethodDto>((Func<PaymentMethodDto, bool>) (dto => dto.IsActive));
  }

  public PaymentMethodDto GetById(char identifier)
  {
    IEnumerable<PaymentMethodDto> source = ((IEnumerable<PaymentMethodDto>) this.AllData).Where<PaymentMethodDto>((Func<PaymentMethodDto, bool>) (data => (int) ((UniqueObject<char>) data).UniqueIdentifier == (int) identifier));
    return source.Count<PaymentMethodDto>() == 1 ? source.Single<PaymentMethodDto>() : throw new InvalidOperationException($"Could not find a {typeof (PaymentMethodDto).Name} for the identifier: '{identifier}' (type: " + $"{typeof (char).Name}). Found {source.Count<PaymentMethodDto>()} rows.");
  }

  public object GetById(object id)
  {
    return id is char identifier ? (object) this.GetById(identifier) : throw new InvalidOperationException("Id must be of type char.");
  }

  public IEnumerable<PaymentMethodDto> GetEntityPaymentMethods(
    Guid entityGuid,
    int glCompanyId,
    int bankGlAcctId)
  {
    return base.Repository.GetEntityPaymentMethods(entityGuid, glCompanyId, bankGlAcctId);
  }
}
