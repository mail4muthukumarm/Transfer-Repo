// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Shared.CostCenterAllocation
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using System;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.Shared;

[Serializable]
public class CostCenterAllocation : CostCenter
{
  private Decimal allocatedAmount;

  public CostCenterAllocation()
  {
  }

  public CostCenterAllocation(int CostCenterId, Decimal AllocatedAmount)
    : base(CostCenterId)
  {
    this.allocatedAmount = AllocatedAmount;
  }

  public Decimal AllocatedAmount
  {
    get => this.allocatedAmount;
    set => this.allocatedAmount = value;
  }

  public void Save(SqlCommand cmd, int PostingNumber, bool IsCredit)
  {
    cmd.CommandText = "dbo.spFin_InsertCostCenterAllocation";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@PostingNum", (object) PostingNumber);
    cmd.Parameters.AddWithValue("@Amount", (object) (!IsCredit || !(this.allocatedAmount > 0M) ? this.allocatedAmount : -this.allocatedAmount));
    cmd.Parameters.AddWithValue("@CostCenterId", (object) this.CostCenterId);
    cmd.ExecuteNonQuery();
  }

  public delegate void CostCenterAllocationsChangedHandler(object sender, EventArgs e);
}
