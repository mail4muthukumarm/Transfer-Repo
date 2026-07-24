// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteAutomationMenuManager
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[MenuManager]
public class NoteAutomationMenuManager : IMenuConsumer
{
  private const string CompanyLineNoteAutomationKey = "CompanyLineNoteAutomationKey";

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (Operators.CompareString(((CancelableToolEventArgs) e).Tool.Key, "fclCompany/Line", false) != 0 || ((ToolsCollectionBase) ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools).Exists("CompanyLineNoteAutomationKey"))
      return;
    ButtonTool buttonTool = new ButtonTool("CompanyLineNoteAutomationKey");
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = "Note Automation...";
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesSmall.Appearance.Image = (object) ImageCache.Instance.NoteSystem;
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).AppearancesLarge.Appearance.Image = (object) ImageCache.Instance.NoteSystem;
    ((CancelableToolEventArgs) e).Tool.ToolbarsManager.Tools.Add((ToolBase) buttonTool);
    ((PopupMenuTool) ((CancelableToolEventArgs) e).Tool).Tools.AddTool("CompanyLineNoteAutomationKey");
    ((CancelableToolEventArgs) e).Tool.ToolbarsManager.RefreshMerge();
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (Operators.CompareString(((ToolEventArgs) e).Tool.Key, "CompanyLineNoteAutomationKey", false) != 0 || !(MDIControls.Instance.MDIParent.ActiveMdiChild is IQueryResponse))
      return;
    Guid companyLineGuid = Database.IsNull(RuntimeHelpers.GetObjectValue(((IQueryResponse) MDIControls.Instance.MDIParent.ActiveMdiChild).RetrieveResponse("CompanyLineGuid", (object) null)), Guid.Empty);
    if (companyLineGuid.Equals(Guid.Empty))
    {
      int num1 = (int) MessageBox.Show("You must first choose a company line prior to invoking this option", "Company Line not chosen", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      using (NoteAutomationEventManagementForm eventManagementForm = new NoteAutomationEventManagementForm(companyLineGuid))
      {
        int num2 = (int) eventManagementForm.ShowDialog();
      }
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
  }
}
