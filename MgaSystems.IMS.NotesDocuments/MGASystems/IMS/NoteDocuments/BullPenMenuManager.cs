// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.BullPenMenuManager
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SecureResource("{A1F56971-A5FE-40e6-A7E3-415AB5CE16AC}", "View All Open Tasks", "Allows the user to view 'All Open Tasks'", "Note System")]
[MenuManager]
public class BullPenMenuManager : IMenuConsumer
{
  private const string BullpenShowFormKey = "BullpenShowFormKey";
  internal const string CanViewAllOpenTask = "{A1F56971-A5FE-40e6-A7E3-415AB5CE16AC}";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "BullpenShowFormKey", false) != 0)
      return;
    MDIControls.Instance.ActivateForm(typeof (BullPenForm), true);
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
    if (menu == null)
      throw new ArgumentNullException(nameof (menu));
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    PopupMenuTool popupMenuTool = menu != null ? (PopupMenuTool) ((ToolsCollectionBase) menu.Tools)["View"] : throw new ArgumentNullException(nameof (menu));
    ButtonTool buttonTool = new ButtonTool("BullpenShowFormKey");
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = "All Open Tasks";
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.NoteSystem;
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) ImageCache.Instance.NoteSystem;
    ((ToolBase) buttonTool).SharedProps.Visible = SecurityManager.Instance.AssertPermission("{A1F56971-A5FE-40e6-A7E3-415AB5CE16AC}");
    menu.Tools.Add((ToolBase) buttonTool);
    popupMenuTool.Tools.AddTool("BullpenShowFormKey");
  }
}
