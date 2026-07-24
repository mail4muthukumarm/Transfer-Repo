// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.ExposureTypes.ExposureType
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures.ExposureTypes;

public enum ExposureType
{
  Premise = 1,
  LiabilityExposure = 2,
  DealerLot = 3,
  Vehicle = 4,
  Location = 5,
  ServiceLot = 6,
  Policy = 7,
  Vessel = 8,
  Equipment = 9,
  Warehouse = 10, // 0x0000000A
  CoverageTypeConveyance = 11, // 0x0000000B
}
