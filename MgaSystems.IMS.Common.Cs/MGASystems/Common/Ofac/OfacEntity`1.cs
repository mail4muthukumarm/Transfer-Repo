// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Ofac.OfacEntity`1
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Common.Data;
using System;

#nullable disable
namespace MGASystems.Common.Ofac;

public abstract class OfacEntity<TDerived> : 
  CommonMappedObject<TDerived>,
  IOfacSearchEntity,
  IOfacEntity,
  IEntityAddress,
  IEntityName
  where TDerived : OfacEntity<TDerived>
{
  public abstract OfacSystem.OfacCriteria GetSearchCriteria(IOfacSetting ofacSetting);

  public abstract OfacSystem.OfacCriteria GetSettingSearchCriteria(IOfacSearchSetting ofacSetting);

  public virtual OfacSystem.OfacStatus GetOfacStatus()
  {
    return OfacSystem.Instance.GetEntityStatus(this.EntityGuid, this.ParentEntityGuid);
  }

  public OfacSystem.OfacCriteria AsOfacCriteria()
  {
    return ObjectFactory.Instance.CreateObjectAs<OfacSystem.OfacCriteria>((object) this);
  }

  public abstract Guid EntityGuid { get; }

  public abstract Guid? ParentEntityGuid { get; }

  public abstract string EntityType { get; }

  public abstract string RecreateTypeName { get; }

  public abstract string Address1 { get; }

  public abstract string Address2 { get; }

  public abstract string City { get; }

  public abstract string State { get; }

  public abstract string ZipCode { get; }

  public abstract string County { get; }

  public abstract string ISOCountryCode { get; }

  public abstract string FirstName { get; }

  public abstract string MiddleName { get; }

  public abstract string LastName { get; }

  public abstract string BusinessName { get; }

  public abstract bool IsIndividual { get; }
}
