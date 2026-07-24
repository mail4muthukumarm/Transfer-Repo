// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.AdHocReportMenu
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Security;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

[MenuManager]
[SecureResource("{9D128BB3-01FD-4183-BAB1-CE2D81E7896C}", "AdHoc Reports", "Controls the ability to add/edit AdHoc reports.", "Reports")]
public class AdHocReportMenu : IMenuConsumer
{
  public const string CanAddEditAdHocReports = "{9D128BB3-01FD-4183-BAB1-CE2D81E7896C}";

  private static void AddMainMenuTool(
    UltraToolbarsManager menu,
    string AddToMenuKey,
    string NewToolKey,
    string NewToolCaption)
  {
    ButtonTool buttonTool = new ButtonTool(NewToolKey);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = NewToolCaption;
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) buttonTool);
    ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)[AddToMenuKey]).Tools.AddTool(NewToolKey);
  }

  void IMenuConsumer.OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key == "show_adhoc_manager"))
      return;
    if (SecurityManager.Instance.AssertPermission("{9D128BB3-01FD-4183-BAB1-CE2D81E7896C}"))
      ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["show_adhoc_manager"].SharedProps.Visible = true;
    else
      ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools)["show_adhoc_manager"].SharedProps.Visible = false;
  }

  void IMenuConsumer.OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "show_adhoc_manager"))
      return;
    FormSettings.ShowForm(typeof (frmAdHocReportManager));
  }

  void IMenuConsumer.OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  void IMenuConsumer.OnSetupIGMenu(UltraToolbarsManager menu)
  {
    AdHocReportMenu.AddMainMenuTool(menu, "Administration", "show_adhoc_manager", "AdHoc Reports Configuration");
  }
}
