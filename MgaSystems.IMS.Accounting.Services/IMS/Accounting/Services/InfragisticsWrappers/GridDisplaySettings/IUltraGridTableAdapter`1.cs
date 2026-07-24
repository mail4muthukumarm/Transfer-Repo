// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.IUltraGridTableAdapter`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;

public interface IUltraGridTableAdapter<TDisplayItem> : 
  IUltraGridTableAdapter,
  IUniqueObject<string>,
  IUniqueObject
{
  void SetFilter(Func<TDisplayItem, bool> filter);

  IUltraGridColumnSettings<TDisplayItem> GetColumnByKey(string columnKey);

  int GetColumnLocation(string columnKey);
}
