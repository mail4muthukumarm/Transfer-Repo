// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.ISupportGenericExposuresAsOf
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures;

public interface ISupportGenericExposuresAsOf
{
  GenericExposuresAsOf GetGenericExposuresAsOf(int controlNo, DateTime AsOfDate);
}
