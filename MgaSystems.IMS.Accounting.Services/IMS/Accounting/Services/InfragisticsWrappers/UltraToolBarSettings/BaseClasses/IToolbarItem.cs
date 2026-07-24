// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses.IToolbarItem
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data.CommonInterface;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;

public interface IToolbarItem : IUniqueObject<string>, IUniqueObject
{
  void AddToToolbar(UltraToolbar toolbar);

  void AddToPopupMenu(UltraToolbarsManager toolbarManager, PopupMenuTool popupTool);
}
