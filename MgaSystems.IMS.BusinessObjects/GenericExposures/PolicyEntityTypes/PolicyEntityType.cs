// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes.PolicyEntityType
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;

public enum PolicyEntityType
{
  Insured = 1,
  Company = 2,
  Producer = 3,
  CompanyContact = 4,
  ProducerContact = 5,
  Underwriter = 6,
  TACSR = 7,
  AdditionalInterest = 8,
  CompanyLocation = 9,
  ProducerLocation = 10, // 0x0000000A
  QuotingLocation = 11, // 0x0000000B
  IssuingLocation = 12, // 0x0000000C
}
