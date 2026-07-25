// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MenuManager
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common.UpdateCheck;
using System.Drawing;

#nullable disable
namespace MGASystems.Common;

[MenuManager]
internal class MenuManager : IMenuConsumer
{
  private const string Help_ToplevelCheckForUpdatesToolKey = "MGASystems.Common.Cs.MenuManager.CheckForUpdatesKey";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "MGASystems.Common.Cs.MenuManager.CheckForUpdatesKey"))
      return;
    UpdateManager.BeginUpdateCheck();
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    MenuManager.AddMenuButton(menu, "MGASystems.Common.Cs.MenuManager.CheckForUpdatesKey", "Check for  Updates...", (Image) null);
    ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)["Help"]).Tools.AddTool("MGASystems.Common.Cs.MenuManager.CheckForUpdatesKey");
  }

  private static ButtonTool AddMenuButton(
    UltraToolbarsManager menu,
    string newToolKey,
    string newToolCaption,
    Image image)
  {
    ButtonTool buttonTool = new ButtonTool(newToolKey);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = newToolCaption;
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) image;
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) buttonTool);
    return buttonTool;
  }
}
