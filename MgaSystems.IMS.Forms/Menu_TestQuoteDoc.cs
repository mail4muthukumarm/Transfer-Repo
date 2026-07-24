// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Menu_TestQuoteDoc
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Forms;

[MenuManager]
[SecureResource("{9FFDC08E-26BE-4612-BBD5-B3D28AE3A105}", "Access Test Quote Documents.", "Controls whether or not the user can access the Test Quote Documents form.", "Test Quote Documents")]
public sealed class Menu_TestQuoteDoc : IMenuConsumer
{
  internal const string SecurityIDTestQuoteDoc = "{9FFDC08E-26BE-4612-BBD5-B3D28AE3A105}";
  private const string testQuoteDocKey = "testQuoteDocKey";

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (menu == null)
      throw new ArgumentNullException(nameof (menu));
    if (Operators.CompareString(Environment.UserDomainName, "MGA", false) != 0)
      return;
    Menu_TestQuoteDoc.AddTool(menu, "Help", "testQuoteDocKey", "Test Quote Document", (Image) null);
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "testQuoteDocKey", false) != 0)
      return;
    FormSettings.ShowForm(typeof (TestQuoteDocs));
  }

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
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
      throw new InvalidOperationException("Could Not Find Top Level Menu");
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
