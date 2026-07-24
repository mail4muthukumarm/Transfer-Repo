// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.AccountsReceivableFilterCondition
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinGrid;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core;

public class AccountsReceivableFilterCondition : FilterCondition
{
  public override bool MeetsCriteria(UltraGridRow row)
  {
    if (!((KeyedSubObjectsCollectionBase) ((GridItemBase) row).Band.Columns).Exists("arapplied") || !((KeyedSubObjectsCollectionBase) ((GridItemBase) row).Band.Columns).Exists("exchapplied") || !((KeyedSubObjectsCollectionBase) ((GridItemBase) row).Band.Columns).Exists("unacctapplied"))
      return false;
    object obj1 = row.Cells["arapplied"].Value;
    object obj2 = row.Cells["unacctapplied"].Value;
    object obj3 = row.Cells["exchapplied"].Value;
    return obj1 != null && (obj1 as Decimal?).HasValue && (obj1 as Decimal?).Value != 0M || obj2 != null && (obj2 as Decimal?).HasValue && (obj2 as Decimal?).Value != 0M || obj3 != null && (obj3 as Decimal?).HasValue && (obj3 as Decimal?).Value != 0M;
  }
}
