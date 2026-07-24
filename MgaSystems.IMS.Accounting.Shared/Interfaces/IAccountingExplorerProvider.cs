// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Interfaces.IAccountingExplorerProvider
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using Infragistics.Win.UltraWinExplorerBar;

#nullable disable
namespace MGASystems.IMS.Accounting.Interfaces;

public interface IAccountingExplorerProvider
{
  int ExplorerMenuIndex { get; }

  UltraExplorerBarGroup BuildExplorerMenu();

  UltraExplorerBarItem[] ProvideTools();

  UltraExplorerBarItem[] ProvideAdministrativeOptions();
}
