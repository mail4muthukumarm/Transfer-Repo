// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.IUltraGridTableSettings`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;

public interface IUltraGridTableSettings<TDisplayItem> : 
  IUltraGridTableSettings,
  IUltraGridTableAdapter,
  IUniqueObject<string>,
  IUniqueObject,
  IUltraGridTableAdapter<TDisplayItem>
{
  UltraGridFilterAdapter<TDisplayItem> FilterAdapter { get; set; }

  Func<TDisplayItem, bool> RowEnabledFunc { get; set; }

  void AddColumn(IUltraGridColumnSettings<TDisplayItem> column, int index);

  void AddColumn(IUltraGridColumnSettings<TDisplayItem> column);

  void AddColumnAfter(IUltraGridColumnSettings<TDisplayItem> columnToAdd, string afterColumnWithKey);

  void AddColumnsAfter(
    IUltraGridColumnSettings<TDisplayItem>[] columnsToAdd,
    string afterColumnWithKey);

  void AddColumnBefore(
    IUltraGridColumnSettings<TDisplayItem> columnToAdd,
    string beforeColumnWithKey);

  void AddColumnsBefore(
    IUltraGridColumnSettings<TDisplayItem>[] columnsToAdd,
    string beforeColumnWithKey);

  void RemoveColumn(string columnKey);
}
