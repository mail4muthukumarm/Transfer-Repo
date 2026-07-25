// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Interfaces.ISupportAutomaticRenewal
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Underwriting.Interfaces;

internal interface ISupportAutomaticRenewal
{
  bool CheckRaterParameters(Guid PolicyGuid, int controlNo);

  Decimal CallRater(Guid RenewedPolicyGuid);

  DataTable GetPremiumInsertionParameters(Guid RenewalGuid);
}
