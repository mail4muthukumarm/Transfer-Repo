// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Forms.MenuManager
// Assembly: MgaSystems.IMS.Forms.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BCC44DDA-AB66-4C54-AF35-347243EEC1D9
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Forms.Cs.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MgaSystems.IMS.Forms.HelpMenuAdmin;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.Forms;

[MenuManager]
[SecureResource("{5AEBEA11-382D-43F1-A8E9-F68A0D6D6BBB}", "Can View Help Menu Admin", "Allows the user to view/edit the custom help menu admin tool", "Administration")]
internal class MenuManager : IMenuConsumer
{
  private static Dictionary<string, string> _helpMenuDictionary = new Dictionary<string, string>();
  private const string ManageHelpMenuTools = "ManageHelpMenuTools";
  private const string CanViewHelpMenuAdmin = "{5AEBEA11-382D-43F1-A8E9-F68A0D6D6BBB}";

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowDynamicHelpMenu"))
      this.AddDynamicHelpMenus(menu);
    if (!SecurityManager.Instance.AssertPermission("{5AEBEA11-382D-43F1-A8E9-F68A0D6D6BBB}"))
      return;
    this.AddAdminMenuTool(menu);
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    string fileName;
    if (MenuManager._helpMenuDictionary.TryGetValue(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key, out fileName))
    {
      try
      {
        Process.Start(fileName);
        return;
      }
      catch (Exception ex)
      {
        ErrorHandler.HandleError(ex);
      }
    }
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "ManageHelpMenuTools":
        ViewHelpMenuAdmin viewHelpMenuAdmin = MgaMdiChild.Create<ViewHelpMenuAdmin>(Array.Empty<object>());
        HelpAdminViewModel helpAdminViewModel = HelpAdminViewModel.Create((IWinMsgBoxService) new WinMsgBoxService());
        helpAdminViewModel.LoadData();
        ((FrameworkElement) viewHelpMenuAdmin).DataContext = (object) helpAdminViewModel;
        viewHelpMenuAdmin.Form.MdiParent = MDIControls.Instance.MDIParent;
        viewHelpMenuAdmin.Form.Show();
        break;
      case "Contact Technical Support":
        new ContactTechnicalSupport().SendMessage();
        break;
    }
  }

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  private void AddDynamicHelpMenus(UltraToolbarsManager menu)
  {
    MenuManager._helpMenuDictionary.Clear();
    string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("DynamicHelpMenu.ClientPrefix");
    string str = (Utility.IsNull((object) setting) ? "" : setting + " ") + "Custom Help";
    PopupMenuTool popupMenuTool = new PopupMenuTool(str);
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = str;
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) popupMenuTool);
    if (((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)["Help"] is PopupMenuTool tool)
      ((ToolsCollectionBase) tool.Tools).Add((ToolBase) popupMenuTool);
    foreach (DataRow row in DefaultDatabase.ExecuteDataTable("spGetDynamicHelpItems").AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (r => r.Field<bool>("Active"))))
    {
      if (SecurityManager.Instance.AssertPermission(row.Field<Guid>("SecurityId")))
      {
        string key = row.Field<string>("HelpToolKey");
        ButtonTool buttonTool = new ButtonTool(key);
        ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = row.Field<string>("HelpToolCaption");
        ((ToolsCollectionBase) menu.Tools).Add((ToolBase) buttonTool);
        MenuManager._helpMenuDictionary.Add(key, row.Field<string>("HelpToolUri"));
        ((ToolsCollectionBase) popupMenuTool.Tools).Add((ToolBase) buttonTool);
      }
    }
  }

  private void AddAdminMenuTool(UltraToolbarsManager menu)
  {
    ButtonTool buttonTool = new ButtonTool("ManageHelpMenuTools");
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = "Manage Help Menu Tools...";
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.Help;
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) buttonTool);
    if (!(((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)["Administration"] is PopupMenuTool tool))
      return;
    ((ToolsCollectionBase) tool.Tools).Add((ToolBase) buttonTool);
  }
}
