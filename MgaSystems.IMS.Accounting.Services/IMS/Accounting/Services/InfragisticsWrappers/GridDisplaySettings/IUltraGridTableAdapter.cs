// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.IUltraGridTableAdapter
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Data.CommonInterface;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;

public interface IUltraGridTableAdapter : IUniqueObject<string>, IUniqueObject
{
  bool ShowContextMenuForRow(UltraGridRow selectedRow);

  object GetSelectedObjectInTableOrSubTable();

  void ReMapObjectsToRows(UltraGrid appliedToGrid);

  bool UpdateValuesForItem(object obj);

  bool IsObjectVisibleAsRow(object obj);

  bool SetSelectedObjectInTableOrSubTable(object selected);
}
