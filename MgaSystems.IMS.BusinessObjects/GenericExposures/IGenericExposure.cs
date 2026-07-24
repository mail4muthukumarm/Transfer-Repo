// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.IGenericExposure
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.GenericExposures.ExposureTypes;
using System.ComponentModel;

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures;

public interface IGenericExposure
{
  int ExposureID { get; }

  ExposureType ExposureType { get; }

  BindingList<ExposureElement> ExposureElements { get; }

  string Description { get; }

  int RaterID { get; }

  int RiskTypeId { get; }

  string RiskTypeDescription { get; }

  BindingList<IGenericCoverage> ExposureCoverages { get; }
}
