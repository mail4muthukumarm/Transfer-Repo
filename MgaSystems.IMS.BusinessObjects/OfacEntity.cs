// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.OfacEntity
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

public abstract class OfacEntity : BaseDataObject, IOfacEntity
{
  public abstract Guid EntityGuid { get; }

  public abstract Guid? ParentEntityGuid { get; }

  public abstract OfacSystem.OfacCriteria GetSearchCriteria(IOfacSetting ofacSetting);

  public virtual OfacSystem.OfacStatus GetOfacStatus()
  {
    return OfacSystem.Instance.GetEntityStatus(this.EntityGuid, this.ParentEntityGuid);
  }

  public OfacSystem.OfacCriteria AsOfacCriteria(string entityType = null, string recreateType = null)
  {
    OfacSystem.OfacCriteria objectAs = ObjectFactory.Instance.CreateObjectAs<OfacSystem.OfacCriteria>((object) this);
    objectAs.EntityType = entityType;
    objectAs.RecreateTypeName = recreateType;
    return objectAs;
  }
}
