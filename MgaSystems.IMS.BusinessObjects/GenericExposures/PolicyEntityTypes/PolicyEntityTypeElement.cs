// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes.PolicyEntityTypeElement
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

#nullable disable
namespace MGASystems.BusinessObjects.GenericExposures.PolicyEntityTypes;

public enum PolicyEntityTypeElement
{
  FirstName = 1,
  LastName = 2,
  MiddleName = 3,
  Salutation = 4,
  Name = 5,
  FEIN = 6,
  SSN = 7,
  BusinessType = 8,
  Address1 = 9,
  Address2 = 10, // 0x0000000A
  City = 11, // 0x0000000B
  State = 12, // 0x0000000C
  ZipCode = 13, // 0x0000000D
  ZipPlus = 14, // 0x0000000E
  County = 15, // 0x0000000F
  CountryCode = 16, // 0x00000010
  Region = 17, // 0x00000011
  Phone = 18, // 0x00000012
  Fax = 19, // 0x00000013
  Mobile = 20, // 0x00000014
  Code = 21, // 0x00000015
  LocationCode = 22, // 0x00000016
  NYSDMVID = 23, // 0x00000017
  NAIC = 24, // 0x00000018
  Email = 25, // 0x00000019
  PhoneExtension = 26, // 0x0000001A
  BusinessName = 27, // 0x0000001B
  DBA = 28, // 0x0000001C
  AdditionalInterestType = 29, // 0x0000001D
  NYSDMVEncryptionKey = 30, // 0x0000001E
  NYSDMVEncryptionPassphrase = 31, // 0x0000001F
}
