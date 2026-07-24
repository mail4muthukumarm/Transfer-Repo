// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes.PolicyDataTypeElement
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;

public enum PolicyDataTypeElement
{
  InsuredPolicyName = 1,
  PolicyNumber = 2,
  EffectiveDate = 3,
  ExpirationDate = 4,
  TransactionEffectiveDate = 5,
  CancellationDate = 6,
  TransactionCreatedDate = 7,
  DateBound = 8,
  DateIssued = 9,
  EndorsementNumber = 10, // 0x0000000A
  PolicyType = 11, // 0x0000000B
  TransactionType = 12, // 0x0000000C
  ExpiringPolicyNumber = 13, // 0x0000000D
  EndorsementEffectiveDate = 14, // 0x0000000E
}
