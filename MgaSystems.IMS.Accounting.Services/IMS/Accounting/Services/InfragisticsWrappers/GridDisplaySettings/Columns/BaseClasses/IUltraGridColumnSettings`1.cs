// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses.IUltraGridColumnSettings`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Data.CommonInterface;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;

public interface IUltraGridColumnSettings<TDisplayItem> : 
  IUltraGridColumnSettings,
  IUniqueObject<string>,
  IUniqueObject
{
  Func<TDisplayItem, string> GetToolTipText { get; set; }

  void AttachListeners(UltraGridBase grid);

  void ApplyToColumn(UltraGridColumn column, Func<TDisplayItem, bool> rowEnabledFunc);

  void RefreshEnabledState(UltraGridRow row, TDisplayItem displayItem);

  void RefreshEnabledState(UltraGridCell cell, TDisplayItem displayItem);

  void SetInitialCellValue(UltraGridRow row, TDisplayItem displayItem);

  void SetInitialCellValue(UltraGridCell cell, TDisplayItem displayItem);

  void UpdateCellValue(UltraGridRow row, TDisplayItem displayItem);

  void UpdateCellValue(UltraGridCell cell, TDisplayItem displayItem);

  UltraGridCell GetCellFromRow(UltraGridRow row);
}
