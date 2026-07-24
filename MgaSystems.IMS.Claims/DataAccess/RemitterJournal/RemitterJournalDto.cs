// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.RemitterJournal.RemitterJournalDto
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.RemitterJournal;

[Serializable]
public class RemitterJournalDto
{
  public DateTime ReceiveDate { get; set; }

  public DateTime DepositDate { get; set; }

  public string CheckNumber { get; set; }

  public Guid RemitterGuid { get; set; }

  public Decimal Amount { get; set; }

  public string Comments { get; set; }

  public object RemittedFrom { get; set; }
}
