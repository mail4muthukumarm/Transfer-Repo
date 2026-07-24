// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Enums.QuoteStatus
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.ComponentModel;

#nullable disable
namespace MGASystems.Common.Enums;

public enum QuoteStatus
{
  [EditorBrowsable(EditorBrowsableState.Never)] Unknown = -1, // 0xFFFFFFFF
  None = 0,
  Submitted = 1,
  Quoted = 2,
  Bound = 3,
  Declined = 4,
  Lost = 5,
  NoticeofCancellation = 6,
  PendingCancellation = 7,
  PendingReinstatement = 8,
  UnboundEndorsement = 9,
  VoidEndorsement = 10, // 0x0000000A
  NotTakenUp = 11, // 0x0000000B
  Cancelled = 12, // 0x0000000C
  Incomplete = 13, // 0x0000000D
  Void = 14, // 0x0000000E
  LostOnBOR = 15, // 0x0000000F
  UnboundCorrection = 16, // 0x00000010
  NonRenewed = 17, // 0x00000011
  RequestForAdditionalInformation = 18, // 0x00000012
  Indicated = 25, // 0x00000019
  UnboundNonRenewal = 26, // 0x0000001A
  UnboundNonRenewalRescinded = 27, // 0x0000001B
  NonRenewalRescinded = 28, // 0x0000001C
  UnboundInternalCorrection = 29, // 0x0000001D
  CreateSupportingLines = 30, // 0x0000001E
}
