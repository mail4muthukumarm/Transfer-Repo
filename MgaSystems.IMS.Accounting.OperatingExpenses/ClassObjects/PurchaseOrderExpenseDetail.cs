// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.PurchaseOrderExpenseDetail
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.Shared;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class PurchaseOrderExpenseDetail : Expense, ISupportCostCenterAllocation, ICloneable
{
  private CostCenterAllocationCollection costCenterAllocations;
  private int glAccountId;
  private Decimal expenseAmount;
  private Decimal discountAmount;
  private bool isDiscountPercentage;
  private DateTime expenseDate;
  private Guid expenseFor;
  private bool is1099Item;
  private PurchaseOrderExpense parent;

  [EditorBrowsable(EditorBrowsableState.Never)]
  private PurchaseOrderExpenseDetail()
  {
  }

  public PurchaseOrderExpenseDetail(int ExpenseCode, int GlAccountId, PurchaseOrderExpense Parent)
    : base(ExpenseCode)
  {
    this.glAccountId = GlAccountId;
    this.parent = Parent;
  }

  public PurchaseOrderExpenseDetail(
    int ExpenseCode,
    Decimal ExpenseAmount,
    int GlAccountId,
    PurchaseOrderExpense Parent)
    : base(ExpenseCode)
  {
    this.expenseAmount = ExpenseAmount;
    this.glAccountId = GlAccountId;
    this.parent = Parent;
  }

  public PurchaseOrderExpenseDetail(
    int ExpenseCode,
    Decimal ExpenseAmount,
    Decimal DiscountAmount,
    bool IsDiscountPercentage,
    DateTime ExpenseDate,
    Guid ExpenseFor,
    int GlAccountId,
    PurchaseOrderExpense Parent)
    : base(ExpenseCode)
  {
    this.expenseAmount = ExpenseAmount;
    this.discountAmount = DiscountAmount;
    this.isDiscountPercentage = IsDiscountPercentage;
    this.expenseDate = ExpenseDate;
    this.expenseFor = ExpenseFor;
    this.glAccountId = GlAccountId;
    this.parent = Parent;
  }

  public CostCenterAllocationCollection CostCenterAllocations
  {
    get
    {
      if (this.costCenterAllocations == null)
        this.costCenterAllocations = new CostCenterAllocationCollection();
      return this.costCenterAllocations;
    }
    set => this.costCenterAllocations = value;
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.Hidden)]
  public int GlAccountId
  {
    get => this.glAccountId;
    set => this.glAccountId = value;
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.NotHidden)]
  public Decimal ExpenseAmount
  {
    get => this.expenseAmount;
    set => this.expenseAmount = value;
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.NotHidden)]
  public Decimal DiscountAmount
  {
    get => this.discountAmount;
    set => this.discountAmount = value;
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.NotHidden)]
  public Decimal ExpenseTotal
  {
    get
    {
      return !this.IsDiscountPercentage ? this.expenseAmount - this.discountAmount : this.expenseAmount - this.expenseAmount * (this.discountAmount / 100M);
    }
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.Hidden)]
  public bool IsDiscountPercentage
  {
    get => this.isDiscountPercentage;
    set => this.isDiscountPercentage = value;
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.NotHidden)]
  public DateTime ExpenseDate
  {
    get => this.expenseDate;
    set => this.expenseDate = value;
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.Hidden)]
  public Guid ExpenseFor
  {
    get => this.expenseFor;
    set => this.expenseFor = value;
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.NotHidden)]
  public string ExpenseForName
  {
    get
    {
      return this.expenseFor.Equals(Guid.Empty) ? MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("EmptyString") : Database.Instance.QueryText.PerformScalarQueryString($"select dbo.GetEntityName('{this.expenseFor}')");
    }
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.Hidden)]
  public PurchaseOrderExpense Parent => this.parent;

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.Hidden)]
  public PurchaseOrderExpenseDetail.DetailObjectState State
  {
    get
    {
      return this.glAccountId != 0 && this.costCenterAllocations != null && this.costCenterAllocations.AllocationsTotal() == this.ExpenseTotal && this.ExpenseCode != 0 ? PurchaseOrderExpenseDetail.DetailObjectState.Complete : PurchaseOrderExpenseDetail.DetailObjectState.InComplete;
    }
  }

  [BindingDisplayOptions(BindingDisplayOptions.GridDisplayOption.NotHidden)]
  public bool Is1099Item
  {
    get => this.is1099Item;
    set => this.is1099Item = value;
  }

  internal void Save(SqlCommand cmd, int PurchaseOrderNumber)
  {
    cmd.CommandText = "dbo.spFin_InsertPODetails";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@PONUM", (object) PurchaseOrderNumber);
    cmd.Parameters.AddWithValue("@EXPENSECODE", (object) this.ExpenseCode);
    cmd.Parameters.AddWithValue("@AMOUNT", (object) this.ExpenseAmount);
    cmd.Parameters.AddWithValue("@DISCOUNT", (object) this.DiscountAmount);
    cmd.Parameters.AddWithValue("@EXPENSEDATE", (object) this.ExpenseDate);
    cmd.Parameters.AddWithValue("@EXPENSEFOR", (object) this.ExpenseFor);
    cmd.Parameters.AddWithValue("@GLACCTID", (object) this.GlAccountId);
    cmd.Parameters.AddWithValue("@IS1099ITEM", (object) this.Is1099Item);
    cmd.ExecuteNonQuery();
  }

  public string GLAccountName => (string) null;

  public DateTime TransactionDate => this.ExpenseDate;

  public int PostingNumber => 0;

  CostCenterAllocationCollection ISupportCostCenterAllocation.CostCenterAllocations
  {
    get => this.CostCenterAllocations;
  }

  public Decimal TransactionTotal => this.ExpenseTotal;

  public object Clone()
  {
    PurchaseOrderExpenseDetail orderExpenseDetail = new PurchaseOrderExpenseDetail(this.ExpenseCode, this.ExpenseAmount, this.DiscountAmount, this.IsDiscountPercentage, this.ExpenseDate, this.ExpenseFor, this.GlAccountId, this.Parent);
    foreach (CostCenterAllocation centerAllocation in (CollectionBase) this.CostCenterAllocations)
    {
      CostCenterAllocation costCenterAllocation = new CostCenterAllocation();
      costCenterAllocation.CostCenterId = centerAllocation.CostCenterId;
      costCenterAllocation.AllocatedAmount = centerAllocation.AllocatedAmount;
      costCenterAllocation.CostCenterName = centerAllocation.CostCenterName;
      costCenterAllocation.CostCenterDescription = centerAllocation.CostCenterDescription;
      costCenterAllocation.GlCompanyId = centerAllocation.GlCompanyId;
      orderExpenseDetail.CostCenterAllocations.Add(costCenterAllocation, this.ExpenseAmount);
    }
    return (object) orderExpenseDetail;
  }

  public enum DetailObjectState
  {
    InComplete,
    Complete,
  }
}
