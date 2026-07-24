// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.Allocation
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class Allocation
{
  public int CostCenterId { get; set; }

  public Decimal? Percentage { get; set; }

  public Decimal AllocatedAmount { get; set; }

  public string CostCenterName { get; set; }

  public Allocation()
  {
  }

  public Allocation(string costCenterName, int costCenterId, Decimal allocatedAmount)
  {
    this.CostCenterName = costCenterName;
    this.CostCenterId = costCenterId;
    this.AllocatedAmount = allocatedAmount;
  }

  public Allocation(
    string costCenterName,
    int costCenterId,
    Decimal percentage,
    Decimal allocatedAmount)
  {
    this.CostCenterName = costCenterName;
    this.CostCenterId = costCenterId;
    this.Percentage = new Decimal?(percentage);
    this.AllocatedAmount = allocatedAmount;
  }
}
