// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Shared.CostCenter
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using MGASystems.Common.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Accounting.Shared;

[Serializable]
public class CostCenter
{
  private static List<CostCenter> _costCenters = new List<CostCenter>();
  private int costCenterId;
  private string costCenterName;
  private string costCenterDesription;
  private int glCompanyId;

  public CostCenter()
  {
  }

  public CostCenter(int CostCenterId)
  {
    CostCenter costCenter = CostCenter.Exists(CostCenterId);
    if (costCenter == null)
    {
      CostCenter._costCenters.Add(this.GetCostCenter(CostCenterId));
    }
    else
    {
      this.CostCenterId = costCenter.costCenterId;
      this.costCenterName = costCenter.costCenterName;
      this.costCenterDesription = costCenter.costCenterDesription;
      this.glCompanyId = costCenter.glCompanyId;
    }
  }

  private CostCenter(int id, string name, string description, int companyId)
  {
    this.costCenterId = id;
    this.costCenterName = name;
    this.costCenterDesription = description;
    this.glCompanyId = companyId;
  }

  private static CostCenter Exists(int costCenterId)
  {
    for (int index = 0; index < CostCenter._costCenters.Count; ++index)
    {
      if (CostCenter._costCenters[index].costCenterId == costCenterId)
        return CostCenter._costCenters[index];
    }
    return (CostCenter) null;
  }

  public int CostCenterId
  {
    get => this.costCenterId;
    set => this.costCenterId = value;
  }

  public string CostCenterName
  {
    get => this.costCenterName;
    set => this.costCenterName = value;
  }

  public string CostCenterDescription
  {
    get => this.costCenterDesription;
    set => this.costCenterDesription = value;
  }

  public int GlCompanyId
  {
    get => this.glCompanyId;
    set => this.glCompanyId = value;
  }

  protected CostCenter GetCostCenter(int CostCenterId)
  {
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetCostCenter", (object) "@groupid", (object) CostCenterId);
    if (dataTable == null || dataTable.Rows.Count == 0)
      throw new ArgumentOutOfRangeException("An cost center with the specified ID could not be found.");
    this.costCenterId = CostCenterId;
    this.costCenterName = dataTable.Rows[0]["groupName"].ToString();
    this.costCenterDesription = dataTable.Rows[0]["groupDescription"].ToString();
    this.glCompanyId = int.Parse(dataTable.Rows[0]["glCompanyId"].ToString());
    return new CostCenter(this.costCenterId, this.costCenterName, this.costCenterDesription, this.glCompanyId);
  }
}
