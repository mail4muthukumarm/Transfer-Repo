// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.IUltraGridAdapter
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;

public interface IUltraGridAdapter
{
  event EventHandler SelectedObjectInGridChanged;

  event Action<object> RowDoubleClicked;

  void ApplySettingsToGrid(UltraGrid grid);

  void UpdateDisplayValuesForItem(object item);

  object SelectedObjectInGrid { get; set; }

  void ClearSelected();

  void ReMapObjectsToRows();

  void InitializeListerners();

  void MoveRowToTopOfTable(object item);
}
