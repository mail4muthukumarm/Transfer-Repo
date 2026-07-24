// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteDocumentToolBarManager
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.DockingManagement;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[MenuManager]
[Preference("Toolbars.NotesAndDocs.Visible", true)]
public class NoteDocumentToolBarManager : IMenuConsumer, IMdiActivationListener
{
  internal const string PREFERENCE_NOTE_DOC_TOOLBAR_ENABLE = "Toolbars.NotesAndDocs.Visible";
  private const string _documentCountQuery = "dbo.GetDocumentCount";
  private const string _noteCountQuery = "dbo.GetNoteCount";
  private UltraToolbarsManager _menu;
  private UltraToolbar _toolbar;
  private IRecreatableEntity _activeEntity;

  public void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
  }

  public void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (this._toolbar == null || !this._toolbar.Visible)
      return;
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Operators.CompareString(key, ((ToolBase) this.AssociatedNotesButton).Key, false) == 0)
    {
      if (!this.IsEnabled)
        return;
      try
      {
        DockingManager.ShowAndActivate("TabNotePanel");
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("An error occurred opening up the note tab. Please try resetting your dockable panes. Go to view, then press 'reset dockable panes'", "Could not display notes tab", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      if (Operators.CompareString(key, ((ToolBase) this.AssociatedDocumentsButton).Key, false) != 0)
        return;
      if (!this.IsEnabled)
        return;
      try
      {
        DockingManager.ShowAndActivate("TabDocumentPanel");
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("An error occurred opening up the document tab. Please try resetting your dockable panes. Go to view, then press 'reset dockable panes'", "Could not display documents tab", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }
  }

  public void OnRefreshTopLevelTools(object sender, UltraToolbarsManager menu)
  {
  }

  private bool IsEnabled => true;

  public void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    this._toolbar = menu.Toolbars.AddToolbar("Notes and Documents");
    if (!this.IsEnabled)
      return;
    this._menu = menu;
    this._toolbar.DockedPosition = (DockedPosition) 1;
    this._toolbar.Text = "Notes and Documents";
    DockingManager.MdiChildActivationListeners.Add((IMdiActivationListener) this);
    this.SetButtonText(this.AssociatedDocumentsButton, 0);
    this.SetButtonText(this.AssociatedNotesButton, 0);
  }

  private ButtonTool AssociatedDocumentsButton
  {
    get
    {
      return this.GetButton(nameof (AssociatedDocumentsButton), ImageCache.Instance.DocMain, "Document(s) on this entity");
    }
  }

  private ButtonTool AssociatedNotesButton
  {
    get
    {
      return this.GetButton(nameof (AssociatedNotesButton), ImageCache.Instance.NoteEntry, "Note(s) on this entity");
    }
  }

  private void SetButtonText(ButtonTool btn, int count)
  {
    if (btn == this.AssociatedNotesButton)
    {
      if (count > 0)
        ((ToolPropsBase) ((ToolBase) btn).SharedProps).Caption = "Click to view the notes on this entity";
      else
        ((ToolPropsBase) ((ToolBase) btn).SharedProps).Caption = "There are no notes on this entity";
    }
    else if (count > 0)
      ((ToolPropsBase) ((ToolBase) btn).SharedProps).Caption = "Click to view the documents on this entity";
    else
      ((ToolPropsBase) ((ToolBase) btn).SharedProps).Caption = "There are no documents on this entity";
  }

  private ButtonTool GetButton(string key, Image image, string captionRoot)
  {
    UltraToolbar toolbar = this._toolbar;
    ButtonTool button;
    if (!((ToolsCollectionBase) ((UltraToolbarBase) this._toolbar).Tools).Exists(key))
    {
      button = new ButtonTool(key);
      ((ToolPropsBase) ((ToolBase) button).SharedProps).AppearancesLarge.Appearance.Image = (object) image;
      ((ToolPropsBase) ((ToolBase) button).SharedProps).AppearancesSmall.Appearance.Image = (object) image;
      ((ToolPropsBase) ((ToolBase) button).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
      ((SubObjectBase) ((ToolBase) button).SharedProps).Tag = (object) captionRoot;
      ((ToolBase) button).SharedProps.ToolTipText = "Click to View";
      this._menu.Tools.Add((ToolBase) button);
      ((UltraToolbarBase) this._toolbar).Tools.AddTool(key);
    }
    else
      button = (ButtonTool) ((ToolsCollectionBase) ((UltraToolbarBase) this._toolbar).Tools)[key];
    return button;
  }

  private void RefreshAll()
  {
    if (this._toolbar == null || !this._toolbar.Visible)
      return;
    if (this._activeEntity != null && MDIControls.Instance.MDIParent.ActiveMdiChild is IRecreatableEntity)
    {
      IRecreatableEntity activeMdiChild = (IRecreatableEntity) MDIControls.Instance.MDIParent.ActiveMdiChild;
      if (activeMdiChild.CanReCreateEntity && !activeMdiChild.EntityGuid.Equals(Guid.Empty))
      {
        if (activeMdiChild.HasControlGUID)
        {
          Database.Instance.QueryMultithreadedSP.PerformScalarQuery(ThreadPriority.Lowest, (Control) MDIControls.Instance.MDIParent, (object) "NDM Notes Count", "dbo.GetNoteCount", new ScalarQueryMultithreadedEventHandler(this.ScalarQuery_Completed), (object) "@EntityGUID", (object) activeMdiChild.EntityGuid, (object) "@ControlGuid", (object) activeMdiChild.ControlGUID);
          Database.Instance.QueryMultithreadedSP.PerformScalarQuery(ThreadPriority.Lowest, (Control) MDIControls.Instance.MDIParent, (object) "NDM Docs Count", "dbo.GetDocumentCount", new ScalarQueryMultithreadedEventHandler(this.ScalarQuery_Completed), (object) "@EntityGUID", (object) activeMdiChild.EntityGuid, (object) "@ControlGuid", (object) activeMdiChild.ControlGUID);
        }
        else
        {
          this.SetButtonText(this.AssociatedDocumentsButton, 0);
          this.SetButtonText(this.AssociatedNotesButton, 0);
        }
      }
      else
      {
        this.SetButtonText(this.AssociatedDocumentsButton, 0);
        this.SetButtonText(this.AssociatedNotesButton, 0);
      }
    }
    else
    {
      this.SetButtonText(this.AssociatedDocumentsButton, 0);
      this.SetButtonText(this.AssociatedNotesButton, 0);
    }
  }

  private void ScalarQuery_Completed(object sender, ScalarQueryMultithreadedEventArgs e)
  {
    if (Operators.CompareString(e.Key.ToString(), "NDM Docs Count", false) == 0)
    {
      this.SetButtonText(this.AssociatedDocumentsButton, Database.IsNull(RuntimeHelpers.GetObjectValue(e.Result), 0));
    }
    else
    {
      if (Operators.CompareString(e.Key.ToString(), "NDM Notes Count", false) != 0)
        return;
      this.SetButtonText(this.AssociatedNotesButton, Database.IsNull(RuntimeHelpers.GetObjectValue(e.Result), 0));
    }
  }

  private void EntityNotesChanged(object sender, EventArgs e)
  {
    if (!(MDIControls.Instance.MDIParent.ActiveMdiChild is IRecreatableEntity))
      return;
    IRecreatableEntity activeMdiChild = (IRecreatableEntity) MDIControls.Instance.MDIParent.ActiveMdiChild;
    if (activeMdiChild.HasControlGUID)
      Database.Instance.QueryMultithreadedSP.PerformScalarQuery(ThreadPriority.Lowest, (Control) MDIControls.Instance.MDIParent, (object) "NDM Notes Count", "dbo.GetNoteCount", new ScalarQueryMultithreadedEventHandler(this.ScalarQuery_Completed), (object) "@EntityGUID", (object) activeMdiChild.EntityGuid, (object) "@ControlGuid", (object) activeMdiChild.ControlGUID);
    else
      this.SetButtonText(this.AssociatedNotesButton, 0);
  }

  private void EntityDocsChanged(object sender, EventArgs e)
  {
    if (!(MDIControls.Instance.MDIParent.ActiveMdiChild is IRecreatableEntity))
      return;
    IRecreatableEntity activeMdiChild = (IRecreatableEntity) MDIControls.Instance.MDIParent.ActiveMdiChild;
    if (activeMdiChild.HasControlGUID)
      Database.Instance.QueryMultithreadedSP.PerformScalarQuery(ThreadPriority.Lowest, (Control) MDIControls.Instance.MDIParent, (object) "NDM Docs Count", "dbo.GetDocumentCount", new ScalarQueryMultithreadedEventHandler(this.ScalarQuery_Completed), (object) "@EntityGUID", (object) activeMdiChild.EntityGuid, (object) "@ControlGuid", (object) activeMdiChild.ControlGUID);
    else
      this.SetButtonText(this.AssociatedDocumentsButton, 0);
  }

  public void MDIChildActivating(Form mdiChild)
  {
    this._activeEntity = mdiChild != null ? mdiChild as IRecreatableEntity : throw new ArgumentNullException(nameof (mdiChild));
    ISupportNoteSystem activeEntity1 = this._activeEntity as ISupportNoteSystem;
    ISupportDocumentSystem activeEntity2 = this._activeEntity as ISupportDocumentSystem;
    if (activeEntity1 != null)
      activeEntity1.EntityInfoChanged += new ISupportNoteSystem.EntityInfoChangedEventHandler(this.EntityNotesChanged);
    if (activeEntity2 != null)
      activeEntity2.EntityInfoChanged += new ISupportDocumentSystem.EntityInfoChangedEventHandler(this.EntityDocsChanged);
    this.RefreshAll();
  }

  public void MDIChildDeActivate(Form mdiChild)
  {
    ISupportNoteSystem supportNoteSystem = mdiChild != null ? ObjectFactory.QueryInterface<ISupportNoteSystem>((object) mdiChild) : throw new ArgumentNullException(nameof (mdiChild));
    ISupportDocumentSystem supportDocumentSystem = ObjectFactory.QueryInterface<ISupportDocumentSystem>((object) mdiChild);
    if (supportNoteSystem != null)
      supportNoteSystem.EntityInfoChanged -= new ISupportNoteSystem.EntityInfoChangedEventHandler(this.EntityNotesChanged);
    if (supportDocumentSystem != null)
      supportDocumentSystem.EntityInfoChanged -= new ISupportDocumentSystem.EntityInfoChangedEventHandler(this.EntityDocsChanged);
    this._activeEntity = (IRecreatableEntity) null;
    this.RefreshAll();
  }
}
