// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.IUltraGridTableSettings
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.PopupMenu;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Utility;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;

public interface IUltraGridTableSettings : 
  IUltraGridTableAdapter,
  IUniqueObject<string>,
  IUniqueObject
{
  RightClickMenu RightClickMenuSettings { get; set; }

  bool HasFilterAdapter();

  void SetColumns(SimpleTreeNode<UltraGridBand> band, UltraGridBase grid);

  void AttachListeners(UltraGridBase grid);

  void SubTablePopulate(UltraGridChildBand childBand);

  void ApplyToGridAsTopLevelTable(UltraGridBase grid);

  void SetRightClickMenu(UltraGridBase grid);

  int GetPreferredWidth();

  bool MoveRowToTop(object displayItem);
}
