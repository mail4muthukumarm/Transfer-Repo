// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Inspections_Menu
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[SecureResource("{9AA79146-1B11-4103-8A99-82E0841832B2}", "View Inspections Client Codes", "Controls whether or not users have the security to view Inspection Client Codes.", "Inspections")]
[SecureResource("{14887789-B46B-4CF2-BBB2-4597C2F0381F}", "View Inspections Lines Admin", "Controls whether or not users have the security to view Inspection Lines Admin.", "Inspections")]
[MenuManager]
public class Inspections_Menu : IMenuConsumer
{
  internal const string CanViewInspectionCodes = "{9AA79146-1B11-4103-8A99-82E0841832B2}";
  internal const string CanViewInspectionLines = "{14887789-B46B-4CF2-BBB2-4597C2F0381F}";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Operators.CompareString(key, "InspectionCodes", false) != 0)
    {
      if (Operators.CompareString(key, "InspectionLinesAdmin", false) != 0)
        return;
      FormSettings.ShowFormDialog(typeof (FormInspectionLineCode));
    }
    else
      FormSettings.ShowFormDialog(typeof (frmAdminInspectionCodes));
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    Inspections_Menu.AddMainMenuTool(menu, "Administration", "InspectionCodes", "Inspections - Client Codes...");
    ((ToolsCollectionBase) menu.Tools)["InspectionCodes"].SharedProps.Enabled = SecurityManager.Instance.AssertPermission("{9AA79146-1B11-4103-8A99-82E0841832B2}");
    Inspections_Menu.AddMainMenuTool(menu, "Administration", "InspectionLinesAdmin", "Inspection Lines Admin ...");
    ((ToolsCollectionBase) menu.Tools)["InspectionLinesAdmin"].SharedProps.Enabled = SecurityManager.Instance.AssertPermission("{14887789-B46B-4CF2-BBB2-4597C2F0381F}");
  }

  private static void AddMainMenuTool(
    UltraToolbarsManager menu,
    string AddToMenuKey,
    string NewToolKey,
    string NewToolCaption)
  {
    ButtonTool buttonTool = new ButtonTool(NewToolKey);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = NewToolCaption;
    menu.Tools.Add((ToolBase) buttonTool);
    ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)[AddToMenuKey]).Tools.AddTool(NewToolKey);
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }
}
