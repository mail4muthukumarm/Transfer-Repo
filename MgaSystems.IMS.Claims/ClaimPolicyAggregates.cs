// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimPolicyAggregates
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Data;
using System;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ClaimPolicyAggregates
{
  public int ControlNumber { get; private set; }

  public int NumberOfClaimants { get; private set; }

  public Decimal IndemnityReserves { get; private set; }

  public Decimal IndemnityPayments { get; private set; }

  public Decimal ExpenseReserves { get; private set; }

  public Decimal ExpensePayments { get; private set; }

  public int Occurences { get; private set; }

  public Decimal AllReserves => this.IndemnityReserves + this.ExpenseReserves;

  public Decimal AllPayments => this.IndemnityPayments + this.ExpensePayments;

  public ClaimPolicyAggregates(int controlNumber)
  {
    this.ControlNumber = controlNumber;
    this.LoadClaimPolicyAggregates();
  }

  private void LoadClaimPolicyAggregates()
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spClaim_GetPolicyClaimAggregates", new object[2]
    {
      (object) "@controlNumber",
      (object) this.ControlNumber
    });
    if (dataRow == null)
      return;
    this.NumberOfClaimants = (int) dataRow["Claimants"];
    this.Occurences = (int) dataRow["Occurences"];
    this.IndemnityReserves = (Decimal) dataRow["IndemnityReserves"];
    this.IndemnityPayments = (Decimal) dataRow["IndemnityPayments"];
    this.ExpenseReserves = (Decimal) dataRow["ExpenseReserves"];
    this.ExpensePayments = (Decimal) dataRow["ExpensePayments"];
  }
}
