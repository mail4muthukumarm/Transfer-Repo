// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.TabNotePanel
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDock;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.DockingManagement;
using MGASystems.Common.Extensions;
using MGASystems.Common.HotKeyManagement;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[Preference("DockingTabs.Notes.ActiveOpenItemsKey", "NOTES")]
[Preference("DockingTabs.Notes.View.UnboundNotes", "110")]
[Preference("DockingTabs.Notes.View.BoundNotes", "110")]
[Preference("DockingTabs.Notes.View.Notes.All", "110")]
[Preference("DockingTabs.Notes.View.Diaries.Upcoming", "110")]
[Preference("DockingTabs.Notes.View.Diaries.Urgent", "110")]
[Preference("DockingTabs.Notes.View.Diaries.All", "110")]
[SecureResource("{777545E2-340A-4df5-A550-7BB58891C3F9}", "Allow completion of diary for all users", "Allows a user to complete the diary for all users.", "Note System")]
[SecureResource("{B700B442-D0E6-4dc3-8B1F-8CC0130B2016}", "Create Notes", "Ability of user to create a note.", "Note System")]
[SecureResource("{953C7A3F-7944-4a53-8805-8DEAD8AF3416}", "Delete Notes", "Ability of user to delete a note", "Note System")]
[SecureResource("{50BEA1D7-25FC-4446-8256-7D0EA1928626}", "Bind Notes", "Ability of user to bind an unbound note to an entity in the system", "Note System")]
[SecureResource("{083720F6-9912-4453-AA32-5CC41CBAC6E8}", "UnBind Notes", "Ability of user to unbind a bound note from an entity in the system", "Note System")]
[SecureResource("{38E68308-622B-4401-9F45-DE5A342AB4AD}", "Complete Diaries", "Ability of user to complete a diary item", "Note System")]
[SecureResource("{93D4AA10-6A3B-4465-8848-6C716EE99751}", "View note or diary", "Ability of user to view the contents of a note", "Note System")]
[SecureTabResource("{E7190600-D227-4fe4-A491-8BB709660B6F}", "Access Note Tab", "Ability of user to access the tab at all", "Note System")]
[SecureHotkeyResource("{CB6BE5ED-97BD-4ecd-9077-7376E3D0C7FE}", "Note System Hot Key", "Determines if the user can access the note system from the hot key bar", "Note System")]
[SecureResource("{82DF5607-B6BD-4200-96E7-51522725A4AF}", "Access to View internal Notes", "Permission to view notes in the note Panel that have the internal bit = True", "Note System")]
[HotKeyInfo("NoteUserPanel", "Notes", "Note System", Keys.F12, "MGASystems.Tools.note.png")]
public class TabNotePanel : 
  DelayLoadUserControl,
  IDockingInfoProvider,
  IHotKeyDisplayItem,
  IMessageListener
{
  private IContainer components;
  private Label lblSubject;
  private Label lblCreatedDate;
  private UltraGroupBox pnlDetails;
  private SqlDataAdapter daNotesUnbound;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cnSQL;
  private dsTabNotePanel DsTabNotePanel;
  private SqlDataAdapter daNotesBound;
  private SqlDataAdapter daNoteEntriesUnread;
  private SqlCommand SqlSelectCommand4;
  private SqlDataAdapter daDiaryEntriesOpen;
  private SqlDataAdapter daDiaryEntriesUpcoming;
  private SqlDataAdapter daDiaryEntriesUrgent;
  private Label lblType;
  private Label lblCreatorName;
  private SqlCommand SqlSelectCommand5;
  private SqlCommand SqlSelectCommand6;
  private SqlCommand SqlSelectCommand7;
  private SqlCommand SqlSelectCommand3;
  private UltraTabControl uTabDiaries;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage2;
  private UltraTabPageControl UltraTabPageControl3;
  private UltraTabPageControl UltraTabPageControl4;
  private UltraTabPageControl UltraTabPageControl5;
  private UltraTabPageControl UltraTabPageControl6;
  private MenuItem MenuItem1;
  private MenuItem MenuItem2;
  private MenuItem MenuItem3;
  private const string ITEMPREFERENCES_KEY = "TABNOTEPANEL_ITEMSORTPREFERENCES";
  private const string TABNOTEPANEL_ACTIVEOPENITEMSKEY = "NoteSystem.ActiveOpenItemKey";
  private const string tabPreferencesSettingsKey = "TabPreferencesSettingsKey";
  private const string _itemPreferencesNotesBoundKey = "NotesBound";
  private const string _itemPreferencesNotesUnBoundKey = "NotesUnBound";
  private ISupportNoteSystem _entityNoteSupport;
  private Dictionary<string, TabNotePanel.TreeNodeSortComparer> _treeNodeSortComparerHash;
  private bool _inDrag;
  private Point _mouseDownPoint;
  private bool _View_internal_Notes;
  private DataTable ViewNoteInternal_Table;
  private readonly bool _showClaimsNoteSummary;
  private readonly bool _showClaimsDiarySummary;
  internal const string PREFERENCE_ACTIVEOPENITEMSKEY = "DockingTabs.Notes.ActiveOpenItemsKey";
  internal const string PREFERENCE_UNBOUNDNOTESVIEW = "DockingTabs.Notes.View.UnboundNotes";
  internal const string PREFERENCE_BOUNDNOTESVIEW = "DockingTabs.Notes.View.BoundNotes";
  internal const string PREFERENCE_NOTESALL = "DockingTabs.Notes.View.Notes.All";
  internal const string PREFERENCE_DIARIESUPCOMING = "DockingTabs.Notes.View.Diaries.Upcoming";
  internal const string PREFERENCE_DIARIESURGENT = "DockingTabs.Notes.View.Diaries.Urgent";
  internal const string PREFERENCE_DIARIESALL = "DockingTabs.Notes.View.Diaries.All";
  internal const string SECURE_RESOURCE_COMPLETEDIARYFORALLUSERS = "{777545E2-340A-4df5-A550-7BB58891C3F9}";
  internal const string SecurityIDCreateNewNote = "{B700B442-D0E6-4dc3-8B1F-8CC0130B2016}";
  internal const string SecurityIDPrintNote = "{1E9CE2D6-E131-4048-95BE-7AFBC689CA40}";
  internal const string SecurityIDDeleteNote = "{953C7A3F-7944-4a53-8805-8DEAD8AF3416}";
  internal const string SecurityIDBindNote = "{50BEA1D7-25FC-4446-8256-7D0EA1928626}";
  internal const string SecurityIDCompleteDiary = "{38E68308-622B-4401-9F45-DE5A342AB4AD}";
  internal const string SecurityIDViewNoteDiary = "{93D4AA10-6A3B-4465-8848-6C716EE99751}";
  internal const string SecurityIDViewNoteTab = "{E7190600-D227-4fe4-A491-8BB709660B6F}";
  internal const string SecurityIDUnbindNote = "{083720F6-9912-4453-AA32-5CC41CBAC6E8}";
  internal const string SecurityIDNotePanelHotKey = "{CB6BE5ED-97BD-4ecd-9077-7376E3D0C7FE}";
  internal const string View_internal_Notes = "{82DF5607-B6BD-4200-96E7-51522725A4AF}";
  private DataTable _updateLatestNoteTypeTable;
  private static Image _flagPurple;
  private static Image _flagGreen;
  private static Image _flagYellow;
  private static Image _flagRed;
  private static Image _flagBlue;

  static TabNotePanel() => TabNotePanel.NodeSubentrySortAsc = true;

  private virtual UltraTree trvNotesUnread
  {
    get => this._trvNotesUnread;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.tree_AfterActivate);
      EventHandler eventHandler2 = new EventHandler(this.tree_DoubleClick);
      UltraTree trvNotesUnread1 = this._trvNotesUnread;
      if (trvNotesUnread1 != null)
      {
        ((Control) trvNotesUnread1).Click -= eventHandler1;
        ((Control) trvNotesUnread1).DoubleClick -= eventHandler2;
      }
      this._trvNotesUnread = value;
      UltraTree trvNotesUnread2 = this._trvNotesUnread;
      if (trvNotesUnread2 == null)
        return;
      ((Control) trvNotesUnread2).Click += eventHandler1;
      ((Control) trvNotesUnread2).DoubleClick += eventHandler2;
    }
  }

  private virtual UltraTree trvNotesUnbound
  {
    get => this._trvNotesUnbound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.tree_AfterActivate);
      EventHandler eventHandler2 = new EventHandler(this.tree_DoubleClick);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.trvNotesUnbound_MouseMove);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.trvNotesUnbound_MouseUp);
      MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.trvNotesUnbound_MouseDown);
      BeforeNodeChangedEventHandler changedEventHandler = new BeforeNodeChangedEventHandler(this.trvNotes_BeforeExpand);
      UltraTree trvNotesUnbound1 = this._trvNotesUnbound;
      if (trvNotesUnbound1 != null)
      {
        ((Control) trvNotesUnbound1).Click -= eventHandler1;
        ((Control) trvNotesUnbound1).DoubleClick -= eventHandler2;
        ((Control) trvNotesUnbound1).MouseMove -= mouseEventHandler1;
        ((Control) trvNotesUnbound1).MouseUp -= mouseEventHandler2;
        ((Control) trvNotesUnbound1).MouseDown -= mouseEventHandler3;
        trvNotesUnbound1.BeforeExpand -= changedEventHandler;
      }
      this._trvNotesUnbound = value;
      UltraTree trvNotesUnbound2 = this._trvNotesUnbound;
      if (trvNotesUnbound2 == null)
        return;
      ((Control) trvNotesUnbound2).Click += eventHandler1;
      ((Control) trvNotesUnbound2).DoubleClick += eventHandler2;
      ((Control) trvNotesUnbound2).MouseMove += mouseEventHandler1;
      ((Control) trvNotesUnbound2).MouseUp += mouseEventHandler2;
      ((Control) trvNotesUnbound2).MouseDown += mouseEventHandler3;
      trvNotesUnbound2.BeforeExpand += changedEventHandler;
    }
  }

  private virtual UltraTree trvNotesBound
  {
    get => this._trvNotesBound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.tree_AfterActivate);
      EventHandler eventHandler2 = new EventHandler(this.tree_DoubleClick);
      DragEventHandler dragEventHandler1 = new DragEventHandler(this.trvNotesBound_DragDrop);
      DragEventHandler dragEventHandler2 = new DragEventHandler(this.trvNotesBound_DragOver);
      BeforeNodeChangedEventHandler changedEventHandler = new BeforeNodeChangedEventHandler(this.trvNotes_BeforeExpand);
      UltraTree trvNotesBound1 = this._trvNotesBound;
      if (trvNotesBound1 != null)
      {
        ((Control) trvNotesBound1).Click -= eventHandler1;
        ((Control) trvNotesBound1).DoubleClick -= eventHandler2;
        ((Control) trvNotesBound1).DragDrop -= dragEventHandler1;
        ((Control) trvNotesBound1).DragOver -= dragEventHandler2;
        trvNotesBound1.BeforeExpand -= changedEventHandler;
      }
      this._trvNotesBound = value;
      UltraTree trvNotesBound2 = this._trvNotesBound;
      if (trvNotesBound2 == null)
        return;
      ((Control) trvNotesBound2).Click += eventHandler1;
      ((Control) trvNotesBound2).DoubleClick += eventHandler2;
      ((Control) trvNotesBound2).DragDrop += dragEventHandler1;
      ((Control) trvNotesBound2).DragOver += dragEventHandler2;
      trvNotesBound2.BeforeExpand += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblCreatorNameSpec")]
  private virtual Label lblCreatorNameSpec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCreatedDateSpec")]
  private virtual Label lblCreatedDateSpec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSubjectSpec")]
  private virtual Label lblSubjectSpec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTypeSpec")]
  private virtual Label lblTypeSpec { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraTree trvDiariesUrgent
  {
    get => this._trvDiariesUrgent;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.tree_AfterActivate);
      EventHandler eventHandler2 = new EventHandler(this.tree_DoubleClick);
      UltraTree trvDiariesUrgent1 = this._trvDiariesUrgent;
      if (trvDiariesUrgent1 != null)
      {
        ((Control) trvDiariesUrgent1).Click -= eventHandler1;
        ((Control) trvDiariesUrgent1).DoubleClick -= eventHandler2;
      }
      this._trvDiariesUrgent = value;
      UltraTree trvDiariesUrgent2 = this._trvDiariesUrgent;
      if (trvDiariesUrgent2 == null)
        return;
      ((Control) trvDiariesUrgent2).Click += eventHandler1;
      ((Control) trvDiariesUrgent2).DoubleClick += eventHandler2;
    }
  }

  private virtual UltraTree trvDiariesUpcoming
  {
    get => this._trvDiariesUpcoming;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.tree_AfterActivate);
      EventHandler eventHandler2 = new EventHandler(this.tree_DoubleClick);
      UltraTree trvDiariesUpcoming1 = this._trvDiariesUpcoming;
      if (trvDiariesUpcoming1 != null)
      {
        ((Control) trvDiariesUpcoming1).Click -= eventHandler1;
        ((Control) trvDiariesUpcoming1).DoubleClick -= eventHandler2;
      }
      this._trvDiariesUpcoming = value;
      UltraTree trvDiariesUpcoming2 = this._trvDiariesUpcoming;
      if (trvDiariesUpcoming2 == null)
        return;
      ((Control) trvDiariesUpcoming2).Click += eventHandler1;
      ((Control) trvDiariesUpcoming2).DoubleClick += eventHandler2;
    }
  }

  private virtual UltraTree trvDiariesAll
  {
    get => this._trvDiariesAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.tree_AfterActivate);
      EventHandler eventHandler2 = new EventHandler(this.tree_DoubleClick);
      UltraTree trvDiariesAll1 = this._trvDiariesAll;
      if (trvDiariesAll1 != null)
      {
        ((Control) trvDiariesAll1).Click -= eventHandler1;
        ((Control) trvDiariesAll1).DoubleClick -= eventHandler2;
      }
      this._trvDiariesAll = value;
      UltraTree trvDiariesAll2 = this._trvDiariesAll;
      if (trvDiariesAll2 == null)
        return;
      ((Control) trvDiariesAll2).Click += eventHandler1;
      ((Control) trvDiariesAll2).DoubleClick += eventHandler2;
    }
  }

  private virtual LinkLabel lnkNewAssociatedNote
  {
    get => this._lnkNewAssociatedNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkNewAssociatedNote_LinkClicked);
      LinkLabel newAssociatedNote1 = this._lnkNewAssociatedNote;
      if (newAssociatedNote1 != null)
        newAssociatedNote1.LinkClicked -= clickedEventHandler;
      this._lnkNewAssociatedNote = value;
      LinkLabel newAssociatedNote2 = this._lnkNewAssociatedNote;
      if (newAssociatedNote2 == null)
        return;
      newAssociatedNote2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkNewUnboundNote
  {
    get => this._lnkNewUnboundNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkNewUnboundNote_LinkClicked);
      LinkLabel lnkNewUnboundNote1 = this._lnkNewUnboundNote;
      if (lnkNewUnboundNote1 != null)
        lnkNewUnboundNote1.LinkClicked -= clickedEventHandler;
      this._lnkNewUnboundNote = value;
      LinkLabel lnkNewUnboundNote2 = this._lnkNewUnboundNote;
      if (lnkNewUnboundNote2 == null)
        return;
      lnkNewUnboundNote2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual ContextMenu ctxTree
  {
    get => this._ctxTree;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ctxTree_Popup);
      ContextMenu ctxTree1 = this._ctxTree;
      if (ctxTree1 != null)
        ctxTree1.Popup -= eventHandler;
      this._ctxTree = value;
      ContextMenu ctxTree2 = this._ctxTree;
      if (ctxTree2 == null)
        return;
      ctxTree2.Popup += eventHandler;
    }
  }

  private virtual MenuItem mnuRefresh
  {
    get => this._mnuRefresh;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuRefresh_Click);
      MenuItem mnuRefresh1 = this._mnuRefresh;
      if (mnuRefresh1 != null)
        mnuRefresh1.Click -= eventHandler;
      this._mnuRefresh = value;
      MenuItem mnuRefresh2 = this._mnuRefresh;
      if (mnuRefresh2 == null)
        return;
      mnuRefresh2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuNewNote
  {
    get => this._mnuNewNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuNewNote_Click);
      MenuItem mnuNewNote1 = this._mnuNewNote;
      if (mnuNewNote1 != null)
        mnuNewNote1.Click -= eventHandler;
      this._mnuNewNote = value;
      MenuItem mnuNewNote2 = this._mnuNewNote;
      if (mnuNewNote2 == null)
        return;
      mnuNewNote2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("mnuSortRoot")]
  private virtual MenuItem mnuSortRoot { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MenuItem mnuSortSubject
  {
    get => this._mnuSortSubject;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuSortSubject_Click);
      MenuItem mnuSortSubject1 = this._mnuSortSubject;
      if (mnuSortSubject1 != null)
        mnuSortSubject1.Click -= eventHandler;
      this._mnuSortSubject = value;
      MenuItem mnuSortSubject2 = this._mnuSortSubject;
      if (mnuSortSubject2 == null)
        return;
      mnuSortSubject2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuSortAuthor
  {
    get => this._mnuSortAuthor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuSortAuthor_Click);
      MenuItem mnuSortAuthor1 = this._mnuSortAuthor;
      if (mnuSortAuthor1 != null)
        mnuSortAuthor1.Click -= eventHandler;
      this._mnuSortAuthor = value;
      MenuItem mnuSortAuthor2 = this._mnuSortAuthor;
      if (mnuSortAuthor2 == null)
        return;
      mnuSortAuthor2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuSortDateCreated
  {
    get => this._mnuSortDateCreated;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuSortDateCreated_Click);
      MenuItem mnuSortDateCreated1 = this._mnuSortDateCreated;
      if (mnuSortDateCreated1 != null)
        mnuSortDateCreated1.Click -= eventHandler;
      this._mnuSortDateCreated = value;
      MenuItem mnuSortDateCreated2 = this._mnuSortDateCreated;
      if (mnuSortDateCreated2 == null)
        return;
      mnuSortDateCreated2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuToggleFolders
  {
    get => this._mnuToggleFolders;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuToggleFolders_Click);
      MenuItem mnuToggleFolders1 = this._mnuToggleFolders;
      if (mnuToggleFolders1 != null)
        mnuToggleFolders1.Click -= eventHandler;
      this._mnuToggleFolders = value;
      MenuItem mnuToggleFolders2 = this._mnuToggleFolders;
      if (mnuToggleFolders2 == null)
        return;
      mnuToggleFolders2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuPrint
  {
    get => this._mnuPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuPrint_Click);
      MenuItem mnuPrint1 = this._mnuPrint;
      if (mnuPrint1 != null)
        mnuPrint1.Click -= eventHandler;
      this._mnuPrint = value;
      MenuItem mnuPrint2 = this._mnuPrint;
      if (mnuPrint2 == null)
        return;
      mnuPrint2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuPrintAllEntityNotes
  {
    get => this._mnuPrintAllEntityNotes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuPrintAllEntityNotes_Click);
      MenuItem printAllEntityNotes1 = this._mnuPrintAllEntityNotes;
      if (printAllEntityNotes1 != null)
        printAllEntityNotes1.Click -= eventHandler;
      this._mnuPrintAllEntityNotes = value;
      MenuItem printAllEntityNotes2 = this._mnuPrintAllEntityNotes;
      if (printAllEntityNotes2 == null)
        return;
      printAllEntityNotes2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuAssociateEntity
  {
    get => this._mnuAssociateEntity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuAssociateEntity_Click);
      MenuItem mnuAssociateEntity1 = this._mnuAssociateEntity;
      if (mnuAssociateEntity1 != null)
        mnuAssociateEntity1.Click -= eventHandler;
      this._mnuAssociateEntity = value;
      MenuItem mnuAssociateEntity2 = this._mnuAssociateEntity;
      if (mnuAssociateEntity2 == null)
        return;
      mnuAssociateEntity2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuDisassociateEntity
  {
    get => this._mnuDisassociateEntity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuDisassociateEntity_Click);
      MenuItem disassociateEntity1 = this._mnuDisassociateEntity;
      if (disassociateEntity1 != null)
        disassociateEntity1.Click -= eventHandler;
      this._mnuDisassociateEntity = value;
      MenuItem disassociateEntity2 = this._mnuDisassociateEntity;
      if (disassociateEntity2 == null)
        return;
      disassociateEntity2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuCompleteDiary
  {
    get => this._mnuCompleteDiary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuCompleteDiary_Click);
      MenuItem mnuCompleteDiary1 = this._mnuCompleteDiary;
      if (mnuCompleteDiary1 != null)
        mnuCompleteDiary1.Click -= eventHandler;
      this._mnuCompleteDiary = value;
      MenuItem mnuCompleteDiary2 = this._mnuCompleteDiary;
      if (mnuCompleteDiary2 == null)
        return;
      mnuCompleteDiary2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuDeleteNote
  {
    get => this._mnuDeleteNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuDeleteNote_Click);
      MenuItem mnuDeleteNote1 = this._mnuDeleteNote;
      if (mnuDeleteNote1 != null)
        mnuDeleteNote1.Click -= eventHandler;
      this._mnuDeleteNote = value;
      MenuItem mnuDeleteNote2 = this._mnuDeleteNote;
      if (mnuDeleteNote2 == null)
        return;
      mnuDeleteNote2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuOpenNote
  {
    get => this._mnuOpenNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuOpenNote_Click);
      MenuItem mnuOpenNote1 = this._mnuOpenNote;
      if (mnuOpenNote1 != null)
        mnuOpenNote1.Click -= eventHandler;
      this._mnuOpenNote = value;
      MenuItem mnuOpenNote2 = this._mnuOpenNote;
      if (mnuOpenNote2 == null)
        return;
      mnuOpenNote2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuCompleteDiaryForAll
  {
    get => this._mnuCompleteDiaryForAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuCompleteDiaryForAll_Click);
      MenuItem completeDiaryForAll1 = this._mnuCompleteDiaryForAll;
      if (completeDiaryForAll1 != null)
        completeDiaryForAll1.Click -= eventHandler;
      this._mnuCompleteDiaryForAll = value;
      MenuItem completeDiaryForAll2 = this._mnuCompleteDiaryForAll;
      if (completeDiaryForAll2 == null)
        return;
      completeDiaryForAll2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlBoundNotes")]
  private virtual UltraGroupBox pnlBoundNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SplitContainer1")]
  internal virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SplitContainer2")]
  internal virtual SplitContainer SplitContainer2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SplitContainer3")]
  internal virtual SplitContainer SplitContainer3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MenuItem mnuViewSummary
  {
    get => this._mnuViewSummary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuViewSummary_Click);
      MenuItem mnuViewSummary1 = this._mnuViewSummary;
      if (mnuViewSummary1 != null)
        mnuViewSummary1.Click -= eventHandler;
      this._mnuViewSummary = value;
      MenuItem mnuViewSummary2 = this._mnuViewSummary;
      if (mnuViewSummary2 == null)
        return;
      mnuViewSummary2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblBody")]
  private virtual Label lblBody { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MenuItem mnuSortDueDate
  {
    get => this._mnuSortDueDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MnuSortDueDate_Click);
      MenuItem mnuSortDueDate1 = this._mnuSortDueDate;
      if (mnuSortDueDate1 != null)
        mnuSortDueDate1.Click -= eventHandler;
      this._mnuSortDueDate = value;
      MenuItem mnuSortDueDate2 = this._mnuSortDueDate;
      if (mnuSortDueDate2 == null)
        return;
      mnuSortDueDate2.Click += eventHandler;
    }
  }

  internal virtual MenuItem mnuViewClaimSummary
  {
    get => this._mnuViewClaimSummary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuViewClaimSummary_Click);
      MenuItem viewClaimSummary1 = this._mnuViewClaimSummary;
      if (viewClaimSummary1 != null)
        viewClaimSummary1.Click -= eventHandler;
      this._mnuViewClaimSummary = value;
      MenuItem viewClaimSummary2 = this._mnuViewClaimSummary;
      if (viewClaimSummary2 == null)
        return;
      viewClaimSummary2.Click += eventHandler;
    }
  }

  internal virtual MenuItem mnuDiarySummary
  {
    get => this._mnuDiarySummary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuDiarySummary_Click);
      MenuItem mnuDiarySummary1 = this._mnuDiarySummary;
      if (mnuDiarySummary1 != null)
        mnuDiarySummary1.Click -= eventHandler;
      this._mnuDiarySummary = value;
      MenuItem mnuDiarySummary2 = this._mnuDiarySummary;
      if (mnuDiarySummary2 == null)
        return;
      mnuDiarySummary2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlNotesUnbound")]
  private virtual UltraGroupBox pnlNotesUnbound { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Override @override = new Override();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.trvDiariesUrgent = new UltraTree();
    this.ctxTree = new ContextMenu();
    this.mnuRefresh = new MenuItem();
    this.MenuItem1 = new MenuItem();
    this.mnuNewNote = new MenuItem();
    this.mnuOpenNote = new MenuItem();
    this.mnuDeleteNote = new MenuItem();
    this.mnuPrint = new MenuItem();
    this.mnuPrintAllEntityNotes = new MenuItem();
    this.MenuItem2 = new MenuItem();
    this.mnuSortRoot = new MenuItem();
    this.mnuSortSubject = new MenuItem();
    this.mnuSortAuthor = new MenuItem();
    this.mnuSortDateCreated = new MenuItem();
    this.mnuSortDueDate = new MenuItem();
    this.mnuToggleFolders = new MenuItem();
    this.mnuViewSummary = new MenuItem();
    this.MenuItem3 = new MenuItem();
    this.mnuAssociateEntity = new MenuItem();
    this.mnuDisassociateEntity = new MenuItem();
    this.mnuCompleteDiary = new MenuItem();
    this.mnuCompleteDiaryForAll = new MenuItem();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.trvDiariesUpcoming = new UltraTree();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.trvDiariesAll = new UltraTree();
    this.UltraTabPageControl6 = new UltraTabPageControl();
    this.trvNotesUnread = new UltraTree();
    this.lnkNewAssociatedNote = new LinkLabel();
    this.trvNotesBound = new UltraTree();
    this.lnkNewUnboundNote = new LinkLabel();
    this.trvNotesUnbound = new UltraTree();
    this.uTabDiaries = new UltraTabControl();
    this.UltraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.pnlDetails = new UltraGroupBox();
    this.lblBody = new Label();
    this.lblCreatorNameSpec = new Label();
    this.lblCreatedDateSpec = new Label();
    this.lblSubject = new Label();
    this.lblCreatedDate = new Label();
    this.lblType = new Label();
    this.lblCreatorName = new Label();
    this.lblSubjectSpec = new Label();
    this.lblTypeSpec = new Label();
    this.daNotesUnbound = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.DsTabNotePanel = new dsTabNotePanel();
    this.daNotesBound = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daNoteEntriesUnread = new SqlDataAdapter();
    this.SqlSelectCommand4 = new SqlCommand();
    this.daDiaryEntriesOpen = new SqlDataAdapter();
    this.SqlSelectCommand5 = new SqlCommand();
    this.daDiaryEntriesUpcoming = new SqlDataAdapter();
    this.SqlSelectCommand6 = new SqlCommand();
    this.daDiaryEntriesUrgent = new SqlDataAdapter();
    this.SqlSelectCommand7 = new SqlCommand();
    this.pnlNotesUnbound = new UltraGroupBox();
    this.pnlBoundNotes = new UltraGroupBox();
    this.SplitContainer1 = new SplitContainer();
    this.SplitContainer2 = new SplitContainer();
    this.SplitContainer3 = new SplitContainer();
    this.mnuViewClaimSummary = new MenuItem();
    this.mnuDiarySummary = new MenuItem();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.trvDiariesUrgent).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.trvDiariesUpcoming).BeginInit();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.trvDiariesAll).BeginInit();
    ((Control) this.UltraTabPageControl6).SuspendLayout();
    ((ISupportInitialize) this.trvNotesUnread).BeginInit();
    ((ISupportInitialize) this.trvNotesBound).BeginInit();
    ((ISupportInitialize) this.trvNotesUnbound).BeginInit();
    ((ISupportInitialize) this.uTabDiaries).BeginInit();
    ((Control) this.uTabDiaries).SuspendLayout();
    ((ISupportInitialize) this.pnlDetails).BeginInit();
    ((Control) this.pnlDetails).SuspendLayout();
    this.DsTabNotePanel.BeginInit();
    ((ISupportInitialize) this.pnlNotesUnbound).BeginInit();
    ((Control) this.pnlNotesUnbound).SuspendLayout();
    ((ISupportInitialize) this.pnlBoundNotes).BeginInit();
    ((Control) this.pnlBoundNotes).SuspendLayout();
    this.SplitContainer1.BeginInit();
    this.SplitContainer1.Panel1.SuspendLayout();
    this.SplitContainer1.Panel2.SuspendLayout();
    this.SplitContainer1.SuspendLayout();
    this.SplitContainer2.BeginInit();
    this.SplitContainer2.Panel1.SuspendLayout();
    this.SplitContainer2.Panel2.SuspendLayout();
    this.SplitContainer2.SuspendLayout();
    this.SplitContainer3.BeginInit();
    this.SplitContainer3.Panel1.SuspendLayout();
    this.SplitContainer3.Panel2.SuspendLayout();
    this.SplitContainer3.SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.trvDiariesUrgent);
    ((Control) this.UltraTabPageControl3).Location = new Point(1, 22);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(419, 88);
    ((Control) this.trvDiariesUrgent).ContextMenu = this.ctxTree;
    ((Control) this.trvDiariesUrgent).Dock = DockStyle.Fill;
    ((Control) this.trvDiariesUrgent).Location = new Point(0, 0);
    ((Control) this.trvDiariesUrgent).Name = "trvDiariesUrgent";
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.trvDiariesUrgent.ScrollBarLook = scrollBarLook1;
    ((Control) this.trvDiariesUrgent).Size = new Size(419, 88);
    ((Control) this.trvDiariesUrgent).TabIndex = 0;
    ((UltraControlBase) this.trvDiariesUrgent).UseFlatMode = (DefaultableBoolean) 1;
    this.ctxTree.MenuItems.AddRange(new MenuItem[18]
    {
      this.mnuRefresh,
      this.MenuItem1,
      this.mnuNewNote,
      this.mnuOpenNote,
      this.mnuDeleteNote,
      this.mnuPrint,
      this.mnuPrintAllEntityNotes,
      this.MenuItem2,
      this.mnuSortRoot,
      this.mnuToggleFolders,
      this.mnuViewSummary,
      this.mnuViewClaimSummary,
      this.mnuDiarySummary,
      this.MenuItem3,
      this.mnuAssociateEntity,
      this.mnuDisassociateEntity,
      this.mnuCompleteDiary,
      this.mnuCompleteDiaryForAll
    });
    this.mnuRefresh.Index = 0;
    this.mnuRefresh.Text = "Refresh";
    this.MenuItem1.Index = 1;
    this.MenuItem1.Text = "-";
    this.mnuNewNote.Index = 2;
    this.mnuNewNote.Text = "New Note";
    this.mnuOpenNote.Index = 3;
    this.mnuOpenNote.Text = "Open Note";
    this.mnuDeleteNote.Index = 4;
    this.mnuDeleteNote.Text = "Delete Note";
    this.mnuPrint.Index = 5;
    this.mnuPrint.Text = "Print Note";
    this.mnuPrintAllEntityNotes.Index = 6;
    this.mnuPrintAllEntityNotes.Text = "Print All Notes";
    this.MenuItem2.Index = 7;
    this.MenuItem2.Text = "-";
    this.mnuSortRoot.Index = 8;
    this.mnuSortRoot.MenuItems.AddRange(new MenuItem[4]
    {
      this.mnuSortSubject,
      this.mnuSortAuthor,
      this.mnuSortDateCreated,
      this.mnuSortDueDate
    });
    this.mnuSortRoot.Text = "Sort";
    this.mnuSortSubject.Index = 0;
    this.mnuSortSubject.Text = "Subject";
    this.mnuSortAuthor.Index = 1;
    this.mnuSortAuthor.Text = "Author";
    this.mnuSortDateCreated.Index = 2;
    this.mnuSortDateCreated.Text = "Date Created";
    this.mnuSortDueDate.Index = 3;
    this.mnuSortDueDate.Text = "Due Date";
    this.mnuToggleFolders.Index = 9;
    this.mnuToggleFolders.Text = "Toggle Folders";
    this.mnuViewSummary.Index = 10;
    this.mnuViewSummary.Text = "View Summary";
    this.MenuItem3.Index = 13;
    this.MenuItem3.Text = "-";
    this.mnuAssociateEntity.Index = 14;
    this.mnuAssociateEntity.Text = "Associate note to this entity";
    this.mnuDisassociateEntity.Index = 15;
    this.mnuDisassociateEntity.Text = "Disassociate note from this entity";
    this.mnuCompleteDiary.Index = 16 /*0x10*/;
    this.mnuCompleteDiary.Text = "Complete Diary";
    this.mnuCompleteDiaryForAll.Index = 17;
    this.mnuCompleteDiaryForAll.Text = "Complete Diary for all recipients";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.trvDiariesUpcoming);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(419, 88);
    ((Control) this.trvDiariesUpcoming).ContextMenu = this.ctxTree;
    ((Control) this.trvDiariesUpcoming).Dock = DockStyle.Fill;
    ((Control) this.trvDiariesUpcoming).Location = new Point(0, 0);
    ((Control) this.trvDiariesUpcoming).Name = "trvDiariesUpcoming";
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.trvDiariesUpcoming.ScrollBarLook = scrollBarLook2;
    ((Control) this.trvDiariesUpcoming).Size = new Size(419, 88);
    ((Control) this.trvDiariesUpcoming).TabIndex = 0;
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.trvDiariesAll);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(419, 88);
    ((Control) this.trvDiariesAll).ContextMenu = this.ctxTree;
    ((Control) this.trvDiariesAll).Dock = DockStyle.Fill;
    ((Control) this.trvDiariesAll).Location = new Point(0, 0);
    ((Control) this.trvDiariesAll).Name = "trvDiariesAll";
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.trvDiariesAll.ScrollBarLook = scrollBarLook3;
    ((Control) this.trvDiariesAll).Size = new Size(419, 88);
    ((Control) this.trvDiariesAll).TabIndex = 0;
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.trvNotesUnread);
    ((Control) this.UltraTabPageControl6).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl6).Name = "UltraTabPageControl6";
    ((Control) this.UltraTabPageControl6).Size = new Size(419, 88);
    ((Control) this.trvNotesUnread).ContextMenu = this.ctxTree;
    ((Control) this.trvNotesUnread).Dock = DockStyle.Fill;
    ((Control) this.trvNotesUnread).Location = new Point(0, 0);
    ((Control) this.trvNotesUnread).Name = "trvNotesUnread";
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.trvNotesUnread.ScrollBarLook = scrollBarLook4;
    ((Control) this.trvNotesUnread).Size = new Size(419, 88);
    ((Control) this.trvNotesUnread).TabIndex = 0;
    this.lnkNewAssociatedNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkNewAssociatedNote.AutoSize = true;
    this.lnkNewAssociatedNote.Enabled = false;
    this.lnkNewAssociatedNote.Location = new Point(478, 23);
    this.lnkNewAssociatedNote.Name = "lnkNewAssociatedNote";
    this.lnkNewAssociatedNote.Size = new Size(109, 13);
    this.lnkNewAssociatedNote.TabIndex = 2;
    this.lnkNewAssociatedNote.TabStop = true;
    this.lnkNewAssociatedNote.Text = "New Associated Note";
    this.lnkNewAssociatedNote.TextAlign = ContentAlignment.TopRight;
    ((Control) this.trvNotesBound).AllowDrop = true;
    this.trvNotesBound.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.trvNotesBound).ContextMenu = this.ctxTree;
    ((Control) this.trvNotesBound).Dock = DockStyle.Fill;
    ((Control) this.trvNotesBound).Location = new Point(2, 19);
    ((Control) this.trvNotesBound).Name = "trvNotesBound";
    @override.ShowExpansionIndicator = (ShowExpansionIndicator) 4;
    this.trvNotesBound.Override = @override;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    this.trvNotesBound.ScrollBarLook = scrollBarLook5;
    ((Control) this.trvNotesBound).Size = new Size(417, 178);
    ((Control) this.trvNotesBound).TabIndex = 0;
    ((UltraControlBase) this.trvNotesBound).UseFlatMode = (DefaultableBoolean) 1;
    this.lnkNewUnboundNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkNewUnboundNote.AutoSize = true;
    this.lnkNewUnboundNote.Location = new Point(464, 6);
    this.lnkNewUnboundNote.Name = "lnkNewUnboundNote";
    this.lnkNewUnboundNote.Size = new Size(121, 13);
    this.lnkNewUnboundNote.TabIndex = 1;
    this.lnkNewUnboundNote.TabStop = true;
    this.lnkNewUnboundNote.Text = "New Unassociated Note";
    this.lnkNewUnboundNote.TextAlign = ContentAlignment.TopRight;
    this.trvNotesUnbound.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.trvNotesUnbound).ContextMenu = this.ctxTree;
    ((Control) this.trvNotesUnbound).Dock = DockStyle.Fill;
    ((Control) this.trvNotesUnbound).Location = new Point(2, 19);
    ((Control) this.trvNotesUnbound).Name = "trvNotesUnbound";
    scrollBarLook6.ViewStyle = (ScrollBarViewStyle) 3;
    this.trvNotesUnbound.ScrollBarLook = scrollBarLook6;
    ((Control) this.trvNotesUnbound).Size = new Size(417, 98);
    ((Control) this.trvNotesUnbound).TabIndex = 0;
    ((UltraControlBase) this.trvNotesUnbound).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.uTabDiaries).Controls.Add((Control) this.UltraTabSharedControlsPage2);
    ((Control) this.uTabDiaries).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.uTabDiaries).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.uTabDiaries).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.uTabDiaries).Controls.Add((Control) this.UltraTabPageControl6);
    ((Control) this.uTabDiaries).Dock = DockStyle.Fill;
    ((Control) this.uTabDiaries).Location = new Point(0, 0);
    ((Control) this.uTabDiaries).Name = "uTabDiaries";
    ((UltraTabControlBase) this.uTabDiaries).SharedControlsPage = this.UltraTabSharedControlsPage2;
    ((Control) this.uTabDiaries).Size = new Size(421, 111);
    ((Control) this.uTabDiaries).TabIndex = 1;
    ((UltraTabControlBase) this.uTabDiaries).TabPadding = new Size(3, 1);
    ultraTab1.Key = "URGENT";
    ultraTab1.TabPage = this.UltraTabPageControl3;
    ultraTab1.Text = "Urgent diaries";
    ultraTab2.Key = "UPCOMING";
    ultraTab2.TabPage = this.UltraTabPageControl4;
    ultraTab2.Text = "Upcoming diaries";
    ultraTab3.Key = "ALL";
    ultraTab3.TabPage = this.UltraTabPageControl5;
    ultraTab3.Text = "All diaries";
    ultraTab4.Key = "NOTES";
    ultraTab4.TabPage = this.UltraTabPageControl6;
    ultraTab4.Text = "Notes";
    ((UltraTabControlBase) this.uTabDiaries).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraControlBase) this.uTabDiaries).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.uTabDiaries).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.uTabDiaries).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage2).Name = "UltraTabSharedControlsPage2";
    ((Control) this.UltraTabSharedControlsPage2).Size = new Size(419, 88);
    appearance1.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.pnlDetails.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblBody);
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblCreatorNameSpec);
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblCreatedDateSpec);
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblSubject);
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblCreatedDate);
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblType);
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblCreatorName);
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblSubjectSpec);
    ((Control) this.pnlDetails).Controls.Add((Control) this.lblTypeSpec);
    this.pnlDetails.Dock = DockStyle.Fill;
    appearance2.ForeColor = Color.FromArgb(21, 66, 139);
    this.pnlDetails.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.pnlDetails).Location = new Point(0, 0);
    ((Control) this.pnlDetails).Name = "pnlDetails";
    ((Control) this.pnlDetails).Size = new Size(421, 101);
    ((Control) this.pnlDetails).TabIndex = 0;
    this.pnlDetails.Text = " Details";
    this.pnlDetails.ViewStyle = (GroupBoxViewStyle) 2;
    this.lblBody.AutoSize = true;
    this.lblBody.BackColor = Color.Transparent;
    this.lblBody.Location = new Point(8, 87);
    this.lblBody.MaximumSize = new Size(270, 0);
    this.lblBody.Name = "lblBody";
    this.lblBody.Size = new Size(31 /*0x1F*/, 13);
    this.lblBody.TabIndex = 9;
    this.lblBody.Text = "Body";
    this.lblCreatorNameSpec.BackColor = Color.Transparent;
    this.lblCreatorNameSpec.Location = new Point(8, 56);
    this.lblCreatorNameSpec.Name = "lblCreatorNameSpec";
    this.lblCreatorNameSpec.Size = new Size(58, 17);
    this.lblCreatorNameSpec.TabIndex = 5;
    this.lblCreatorNameSpec.Text = "Originator:";
    this.lblCreatorNameSpec.TextAlign = ContentAlignment.MiddleLeft;
    this.lblCreatedDateSpec.BackColor = Color.Transparent;
    this.lblCreatedDateSpec.Location = new Point(8, 40);
    this.lblCreatedDateSpec.Name = "lblCreatedDateSpec";
    this.lblCreatedDateSpec.Size = new Size(47, 17);
    this.lblCreatedDateSpec.TabIndex = 3;
    this.lblCreatedDateSpec.Text = "Created:";
    this.lblCreatedDateSpec.TextAlign = ContentAlignment.MiddleLeft;
    this.lblSubject.AutoSize = true;
    this.lblSubject.BackColor = Color.Transparent;
    this.lblSubject.Location = new Point(72, 26);
    this.lblSubject.Name = "lblSubject";
    this.lblSubject.Size = new Size(10, 13);
    this.lblSubject.TabIndex = 2;
    this.lblSubject.Text = " ";
    this.lblCreatedDate.AutoSize = true;
    this.lblCreatedDate.BackColor = Color.Transparent;
    this.lblCreatedDate.Location = new Point(72, 42);
    this.lblCreatedDate.Name = "lblCreatedDate";
    this.lblCreatedDate.Size = new Size(10, 13);
    this.lblCreatedDate.TabIndex = 4;
    this.lblCreatedDate.Text = " ";
    this.lblType.AutoSize = true;
    this.lblType.BackColor = Color.Transparent;
    this.lblType.Location = new Point(72, 74);
    this.lblType.Name = "lblType";
    this.lblType.Size = new Size(10, 13);
    this.lblType.TabIndex = 8;
    this.lblType.Text = " ";
    this.lblCreatorName.AutoSize = true;
    this.lblCreatorName.BackColor = Color.Transparent;
    this.lblCreatorName.Location = new Point(72, 58);
    this.lblCreatorName.Name = "lblCreatorName";
    this.lblCreatorName.Size = new Size(10, 13);
    this.lblCreatorName.TabIndex = 6;
    this.lblCreatorName.Text = " ";
    this.lblSubjectSpec.BackColor = Color.Transparent;
    this.lblSubjectSpec.Location = new Point(8, 24);
    this.lblSubjectSpec.Name = "lblSubjectSpec";
    this.lblSubjectSpec.Size = new Size(45, 17);
    this.lblSubjectSpec.TabIndex = 1;
    this.lblSubjectSpec.Text = "Subject:";
    this.lblSubjectSpec.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTypeSpec.BackColor = Color.Transparent;
    this.lblTypeSpec.Location = new Point(8, 72);
    this.lblTypeSpec.Name = "lblTypeSpec";
    this.lblTypeSpec.Size = new Size(33, 17);
    this.lblTypeSpec.TabIndex = 7;
    this.lblTypeSpec.Text = "Type:";
    this.lblTypeSpec.TextAlign = ContentAlignment.MiddleLeft;
    this.daNotesUnbound.SelectCommand = this.SqlSelectCommand1;
    this.daNotesUnbound.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblNotesUnbound", new DataColumnMapping[5]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CreatedDate", "CreatedDate"),
        new DataColumnMapping("Type", "Type"),
        new DataColumnMapping("Subject", "Subject"),
        new DataColumnMapping("UserName", "UserName")
      })
    });
    this.SqlSelectCommand1.CommandText = "NoteSystem_FetchUnboundNotes";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID")
    });
    this.cnSQL.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.DsTabNotePanel.DataSetName = "dsTabNotePanel";
    this.DsTabNotePanel.Locale = new CultureInfo("en-US");
    this.DsTabNotePanel.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daNotesBound.SelectCommand = this.SqlSelectCommand3;
    this.daNotesBound.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblNoteStore", new DataColumnMapping[5]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CreatedDate", "CreatedDate"),
        new DataColumnMapping("Type", "Type"),
        new DataColumnMapping("Subject", "Subject"),
        new DataColumnMapping("UserName", "UserName")
      })
    });
    this.SqlSelectCommand3.CommandText = "NoteSystem_FetchBoundNotes";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@EntityGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AssociatedEntityGUID"),
      new SqlParameter("@ControlGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ControlGuid")
    });
    this.daNoteEntriesUnread.SelectCommand = this.SqlSelectCommand4;
    this.daNoteEntriesUnread.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblEntriesUnread", new DataColumnMapping[7]
      {
        new DataColumnMapping("EntryGUID", "EntryGUID"),
        new DataColumnMapping("NoteGUID", "NoteGUID"),
        new DataColumnMapping("CreatedDate", "CreatedDate"),
        new DataColumnMapping("BODY", "BODY"),
        new DataColumnMapping("UserName", "UserName"),
        new DataColumnMapping("Subject", "Subject"),
        new DataColumnMapping("Type", "Type")
      })
    });
    this.SqlSelectCommand4.CommandText = "NoteSystem_FetchUnreadNoteEntries";
    this.SqlSelectCommand4.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand4.Connection = this.cnSQL;
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID")
    });
    this.daDiaryEntriesOpen.SelectCommand = this.SqlSelectCommand5;
    this.daDiaryEntriesOpen.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDiaryEntriesOpen", new DataColumnMapping[9]
      {
        new DataColumnMapping("EntryGUID", "EntryGUID"),
        new DataColumnMapping("NoteGUID", "NoteGUID"),
        new DataColumnMapping("IsDiary", "IsDiary"),
        new DataColumnMapping("CreatedDate", "CreatedDate"),
        new DataColumnMapping("DueDate", "DueDate"),
        new DataColumnMapping("Body", "Body"),
        new DataColumnMapping("Type", "Type"),
        new DataColumnMapping("Subject", "Subject"),
        new DataColumnMapping("UserName", "UserName")
      })
    });
    this.SqlSelectCommand5.CommandText = "NoteSystem_FetchOpenDiaryEntries";
    this.SqlSelectCommand5.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand5.Connection = this.cnSQL;
    this.SqlSelectCommand5.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID")
    });
    this.daDiaryEntriesUpcoming.SelectCommand = this.SqlSelectCommand6;
    this.daDiaryEntriesUpcoming.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblNoteRecipients", new DataColumnMapping[9]
      {
        new DataColumnMapping("EntryGUID", "EntryGUID"),
        new DataColumnMapping("NoteGUID", "NoteGUID"),
        new DataColumnMapping("IsDiary", "IsDiary"),
        new DataColumnMapping("CreatedDate", "CreatedDate"),
        new DataColumnMapping("DueDate", "DueDate"),
        new DataColumnMapping("Body", "Body"),
        new DataColumnMapping("Type", "Type"),
        new DataColumnMapping("Subject", "Subject"),
        new DataColumnMapping("UserName", "UserName")
      })
    });
    this.SqlSelectCommand6.CommandText = "NoteSystem_FetchUpcomingDiaryEntries";
    this.SqlSelectCommand6.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand6.Connection = this.cnSQL;
    this.SqlSelectCommand6.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID")
    });
    this.daDiaryEntriesUrgent.SelectCommand = this.SqlSelectCommand7;
    this.daDiaryEntriesUrgent.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDiaryEntriesUrgent", new DataColumnMapping[9]
      {
        new DataColumnMapping("EntryGUID", "EntryGUID"),
        new DataColumnMapping("NoteGUID", "NoteGUID"),
        new DataColumnMapping("IsDiary", "IsDiary"),
        new DataColumnMapping("CreatedDate", "CreatedDate"),
        new DataColumnMapping("DueDate", "DueDate"),
        new DataColumnMapping("Body", "Body"),
        new DataColumnMapping("Type", "Type"),
        new DataColumnMapping("Subject", "Subject"),
        new DataColumnMapping("UserName", "UserName")
      })
    });
    this.SqlSelectCommand7.CommandText = "NoteSystem_FetchUrgentDiaryEntries";
    this.SqlSelectCommand7.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand7.Connection = this.cnSQL;
    this.SqlSelectCommand7.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@UserGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UserGUID")
    });
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.pnlNotesUnbound.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.pnlNotesUnbound).Controls.Add((Control) this.lnkNewUnboundNote);
    ((Control) this.pnlNotesUnbound).Controls.Add((Control) this.trvNotesUnbound);
    this.pnlNotesUnbound.Dock = DockStyle.Fill;
    appearance4.ForeColor = Color.FromArgb(21, 66, 139);
    this.pnlNotesUnbound.HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.pnlNotesUnbound).Location = new Point(0, 0);
    ((Control) this.pnlNotesUnbound).Name = "pnlNotesUnbound";
    ((Control) this.pnlNotesUnbound).Size = new Size(421, 119);
    ((Control) this.pnlNotesUnbound).TabIndex = 6;
    this.pnlNotesUnbound.Text = "Un-Associated Notes";
    this.pnlNotesUnbound.ViewStyle = (GroupBoxViewStyle) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.pnlBoundNotes.ContentAreaAppearance = (AppearanceBase) appearance5;
    ((Control) this.pnlBoundNotes).Controls.Add((Control) this.trvNotesBound);
    ((Control) this.pnlBoundNotes).Controls.Add((Control) this.lnkNewAssociatedNote);
    this.pnlBoundNotes.Dock = DockStyle.Fill;
    appearance6.ForeColor = Color.FromArgb(21, 66, 139);
    this.pnlBoundNotes.HeaderAppearance = (AppearanceBase) appearance6;
    ((Control) this.pnlBoundNotes).Location = new Point(0, 0);
    ((Control) this.pnlBoundNotes).Name = "pnlBoundNotes";
    ((Control) this.pnlBoundNotes).Size = new Size(421, 199);
    ((Control) this.pnlBoundNotes).TabIndex = 8;
    this.pnlBoundNotes.Text = "Associated Notes";
    this.pnlBoundNotes.ViewStyle = (GroupBoxViewStyle) 2;
    this.SplitContainer1.Dock = DockStyle.Fill;
    this.SplitContainer1.Location = new Point(0, 0);
    this.SplitContainer1.Name = "SplitContainer1";
    this.SplitContainer1.Orientation = Orientation.Horizontal;
    this.SplitContainer1.Panel1.Controls.Add((Control) this.pnlBoundNotes);
    this.SplitContainer1.Panel2.Controls.Add((Control) this.SplitContainer2);
    this.SplitContainer1.Size = new Size(421, 542);
    this.SplitContainer1.SplitterDistance = 199;
    this.SplitContainer1.TabIndex = 9;
    this.SplitContainer2.Dock = DockStyle.Fill;
    this.SplitContainer2.Location = new Point(0, 0);
    this.SplitContainer2.Name = "SplitContainer2";
    this.SplitContainer2.Orientation = Orientation.Horizontal;
    this.SplitContainer2.Panel1.Controls.Add((Control) this.pnlNotesUnbound);
    this.SplitContainer2.Panel2.Controls.Add((Control) this.SplitContainer3);
    this.SplitContainer2.Size = new Size(421, 339);
    this.SplitContainer2.SplitterDistance = 119;
    this.SplitContainer2.TabIndex = 10;
    this.SplitContainer3.Dock = DockStyle.Fill;
    this.SplitContainer3.Location = new Point(0, 0);
    this.SplitContainer3.Name = "SplitContainer3";
    this.SplitContainer3.Orientation = Orientation.Horizontal;
    this.SplitContainer3.Panel1.Controls.Add((Control) this.uTabDiaries);
    this.SplitContainer3.Panel2.Controls.Add((Control) this.pnlDetails);
    this.SplitContainer3.Size = new Size(421, 216);
    this.SplitContainer3.SplitterDistance = 111;
    this.SplitContainer3.TabIndex = 0;
    this.mnuViewClaimSummary.Index = 11;
    this.mnuViewClaimSummary.Text = "View Claim Notes Summary";
    this.mnuDiarySummary.Index = 12;
    this.mnuDiarySummary.Text = "View Diary Summary";
    this.BackColor = Color.FromArgb(193, 215, 249);
    this.Controls.Add((Control) this.SplitContainer1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (TabNotePanel);
    this.Size = new Size(421, 542);
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.trvDiariesUrgent).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.trvDiariesUpcoming).EndInit();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.trvDiariesAll).EndInit();
    ((Control) this.UltraTabPageControl6).ResumeLayout(false);
    ((ISupportInitialize) this.trvNotesUnread).EndInit();
    ((ISupportInitialize) this.trvNotesBound).EndInit();
    ((ISupportInitialize) this.trvNotesUnbound).EndInit();
    ((ISupportInitialize) this.uTabDiaries).EndInit();
    ((Control) this.uTabDiaries).ResumeLayout(false);
    ((ISupportInitialize) this.pnlDetails).EndInit();
    ((Control) this.pnlDetails).ResumeLayout(false);
    ((Control) this.pnlDetails).PerformLayout();
    this.DsTabNotePanel.EndInit();
    ((ISupportInitialize) this.pnlNotesUnbound).EndInit();
    ((Control) this.pnlNotesUnbound).ResumeLayout(false);
    ((Control) this.pnlNotesUnbound).PerformLayout();
    ((ISupportInitialize) this.pnlBoundNotes).EndInit();
    ((Control) this.pnlBoundNotes).ResumeLayout(false);
    ((Control) this.pnlBoundNotes).PerformLayout();
    this.SplitContainer1.Panel1.ResumeLayout(false);
    this.SplitContainer1.Panel2.ResumeLayout(false);
    this.SplitContainer1.EndInit();
    this.SplitContainer1.ResumeLayout(false);
    this.SplitContainer2.Panel1.ResumeLayout(false);
    this.SplitContainer2.Panel2.ResumeLayout(false);
    this.SplitContainer2.EndInit();
    this.SplitContainer2.ResumeLayout(false);
    this.SplitContainer3.Panel1.ResumeLayout(false);
    this.SplitContainer3.Panel2.ResumeLayout(false);
    this.SplitContainer3.EndInit();
    this.SplitContainer3.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public TabNotePanel()
  {
    this.DelayLoad += new EventHandler(this.TabNotePanel_DelayLoad);
    this.RefreshUI += new EventHandler(this.TabNotePanel_RefreshUI);
    this._treeNodeSortComparerHash = new Dictionary<string, TabNotePanel.TreeNodeSortComparer>();
    this._View_internal_Notes = false;
    this.ViewNoteInternal_Table = (DataTable) null;
    this.InitializeComponent();
    this.trvNotesUnbound.SelectionBehavior = (SelectionBehavior) 1;
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._showClaimsNoteSummary = SystemSettings.GetSetting<bool>("Notes.Show.ClaimSummaryMenu", false);
    this._showClaimsDiarySummary = SystemSettings.GetSetting<bool>("Notes.Show.DiarySummaryMenu", false);
  }

  private void TabNotePanel_DelayLoad(object sender, EventArgs e)
  {
    this.lblBody.Text = "";
    this.SecureUI();
    this.LoadUISettings();
    this.LoadAllNotes();
    Note_System.Instance.NoteCollectionModified += new Note_System.NoteCollectionModifiedEventhandler(this.NoteSystem_NoteCollectionChanged);
    TabNotePanel.TreeDragDropHelper treeDragDropHelper = new TabNotePanel.TreeDragDropHelper(this.trvNotesBound, this);
  }

  private static TabNotePanel.TreeViewPreferences GetTreePreferencesFromTree(UltraTree tree)
  {
    if (((Control) tree).Tag == null)
      ((Control) tree).Tag = (object) new TabNotePanel.TreeViewPreferences();
    return (TabNotePanel.TreeViewPreferences) ((Control) tree).Tag;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void LoadUISettings()
  {
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    TabNotePanel.LoadTreePrefs(this.trvNotesUnbound, "DockingTabs.Notes.View.UnboundNotes");
    TabNotePanel.LoadTreePrefs(this.trvNotesBound, "DockingTabs.Notes.View.BoundNotes");
    TabNotePanel.LoadTreePrefs(this.trvNotesUnread, "DockingTabs.Notes.View.Notes.All");
    TabNotePanel.LoadTreePrefs(this.trvDiariesUpcoming, "DockingTabs.Notes.View.Diaries.Upcoming");
    TabNotePanel.LoadTreePrefs(this.trvDiariesUrgent, "DockingTabs.Notes.View.Diaries.Urgent");
    TabNotePanel.LoadTreePrefs(this.trvDiariesAll, "DockingTabs.Notes.View.Diaries.All");
  }

  private static void LoadTreePrefs(UltraTree tree, string prefKey)
  {
    if (((Control) tree).Tag != null)
      return;
    ((Control) tree).Tag = (object) TabNotePanel.TreeViewPreferences.FromString(Conversions.ToString(Preferences.GetPreference(prefKey)));
  }

  private void SaveUISettings()
  {
    Preferences.SetPreference("DockingTabs.Notes.View.UnboundNotes", TabNotePanel.GetTreePreferencesFromTree(this.trvNotesUnbound).ToString());
    Preferences.SetPreference("DockingTabs.Notes.View.BoundNotes", TabNotePanel.GetTreePreferencesFromTree(this.trvNotesBound).ToString());
    Preferences.SetPreference("DockingTabs.Notes.View.Notes.All", TabNotePanel.GetTreePreferencesFromTree(this.trvNotesUnread).ToString());
    Preferences.SetPreference("DockingTabs.Notes.View.Diaries.Upcoming", TabNotePanel.GetTreePreferencesFromTree(this.trvDiariesUpcoming).ToString());
    Preferences.SetPreference("DockingTabs.Notes.View.Diaries.Urgent", TabNotePanel.GetTreePreferencesFromTree(this.trvDiariesUrgent).ToString());
    Preferences.SetPreference("DockingTabs.Notes.View.Diaries.All", TabNotePanel.GetTreePreferencesFromTree(this.trvDiariesAll).ToString());
  }

  private void SecureUI()
  {
    SecurityManager.BeginAssertPermission((Control) MDIControls.Instance.MDIParent, new AssertPermissionEventHandler(this.SecurityManager_PermissionResolved), "{1E9CE2D6-E131-4048-95BE-7AFBC689CA40}", "{083720F6-9912-4453-AA32-5CC41CBAC6E8}", "{B700B442-D0E6-4dc3-8B1F-8CC0130B2016}", "{953C7A3F-7944-4a53-8805-8DEAD8AF3416}", "{38E68308-622B-4401-9F45-DE5A342AB4AD}", "{50BEA1D7-25FC-4446-8256-7D0EA1928626}");
    this._View_internal_Notes = SecurityManager.Instance.AssertPermission("{82DF5607-B6BD-4200-96E7-51522725A4AF}");
  }

  private void SecurityManager_PermissionResolved(object sender, AssertPermissionEventArgs e)
  {
  }

  private void SortTree(UltraTree tree)
  {
    ((UltraControlBase) tree).BeginUpdate();
    try
    {
      tree.Override.Sort = (SortType) 3;
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
      return;
    }
    TabNotePanel.TreeNodeSortComparer nodeSortComparer = this.GetTreeNodeSortComparer(tree);
    TabNotePanel.TreeViewPreferences preferencesFromTree = TabNotePanel.GetTreePreferencesFromTree(tree);
    try
    {
      tree.Override.SortComparer = (IComparer) nodeSortComparer;
      tree.Override.Sort = !preferencesFromTree.SortAsc ? (SortType) 2 : (SortType) 1;
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
      return;
    }
    ((UltraControlBase) tree).EndUpdate();
  }

  private void RefreshTree(UltraTree tree)
  {
    TreeNodeStructureSerializer structureSerializer = new TreeNodeStructureSerializer(tree);
    structureSerializer.SaveStructure();
    tree.Nodes.Clear();
    try
    {
      tree.Nodes.Add("Loading, Please wait...");
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    ((UltraControlBase) tree).BeginUpdate();
    if (tree == this.trvNotesBound || tree == this.trvNotesUnbound)
      this.RefreshTreeNotes(tree);
    else if (tree == this.trvNotesUnread)
      this.RefreshTreeEntries(tree);
    else
      this.RefreshTreeDiaries(tree);
    ((UltraControlBase) tree).EndUpdate();
    structureSerializer.ApplyStructure();
    this.SortTree(tree);
  }

  public DockWindowCreationInfo CreationInfo
  {
    get
    {
      return new DockWindowCreationInfo(nameof (TabNotePanel), "Notes", (DockedLocation) 1, "LeftGroupKey", ImageCache.Instance.NoteSystem, false);
    }
  }

  public void InitializeOnSplashLoad()
  {
    if (Database.Instance.QueryText.PerformScalarQueryInt("SELECT COUNT(*) FROM lstSystemEntities WHERE SystemEntityID = 1") != 0)
      return;
    Database.Instance.QueryText.PerformNonQuery("INSERT INTO lstSystemEntities (SystemEntityID, Description) VALUES (1,'IMS')");
  }

  void IMdiActivationListener.MDIChildActivating(Form mdiChild)
  {
    this._entityNoteSupport = ObjectFactory.QueryInterface<ISupportNoteSystem>((object) mdiChild);
    if (this._entityNoteSupport != null)
    {
      if (this.Visible)
        this.RefreshTree(this.trvNotesBound);
      else
        this.DirtyUI();
      this._entityNoteSupport.EntityInfoChanged += new ISupportNoteSystem.EntityInfoChangedEventHandler(this.entityNoteSupport_EntityChanged);
      this.lnkNewAssociatedNote.Enabled = true;
    }
    else
    {
      if (this.trvNotesBound.Nodes.Count > 0)
        this.trvNotesBound.Nodes.Clear();
      try
      {
        this.trvNotesBound.Nodes.Add("This entity does not support notes.");
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      this.lnkNewAssociatedNote.Enabled = false;
    }
  }

  void IMdiActivationListener.MDIChildDeActivate(Form mdiChild)
  {
    this.lnkNewAssociatedNote.Enabled = false;
    if (this._entityNoteSupport != null)
    {
      this._entityNoteSupport.EntityInfoChanged -= new ISupportNoteSystem.EntityInfoChangedEventHandler(this.entityNoteSupport_EntityChanged);
      this._entityNoteSupport = (ISupportNoteSystem) null;
    }
    this.trvNotesBound.Nodes.Clear();
  }

  public void AfterLogon()
  {
    this.SecureUI();
    this.LoadUISettings();
    this.LoadAllNotes();
    Note_System.Instance.NoteCollectionModified += new Note_System.NoteCollectionModifiedEventhandler(this.NoteSystem_NoteCollectionChanged);
  }

  public void BeforeLogOut()
  {
    this.SaveUISettings();
    Note_System.Instance.NoteCollectionModified -= new Note_System.NoteCollectionModifiedEventhandler(this.NoteSystem_NoteCollectionChanged);
  }

  private void NoteSystem_NoteCollectionChanged(object sender, NoteCollectionModifiedEventArgs e)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new TabNotePanel.NoteSystem_NoteCollectionChangedHandler(this.NoteSystem_NoteCollectionChanged), sender, (object) e);
    }
    else
    {
      switch (e.CollectionModified)
      {
        case NoteCollections.NotesBound:
          this.RefreshTree(this.trvNotesBound);
          break;
        case NoteCollections.NotesUnbound:
          this.RefreshTree(this.trvNotesUnbound);
          break;
        case NoteCollections.NoteEntriesOpen:
          this.RefreshTree(this.trvNotesUnread);
          break;
        case NoteCollections.DiaryEntriesAllOpen:
          this.RefreshTree(this.trvDiariesAll);
          break;
        case NoteCollections.DiaryEntriesUpcoming:
          this.RefreshTree(this.trvDiariesUpcoming);
          break;
        case NoteCollections.DiaryEntriesUrgent:
          this.RefreshTree(this.trvDiariesUrgent);
          break;
        case NoteCollections.All:
          this.LoadAllNotes();
          break;
      }
    }
  }

  private void entityNoteSupport_EntityChanged(object sender, EventArgs e)
  {
    if (!this.HasLoaded)
      return;
    if (this.Visible)
      this.RefreshUserInterface();
    else
      this.DirtyUI();
  }

  private void TabNotePanel_RefreshUI(object sender, EventArgs e) => this.RefreshUserInterface();

  private void RefreshUserInterface() => this.RefreshTree(this.trvNotesBound);

  private static UltraTree OpenItemTreeFromTab(UltraTab tab)
  {
    UltraTree ultraTree1;
    if (tab == null)
    {
      ultraTree1 = (UltraTree) null;
    }
    else
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control is UltraTree ultraTree2)
          {
            ultraTree1 = ultraTree2;
            goto label_10;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ultraTree1 = (UltraTree) null;
    }
label_10:
    return ultraTree1;
  }

  private void LoadAllNotes()
  {
    this.RefreshTree(this.trvNotesBound);
    this.RefreshTree(this.trvNotesUnbound);
    this.RefreshTree(this.trvNotesUnread);
    this.RefreshTree(this.trvDiariesUrgent);
    this.RefreshTree(this.trvDiariesUpcoming);
    this.RefreshTree(this.trvDiariesAll);
    this.GetAllNotesWithInternalCHeck();
  }

  private void RefreshTreeNotes(UltraTree tree)
  {
    if (tree == this.trvNotesUnbound)
    {
      this.daNotesUnbound.SelectCommand.Parameters["@UserGUID"].Value = (object) CurrentUser.Instance.UserGUID;
      this.DsTabNotePanel.tblNotesUnbound.Clear();
      Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daNotesUnbound", this.daNotesUnbound, new TableQueryMultithreadEventHandler(this.UnboundNotes_TableFilled), (DataTable) this.DsTabNotePanel.tblNotesUnbound);
    }
    else
    {
      if (tree != this.trvNotesBound)
        return;
      if (this._entityNoteSupport != null && this._entityNoteSupport.CanCreateNewNote)
      {
        this.DsTabNotePanel.tblNotesBound.Clear();
        this.daNotesBound.SelectCommand.Parameters["@ControlGuid"].Value = (object) Guid.Empty;
        this.daNotesBound.SelectCommand.Parameters["@EntityGUID"].Value = (object) this._entityNoteSupport.EntityGuid;
        if (this._entityNoteSupport.HasControlGUID)
          this.daNotesBound.SelectCommand.Parameters["@ControlGuid"].Value = (object) this._entityNoteSupport.ControlGUID;
        Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daNotesBound", this.daNotesBound, new TableQueryMultithreadEventHandler(this.BoundNotes_TableFilled), (DataTable) this.DsTabNotePanel.tblNotesBound);
      }
      else
      {
        tree.Nodes.Clear();
        if (Form.ActiveForm == null || Form.ActiveForm == MDIControls.Instance.MDIParent)
          return;
        tree.Nodes.Add("Active entity does not support notes");
      }
    }
  }

  private void UnboundNotes_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this.PopulateNoteTree(this.trvNotesUnbound, e.Table);
  }

  private void BoundNotes_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this.PopulateNoteTree(this.trvNotesBound, e.Table);
  }

  private void GetAllNotesWithInternalCHeck()
  {
    if (this.ViewNoteInternal_Table != null)
      return;
    DataTable dataTable = new DataTable();
    this.ViewNoteInternal_Table = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select NoteGUID as NoteGUID from tblNoteEntries wtih (nolock) WHERE Internal = 1");
  }

  private bool CanViewNote(string NoteGUID)
  {
    return !(this.ViewNoteInternal_Table.Select($"NoteGUID = '{NoteGUID}'").Length > 0 & !this._View_internal_Notes);
  }

  private void PopulateNoteTree(UltraTree tree, DataTable table)
  {
    ((UltraControlBase) tree).BeginUpdate();
    tree.Nodes.Clear();
    if (TabNotePanel.GetTreePreferencesFromTree(tree).ShowFolders)
    {
      DataTable dataTable = this.UpdateLatestNoteTypeTable();
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          UltraTreeNode ultraTreeNode = (UltraTreeNode) new TabNotePanel.NoteTypeTreeNode(row);
          tree.Nodes.Add(ultraTreeNode);
          DataRow[] dataRowArray = table.Select($"Type = {RuntimeHelpers.GetObjectValue(row["NoteTypeID"])}");
          int index = 0;
          while (index < dataRowArray.Length)
          {
            TabNotePanel.NoteTreeNode noteTreeNode = new TabNotePanel.NoteTreeNode(dataRowArray[index]);
            if (!((KeyedSubObjectsCollectionBase) ultraTreeNode.Nodes).Exists(noteTreeNode.Key) & this.CanViewNote(noteTreeNode.Key))
              ultraTreeNode.Nodes.Add((UltraTreeNode) noteTreeNode);
            checked { ++index; }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (tree != this.trvNotesBound || tree == this.trvNotesBound && !this._inDrag)
      {
        for (int index = tree.Nodes.Count - 1; index >= 0; index += -1)
        {
          UltraTreeNode node = tree.Nodes[index];
          if (node.Nodes.Count == 0)
            tree.Nodes.Remove(node);
        }
      }
    }
    else
    {
      try
      {
        foreach (DataRow row in table.Rows)
        {
          TabNotePanel.NoteTreeNode noteTreeNode = new TabNotePanel.NoteTreeNode(row);
          if (!((KeyedSubObjectsCollectionBase) tree.Nodes).Exists(noteTreeNode.Key))
            tree.Nodes.Add((UltraTreeNode) noteTreeNode);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ((UltraControlBase) tree).EndUpdate();
  }

  private void RefreshTreeEntries(UltraTree tree)
  {
    if (tree != this.trvNotesUnread)
      return;
    this.daNoteEntriesUnread.SelectCommand.Parameters["@UserGUID"].Value = (object) CurrentUser.Instance.UserGUID;
    this.DsTabNotePanel.tblEntriesUnread.Clear();
    Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daNoteEntriesUnread", this.daNoteEntriesUnread, new TableQueryMultithreadEventHandler(this.UnreadNoteEntries_TableFilled), (DataTable) this.DsTabNotePanel.tblEntriesUnread);
  }

  private void UnreadNoteEntries_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    ((UltraTabControlBase) this.uTabDiaries).Tabs["NOTES"].Text = $"Notes ({e.Table.Rows.Count})";
    this.PopulateEntryTree(false, this.trvNotesUnread, e.Table);
  }

  private void PopulateEntryTree(bool isDiaryEntry, UltraTree tree, DataTable table)
  {
    ((UltraControlBase) tree).BeginUpdate();
    tree.Nodes.Clear();
    if (TabNotePanel.GetTreePreferencesFromTree(tree).ShowFolders)
    {
      DataTable dataTable = this.UpdateLatestNoteTypeTable();
      try
      {
        foreach (DataRow row1 in dataTable.Rows)
        {
          UltraTreeNode ultraTreeNode1 = (UltraTreeNode) new TabNotePanel.NoteTypeTreeNode(row1);
          tree.Nodes.Add(ultraTreeNode1);
          DataRow[] dataRowArray = table.Select($"Type = {RuntimeHelpers.GetObjectValue(row1["NoteTypeID"])}");
          int index = 0;
          while (index < dataRowArray.Length)
          {
            DataRow row2 = dataRowArray[index];
            UltraTreeNode ultraTreeNode2 = !isDiaryEntry ? (UltraTreeNode) new TabNotePanel.NoteEntryTreeNode(row2) : (UltraTreeNode) new TabNotePanel.NoteDiaryEntryTreeNode(row2);
            if (!((KeyedSubObjectsCollectionBase) ultraTreeNode1.Nodes).Exists(ultraTreeNode2.Key))
              ultraTreeNode1.Nodes.Add(ultraTreeNode2);
            checked { ++index; }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      for (int index = tree.Nodes.Count - 1; index >= 0; index += -1)
      {
        UltraTreeNode node = tree.Nodes[index];
        if (node.Nodes.Count == 0)
          tree.Nodes.Remove(node);
      }
    }
    else
    {
      try
      {
        foreach (DataRow row in table.Rows)
        {
          UltraTreeNode ultraTreeNode = !isDiaryEntry ? (UltraTreeNode) new TabNotePanel.NoteEntryTreeNode(row) : (UltraTreeNode) new TabNotePanel.NoteDiaryEntryTreeNode(row);
          if (!((KeyedSubObjectsCollectionBase) tree.Nodes).Exists(ultraTreeNode.Key))
            tree.Nodes.Add(ultraTreeNode);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    ((UltraControlBase) tree).EndUpdate();
  }

  private void RefreshTreeDiaries(UltraTree tree)
  {
    if (tree == this.trvDiariesUrgent)
    {
      this.daDiaryEntriesUrgent.SelectCommand.Parameters["@UserGUID"].Value = (object) CurrentUser.Instance.UserGUID;
      this.DsTabNotePanel.tblDiaryEntriesUrgent.Clear();
      Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daDiaryEntriesUrgent", this.daDiaryEntriesUrgent, new TableQueryMultithreadEventHandler(this.UrgentDiariesEntries_TableFilled), (DataTable) this.DsTabNotePanel.tblDiaryEntriesUrgent);
    }
    else if (tree == this.trvDiariesUpcoming)
    {
      this.daDiaryEntriesUpcoming.SelectCommand.Parameters["@UserGUID"].Value = (object) CurrentUser.Instance.UserGUID;
      this.DsTabNotePanel.tblDiaryEntriesUpcoming.Clear();
      Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daDiaryEntriesUpcoming", this.daDiaryEntriesUpcoming, new TableQueryMultithreadEventHandler(this.UpcomingDiariesEntries_TableFilled), (DataTable) this.DsTabNotePanel.tblDiaryEntriesUpcoming);
    }
    else
    {
      if (tree != this.trvDiariesAll)
        return;
      this.daDiaryEntriesOpen.SelectCommand.Parameters["@UserGUID"].Value = (object) CurrentUser.Instance.UserGUID;
      this.DsTabNotePanel.tblDiaryEntriesOpen.Clear();
      Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "daDiaryEntriesOpen", this.daDiaryEntriesOpen, new TableQueryMultithreadEventHandler(this.AllDiariesEntries_TableFilled), (DataTable) this.DsTabNotePanel.tblDiaryEntriesOpen);
    }
  }

  private void UrgentDiariesEntries_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    ((UltraTabControlBase) this.uTabDiaries).Tabs["URGENT"].Text = $"Urgent ({e.Table.Rows.Count})";
    this.PopulateEntryTree(true, this.trvDiariesUrgent, e.Table);
  }

  private void UpcomingDiariesEntries_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    ((UltraTabControlBase) this.uTabDiaries).Tabs["UPCOMING"].Text = $"Upcoming ({e.Table.Rows.Count})";
    this.PopulateEntryTree(true, this.trvDiariesUpcoming, e.Table);
  }

  private void AllDiariesEntries_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    ((UltraTabControlBase) this.uTabDiaries).Tabs["ALL"].Text = $"All ({e.Table.Rows.Count})";
    this.PopulateEntryTree(true, this.trvDiariesAll, e.Table);
  }

  private DataTable UpdateLatestNoteTypeTable()
  {
    if (this._updateLatestNoteTypeTable == null)
      this._updateLatestNoteTypeTable = Database.Instance.QueryText.PerformTableQuery("SELECT NoteTypeID, Description FROM lstNoteTypes (NOLOCK)");
    return this._updateLatestNoteTypeTable;
  }

  private TabNotePanel.TreeNodeSortComparer GetTreeNodeSortComparer(UltraTree tree)
  {
    TabNotePanel.TreeViewPreferences preferencesFromTree = TabNotePanel.GetTreePreferencesFromTree(tree);
    TabNotePanel.TreeNodeSortComparer nodeSortComparer1;
    if (this._treeNodeSortComparerHash.ContainsKey(((Control) tree).Name))
    {
      nodeSortComparer1 = this._treeNodeSortComparerHash[((Control) tree).Name];
    }
    else
    {
      TabNotePanel.TreeNodeSortComparer nodeSortComparer2 = new TabNotePanel.TreeNodeSortComparer(preferencesFromTree);
      this._treeNodeSortComparerHash.Add(((Control) tree).Name, nodeSortComparer2);
      nodeSortComparer1 = nodeSortComparer2;
    }
    return nodeSortComparer1;
  }

  private void UpdateDetailsDisplay(TabNotePanel.NoteNodeBase node)
  {
    if (node == null)
    {
      this.lblCreatedDateSpec.Text = string.Empty;
      this.lblCreatorNameSpec.Text = string.Empty;
      this.lblSubjectSpec.Text = string.Empty;
      this.lblTypeSpec.Text = string.Empty;
      this.lblCreatedDate.Text = string.Empty;
      this.lblCreatorName.Text = string.Empty;
      this.lblSubject.Text = string.Empty;
      this.lblType.Text = string.Empty;
    }
    else
    {
      if (node is TabNotePanel.NoteDiaryEntryTreeNode diaryEntryTreeNode)
      {
        this.lblCreatedDateSpec.Text = "Due:";
        this.lblCreatorNameSpec.Text = "Originator:";
        this.lblSubjectSpec.Text = "Text:";
        this.lblTypeSpec.Text = "Type:";
        this.lblCreatedDate.Text = diaryEntryTreeNode.DueDate.ToShortDateString();
        this.lblCreatorName.Text = node.Author;
        this.lblSubject.Text = diaryEntryTreeNode.Body;
      }
      else
      {
        this.lblCreatedDateSpec.Text = "Created:";
        this.lblCreatorNameSpec.Text = "Originator:";
        this.lblSubjectSpec.Text = "Subject:";
        this.lblTypeSpec.Text = "Type:";
        this.lblCreatedDate.Text = node.CreatedDate.ToShortDateString();
        this.lblCreatorName.Text = node.Author;
        this.lblSubject.Text = node.Subject;
      }
      DataRow[] dataRowArray = this.UpdateLatestNoteTypeTable().Select($"NoteTypeID = {node.NoteTypeID}");
      if (dataRowArray.Length <= 0)
        return;
      this.lblType.Text = Conversions.ToString(dataRowArray[0]["Description"]);
    }
  }

  private void UpdateDetailsDisplay(
    TabNotePanel.NoteNodeBase mainNoteNode,
    TabNotePanel.NoteSubEntry subEntry)
  {
    if (mainNoteNode is TabNotePanel.NoteDiaryEntryTreeNode diaryEntryTreeNode)
    {
      this.lblCreatedDateSpec.Text = "Due:";
      this.lblCreatorNameSpec.Text = "Originator:";
      this.lblSubjectSpec.Text = "Text:";
      this.lblTypeSpec.Text = "Type:";
      this.lblCreatedDate.Text = diaryEntryTreeNode.DueDate.ToShortDateString();
      this.lblCreatorName.Text = mainNoteNode.Author;
      this.lblSubject.Text = diaryEntryTreeNode.Body;
    }
    else
    {
      this.lblCreatedDateSpec.Text = "Created:";
      this.lblCreatorNameSpec.Text = "Originator:";
      this.lblSubjectSpec.Text = "Subject:";
      this.lblTypeSpec.Text = "Type:";
      this.lblCreatedDate.Text = mainNoteNode.CreatedDate.ToShortDateString();
      this.lblCreatorName.Text = mainNoteNode.Author;
      this.lblSubject.Text = mainNoteNode.Subject;
    }
    if (subEntry != null)
      this.lblBody.Text = subEntry.Text;
    DataRow[] dataRowArray = this.UpdateLatestNoteTypeTable().Select($"NoteTypeID = {mainNoteNode.NoteTypeID}");
    if (dataRowArray.Length <= 0)
      return;
    this.lblType.Text = Conversions.ToString(dataRowArray[0]["Description"]);
  }

  private void tree_AfterActivate(object sender, EventArgs e)
  {
    UltraTreeNode activeNode = ((UltraTree) sender).ActiveNode;
    TabNotePanel.NoteNodeBase node = activeNode as TabNotePanel.NoteNodeBase;
    this.lblBody.Text = "";
    if (activeNode is TabNotePanel.NoteSubEntry subEntry)
    {
      subEntry.Parent.GetType();
      this.UpdateDetailsDisplay(subEntry.Parent as TabNotePanel.NoteNodeBase, subEntry);
    }
    else
      this.UpdateDetailsDisplay(node);
  }

  private void tree_DoubleClick(object sender, EventArgs e)
  {
    UltraTree ultraTree = (UltraTree) sender;
    if (!(((ControlUIElementBase) ultraTree.UIElement).LastElementEntered is TreeNodeUIElement) && ((ControlUIElementBase) ultraTree.UIElement).LastElementEntered.GetAncestor(typeof (TreeNodeUIElement)) == null)
      return;
    UltraTreeNode activeNode = ultraTree.ActiveNode;
    TabNotePanel.NoteEntryTreeNode noteEntryTreeNode = activeNode as TabNotePanel.NoteEntryTreeNode;
    TabNotePanel.NoteNodeBase noteNodeBase = activeNode as TabNotePanel.NoteNodeBase;
    TabNotePanel.NoteSubEntry noteSubEntry = activeNode as TabNotePanel.NoteSubEntry;
    if (noteEntryTreeNode != null)
      Note_System.Instance.UIInteractive.ViewNote(noteEntryTreeNode.NoteGUID, noteEntryTreeNode.EntryGUID, this._entityNoteSupport);
    else if (noteNodeBase != null)
    {
      Note_System.Instance.UIInteractive.ViewNote(noteNodeBase.NoteGUID);
    }
    else
    {
      if (noteSubEntry == null)
        return;
      Note_System.Instance.UIInteractive.ViewNoteFromEntryGUID(noteSubEntry.EntryGUID, this._entityNoteSupport);
    }
  }

  private void trvNotesUnbound_MouseMove(object sender, MouseEventArgs e)
  {
    if (this._entityNoteSupport == null || this._inDrag || Control.MouseButtons != MouseButtons.Left || !(((ControlUIElementBase) this.trvNotesUnbound.UIElement).LastElementEntered is TreeNodeUIElement) && ((ControlUIElementBase) this.trvNotesUnbound.UIElement).LastElementEntered.GetAncestor(typeof (TreeNodeUIElement)) == null || !(this.trvNotesUnbound.ActiveNode is TabNotePanel.NoteTreeNode))
      return;
    int x1 = e.X;
    int y1 = e.Y;
    int x2 = this._mouseDownPoint.X;
    int y2 = this._mouseDownPoint.Y;
    if (Math.Max(x1, x2) - Math.Min(x1, x2) <= 5 && Math.Max(y1, y2) - Math.Min(y1, y2) <= 5)
      return;
    this._inDrag = true;
    this.PopulateNoteTree(this.trvNotesBound, (DataTable) this.DsTabNotePanel.tblNotesBound);
    int num = (int) ((Control) this.trvNotesUnbound).DoDragDrop((object) this.trvNotesUnbound.ActiveNode, DragDropEffects.Move);
    this._inDrag = false;
    this.PopulateNoteTree(this.trvNotesBound, (DataTable) this.DsTabNotePanel.tblNotesBound);
  }

  private void trvNotesUnbound_MouseUp(object sender, MouseEventArgs e) => this._inDrag = false;

  private void trvNotesUnbound_MouseDown(object sender, MouseEventArgs e)
  {
    this._mouseDownPoint = new Point(e.X, e.Y);
  }

  private void trvNotesBound_DragDrop(object sender, DragEventArgs e)
  {
    if (this._entityNoteSupport == null)
    {
      e.Effect = DragDropEffects.None;
    }
    else
    {
      e.Effect = DragDropEffects.All;
      object obj = RuntimeHelpers.GetObjectValue(e.Data.GetData("MGASystems.Ims.Forms.TabNotePanel+NoteTreeNode")) ?? RuntimeHelpers.GetObjectValue(e.Data.GetData("MGASystems.IMS.NoteDocuments.TabNotePanel+NoteTreeNode"));
      if (obj == null)
        return;
      TabNotePanel.NoteTreeNode noteTreeNode1 = (TabNotePanel.NoteTreeNode) obj;
      Note_System.Instance.NonInteractive.BeginBindNote(noteTreeNode1.NoteGUID, this._entityNoteSupport);
      UltraTreeNode ultraTreeNode = (UltraTreeNode) null;
      UIElement uiElement = ((UIElement) this.trvNotesBound.UIElement).ElementFromPoint(((Control) this.trvNotesBound).PointToClient(Cursor.Position));
      if (uiElement != null)
      {
        if (uiElement is TreeNodeUIElement)
          ultraTreeNode = (UltraTreeNode) uiElement.GetContext(typeof (UltraTreeNode));
        else if (uiElement.GetAncestor(typeof (TreeNodeUIElement)) != null)
          ultraTreeNode = (UltraTreeNode) uiElement.GetAncestor(typeof (TreeNodeUIElement)).GetContext(typeof (UltraTreeNode));
      }
      TabNotePanel.NoteTreeNode noteTreeNode2 = ultraTreeNode as TabNotePanel.NoteTreeNode;
      TabNotePanel.NoteTypeTreeNode noteTypeTreeNode = ultraTreeNode as TabNotePanel.NoteTypeTreeNode;
      if (noteTreeNode2 != null)
      {
        Note_System.Instance.NonInteractive.BeginUpdateNote(noteTreeNode1.NoteGUID, noteTreeNode1.Subject, noteTreeNode2.NoteTypeID);
      }
      else
      {
        if (noteTypeTreeNode == null)
          return;
        Note_System.Instance.NonInteractive.BeginUpdateNote(noteTreeNode1.NoteGUID, noteTreeNode1.Subject, noteTypeTreeNode.NoteTypeID);
      }
    }
  }

  private void trvNotesBound_DragOver(object sender, DragEventArgs e)
  {
    if (this._entityNoteSupport == null)
    {
      e.Effect = DragDropEffects.None;
    }
    else
    {
      string[] formats = e.Data.GetFormats();
      int index = 0;
      while (index < formats.Length)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(formats[index], "MGANOTEDRAGLOOP", false) == 0)
        {
          e.Effect = DragDropEffects.None;
          return;
        }
        checked { ++index; }
      }
      e.Effect = DragDropEffects.All;
    }
  }

  public void ShowItem() => DockingManager.ShowAndActivate(this.CreationInfo.Key);

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    if (!eventGuid.Equals(BroadcastMessages.NoteTypesUpdated))
      return;
    this._updateLatestNoteTypeTable = (DataTable) null;
  }

  private void mnuNoteOpen_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || activeControl.ActiveNode == null || !(activeControl.ActiveNode is TabNotePanel.NoteNodeBase))
      return;
    Note_System.Instance.UIInteractive.ViewNote(((TabNotePanel.NoteNodeBase) activeControl.ActiveNode).NoteGUID);
  }

  private void mnuNoteBind_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || activeControl.ActiveNode == null || !(activeControl.ActiveNode is TabNotePanel.NoteNodeBase))
      return;
    Guid noteGuid = ((TabNotePanel.NoteNodeBase) activeControl.ActiveNode).NoteGUID;
    Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
    if (this._entityNoteSupport == null)
      return;
    nonInteractive.BeginBindNote(noteGuid, this._entityNoteSupport);
  }

  private void mnuNoteUnbind_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || activeControl.ActiveNode == null || !(activeControl.ActiveNode is TabNotePanel.NoteNodeBase))
      return;
    Guid noteGuid = ((TabNotePanel.NoteNodeBase) activeControl.ActiveNode).NoteGUID;
    Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
    if (this._entityNoteSupport == null)
      return;
    nonInteractive.BeginUnbindNote(noteGuid, this._entityNoteSupport.EntityGuid, this._entityNoteSupport.ControlGUID);
  }

  private void mnuNoteDelete_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || activeControl.ActiveNode == null || !(activeControl.ActiveNode is TabNotePanel.NoteNodeBase))
      return;
    Guid noteGuid = ((TabNotePanel.NoteNodeBase) activeControl.ActiveNode).NoteGUID;
    Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
    if (MessageBox.Show("Are you sure you want to delete this note?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    nonInteractive.BeginDeleteNote(noteGuid);
  }

  private void mnuNotePrint_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || activeControl.ActiveNode == null || !(activeControl.ActiveNode is TabNotePanel.NoteNodeBase))
      return;
    Note_System.Instance.NonInteractive.BeginPrintNote(((TabNotePanel.NoteNodeBase) activeControl.ActiveNode).NoteGUID);
  }

  private void trvNotes_BeforeExpand(object sender, CancelableNodeEventArgs e)
  {
    if (!(e.TreeNode is TabNotePanel.NoteNodeBase))
      return;
    TabNotePanel.NoteNodeBase treeNode = (TabNotePanel.NoteNodeBase) e.TreeNode;
    treeNode.Nodes.Clear();
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("GetNoteEntries", (object) "@UserGUID", (object) CurrentUser.Instance.UserGUID, (object) "@NoteGUID", (object) treeNode.NoteGUID);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        TabNotePanel.NoteSubEntry noteSubEntry = new TabNotePanel.NoteSubEntry(row);
        treeNode.Nodes.Add((UltraTreeNode) noteSubEntry);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private static Image FlagPurple
  {
    get
    {
      if (TabNotePanel._flagPurple == null)
        TabNotePanel._flagPurple = (Image) MGASystems.IMS.NoteDocuments.My.Resources.Resources.flag_purple;
      return TabNotePanel._flagPurple;
    }
  }

  private static Image FlagGreen
  {
    get
    {
      if (TabNotePanel._flagGreen == null)
        TabNotePanel._flagGreen = (Image) MGASystems.IMS.NoteDocuments.My.Resources.Resources.flag_green;
      return TabNotePanel._flagGreen;
    }
  }

  private static Image FlagYellow
  {
    get
    {
      if (TabNotePanel._flagYellow == null)
        TabNotePanel._flagYellow = (Image) MGASystems.IMS.NoteDocuments.My.Resources.Resources.flag_yellow;
      return TabNotePanel._flagYellow;
    }
  }

  private static Image FlagRed
  {
    get
    {
      if (TabNotePanel._flagRed == null)
        TabNotePanel._flagRed = (Image) MGASystems.IMS.NoteDocuments.My.Resources.Resources.flag_red;
      return TabNotePanel._flagRed;
    }
  }

  private static Image FlagBlue
  {
    get
    {
      if (TabNotePanel._flagBlue == null)
        TabNotePanel._flagBlue = (Image) MGASystems.IMS.NoteDocuments.My.Resources.Resources.flag_blue;
      return TabNotePanel._flagBlue;
    }
  }

  private void lnkNewAssociatedNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Note_System.Instance.UIInteractive.CreateBoundNote(this._entityNoteSupport);
  }

  private void lnkNewUnboundNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Note_System.Instance.UIInteractive.CreateNote();
  }

  private void ctxTree_Popup(object sender, EventArgs e)
  {
    try
    {
      foreach (MenuItem menuItem in this.ctxTree.MenuItems)
        menuItem.Visible = true;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.GetActiveControl() is UltraTree activeControl)
    {
      UltraTreeNode nodeFromPoint = activeControl.GetNodeFromPoint(((Control) activeControl).PointToClient(Cursor.Position));
      activeControl.ActiveNode = nodeFromPoint;
      bool canActOnNode = activeControl.ActiveNode != null && activeControl.ActiveNode is TabNotePanel.NoteNodeBase;
      this.HideTreeMenuItems(activeControl, canActOnNode);
      this.mnuCompleteDiary.Visible = activeControl.ActiveNode != null && activeControl.ActiveNode is TabNotePanel.NoteDiaryEntryTreeNode || activeControl.ActiveNode != null && activeControl.ActiveNode is TabNotePanel.NoteSubEntry && ((TabNotePanel.NoteSubEntry) activeControl.ActiveNode).IsDiary;
    }
    this.mnuSortDueDate.Visible = activeControl.ActiveNode != null && activeControl.ActiveNode is TabNotePanel.NoteNodeBase;
    this.HideTreeMenuItemsBySecurity();
    this.mnuCompleteDiaryForAll.Visible = this.mnuCompleteDiary.Visible && SecurityManager.Instance.AssertPermission("{777545E2-340A-4df5-A550-7BB58891C3F9}", 60);
    this.CleanUpTreeMenuSeparators();
  }

  private void HideTreeMenuItems(UltraTree tree, bool canActOnNode)
  {
    this.mnuViewSummary.Visible = false;
    this.mnuDiarySummary.Visible = false;
    this.mnuViewClaimSummary.Visible = false;
    if (tree == this.trvNotesBound)
    {
      this.mnuAssociateEntity.Visible = false;
      this.mnuDeleteNote.Visible = false;
      if (!canActOnNode)
      {
        this.mnuOpenNote.Visible = false;
        this.mnuDisassociateEntity.Visible = false;
        this.mnuPrint.Visible = false;
        this.mnuPrintAllEntityNotes.Visible = true;
      }
      else
        this.mnuPrintAllEntityNotes.Visible = false;
      if (this._entityNoteSupport == null)
      {
        this.mnuNewNote.Visible = false;
        this.mnuDiarySummary.Visible = false;
        this.mnuViewClaimSummary.Visible = false;
      }
      else
      {
        this.mnuViewSummary.Visible = true;
        this.mnuDiarySummary.Visible = this._showClaimsDiarySummary;
        this.mnuViewClaimSummary.Visible = this._showClaimsNoteSummary;
      }
    }
    else if (tree == this.trvNotesUnbound)
    {
      this.mnuDisassociateEntity.Visible = false;
      if (canActOnNode)
      {
        if (this._entityNoteSupport == null)
          this.mnuAssociateEntity.Visible = false;
        this.mnuPrintAllEntityNotes.Visible = false;
      }
      else
      {
        this.mnuAssociateEntity.Visible = false;
        this.mnuDeleteNote.Visible = false;
        this.mnuOpenNote.Visible = false;
        this.mnuPrint.Visible = false;
        this.mnuPrintAllEntityNotes.Visible = false;
      }
    }
    else if (tree == this.trvNotesUnread)
    {
      this.mnuDeleteNote.Visible = false;
      this.mnuAssociateEntity.Visible = false;
      this.mnuDisassociateEntity.Visible = false;
      if (canActOnNode)
        return;
      this.mnuOpenNote.Visible = false;
      this.mnuPrint.Visible = false;
      this.mnuPrintAllEntityNotes.Visible = false;
    }
    else
    {
      if (tree != this.trvDiariesAll && tree != this.trvDiariesUpcoming && tree != this.trvDiariesUrgent)
        return;
      this.mnuDeleteNote.Visible = false;
      this.mnuAssociateEntity.Visible = false;
      this.mnuDisassociateEntity.Visible = false;
      if (canActOnNode)
        return;
      this.mnuOpenNote.Visible = false;
      this.mnuPrint.Visible = false;
      this.mnuPrintAllEntityNotes.Visible = false;
    }
  }

  private void HideTreeMenuItemsBySecurity()
  {
    try
    {
      foreach (MenuItem menuItem in this.ctxTree.MenuItems)
      {
        if (menuItem.Visible && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(menuItem.Text, "-", false) != 0)
        {
          string str = string.Empty;
          if (menuItem == this.mnuDeleteNote)
            str = "{953C7A3F-7944-4a53-8805-8DEAD8AF3416}";
          else if (menuItem == this.mnuNewNote)
            str = "{B700B442-D0E6-4dc3-8B1F-8CC0130B2016}";
          else if (menuItem == this.mnuAssociateEntity)
            str = "{50BEA1D7-25FC-4446-8256-7D0EA1928626}";
          else if (menuItem == this.mnuDisassociateEntity)
            str = "{083720F6-9912-4453-AA32-5CC41CBAC6E8}";
          else if (menuItem == this.mnuCompleteDiary)
            str = "{38E68308-622B-4401-9F45-DE5A342AB4AD}";
          else if (menuItem == this.mnuOpenNote)
            str = "{93D4AA10-6A3B-4465-8848-6C716EE99751}";
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, string.Empty, false) != 0)
            menuItem.Visible = SecurityManager.Instance.AssertPermission(str, 60);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void CleanUpTreeMenuSeparators()
  {
    MenuItem menuItem1 = (MenuItem) null;
    try
    {
      foreach (MenuItem menuItem2 in this.ctxTree.MenuItems)
      {
        if (menuItem2.Visible)
        {
          if (menuItem1 != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(menuItem2.Text, "-", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(menuItem1.Text, "-", false) == 0)
            menuItem2.Visible = false;
          menuItem1 = menuItem2;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (menuItem1 == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(menuItem1.Text, "-", false) != 0)
      return;
    menuItem1.Visible = false;
  }

  private void mnuRefresh_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    this.RefreshTree(activeControl);
  }

  private void mnuNewNote_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    if (activeControl == this.trvNotesBound)
      Note_System.Instance.UIInteractive.CreateBoundNote(this._entityNoteSupport);
    else
      Note_System.Instance.UIInteractive.CreateNote();
  }

  private Control GetActiveControl()
  {
    Control activeControl = this.ActiveControl;
    for (ContainerControl containerControl = activeControl as ContainerControl; containerControl != null; containerControl = activeControl as ContainerControl)
      activeControl = containerControl.ActiveControl;
    return activeControl;
  }

  private void mnuOpenNote_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    UltraTreeNode activeNode = activeControl.ActiveNode;
    TabNotePanel.NoteEntryTreeNode noteEntryTreeNode = activeNode as TabNotePanel.NoteEntryTreeNode;
    TabNotePanel.NoteSubEntry noteSubEntry = activeNode as TabNotePanel.NoteSubEntry;
    TabNotePanel.NoteNodeBase noteNodeBase = activeNode as TabNotePanel.NoteNodeBase;
    if (noteEntryTreeNode != null)
      Note_System.Instance.UIInteractive.ViewNote(noteEntryTreeNode.NoteGUID, noteEntryTreeNode.EntryGUID, this._entityNoteSupport);
    else if (noteNodeBase != null)
    {
      if (this._entityNoteSupport != null)
        Note_System.Instance.UIInteractive.ViewNote(noteNodeBase.NoteGUID, this._entityNoteSupport);
      else
        Note_System.Instance.UIInteractive.ViewNote(noteNodeBase.NoteGUID);
    }
    else
    {
      if (noteSubEntry == null)
        return;
      Note_System.Instance.UIInteractive.ViewNoteFromEntryGUID(noteSubEntry.EntryGUID, this._entityNoteSupport);
    }
  }

  private void mnuDeleteNote_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || activeControl.ActiveNode == null || !(activeControl.ActiveNode is TabNotePanel.NoteNodeBase))
      return;
    Guid noteGuid = ((TabNotePanel.NoteNodeBase) activeControl.ActiveNode).NoteGUID;
    Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
    if (MessageBox.Show("Are you sure you want to delete this note?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    nonInteractive.BeginDeleteNote(noteGuid);
  }

  private void mnuPrint_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || activeControl.ActiveNode == null || !(activeControl.ActiveNode is TabNotePanel.NoteNodeBase))
      return;
    Note_System.Instance.NonInteractive.BeginPrintNote(((TabNotePanel.NoteNodeBase) activeControl.ActiveNode).NoteGUID);
  }

  private void mnuPrintAllEntityNotes_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound || this._entityNoteSupport == null)
      return;
    Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
    if (MessageBox.Show("Are you sure you would like to print all notes?", "Print All Notes Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    nonInteractive.BeginPrintEntityNotes(this._entityNoteSupport.EntityGuid, this._entityNoteSupport.ControlGUID, this._entityNoteSupport.FriendlyEntityName);
  }

  private void mnuSortSubject_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    TabNotePanel.TreeViewPreferences preferencesFromTree = TabNotePanel.GetTreePreferencesFromTree(activeControl);
    if (preferencesFromTree.SortBy == TabNotePanel.TreeViewPreferencesSortBy.Subject)
      preferencesFromTree.SortAsc = !preferencesFromTree.SortAsc;
    else
      preferencesFromTree.SortBy = TabNotePanel.TreeViewPreferencesSortBy.Subject;
    this.SortTree(activeControl);
  }

  private void mnuSortAuthor_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    TabNotePanel.TreeViewPreferences preferencesFromTree = TabNotePanel.GetTreePreferencesFromTree(activeControl);
    if (preferencesFromTree.SortBy == TabNotePanel.TreeViewPreferencesSortBy.Author)
      preferencesFromTree.SortAsc = !preferencesFromTree.SortAsc;
    else
      preferencesFromTree.SortBy = TabNotePanel.TreeViewPreferencesSortBy.Author;
    this.SortTree(activeControl);
  }

  private void mnuSortDateCreated_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    TabNotePanel.TreeViewPreferences preferencesFromTree = TabNotePanel.GetTreePreferencesFromTree(activeControl);
    if (preferencesFromTree.SortBy == TabNotePanel.TreeViewPreferencesSortBy.DateCreated)
      preferencesFromTree.SortAsc = !preferencesFromTree.SortAsc;
    else
      preferencesFromTree.SortBy = TabNotePanel.TreeViewPreferencesSortBy.DateCreated;
    this.SortTree(activeControl);
  }

  private void mnuToggleFolders_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    TabNotePanel.TreeViewPreferences preferencesFromTree = TabNotePanel.GetTreePreferencesFromTree(activeControl);
    preferencesFromTree.ShowFolders = !preferencesFromTree.ShowFolders;
    this.RefreshTree(activeControl);
  }

  private void mnuAssociateEntity_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || ((DisposableObjectCollectionBase) activeControl.SelectedNodes).Count <= 0)
      return;
    int num = ((DisposableObjectCollectionBase) activeControl.SelectedNodes).Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (activeControl.SelectedNodes[index] is TabNotePanel.NoteNodeBase)
      {
        Guid noteGuid = ((TabNotePanel.NoteNodeBase) activeControl.SelectedNodes[index]).NoteGUID;
        Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
        if (this._entityNoteSupport != null)
          nonInteractive.BeginBindNote(noteGuid, this._entityNoteSupport);
      }
    }
  }

  private void mnuDisassociateEntity_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl) || activeControl != this.trvNotesBound && activeControl != this.trvNotesUnbound || ((DisposableObjectCollectionBase) activeControl.SelectedNodes).Count <= 0)
      return;
    int num = ((DisposableObjectCollectionBase) activeControl.SelectedNodes).Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (activeControl.SelectedNodes[index] is TabNotePanel.NoteNodeBase)
      {
        Guid noteGuid = ((TabNotePanel.NoteNodeBase) activeControl.SelectedNodes[index]).NoteGUID;
        Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
        if (this._entityNoteSupport != null)
          nonInteractive.BeginUnbindNote(noteGuid, this._entityNoteSupport.EntityGuid, this._entityNoteSupport.ControlGUID);
      }
    }
  }

  private void mnuCompleteDiary_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    UltraTreeNode activeNode = activeControl.ActiveNode;
    TabNotePanel.NoteEntryTreeNode noteEntryTreeNode = activeNode as TabNotePanel.NoteEntryTreeNode;
    TabNotePanel.NoteSubEntry noteSubEntry = activeNode as TabNotePanel.NoteSubEntry;
    if (noteEntryTreeNode != null)
    {
      Note_System.Instance.NonInteractive.CompleteDiaryEntry(noteEntryTreeNode.EntryGUID, CurrentUser.Instance.UserGUID);
    }
    else
    {
      if (noteSubEntry == null || !noteSubEntry.IsDiary)
        return;
      Note_System.Instance.NonInteractive.CompleteDiaryEntry(noteSubEntry.EntryGUID, CurrentUser.Instance.UserGUID);
    }
  }

  private void mnuCompleteDiaryForAll_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    UltraTreeNode activeNode = activeControl.ActiveNode;
    TabNotePanel.NoteEntryTreeNode noteEntryTreeNode = activeNode as TabNotePanel.NoteEntryTreeNode;
    TabNotePanel.NoteSubEntry noteSubEntry = activeNode as TabNotePanel.NoteSubEntry;
    if (noteEntryTreeNode != null)
    {
      if (MessageBox.Show("You have chosen to complete this diary for all recipients. Are you sure you want to continue?", "Administrative diary completion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      Note_System.Instance.NonInteractive.CompleteDiaryEntryForAllAdministrative(noteEntryTreeNode.EntryGUID, CurrentUser.Instance.UserGUID, CurrentUser.Instance.UserName);
    }
    else
    {
      if (noteSubEntry == null || !noteSubEntry.IsDiary || MessageBox.Show("You have chosen to complete this diary for all recipients. Are you sure you want to continue?", "Administrative diary completion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      Note_System.Instance.NonInteractive.CompleteDiaryEntryForAllAdministrative(noteSubEntry.EntryGUID, CurrentUser.Instance.UserGUID, CurrentUser.Instance.UserName);
    }
  }

  public int PreferredPosition => 2;

  public static bool NodeSubentrySortAsc { get; set; }

  private void mnuViewSummary_Click(object sender, EventArgs e)
  {
    if (this._entityNoteSupport == null)
      return;
    ObjectFactory.Instance.CreateObjectAs<SummaryOverride>().RunSummary((IRecreatableEntity) new NoteSupportCache(this._entityNoteSupport), -1);
  }

  private void MnuSortDueDate_Click(object sender, EventArgs e)
  {
    if (!(this.GetActiveControl() is UltraTree activeControl))
      return;
    this.SortSubNodeByDueDate(activeControl.ActiveNode);
  }

  private void SortSubNodeByDueDate(UltraTreeNode node)
  {
    List<UltraTreeNode> ultraTreeNodeList = new List<UltraTreeNode>();
    foreach (UltraTreeNode node1 in node.Nodes)
      ultraTreeNodeList.Add(node1);
    ultraTreeNodeList.Sort();
    ultraTreeNodeList.Sort(TabNotePanel.SortNodeTree());
    if (!TabNotePanel.NodeSubentrySortAsc)
    {
      ultraTreeNodeList.Reverse();
      TabNotePanel.NodeSubentrySortAsc = true;
    }
    else
      TabNotePanel.NodeSubentrySortAsc = false;
    node.Nodes.Clear();
    node.Nodes.Override.Sort = (SortType) 3;
    try
    {
      foreach (UltraTreeNode ultraTreeNode in ultraTreeNodeList)
        node.Nodes.Add(ultraTreeNode);
    }
    finally
    {
      List<UltraTreeNode>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private static Comparison<UltraTreeNode> SortNodeTree()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return TabNotePanel._Closure\u0024__.\u0024I327\u002D0 != null ? TabNotePanel._Closure\u0024__.\u0024I327\u002D0 : (TabNotePanel._Closure\u0024__.\u0024I327\u002D0 = (Comparison<UltraTreeNode>) ([SpecialName] (x, y) => DateTime.Compare(((TabNotePanel.NoteSubEntry) (x as UltraTreeNode)).DueDate, ((TabNotePanel.NoteSubEntry) (y as UltraTreeNode)).DueDate)));
  }

  private void mnuViewClaimSummary_Click(object sender, EventArgs e)
  {
    if (this._entityNoteSupport == null)
      return;
    int setting = SystemSettings.GetSetting<int>("Notes.ClaimsNotesTypeID", -1);
    ObjectFactory.Instance.CreateObjectAs<SummaryOverride>().RunSummary((IRecreatableEntity) new NoteSupportCache(this._entityNoteSupport), setting);
  }

  private void mnuDiarySummary_Click(object sender, EventArgs e)
  {
    if (this._entityNoteSupport == null)
      return;
    int setting = SystemSettings.GetSetting<int>("Notes.ClaimsDiaryTypeID", -1);
    ObjectFactory.Instance.CreateObjectAs<SummaryOverride>().RunSummary((IRecreatableEntity) new NoteSupportCache(this._entityNoteSupport), setting);
  }

  private enum TreeViewPreferencesSortBy
  {
    Subject,
    Author,
    DateCreated,
    DueDate,
  }

  private class TreeViewPreferences
  {
    private bool _showFolders;
    private bool _sortAsc;
    private TabNotePanel.TreeViewPreferencesSortBy _sortBy;

    public TreeViewPreferences()
    {
      this._showFolders = true;
      this._sortAsc = true;
      this._sortBy = TabNotePanel.TreeViewPreferencesSortBy.DateCreated;
    }

    public bool ShowFolders
    {
      get => this._showFolders;
      set => this._showFolders = value;
    }

    public bool SortAsc
    {
      get => this._sortAsc;
      set => this._sortAsc = value;
    }

    public TabNotePanel.TreeViewPreferencesSortBy SortBy
    {
      get => this._sortBy;
      set => this._sortBy = value;
    }

    public static TabNotePanel.TreeViewPreferences FromString(string value)
    {
      TabNotePanel.TreeViewPreferences treeViewPreferences = new TabNotePanel.TreeViewPreferences();
      int num = value.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        switch (index)
        {
          case 0:
            treeViewPreferences.ShowFolders = Conversions.ToBoolean(Conversions.ToString(value[0]));
            break;
          case 1:
            treeViewPreferences.SortAsc = Conversions.ToBoolean(Conversions.ToString(value[1]));
            break;
          case 2:
            treeViewPreferences.SortBy = (TabNotePanel.TreeViewPreferencesSortBy) Enum.Parse(typeof (TabNotePanel.TreeViewPreferencesSortBy), Conversions.ToString(value[2]));
            break;
        }
      }
      return treeViewPreferences;
    }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      if (this.ShowFolders)
        stringBuilder.Append("1");
      else
        stringBuilder.Append("0");
      if (this.SortAsc)
        stringBuilder.Append("1");
      else
        stringBuilder.Append("0");
      stringBuilder.Append((int) this.SortBy);
      return stringBuilder.ToString();
    }
  }

  private delegate void NoteSystem_NoteCollectionChangedHandler(
    object sender,
    NoteCollectionModifiedEventArgs e);

  internal class NoteTreeNode : TabNotePanel.NoteNodeBase
  {
    public NoteTreeNode(DataRow row)
    {
      DataRow row1 = row;
      string key = row["ID"].ToString();
      object obj = row["ID"];
      Guid noteGUID = obj != null ? (Guid) obj : new Guid();
      // ISSUE: explicit constructor call
      base.\u002Ector(row1, key, noteGUID);
      DateTime createdDate = this.CreatedDate;
      string shortDateString = createdDate.ToShortDateString();
      createdDate = this.CreatedDate;
      string shortTimeString = createdDate.ToShortTimeString();
      string subject = this.Subject;
      this.Text = $"[{shortDateString} / {shortTimeString}] - {subject}";
      if (!row.Table.Columns.Contains("UncompletedDiaryRecipientCount") || Conversions.ToInteger(row["UncompletedDiaryRecipientCount"]) <= 0)
        return;
      this.LeftImages.Add((object) TabNotePanel.FlagRed);
    }
  }

  private class NoteTypeTreeNode : UltraTreeNode
  {
    private static Image _folder;

    private static Image Folder
    {
      get
      {
        if (TabNotePanel.NoteTypeTreeNode._folder == null)
          TabNotePanel.NoteTypeTreeNode._folder = (Image) MGASystems.IMS.NoteDocuments.My.Resources.Resources.folder;
        return TabNotePanel.NoteTypeTreeNode._folder;
      }
    }

    public NoteTypeTreeNode(DataRow row)
      : base(row[nameof (NoteTypeID)].ToString(), row["Description"].ToString())
    {
      this.LeftImages.Add((object) TabNotePanel.NoteTypeTreeNode.Folder);
    }

    protected override void OnDispose() => ((DisposableObject) this).Dispose();

    public int NoteTypeID => Conversions.ToInteger(this.Key);
  }

  private class NoteDiaryEntryTreeNode : TabNotePanel.NoteEntryTreeNode
  {
    private DateTime _dueDate;
    private string _policyNumber;
    private string _insuredPolicyName;

    public NoteDiaryEntryTreeNode(DataRow row)
      : base(row)
    {
      this._policyNumber = string.Empty;
      this._insuredPolicyName = string.Empty;
      this._dueDate = Conversions.ToDate(row[nameof (DueDate)]);
      if (!row.IsNull(nameof (PolicyNumber)))
        this._policyNumber = Conversions.ToString(row[nameof (PolicyNumber)]);
      if (!row.IsNull(nameof (InsuredPolicyName)))
        this._insuredPolicyName = Conversions.ToString(row[nameof (InsuredPolicyName)]);
      if (this.HasInsuredPolicyName && this.HasPolicyNumber)
        this.Text = $"[{this.DueDate.ToShortDateString()}] [{this.InsuredPolicyName}] [{this.PolicyNumber}] - {this.Body}";
      else if (this.HasInsuredPolicyName)
        this.Text = $"[{this.DueDate.ToShortDateString()}] [{this.InsuredPolicyName}] - {this.Body}";
      else if (this.HasPolicyNumber)
        this.Text = $"[{this.DueDate.ToShortDateString()}] [{this.PolicyNumber}] - {this.Body}";
      else
        this.Text = $"[{this.DueDate.ToShortDateString()}] - {this.Body}";
    }

    public bool HasPolicyNumber => this._policyNumber.Length > 0;

    public bool HasInsuredPolicyName => this._insuredPolicyName.Length > 0;

    public string InsuredPolicyName => this._insuredPolicyName;

    public string PolicyNumber => this._policyNumber;

    public DateTime DueDate => this._dueDate;
  }

  private class NoteEntryTreeNode : TabNotePanel.NoteNodeBase
  {
    private string _body;

    public NoteEntryTreeNode(DataRow row)
    {
      DataRow row1 = row;
      string key = row[nameof (EntryGUID)].ToString();
      object obj = row["NoteGUID"];
      Guid noteGUID = obj != null ? (Guid) obj : new Guid();
      // ISSUE: explicit constructor call
      base.\u002Ector(row1, key, noteGUID);
      this._body = Conversions.ToString(row[nameof (Body)]);
      this.Text = $"[{this.CreatedDate.ToShortDateString()}] - {this._body}";
    }

    public Guid EntryGUID => new Guid(this.Key);

    public string Body => this._body;
  }

  internal class NoteNodeBase : UltraTreeNode
  {
    private DateTime _createdDate;
    private string _subject;
    private string _author;
    private Guid _noteGUID;
    private int _noteTypeID;

    public NoteNodeBase(DataRow row, string key, Guid noteGUID)
      : base(key)
    {
      this._createdDate = Conversions.ToDate(row[nameof (CreatedDate)]);
      this._author = Database.IsNull(RuntimeHelpers.GetObjectValue(row["UserName"]), "Unknown");
      this._subject = Conversions.ToString(row[nameof (Subject)]);
      this._noteTypeID = Conversions.ToInteger(row["Type"]);
      this._noteGUID = noteGUID;
    }

    public Guid NoteGUID => this._noteGUID;

    public DateTime CreatedDate => this._createdDate;

    public string Subject => this._subject;

    public string Author => this._author;

    public int NoteTypeID => this._noteTypeID;

    protected override void OnDispose() => ((DisposableObject) this).Dispose();
  }

  private class TreeNodeSortComparer : IComparer
  {
    private TabNotePanel.TreeViewPreferences _itemPreferences;

    public TreeNodeSortComparer(TabNotePanel.TreeViewPreferences ip) => this._itemPreferences = ip;

    public int Compare(object x, object y)
    {
      if (x == null)
        throw new ArgumentNullException(nameof (x));
      if (y == null)
        throw new ArgumentNullException(nameof (y));
      TabNotePanel.NoteNodeBase noteNodeBase1 = x as TabNotePanel.NoteNodeBase;
      TabNotePanel.NoteNodeBase noteNodeBase2 = y as TabNotePanel.NoteNodeBase;
      int num;
      if (noteNodeBase1 != null && noteNodeBase2 != null)
      {
        switch (this._itemPreferences.SortBy)
        {
          case TabNotePanel.TreeViewPreferencesSortBy.Subject:
            num = string.Compare(noteNodeBase1.Subject, noteNodeBase2.Subject);
            break;
          case TabNotePanel.TreeViewPreferencesSortBy.Author:
            num = string.Compare(noteNodeBase1.Author, noteNodeBase2.Author);
            break;
          case TabNotePanel.TreeViewPreferencesSortBy.DateCreated:
            TabNotePanel.NoteDiaryEntryTreeNode diaryEntryTreeNode1 = x as TabNotePanel.NoteDiaryEntryTreeNode;
            TabNotePanel.NoteDiaryEntryTreeNode diaryEntryTreeNode2 = y as TabNotePanel.NoteDiaryEntryTreeNode;
            num = diaryEntryTreeNode1 == null || diaryEntryTreeNode2 == null ? DateTime.Compare(noteNodeBase1.CreatedDate, noteNodeBase2.CreatedDate) : DateTime.Compare(diaryEntryTreeNode1.DueDate, diaryEntryTreeNode2.DueDate);
            break;
        }
      }
      else
        num = string.Compare(((UltraTreeNode) x).Text, ((UltraTreeNode) y).Text);
      return num;
    }
  }

  private sealed class NoteSubEntry : UltraTreeNode
  {
    private bool _isDiary;
    private string _body;
    private Guid _entryGUID;
    private bool _completedByUser;
    private bool _requiredCompletionByUser;
    private bool _diaryCompletedByAll;
    private DateTime _dueDate;

    public bool IsDiary => this._isDiary;

    public Guid EntryGUID => this._entryGUID;

    public string Body => this._body;

    public DateTime DueDate => this._dueDate;

    public NoteSubEntry(DataRow row)
    {
      object obj = row[nameof (EntryGUID)];
      this._entryGUID = obj != null ? (Guid) obj : new Guid();
      this._body = Conversions.ToString(row[nameof (Body)]);
      this._isDiary = Conversions.ToBoolean(row[nameof (IsDiary)]);
      if (this._isDiary)
      {
        this._completedByUser = Conversions.ToBoolean(row["CompletedByUser"]);
        this._requiredCompletionByUser = Conversions.ToBoolean(row["RequiresCompletionByUser"]);
        this._diaryCompletedByAll = Conversions.ToBoolean(row["DiaryCompletedByAll"]);
        this._dueDate = Conversions.ToDate(row[nameof (DueDate)]);
        this.Text = $"[{this._dueDate.ToShortDateString()}] - {this._body}";
      }
      else
        this.Text = this._body;
      this.Key = this._entryGUID.ToString();
      this.Override.ShowExpansionIndicator = (ShowExpansionIndicator) 2;
      if (!this._isDiary)
        return;
      if (this._diaryCompletedByAll)
      {
        if (row.Table.Columns.Contains("DiaryRecipientCount") && Conversions.ToInteger(row["DiaryRecipientCount"]) == 0)
          this.LeftImages.Add((object) TabNotePanel.FlagPurple);
        else
          this.LeftImages.Add((object) TabNotePanel.FlagGreen);
      }
      else if (this._requiredCompletionByUser)
      {
        if (this._completedByUser)
          this.LeftImages.Add((object) TabNotePanel.FlagYellow);
        else
          this.LeftImages.Add((object) TabNotePanel.FlagRed);
      }
      else
        this.LeftImages.Add((object) TabNotePanel.FlagBlue);
    }
  }

  private class TreeDragDropHelper : IDisposable
  {
    private UltraTree _tree;
    private Rectangle _dragBoxFromMouseDown;
    private UltraTreeNode _itemUnderMouse;
    private Cursor _dragCursor;
    private TabNotePanel _notePanel;

    public TreeDragDropHelper(UltraTree tree, TabNotePanel notePanel)
    {
      this._tree = tree;
      this._notePanel = notePanel;
      this._tree.SelectionBehavior = (SelectionBehavior) 1;
      ((Control) this._tree).MouseMove += new MouseEventHandler(this.tree_MouseMove);
      ((Control) this._tree).MouseDown += new MouseEventHandler(this.tree_MouseDown);
      ((Control) this._tree).MouseUp += new MouseEventHandler(this.tree_MouseUp);
    }

    public void Dispose()
    {
      ((Control) this._tree).MouseMove -= new MouseEventHandler(this.tree_MouseMove);
      ((Control) this._tree).MouseDown -= new MouseEventHandler(this.tree_MouseDown);
      ((Control) this._tree).MouseUp -= new MouseEventHandler(this.tree_MouseUp);
    }

    private void tree_MouseDown(object sender, MouseEventArgs e)
    {
      this._itemUnderMouse = this._tree.GetNodeFromPoint(e.X, e.Y);
      if (this._itemUnderMouse == null)
      {
        this._dragBoxFromMouseDown = Rectangle.Empty;
      }
      else
      {
        Size dragSize = SystemInformation.DragSize;
        this._dragBoxFromMouseDown = new Rectangle(new Point(e.X - (int) Math.Round((double) dragSize.Width / 2.0), e.Y - (int) Math.Round((double) dragSize.Height / 2.0)), dragSize);
      }
    }

    private void tree_MouseUp(object sender, MouseEventArgs e)
    {
      this._dragBoxFromMouseDown = Rectangle.Empty;
      this._itemUnderMouse = (UltraTreeNode) null;
    }

    private void tree_MouseMove(object sender, MouseEventArgs e)
    {
      if ((e.Button & MouseButtons.Left) != MouseButtons.Left)
        return;
      if (!(this._dragBoxFromMouseDown != Rectangle.Empty & !this._dragBoxFromMouseDown.Contains(e.X, e.Y)))
        return;
      try
      {
        if (this._itemUnderMouse == null || !(this._itemUnderMouse is TabNotePanel.NoteTreeNode itemUnderMouse))
          return;
        MGANoteDataObject data = new MGANoteDataObject((object) itemUnderMouse);
        data.SetData(DataFormats.FileDrop, true, (object) "");
        data.SetData("MGANOTEDRAGLOOP", false, (object) "MGANOTEDRAGLOOP");
        data.Tree = this._tree;
        int num = (int) ((Control) this._tree).DoDragDrop((object) data, DragDropEffects.Copy);
      }
      finally
      {
        if ((object) this._dragCursor != null)
          this._dragCursor.Dispose();
      }
    }
  }
}
