// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmReportsTemplatesMenu
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.IMS.Forms;

[MenuManager]
[SecureResource("{86F498C8-4825-4798-955E-F3F41C13067B}", "Administer Email Templates Reports Associations", "Allows administration of association email templates for reports", "Document System")]
public class frmReportsTemplatesMenu : IMenuConsumer
{
  private const string REPORT_TEMPLATE_ASSOCIATIONS_KEY = "REPORT_TEMPLATE_ASSOCIATIONS_KEY";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "REPORT_TEMPLATE_ASSOCIATIONS_KEY", false) != 0)
      return;
    MDIControls.Instance.ActivateForm(typeof (frmReportsTemplates), true);
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (!SecurityManager.Instance.AssertPermission("{86F498C8-4825-4798-955E-F3F41C13067B}"))
      return;
    PopupMenuTool tool = (PopupMenuTool) ((ToolsCollectionBase) menu.Tools)["Documents"];
    ButtonTool buttonTool = new ButtonTool("REPORT_TEMPLATE_ASSOCIATIONS_KEY");
    menu.Tools.Add((ToolBase) buttonTool);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) ImageCache.Instance.DocMain;
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.DocMain;
    tool.Tools.AddTool("REPORT_TEMPLATE_ASSOCIATIONS_KEY");
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = "Email Templates Reports Associations";
  }
}
