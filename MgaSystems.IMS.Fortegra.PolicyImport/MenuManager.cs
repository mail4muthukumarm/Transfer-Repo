// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.PolicyImport.MenuManager
// Assembly: MgaSystems.Ims.Fortegra.PolicyImport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 189D48CE-5EAC-426D-A8A8-CE161521563A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.PolicyImport.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MgaSystems.Ims.Fortegra.PolicyImport.UI;
using MGASystems.IMS.Security;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.PolicyImport;

[MenuManager]
public class MenuManager : IMenuConsumer
{
  private const string PolicyImportAdmin = "PolicyImportAdmin";

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    PopupMenuTool popupMenuTool = new PopupMenuTool("FortegraToolsMenu");
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "Fortegra";
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) popupMenuTool);
    ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools.AddTool("FortegraToolsMenu");
    ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) MenuManager.AddFortegraMenuOption(menu, "PolicyImportAdmin", "Policy Import Admin...", (Image) null));
  }

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "PolicyImportAdmin"))
      return;
    if (SecurityManager.Instance.AssertPermission("{F92C98DB-0779-4713-A09D-CEB8162686B4}"))
    {
      PolicyImportSummaryView importSummaryView = MgaMdiChild.Create<PolicyImportSummaryView>(Array.Empty<object>());
      importSummaryView.Form.MdiParent = MDIControls.Instance.MDIParent;
      importSummaryView.Form.Show();
    }
    else
    {
      int num = (int) MessageBox.Show("You currently do not have permission to run the policy import tool.");
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  private static ButtonTool AddFortegraMenuOption(
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
