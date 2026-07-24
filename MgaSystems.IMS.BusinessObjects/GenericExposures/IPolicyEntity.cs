// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.IPolicyEntity
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;
using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures;

public interface IPolicyEntity
{
  Guid EntityGuid { get; }

  PolicyEntityType EntityType { get; }

  BindingList<PolicyEntityElement> PolicyEntityElements { get; }

  string Description { get; }
}
