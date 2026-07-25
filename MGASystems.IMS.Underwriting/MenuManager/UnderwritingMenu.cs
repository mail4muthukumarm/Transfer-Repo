// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.MenuManager.UnderwritingMenu
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using Mga.Wpf.Ims.Interop;
using MGASystems.Common;
using MGASystems.IMS.Security;
using MGASystems.IMS.Underwriting.Additional_Interests_Admin;
using MGASystems.IMS.Underwriting.Bulk_NonRenewal_Utility;
using MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;
using MGASystems.IMS.Underwriting.Commission_Check_Tool;
using MGASystems.IMS.Underwriting.Import_Inspection;
using MGASystems.IMS.Underwriting.Properties;
using MGASystems.IMS.Underwriting.Risk_Meter;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.MenuManager;

[SecureResource("{78B7AD3E-825C-45A6-8D67-09B3B537A577}", "Can View  Import Inspection Information Menu", "Controls the ability to view  Import Inspection Information off tools menu.", "Tools")]
[SecureResource("{308b1ed7-b349-4e55-b129-a39884cc9813}", "Can View Bulk Non-Renewal from Tools menu", "Controls the ability to view  Bulk Non-Renewal off tools menu.", "Tools")]
[MGASystems.Common.MenuManager]
public class UnderwritingMenu : IMenuConsumer
{
  public const string CanViewImportInspectionInformation = "{78B7AD3E-825C-45A6-8D67-09B3B537A577}";
  public const string CanViewBulkUtilNonrenewMenu = "{308b1ed7-b349-4e55-b129-a39884cc9813}";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "BulkRenewalUtility":
        if (!SecurityManager.Instance.AssertPermission("{7C044B89-3BEC-4012-BE26-4D78DDA7E18D}"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("You do not have sufficient security permission to run the Bulk Renewal Utility", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        FormSettings.ShowForm(typeof (FormBulkRenewalUtility));
        break;
      case "BulklUtilityForNonRenewals":
        FormSettings.ShowForm(typeof (frmBulkNonRenewalUtility));
        break;
      case "Risk Meter":
        if (!SecurityManager.Instance.AssertPermission("{4A685563-11FB-4814-94AC-12789925FB04}"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("You do not have sufficient security permission to run Risk Meter.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        FormSettings.ShowForm(typeof (FormRiskMeter));
        break;
      case "Producer / Carrier Commissions":
        if (!SecurityManager.Instance.AssertPermission("{21CB0CD5-8A59-48fe-8E28-7AA9DB84E968}"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("You do not have sufficient security permission to access this form.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          break;
        }
        FormSettings.ShowForm(typeof (FormCommissionCheck));
        break;
      case "Additional Interest":
        FormSettings.ShowForm(typeof (FormAdditionalInterestsAdmin));
        break;
      case "ImportInspectionInformation":
        this.DisplayImportInspextionView();
        break;
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    UnderwritingMenu.AddMainMenuTool(menu, "Tools", "BulkRenewalUtility", "Bulk Renewal Utility ...", (Image) Resources.BulkRenewal);
    UnderwritingMenu.AddMainMenuTool(menu, "Tools", "Producer / Carrier Commissions", "Commissions Check", (Image) Resources.PieChart);
    if (SecurityManager.Instance.AssertPermission("{78B7AD3E-825C-45A6-8D67-09B3B537A577}"))
      UnderwritingMenu.AddMainMenuTool(menu, "Tools", "ImportInspectionInformation", "Import Inspection Information ...", (Image) null);
    UnderwritingMenu.AddMainMenuTool(menu, "Administration", "Additional Interest", "Additional Interests ...", (Image) Resources.AdditionalInterest);
    UnderwritingMenu.AddMainMenuTool(menu, "Administration", "Risk Meter", "Risk Meter ...", (Image) Resources.PieChart);
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowRiskMeterOnMenus"))
      ((ToolsCollectionBase) menu.Tools)["Risk Meter"].SharedProps.Visible = false;
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowBulkUtilityForNonRenewalsOnMenus") || !SecurityManager.Instance.AssertPermission("{308b1ed7-b349-4e55-b129-a39884cc9813}"))
      return;
    UnderwritingMenu.AddMainMenuTool(menu, "Tools", "BulklUtilityForNonRenewals", "Bulk Non-Renewal Status / Mail Changes ...", (Image) Resources.BulkRenewal);
  }

  private static ButtonTool AddMainMenuTool(
    UltraToolbarsManager menu,
    string AddToMenuKey,
    string NewToolKey,
    string NewToolCaption)
  {
    ButtonTool buttonTool = new ButtonTool(NewToolKey);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = NewToolCaption;
    ((ToolBase) buttonTool).SharedProps.Category = AddToMenuKey;
    ((ToolsCollectionBase) menu.Tools).Add((ToolBase) buttonTool);
    ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)[AddToMenuKey]).Tools.AddTool(NewToolKey);
    return buttonTool;
  }

  private static ButtonTool AddMainMenuTool(
    UltraToolbarsManager menu,
    string AddToMenuKey,
    string NewToolKey,
    string NewToolCaption,
    Image img)
  {
    ButtonTool buttonTool = UnderwritingMenu.AddMainMenuTool(menu, AddToMenuKey, NewToolKey, NewToolCaption);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) img;
    return buttonTool;
  }

  private void DisplayImportInspextionView()
  {
    ImportInspectionViewModel inspectionViewModel = ImportInspectionViewModel.Create();
    ImportInspectionView importInspectionView = MgaMdiChild.Create<ImportInspectionView>(Array.Empty<object>());
    ((FrameworkElement) importInspectionView).DataContext = (object) inspectionViewModel;
    importInspectionView.Form.MdiParent = MDIControls.Instance.MDIParent;
    importInspectionView.Form.Show();
  }
}
