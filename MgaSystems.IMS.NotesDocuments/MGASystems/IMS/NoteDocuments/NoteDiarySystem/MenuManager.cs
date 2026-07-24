// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteDiarySystem.MenuManager
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.NoteDiarySystem;

[MenuManager]
public class MenuManager : IMenuConsumer
{
  private const string administrationMenuKey = "Administration";
  private const string mainMenuKey = "mainMenu";
  private const string policyMenuKey = "AdminPolicy";
  private const string globalNotesAdminKey = "globalNotesAdmin";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "globalNotesAdmin", false) != 0)
      return;
    FormSettings.ShowForm(typeof (GlobalNotesSetupFormML));
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (menu == null)
      throw new ArgumentNullException(nameof (menu));
    PopupMenuTool popupMenuTool = MenuManager.GetPopupMenuTool("AdminPolicy", MenuManager.GetPopupMenuTool("Administration", ((UltraToolbarBase) MenuManager.GetToolbar("mainMenu", menu)).Tools).Tools);
    ButtonTool buttonTool = new ButtonTool("globalNotesAdmin");
    menu.Tools.Add((ToolBase) buttonTool);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) ImageCache.Instance.NoteMain;
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.NoteMain;
    popupMenuTool.Tools.AddTool("globalNotesAdmin");
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = "&Global Notes Administration";
    ((ToolBase) buttonTool).SharedProps.Enabled = SecurityManager.Instance.AssertPermission("{20FD3E39-4F89-435c-8A34-DDA629B0E35E}");
  }

  private static PopupMenuTool GetPopupMenuTool(string key, ToolsCollection parentTools)
  {
    if (!((ToolsCollectionBase) parentTools).Exists(key))
      throw new InvalidOperationException($"Unable to locate the toolbar with key {key} under {((ToolsCollectionBase) parentTools).Owner.ToString()}");
    if (((ToolsCollectionBase) parentTools)[key] is PopupMenuTool parentTool)
      return parentTool;
    throw new InvalidOperationException($"The tool specified by key {key} is not of type PopupMenuTool");
  }

  private static UltraToolbar GetToolbar(string key, UltraToolbarsManager parent)
  {
    if (((KeyedSubObjectsCollectionBase) parent.Toolbars).Exists(key))
      return parent.Toolbars[key];
    throw new InvalidOperationException($"Unable to locate the toolbar with key {key}");
  }
}
