// Decompiled with JetBrains decompiler
// Type: CancellationNotices.MenuManager
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace CancellationNotices;

[MenuManager]
[SecureResource("{4186E632-F314-4558-864D-59B7049E747C}", "NOC Forms Override Administration", "Controls access to the notice of cancellation forms override adminstration screen.", "Notice Of Cancellation")]
public class MenuManager : IMenuConsumer
{
  internal const string SECURITYID_NOCFORMS = "{4186E632-F314-4558-864D-59B7049E747C}";
  private const string nocAdministrationKey = "Administration_NOCFormOverride";

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (menu == null)
      throw new ArgumentNullException(nameof (menu));
    if (!SecurityManager.Instance.AssertPermission("{4186E632-F314-4558-864D-59B7049E747C}"))
      return;
    MenuManager.AddTool(menu, "Administration", "Administration_NOCFormOverride", "NOC Forms Override", ImageCache.Instance.DocMain);
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "Administration_NOCFormOverride", false) != 0)
      return;
    using (Form form = ObjectFactory.Instance.CreateForm(typeof (FormCompanyLineNOCManagement)))
    {
      int num = (int) form.ShowDialog();
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public static void AddTool(
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
    if (!(((ToolsCollectionBase) menu.Tools)[topLevelMenuKey] is PopupMenuTool tool))
      throw new InvalidOperationException(CancellationNotices.My.Resources.Resources.ExceptionTextCouldNotFindTopLevelMenu);
    ButtonTool buttonTool = new ButtonTool(toolKey);
    menu.Tools.Add((ToolBase) buttonTool);
    if (toolImage != null)
    {
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) toolImage;
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) toolImage;
    }
    tool.Tools.AddTool(toolKey);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = toolCaption;
  }
}
