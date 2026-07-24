// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.BindingChecklist.BreckMenu
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MgaSystems.IMS.Policies.AuthorityLimit.UI;
using MgaSystems.IMS.Policies.FCWComments;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.UI;
using MgaSystems.IMS.Policies.ThresholdLimit.UI;
using System;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.Policies.BindingChecklist;

[MenuManager]
public class BreckMenu : IMenuConsumer
{
  public const string BindingRequirementsAdminKey = "BindingChecklist";
  public const string SharePointKey = "BindingChecklist_key";
  private const string authorityLimitAdmin = "Admin_AuthorityLimit";
  private const string createSimpleQuote = "Admin_CreateSimpleQuote";
  private const string thresholdLimitAdmin = "Admin_ThresholdLimit";
  private const string FCWNetrateListAdmin = "Tools_FCWNetrateListAdmin";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key == "BindingChecklist"))
      return;
    ((CancelableToolEventArgs) e).Tool.SharedProps.Visible = true;
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "BindingChecklist":
        BindingChecklistAdmin_ViewModel checklistAdminViewModel = BindingChecklistAdmin_ViewModel.Create();
        BindingChecklistView bindingChecklistView = MgaMdiChild.Create<BindingChecklistView>(Array.Empty<object>());
        ((FrameworkElement) bindingChecklistView).DataContext = (object) checklistAdminViewModel;
        bindingChecklistView.Form.MdiParent = MDIControls.Instance.MDIParent;
        bindingChecklistView.Form.Show();
        break;
      case "Admin_AuthorityLimit":
        AuthorityLimitView authorityLimitView = MgaMdiChild.Create<AuthorityLimitView>(Array.Empty<object>());
        ((FrameworkElement) authorityLimitView).DataContext = (object) AuthorityLimitViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
        authorityLimitView.Form.MdiParent = MDIControls.Instance.MDIParent;
        authorityLimitView.Form.Show();
        break;
      case "Admin_CreateSimpleQuote":
        ObjectFactory.Instance.CreateObjectAs<SimpleQuoteDisplay>()?.ShowSimpleQuote();
        break;
      case "Admin_ThresholdLimit":
        ThresholdLimitAdminView thresholdLimitAdminView = MgaMdiChild.Create<ThresholdLimitAdminView>(Array.Empty<object>());
        ((FrameworkElement) thresholdLimitAdminView).DataContext = (object) ThresholdLimitAdminViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
        thresholdLimitAdminView.Form.MdiParent = MDIControls.Instance.MDIParent;
        thresholdLimitAdminView.Form.Show();
        break;
      case "Tools_FCWNetrateListAdmin":
        NetrateFCWListView netrateFcwListView = MgaMdiChild.Create<NetrateFCWListView>(Array.Empty<object>());
        ((FrameworkElement) netrateFcwListView).DataContext = (object) NetrateFCWListViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
        netrateFcwListView.Form.MdiParent = MDIControls.Instance.MDIParent;
        netrateFcwListView.Form.Show();
        break;
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (SystemSettings.KeyExists("ShowBindingRequirementsChecklistScreens") && SystemSettings.GetBoolSetting("ShowBindingRequirementsChecklistScreens"))
      BreckMenu.AddMainMenuTool(menu, "Administration", "BindingChecklist", "Binding Checklist");
    if (PolSecurity.CanAccessAuthorityLimitAdmin)
      BreckMenu.AddMainMenuTool(menu, "Administration", "Admin_AuthorityLimit", "Authority Limits Admin...");
    if (PolSecurity.CanAccessCreateQuote)
      BreckMenu.AddMainMenuTool(menu, "Tools", "Admin_CreateSimpleQuote", "Create Quote...");
    if (PolSecurity.CanAccessThresholdLimitAdmin)
      BreckMenu.AddMainMenuTool(menu, "Administration", "Admin_ThresholdLimit", "Threshold Limits Admin...");
    BreckMenu.AddMainMenuTool(menu, "Tools", "Tools_FCWNetrateListAdmin", "FCW Comments...");
  }

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
}
