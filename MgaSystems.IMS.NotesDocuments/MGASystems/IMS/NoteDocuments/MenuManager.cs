// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.MenuManager
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

[MenuManager]
[SecureResource("C6F2E8F3-A0BC-49ca-971E-76BFBACB50EC", "Administer Folder Associations", "Allows administration of folder associations", "Document System")]
[SecureResource("D508E70E-4E79-4924-B065-EC8ACBFF0B16", "Document Bulk Folder Copy", "Bulk copy documents from one folder to another", "Document System")]
public sealed class MenuManager : IMenuConsumer
{
  private const string DOC_FOLDER_ASSOCIATIONS_KEY = "DOC_FOLDER_ASSOCIATIONS_KEY";
  internal const string SECURITYID_FOLDERASSOCIATIONS = "C6F2E8F3-A0BC-49ca-971E-76BFBACB50EC";
  private const string DOC_FOLDER_MOVEALLDOCS_KEY = "DOC_FOLDER_MOVEALLDOCS_KEY";
  internal const string SECURITYID_FOLDER_MOVEALLDOCS = "D508E70E-4E79-4924-B065-EC8ACBFF0B16";
  private const string DocTypes_Admin_Key = "DocTypes_Admin";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "DOC_FOLDER_ASSOCIATIONS_KEY", false) == 0)
      ((DocumentFolderAssociationController) ObjectFactory.Instance.CreateObject(typeof (DocumentFolderAssociationController))).DisplayUI(DocumentFilterType.GetDocumentFilterTypeList());
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "DOC_FOLDER_MOVEALLDOCS_KEY", false) == 0)
      MDIControls.Instance.ActivateForm(typeof (frmDocumentFolderBulkTransfer), true);
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "DocTypes_Admin", false) != 0)
      return;
    MDIControls.Instance.ActivateForm(typeof (frmAdminDocumentType), true);
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    if (menu == null)
      throw new ArgumentNullException(nameof (menu));
    if (SecurityManager.Instance.AssertPermission("C6F2E8F3-A0BC-49ca-971E-76BFBACB50EC"))
    {
      PopupMenuTool tool = (PopupMenuTool) ((ToolsCollectionBase) menu.Tools)["Documents"];
      ButtonTool buttonTool = new ButtonTool("DOC_FOLDER_ASSOCIATIONS_KEY");
      menu.Tools.Add((ToolBase) buttonTool);
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) ImageCache.Instance.DocMain;
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.DocMain;
      tool.Tools.AddTool("DOC_FOLDER_ASSOCIATIONS_KEY");
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = "Document Folder Associations";
    }
    if (SecurityManager.Instance.AssertPermission("D508E70E-4E79-4924-B065-EC8ACBFF0B16"))
    {
      PopupMenuTool tool = (PopupMenuTool) ((ToolsCollectionBase) menu.Tools)["Documents"];
      ButtonTool buttonTool = new ButtonTool("DOC_FOLDER_MOVEALLDOCS_KEY");
      menu.Tools.Add((ToolBase) buttonTool);
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) ImageCache.Instance.Folder;
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.Folder;
      tool.Tools.AddTool("DOC_FOLDER_MOVEALLDOCS_KEY");
      ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = "Document Folder Bulk Transfer";
    }
    if (!SystemSettings.GetSetting<bool>("DocumentSystem.ShowDocumentTypes", false))
      return;
    PopupMenuTool tool1 = (PopupMenuTool) ((ToolsCollectionBase) menu.Tools)["Documents"];
    ButtonTool buttonTool1 = new ButtonTool("DocTypes_Admin");
    menu.Tools.Add((ToolBase) buttonTool1);
    tool1.Tools.AddTool("DocTypes_Admin");
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedProps).Caption = "Document Types...";
  }
}
