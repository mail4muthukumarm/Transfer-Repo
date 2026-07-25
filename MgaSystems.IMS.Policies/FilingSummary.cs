// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FilingSummary
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win.UltraWinGrid;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

public class FilingSummary : ICustomSummaryCalculator
{
  private string _columnName;

  public FilingSummary(string columnName) => this._columnName = columnName;

  void ICustomSummaryCalculator.BeginCustomSummary(
    SummarySettings summarySettings,
    RowsCollection rows)
  {
  }

  object ICustomSummaryCalculator.ICustomSummaryCalculator_EndCustomSummary(
    SummarySettings summarySettings,
    RowsCollection rows)
  {
    Decimal d1 = 0M;
    foreach (UltraGridRow row in rows)
    {
      if (row.Cells[this._columnName].Value != null && row.Cells[this._columnName].Value != DBNull.Value)
        d1 = Decimal.Add(d1, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row.Cells[this._columnName].Value)));
    }
    return (object) d1;
  }

  void ICustomSummaryCalculator.ICustomSummaryCalculator_AggregateCustomSummary(
    SummarySettings summarySettings,
    UltraGridRow row)
  {
  }
}
