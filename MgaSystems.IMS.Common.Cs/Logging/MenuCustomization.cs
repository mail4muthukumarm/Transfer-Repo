// Decompiled with JetBrains decompiler
// Type: Logging.MenuCustomization
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Logging.Administration;
using MGASystems.Common;
using MGASystems.Common.DockingManagement;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace Logging;

[MenuManager]
[SecureResource("{BAA62ABB-D932-458d-B240-15998280A2ED}", "Can View Trouble Shooting Screen", "Controls whether or not a user can view 'Trouble Shooting' menu item.", "TroubleShooting")]
public class MenuCustomization : IMenuConsumer
{
  protected const string CanViewTroubleShooting = "{BAA62ABB-D932-458d-B240-15998280A2ED}";
  private const string troubleShootingAdministrationKey = "Help_TroubleShooting";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "Help_TroubleShooting"))
      return;
    if (DockingManager.Security.AssertPermission(new Guid("{BAA62ABB-D932-458d-B240-15998280A2ED}"), 0))
    {
      ObjectFactory.Instance.CreateForm(typeof (TroubleshootingAdminWindow)).Show();
    }
    else
    {
      int num = (int) MessageBox.Show("You do not have permission to access this feature", "TroubleShooting", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (menu == null)
      throw new ArgumentNullException(nameof (menu));
    this.AddTool(menu, "Help", "Help_TroubleShooting", "Troubleshooting", (Image) Resources.GetObject("Troubleshooting"));
  }

  private void AddTool(
    UltraToolbarsManager menu,
    string topLevelMenuKey,
    string toolKey,
    string toolCaption,
    Image toolImage)
  {
    if (menu == null)
      throw new ArgumentNullException(nameof (menu));
    if (string.IsNullOrEmpty(topLevelMenuKey))
      throw new ArgumentNullException(nameof (topLevelMenuKey));
    if (string.IsNullOrEmpty(toolKey))
      throw new ArgumentNullException(nameof (toolKey));
    if (string.IsNullOrEmpty(toolCaption))
      throw new ArgumentNullException(nameof (toolCaption));
    PopupMenuTool tool = (PopupMenuTool) ((ToolsCollectionBase) menu.Tools)[topLevelMenuKey];
    if (tool == null)
      throw new InvalidOperationException("Could not find top level menu");
    ButtonTool buttonTool = new ButtonTool(toolKey);
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) buttonTool);
    if (toolImage != null)
    {
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) toolImage;
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) toolImage;
    }
    tool.Tools.AddTool(toolKey);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = toolCaption;
  }
}
