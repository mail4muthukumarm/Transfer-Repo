// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses.IComboBoxColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.CommonInterface;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;

public interface IComboBoxColumn<TDisplayItem> : 
  IComboBoxColumn,
  IReadOnlyColumn,
  IUltraGridColumnSettings,
  IUniqueObject<string>,
  IUniqueObject,
  IReadOnlyColumn<TDisplayItem>,
  IUltraGridColumnSettings<TDisplayItem>
{
}
