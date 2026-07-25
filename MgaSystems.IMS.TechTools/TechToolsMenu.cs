// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.TechToolsMenu
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MgaSystems.IMS.TechTools.AutomationEventAdmin.UI;
using MgaSystems.IMS.TechTools.QuoteStatusAdmin.UI;
using MgaSystems.IMS.TechTools.QuoteStatusSystemEventAdmin.UI;
using MgaSystems.IMS.TechTools.ViewModels;
using MgaSystems.IMS.TechTools.Views;
using System;
using System.Drawing;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.TechTools;

[MenuManager]
public class TechToolsMenu : IMenuConsumer
{
  private const string QuoteStatusAdmin = "QuoteStatusAdmin";
  private const string TestRunner = "TestRunner";
  private const string DynamicReports = "DynamicReports";
  private const string AutomationEventAdmin = "AutomationEventAdmin";
  private const string RaterFinder = "RaterFinder";
  private const string CheckFinder = "CheckFinder";
  private const string QuoteStatusSystemEventAdmin = "QuoteStatusSystemEventAdmin";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 10:
        if (!(key == "TestRunner"))
          break;
        TestingView testingView = MgaMdiChild.Create<TestingView>(Array.Empty<object>());
        ((FrameworkElement) testingView).DataContext = (object) TestViewModel.Create();
        testingView.Form.MdiParent = MDIControls.Instance.MDIParent;
        testingView.Form.Show();
        break;
      case 11:
        switch (key[0])
        {
          case 'C':
            if (!(key == "CheckFinder"))
              return;
            CheckFinderView checkFinderView = MgaMdiChild.Create<CheckFinderView>(Array.Empty<object>());
            ((FrameworkElement) checkFinderView).DataContext = (object) CheckFinderViewModel.Create();
            checkFinderView.Form.MdiParent = MDIControls.Instance.MDIParent;
            checkFinderView.Form.Show();
            return;
          case 'R':
            if (!(key == "RaterFinder"))
              return;
            RaterFinderView raterFinderView = MgaMdiChild.Create<RaterFinderView>(Array.Empty<object>());
            ((FrameworkElement) raterFinderView).DataContext = (object) RaterFinderViewModel.Create();
            raterFinderView.Form.MdiParent = MDIControls.Instance.MDIParent;
            raterFinderView.Form.Show();
            return;
          default:
            return;
        }
      case 14:
        if (!(key == "DynamicReports"))
          break;
        DynamicReportsTestingView reportsTestingView = MgaMdiChild.Create<DynamicReportsTestingView>(Array.Empty<object>());
        ((FrameworkElement) reportsTestingView).DataContext = (object) DynamicReportsTestingModel.Create();
        reportsTestingView.Form.MdiParent = MDIControls.Instance.MDIParent;
        reportsTestingView.Form.Show();
        break;
      case 16 /*0x10*/:
        if (!(key == "QuoteStatusAdmin"))
          break;
        QuoteStatusView quoteStatusView = MgaMdiChild.Create<QuoteStatusView>(Array.Empty<object>());
        ((FrameworkElement) quoteStatusView).DataContext = (object) QuoteStatusViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
        quoteStatusView.Form.MdiParent = MDIControls.Instance.MDIParent;
        quoteStatusView.Form.Show();
        break;
      case 20:
        if (!(key == "AutomationEventAdmin"))
          break;
        AutomationEventView automationEventView = MgaMdiChild.Create<AutomationEventView>(Array.Empty<object>());
        ((FrameworkElement) automationEventView).DataContext = (object) AutomationEventViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
        automationEventView.Form.MdiParent = MDIControls.Instance.MDIParent;
        automationEventView.Form.Show();
        break;
      case 27:
        if (!(key == "QuoteStatusSystemEventAdmin"))
          break;
        QuoteStatusSystemEventView statusSystemEventView = MgaMdiChild.Create<QuoteStatusSystemEventView>(Array.Empty<object>());
        ((FrameworkElement) statusSystemEventView).DataContext = (object) QuoteStatusSystemEventViewModel.Create();
        statusSystemEventView.Form.MdiParent = MDIControls.Instance.MDIParent;
        statusSystemEventView.Form.Show();
        break;
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (!CurrentUser.IsMGADeveloper)
      return;
    PopupMenuTool popupMenuTool = new PopupMenuTool("MGATechToolsMenu");
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "MGA Tech Tools";
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) popupMenuTool);
    ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools.AddTool("MGATechToolsMenu");
    ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) TechToolsMenu.AddTechMenuOption(menu, "QuoteStatusAdmin", "Quote Status Admin...", (Image) null));
    ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) TechToolsMenu.AddTechMenuOption(menu, "TestRunner", "Run IMS Tests...", (Image) null));
    ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) TechToolsMenu.AddTechMenuOption(menu, "DynamicReports", "Run IMS Reports...", (Image) null));
    ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) TechToolsMenu.AddTechMenuOption(menu, "AutomationEventAdmin", "Automation Event Admin...", (Image) null));
    ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) TechToolsMenu.AddTechMenuOption(menu, "RaterFinder", "Find Quotes by Rater Type...", (Image) null));
    ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) TechToolsMenu.AddTechMenuOption(menu, "CheckFinder", "Find Checks to Print...", (Image) null));
    ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) TechToolsMenu.AddTechMenuOption(menu, "QuoteStatusSystemEventAdmin", "Quote Status / System Event Admin...", (Image) null));
  }

  private static ButtonTool AddTechMenuOption(
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
