// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.MultiCurrencyMenuManager
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[MenuManager]
public class MultiCurrencyMenuManager : IMenuConsumer
{
  private const string MULTICURRENCY_OPTIONS = "MultiCurrencyOptions";
  private const string MULTICURRENCY_ADMINISTRATION = "MultiCurrencyAdmin";
  private const string MULTICURRENCY_ASSIGNMENT = "MultiCurrencyAssignment";
  private const string MULTICURRENCY_AUTHORIZATION = "MultiCurrencyAuthorization";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Operators.CompareString(key, "MultiCurrencyAdmin", false) != 0)
    {
      if (Operators.CompareString(key, "MultiCurrencyAssignment", false) != 0)
      {
        if (Operators.CompareString(key, "MultiCurrencyAuthorization", false) != 0)
          return;
        using (FormAuthorizeOfficeLocationCurrencies locationCurrencies = new FormAuthorizeOfficeLocationCurrencies())
        {
          int num = (int) locationCurrencies.ShowDialog();
        }
      }
      else
      {
        using (Form form = ObjectFactory.Instance.CreateForm(typeof (FormMultiCurrencyAssignment)))
        {
          int num = (int) form.ShowDialog();
        }
      }
    }
    else
    {
      using (FormMultiCurrencyAdmin multiCurrencyAdmin = new FormMultiCurrencyAdmin())
      {
        int num = (int) multiCurrencyAdmin.ShowDialog();
      }
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    MultiCurrencyMenuManager.AddPopupMainMenuTool(menu, "Administration", "MultiCurrencyOptions", "Multi-Currency Options...");
    ((ToolPropsBase) ((ToolBase) MultiCurrencyMenuManager.AddMainMenuTool(menu, "MultiCurrencyOptions", "MultiCurrencyAdmin", "Manage Currencies")).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.Coins;
    ((ToolPropsBase) ((ToolBase) MultiCurrencyMenuManager.AddMainMenuTool(menu, "MultiCurrencyOptions", "MultiCurrencyAssignment", "Assign Currencies")).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.Dollar;
    ((ToolPropsBase) ((ToolBase) MultiCurrencyMenuManager.AddMainMenuTool(menu, "MultiCurrencyOptions", "MultiCurrencyAuthorization", "Authorize Office Location Currencies")).SharedProps).AppearancesSmall.Appearance.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.cog_edit;
  }

  private static ButtonTool AddMainMenuTool(
    UltraToolbarsManager menu,
    string AddToMenuKey,
    string NewToolKey,
    string NewToolCaption)
  {
    ButtonTool buttonTool = new ButtonTool(NewToolKey);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = NewToolCaption;
    menu.Tools.Add((ToolBase) buttonTool);
    ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)["Administration"]).Tools)[AddToMenuKey]).Tools.AddTool(NewToolKey);
    return buttonTool;
  }

  private static PopupMenuTool AddPopupMainMenuTool(
    UltraToolbarsManager menu,
    string AddToMenuKey,
    string NewToolKey,
    string NewToolCaption)
  {
    PopupMenuTool popupMenuTool = new PopupMenuTool(NewToolKey);
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = NewToolCaption;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).AppearancesSmall.Appearance.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.money;
    menu.Tools.Add((ToolBase) popupMenuTool);
    ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)[AddToMenuKey]).Tools.AddTool(NewToolKey);
    return popupMenuTool;
  }
}
