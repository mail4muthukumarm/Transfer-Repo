// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.IMS_Overrides.ClaimReceivableValue
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims.IMS_Overrides;

[Serializable]
public class ClaimReceivableValue
{
  public ClaimReceivableValue(int claimId, int uaExpenseId, int resPayId, Decimal amount)
  {
    this.ClaimId = claimId;
    this.UAExpenseId = uaExpenseId;
    this.ResPayId = resPayId;
    this.Amount = amount;
  }

  public int ClaimId { get; set; }

  public int UAExpenseId { get; set; }

  public int ResPayId { get; set; }

  public Decimal Amount { get; set; }
}
