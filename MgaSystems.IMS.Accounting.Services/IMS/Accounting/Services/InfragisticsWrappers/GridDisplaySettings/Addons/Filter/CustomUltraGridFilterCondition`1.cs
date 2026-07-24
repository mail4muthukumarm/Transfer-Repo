// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter.CustomUltraGridFilterCondition`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter;

public class CustomUltraGridFilterCondition<TDisplayItem> : CustomUltraGridFilterCondition
{
  public Func<TDisplayItem, bool> ShouldDisplayFunc { get; }

  internal CustomUltraGridFilterCondition(Func<TDisplayItem, bool> shouldDisplayFunc)
  {
    this.ShouldDisplayFunc = shouldDisplayFunc ?? throw new ArgumentNullException(nameof (shouldDisplayFunc));
  }

  public override bool MeetsCriteria(UltraGridRow row)
  {
    return this.ShouldDisplayFunc((TDisplayItem) row.ListObject) && base.MeetsCriteria(row);
  }
}
