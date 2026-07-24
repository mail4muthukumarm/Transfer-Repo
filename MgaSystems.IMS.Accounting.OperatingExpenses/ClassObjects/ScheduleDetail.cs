// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ScheduleDetail
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class ScheduleDetail
{
  private DateTime expenseDate;
  private string payeeName;
  private Decimal expenseAmount;

  private ScheduleDetail()
  {
  }

  public ScheduleDetail(DateTime ExpenseDate, string PayeeName, Decimal ExpenseAmount)
  {
    this.expenseDate = ExpenseDate;
    this.payeeName = PayeeName;
    this.expenseAmount = ExpenseAmount;
  }

  public DateTime ExpenseDate => this.expenseDate;

  public string PayeeName => this.payeeName;

  public Decimal ExpenseAmount => this.expenseAmount;
}
