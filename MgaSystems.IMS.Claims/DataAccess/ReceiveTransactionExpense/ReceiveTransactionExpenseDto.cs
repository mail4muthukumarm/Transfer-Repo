// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.DataAccess.ReceiveTransactionExpense.ReceiveTransactionExpenseDto
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;

#nullable disable
namespace MGASystems.IMS.Claims.DataAccess.ReceiveTransactionExpense;

[Serializable]
public class ReceiveTransactionExpenseDto
{
  public Guid UserGuid { get; set; }

  public int ClaimId { get; set; }

  public int UAExpenseId { get; set; }

  public Decimal Amount { get; set; }

  public object BankAccount { get; set; }

  public Guid EntityGuid { get; set; }
}
