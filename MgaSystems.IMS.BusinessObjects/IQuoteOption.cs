// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.IQuoteOption
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common.Enums;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

public interface IQuoteOption
{
  Decimal CalculateFactor(EndorsementCalcTypes CalcType, DateTime effectiveDate);
}
