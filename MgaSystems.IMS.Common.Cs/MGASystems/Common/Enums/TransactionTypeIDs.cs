// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Enums.TransactionTypeIDs
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

#nullable disable
namespace MGASystems.Common.Enums;

public enum TransactionTypeIDs
{
  None = 32, // 0x00000020
  Audit = 65, // 0x00000041
  Cancellation = 67, // 0x00000043
  DownwardInternalCorrection = 68, // 0x00000044
  Endorsement = 69, // 0x00000045
  Installment = 73, // 0x00000049
  Correction = 78, // 0x0000004E
  Reinstatement = 82, // 0x00000052
  UpwardInternalCorrection = 85, // 0x00000055
}
