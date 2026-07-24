// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Enums.PolicyTypes
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

#nullable disable
namespace MGASystems.Common.Enums;

public enum PolicyTypes
{
  Unknown = -1, // 0xFFFFFFFF
  None = 0,
  NewBusiness = 1,
  Renewal = 2,
  Rewrite = 3,
  CourtesyFiling = 4,
  BrokerOnRecord = 5,
  CarrierRenewal = 6,
  PurchasedBook = 7,
}
