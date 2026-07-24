// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.TabDocumentPanel
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDock;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinToolTip;
using Infragistics.Win.UltraWinTree;
using MGASystems.AsposeFacade.Email.Outlook;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.DockingManagement;
using MGASystems.Common.Email;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.FileIO;
using MGASystems.Common.FileSystemObserver;
using MGASystems.Common.HotKeyManagement;
using MGASystems.Data;
using MGASystems.ExtendedEditors.DragDrop;
using MGASystems.IMS.DocumentStorage;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.DocuSign;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.Office.Interop.Outlook;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[Preference("DockingTabs.Documents.AssociatedDocs.ShowFolders", true)]
[Preference("MGASystems.IMS.Email.DocSupport.Override", -1)]
[Preference("DockingTabs.Documents.ShowFoldersOnEntityChange.Override", -1)]
[Preference("DockingTabs.Documents.AssociatedDocs.FilterEntitiesOnly", false)]
[Preference("DockingTabs.Documents.DisassociatedDocs.ShowFolders", true)]
[Preference("DockingTabs.Documents.EnhancedToolTips", false)]
[Preference("DockingTabs.Documents.OpenOnSecondMonitor", true)]
[Preference("DockingTabs.Documents.DisassociatedDocs.SortOrder.Asc", true)]
[Preference("DockingTabs.Documents.Email.Subject.UseFileDescriptions", false)]
[Preference("DockingTabs.Documents.AssociatedDocs.SortOrder.Asc", true)]
[Preference("DockingTabs.Documents.AssociatedDocs.SortCriteria", 0)]
[Preference("DockingTabs.Documents.AssociatedDocs.FilterFoldersByEntity", true)]
[Preference("DockingTabs.Documents.ShowFileNames", false)]
[Preference("DockingTabs.Documents.MailDateStyle", 0)]
[SecureResource("{72A4A5DB-D9D1-4181-8338-43EB57313025}", "Access Document Context Menu", "Allows access to the document context menu.", "Document System")]
[SecureResource("{16EF6A9D-91A2-45c7-AB12-AC6A601368DE}", "Unbind Documents", "Allows users to unbind documents.", "Document System")]
[SecureResource("{443BB180-4020-4407-9A91-B8A1A985B87A}", "Print Documents", "Allows user to print documents", "Document System")]
[SecureResource("{7994442C-0ECF-492b-8949-C8D67814751C}", "Open Documents", "Allows user to add documents", "Document System")]
[SecureResource("{B91DE12D-F7DC-40e1-969C-6A0447EEC928}", "Zip and email documents", "Allows user to send a document via email", "Document System")]
[SecureResource("{BB22B0B4-0841-4147-B58B-33C7C3DCA163}", "Save document to disk", "Allows user to save a document locally", "Document System")]
[SecureResource("{F64B30DF-7B2B-436e-BB1E-AD21C5D23F79}", "View document properties", "Allow user to view document properties", "Document System")]
[SecureResource("{463F6A83-2388-4535-A781-1DB0A7985187}", "Associate Documents", "Allows users to associated documents to entities", "Document System")]
[SecureResource("{A24AE1FA-B6C5-4e4d-BC52-3B4FE0343104}", "Delete Documents", "Allows user to permanently delete documents from the system.", "Document System")]
[SecureResource("{A4C4CE34-0130-4bea-B7BD-7FF75DB73E82}", "Transfer Documents", "Allows user to transfer ownership of documents from one user to another.", "Document System")]
[SecureResource("{741550D6-3346-4900-B071-D0D347A0A6E8}", "Folder Admin", "Determines whether or not a user can add/delete/modify folders in the system.", "Document System")]
[SecureResource("{20E00F1B-79BA-4D04-AB6F-13A63F0BF8A9}", "File Move", "Determines whether or not a user can move files between folders in the system.", "Document System")]
[SecureResource("{ECC3C7CB-B41B-415a-843D-5540DAAEE2B1}", "Adobe Document Manipulation", "Determines whether or not a user can use the Adobe PDF functions in the document system.", "Document System")]
[SecureResource("{60C00A7E-2D44-4108-B607-7F48FBEE7897}", "Allow Disable Folder Filtering", "Determines whether or not a user can disable folder filtering.", "Document System")]
[SecureResource("{242C8238-6072-4c25-9B3E-C07D4206CA8C}", "Allow Hide Folders", "Determines whether or not a user can hide folders", "Document System")]
[SecureResource("{9BE131D4-47F3-4A47-9C64-2512CA875E19}", "Allow Moving of Folders", "Determines whether or not a user can move a folder.", "Document System")]
[SecureResource("{907B56F7-0C11-4CB7-869C-1A2F62191C98}", "Allow Add Document", "Determines whether or not a user can add a document.", "Document System")]
[SecureResource("{D3C6588D-56C9-4F1A-8F49-9C5CF6CCA93B}", "Bypass document viewing rights", "Allows user to bypass document viewing rights.", "Document System")]
[Preference("DockingTabs.Documents.DisassociatedDocs.SortCriteria", 0)]
[Preference("DockingTabs.Documents.AssociatedDocs.Height", 400)]
[Preference("DockingTabs.Documents.FileName.RevisionMarker", "")]
[LogCategory("DocumentSystem.DocumentPanel", "DocumentSystem.DocumentPanel")]
[LogCategory("DocumentSystem.DocumentPanel.Performance", "DocumentSystem.DocumentPanel.Performance")]
[SecureHotkeyResource("{29FD9EDB-F287-4c29-9887-3F44D480FEC8}", "Document Panel Hot Key", "Determines if the current user can access the document system thru the hot key bar", "Document System")]
[HotKeyInfo("DocumentuserPanel", "Documents", "Document System", Keys.F11, "MGASystems.Tools.document_add.png")]
public class TabDocumentPanel : 
  DelayLoadUserControl,
  IDockingInfoProvider,
  IHotKeyDisplayItem,
  IMessageListener
{
  internal const string SecurityIDTabUserDocumentPanelHotKey = "{29FD9EDB-F287-4c29-9887-3F44D480FEC8}";
  internal const string SecurityIDAccessDocumentContextMenu = "{72A4A5DB-D9D1-4181-8338-43EB57313025}";
  internal const string SecurityIDAllowUnbindDoc = "{16EF6A9D-91A2-45c7-AB12-AC6A601368DE}";
  internal const string SecurityIDAllowPrintDoc = "{443BB180-4020-4407-9A91-B8A1A985B87A}";
  internal const string SecurityIDAllowOpenDoc = "{7994442C-0ECF-492b-8949-C8D67814751C}";
  internal const string SecurityIDAllowZipEmailDoc = "{B91DE12D-F7DC-40e1-969C-6A0447EEC928}";
  internal const string SecurityIDAllowSaveDoc = "{BB22B0B4-0841-4147-B58B-33C7C3DCA163}";
  internal const string SecurityIDAllowViewPropsDoc = "{F64B30DF-7B2B-436e-BB1E-AD21C5D23F79}";
  internal const string SecurityIDAllowBindDoc = "{463F6A83-2388-4535-A781-1DB0A7985187}";
  internal const string SecurityIDAllowDeleteDoc = "{A24AE1FA-B6C5-4e4d-BC52-3B4FE0343104}";
  internal const string SecurityIDFolderAdmin = "{741550D6-3346-4900-B071-D0D347A0A6E8}";
  internal const string SecurityIDFileMove = "{20E00F1B-79BA-4D04-AB6F-13A63F0BF8A9}";
  internal const string SecurityIDSplitAdobeDocuments = "{ECC3C7CB-B41B-415a-843D-5540DAAEE2B1}";
  internal const string SecurityIDAllowFileTransfer = "{A4C4CE34-0130-4bea-B7BD-7FF75DB73E82}";
  internal const string SecurityIDAllowDisableFolderFiltering = "{60C00A7E-2D44-4108-B607-7F48FBEE7897}";
  internal const string SecurityIDAllowHideFolders = "{242C8238-6072-4c25-9B3E-C07D4206CA8C}";
  internal const string SecurityIDAllowMoveFolders = "{9BE131D4-47F3-4A47-9C64-2512CA875E19}";
  internal const string SecurityCanAddFile = "{907B56F7-0C11-4CB7-869C-1A2F62191C98}";
  internal const string SecurityBypassViewingRights = "{D3C6588D-56C9-4F1A-8F49-9C5CF6CCA93B}";
  internal const string PREFERENCE_SHOWFOLDERSONENTITYCHANGE = "DockingTabs.Documents.ShowFoldersOnEntityChange.Override";
  internal const string PREFERENCE_ASSOCIATEDDOCSFILTERBYENTITY = "DockingTabs.Documents.AssociatedDocs.FilterEntitiesOnly";
  internal const string PREFERENCE_OUTLOOKTRACKINGDISPLAYADDFILEDIALOG = "MGASystems.IMS.Email.DocSupport.Override";
  internal const string PREFERENCE_DOCSREVISIONMARKER = "DockingTabs.Documents.FileName.RevisionMarker";
  internal const string PREFERENCE_ASSOCIATEDPANELHEIGHT = "DockingTabs.Documents.AssociatedDocs.Height";
  internal const string PREFERENCE_USEFILEDESCRIPTIONS = "DockingTabs.Documents.Email.Subject.UseFileDescriptions";
  internal const string PREFERENCE_SHOWENTITYFOLDERS = "DockingTabs.Documents.AssociatedDocs.ShowFolders";
  internal const string PREFERENCE_SHOWUSERFOLDERS = "DockingTabs.Documents.DisassociatedDocs.ShowFolders";
  internal const string PREFERENCE_ENTITYDOCS_SORTCRITERIA = "DockingTabs.Documents.AssociatedDocs.SortCriteria";
  internal const string PREFERENCE_USERDOCS_SORTCRITERIA = "DockingTabs.Documents.DisassociatedDocs.SortCriteria";
  internal const string PREFERENCE_ENTITYDOCS_SORTASC = "DockingTabs.Documents.AssociatedDocs.SortOrder.Asc";
  internal const string PREFERENCE_OPEN_DOCS_SECOND_MONITOR = "DockingTabs.Documents.OpenOnSecondMonitor";
  internal const string PREFERENCE_TREE_ENHANCED_TOOLTIPS = "DockingTabs.Documents.EnhancedToolTips";
  internal const string PREFERENCE_USERDOCS_SORTASC = "DockingTabs.Documents.DisassociatedDocs.SortOrder.Asc";
  internal const string PREFERENCE_FOLDERVIEW_FILTERING = "DockingTabs.Documents.AssociatedDocs.FilterFoldersByEntity";
  internal const string PREFERENCE_SHOWFILENAMES = "DockingTabs.Documents.ShowFileNames";
  internal const string PREFERENCE_MAILDATESTYLE = "DockingTabs.Documents.MailDateStyle";
  internal const string LogKeyDocumentPanel = "DocumentSystem.DocumentPanel";
  internal const string LogKeyDocumentPanelPerformance = "DocumentSystem.DocumentPanel.Performance";
  private TabDocumentPanel.FloatControl _floater;
  private TabDocumentPanel.TreeSortInfo _entityDocsSortInfo;
  private TabDocumentPanel.TreeSortInfo _userDocsSortInfo;
  private DockWindowCreationInfo _creationInfo;
  private UltraTreeNode _workingNode;
  private TabDocumentPanel.TreeDragDropHelper _userTreeDragDropHelper;
  private TabDocumentPanel.TreeDragDropHelper _entityTreeDragDropHelper;
  private ISupportDocumentSystem _entityDocs;
  private MGASystems.Common.FileSystemObserver.FileSystemObserver _fileWatcher;
  private bool _showDocumentTypes;
  private bool _enableDocuSign;
  private Guid? _renewalControlGuid;
  private int _renewedFromControlNo;
  private bool _canReplaceAdobePage;
  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
  [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId = "Member")]
  public const string CONST_FILENODE = "MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode";
  public const string ConstFolderNode = "MGASystems.IMS.NoteDocuments.TabDocumentPanel+FolderNode";
  private IContainer components;
  private SqlDataAdapter daGetFolders;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cnSql;
  private UltraGroupBox pnlAssociated;
  private UltraGroupBox pnlDisassociated;
  private Splitter Splitter1;
  private dsDocumentPanel ds;
  private ZipUtility ZipUtility1;
  private FolderBrowserDialog FolderBrowserDialog1;
  private OpenFileDialog OpenFileDialog1;
  private System.Windows.Forms.Label Label3;
  private System.Windows.Forms.TextBox lblDetails;
  private MemoryCache _structureCache;
  private List<string> _changedFiles;
  private Dictionary<Guid, Guid> _uploadedFiles;
  private static Dictionary<string, Guid> _watchedFiles;
  private string associatedTitleText;
  private string unassociatedTitleText;
  private Guid _filterTypeGuid;
  private static bool _inParseEmailOptionsStorageOperation;
  private static frmMessageDropOptions.MessageImportOptions? _savedImportOptions;
  private List<Guid> _documentGuidsFromMessageFiles;
  private DocumentSystemContextImageRightMenuOverride _imageRightMenuOverride;
  private List<string> nodeKeyList;

  private TabDocumentPanel.TreeSortInfo EntityDocsSortInfo
  {
    get
    {
      if (this._entityDocsSortInfo == null)
        this._entityDocsSortInfo = new TabDocumentPanel.TreeSortInfo("DockingTabs.Documents.AssociatedDocs.SortCriteria", "DockingTabs.Documents.AssociatedDocs.SortOrder.Asc");
      return this._entityDocsSortInfo;
    }
  }

  private TabDocumentPanel.TreeSortInfo UserDocsSortInfo
  {
    get
    {
      if (this._userDocsSortInfo == null)
        this._userDocsSortInfo = new TabDocumentPanel.TreeSortInfo("DockingTabs.Documents.DisassociatedDocs.SortCriteria", "DockingTabs.Documents.DisassociatedDocs.SortOrder.Asc");
      return this._userDocsSortInfo;
    }
  }

  internal virtual UltraToolbarsManager ctxMenu
  {
    get => this._ctxMenu;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.contextMenu_BeforeToolDropdown);
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.contextMenu_ToolClick);
      UltraToolbarsManager ctxMenu1 = this._ctxMenu;
      if (ctxMenu1 != null)
      {
        ctxMenu1.BeforeToolDropdown -= dropdownEventHandler;
        ctxMenu1.ToolClick -= clickEventHandler;
      }
      this._ctxMenu = value;
      UltraToolbarsManager ctxMenu2 = this._ctxMenu;
      if (ctxMenu2 == null)
        return;
      ctxMenu2.BeforeToolDropdown += dropdownEventHandler;
      ctxMenu2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("_TabDocumentPanel_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _TabDocumentPanel_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_TabDocumentPanel_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _TabDocumentPanel_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_TabDocumentPanel_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _TabDocumentPanel_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_TabDocumentPanel_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _TabDocumentPanel_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DragDropExtenderUserTree")]
  private virtual DragDropExtender DragDropExtenderUserTree { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelLoading")]
  internal virtual System.Windows.Forms.Panel panelLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual System.Windows.Forms.Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TabControl1")]
  internal virtual MGATab TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  internal virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  internal virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPreviewText")]
  internal virtual System.Windows.Forms.TextBox txtPreviewText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkEntityOnly
  {
    get => this._chkEntityOnly;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkEntityOnly_CheckedChanged);
      MGACheckBox chkEntityOnly1 = this._chkEntityOnly;
      if (chkEntityOnly1 != null)
        ((UltraToggleEditorBase) chkEntityOnly1).CheckedChanged -= eventHandler;
      this._chkEntityOnly = value;
      MGACheckBox chkEntityOnly2 = this._chkEntityOnly;
      if (chkEntityOnly2 == null)
        return;
      ((UltraToggleEditorBase) chkEntityOnly2).CheckedChanged += eventHandler;
    }
  }

  internal virtual MGATextBox txtFilterAssoc
  {
    get => this._txtFilterAssoc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFilterAssoc_TextChanged);
      MGATextBox txtFilterAssoc1 = this._txtFilterAssoc;
      if (txtFilterAssoc1 != null)
        ((System.Windows.Forms.Control) txtFilterAssoc1).TextChanged -= eventHandler;
      this._txtFilterAssoc = value;
      MGATextBox txtFilterAssoc2 = this._txtFilterAssoc;
      if (txtFilterAssoc2 == null)
        return;
      ((System.Windows.Forms.Control) txtFilterAssoc2).TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("DragDropExtenderEntityTree")]
  private virtual DragDropExtender DragDropExtenderEntityTree { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected override void Dispose(bool disposing)
  {
    if (this._userTreeDragDropHelper != null)
      this._userTreeDragDropHelper.Dispose();
    if (this._entityTreeDragDropHelper != null)
      this._entityTreeDragDropHelper.Dispose();
    if (this._fileWatcher != null)
    {
      this._fileWatcher.ChangedEvent -= new FileSystemEvent(this.FileModified);
      this._fileWatcher.RenamedEvent -= new FileSystemRenameEvent(this.FileRenamed);
      this._fileWatcher.Stop();
    }
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  public TabDocumentPanel()
  {
    this.Load += new EventHandler(this.TabDocumentPanel_Load);
    this.ZipUtility1 = new ZipUtility();
    this._structureCache = new MemoryCache("NoteSystem.DocumentPanel.StructureCache");
    this._changedFiles = new List<string>();
    this._uploadedFiles = new Dictionary<Guid, Guid>();
    this._filterTypeGuid = Guid.Empty;
    this._documentGuidsFromMessageFiles = new List<Guid>();
    this.nodeKeyList = new List<string>();
    this.InitializeComponent();
  }

  private virtual MGATreeView trvEntity
  {
    get => this._trvEntity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeChangedEventHandler changedEventHandler1 = new AfterNodeChangedEventHandler(this.tree_AfterLabelEdit);
      ValidateLabelEditEventHandler editEventHandler = new ValidateLabelEditEventHandler(this.trvEntity_ValidateLabelEdit);
      AfterNodeChangedEventHandler changedEventHandler2 = new AfterNodeChangedEventHandler(this.tree_AfterActivate);
      EventHandler eventHandler1 = new EventHandler(this.tree_DoubleClick);
      BeforeNodeChangedEventHandler changedEventHandler3 = new BeforeNodeChangedEventHandler(this.trvEntity_BeforeExpand);
      UIElementEventHandler elementEventHandler = new UIElementEventHandler(this.tree_MouseEnterElement);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.trvEntity_KeyUp);
      EventHandler eventHandler2 = new EventHandler(this.trvEntity_Click);
      MGATreeView trvEntity1 = this._trvEntity;
      if (trvEntity1 != null)
      {
        trvEntity1.AfterLabelEdit -= changedEventHandler1;
        trvEntity1.ValidateLabelEdit -= editEventHandler;
        trvEntity1.AfterActivate -= changedEventHandler2;
        ((System.Windows.Forms.Control) trvEntity1).DoubleClick -= eventHandler1;
        trvEntity1.BeforeExpand -= changedEventHandler3;
        ((UltraControlBase) trvEntity1).MouseEnterElement -= elementEventHandler;
        ((System.Windows.Forms.Control) trvEntity1).KeyUp -= keyEventHandler;
        ((System.Windows.Forms.Control) trvEntity1).Click -= eventHandler2;
      }
      this._trvEntity = value;
      MGATreeView trvEntity2 = this._trvEntity;
      if (trvEntity2 == null)
        return;
      trvEntity2.AfterLabelEdit += changedEventHandler1;
      trvEntity2.ValidateLabelEdit += editEventHandler;
      trvEntity2.AfterActivate += changedEventHandler2;
      ((System.Windows.Forms.Control) trvEntity2).DoubleClick += eventHandler1;
      trvEntity2.BeforeExpand += changedEventHandler3;
      ((UltraControlBase) trvEntity2).MouseEnterElement += elementEventHandler;
      ((System.Windows.Forms.Control) trvEntity2).KeyUp += keyEventHandler;
      ((System.Windows.Forms.Control) trvEntity2).Click += eventHandler2;
    }
  }

  private virtual MGATreeView trvUser
  {
    get => this._trvUser;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeChangedEventHandler changedEventHandler1 = new AfterNodeChangedEventHandler(this.tree_AfterLabelEdit);
      ValidateLabelEditEventHandler editEventHandler = new ValidateLabelEditEventHandler(this.trvEntity_ValidateLabelEdit);
      AfterNodeChangedEventHandler changedEventHandler2 = new AfterNodeChangedEventHandler(this.tree_AfterActivate);
      EventHandler eventHandler = new EventHandler(this.tree_DoubleClick);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.trvUser_KeyUp);
      BeforeNodeChangedEventHandler changedEventHandler3 = new BeforeNodeChangedEventHandler(this.trvEntity_BeforeExpand);
      UIElementEventHandler elementEventHandler = new UIElementEventHandler(this.tree_MouseEnterElement);
      MGATreeView trvUser1 = this._trvUser;
      if (trvUser1 != null)
      {
        trvUser1.AfterLabelEdit -= changedEventHandler1;
        trvUser1.ValidateLabelEdit -= editEventHandler;
        trvUser1.AfterActivate -= changedEventHandler2;
        ((System.Windows.Forms.Control) trvUser1).DoubleClick -= eventHandler;
        ((System.Windows.Forms.Control) trvUser1).KeyUp -= keyEventHandler;
        trvUser1.BeforeExpand -= changedEventHandler3;
        ((UltraControlBase) trvUser1).MouseEnterElement -= elementEventHandler;
      }
      this._trvUser = value;
      MGATreeView trvUser2 = this._trvUser;
      if (trvUser2 == null)
        return;
      trvUser2.AfterLabelEdit += changedEventHandler1;
      trvUser2.ValidateLabelEdit += editEventHandler;
      trvUser2.AfterActivate += changedEventHandler2;
      ((System.Windows.Forms.Control) trvUser2).DoubleClick += eventHandler;
      ((System.Windows.Forms.Control) trvUser2).KeyUp += keyEventHandler;
      trvUser2.BeforeExpand += changedEventHandler3;
      ((UltraControlBase) trvUser2).MouseEnterElement += elementEventHandler;
    }
  }

  private virtual LinkLabel lnkAddEntityDoc
  {
    get => this._lnkAddEntityDoc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddEntityDoc_LinkClicked);
      LinkLabel lnkAddEntityDoc1 = this._lnkAddEntityDoc;
      if (lnkAddEntityDoc1 != null)
        lnkAddEntityDoc1.LinkClicked -= clickedEventHandler;
      this._lnkAddEntityDoc = value;
      LinkLabel lnkAddEntityDoc2 = this._lnkAddEntityDoc;
      if (lnkAddEntityDoc2 == null)
        return;
      lnkAddEntityDoc2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkAddUserDoc
  {
    get => this._lnkAddUserDoc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddUserDoc_LinkClicked);
      LinkLabel lnkAddUserDoc1 = this._lnkAddUserDoc;
      if (lnkAddUserDoc1 != null)
        lnkAddUserDoc1.LinkClicked -= clickedEventHandler;
      this._lnkAddUserDoc = value;
      LinkLabel lnkAddUserDoc2 = this._lnkAddUserDoc;
      if (lnkAddUserDoc2 == null)
        return;
      lnkAddUserDoc2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual PictureBox pbPreview
  {
    get => this._pbPreview;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.pbPreview_MouseEnter);
      EventHandler eventHandler2 = new EventHandler(this.pbPreview_MouseLeave);
      PictureBox pbPreview1 = this._pbPreview;
      if (pbPreview1 != null)
      {
        pbPreview1.MouseEnter -= eventHandler1;
        pbPreview1.MouseLeave -= eventHandler2;
      }
      this._pbPreview = value;
      PictureBox pbPreview2 = this._pbPreview;
      if (pbPreview2 == null)
        return;
      pbPreview2.MouseEnter += eventHandler1;
      pbPreview2.MouseLeave += eventHandler2;
    }
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Override override1 = new Override();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TabDocumentPanel));
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance8 = new Appearance();
    Override override2 = new Override();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("contextMenu");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("contextMenu");
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("View");
    ButtonTool buttonTool1 = new ButtonTool("CollapseExpand");
    ButtonTool buttonTool2 = new ButtonTool("Refresh");
    ButtonTool buttonTool3 = new ButtonTool("Show Folders");
    ButtonTool buttonTool4 = new ButtonTool("Enable Folder Filter");
    ButtonTool buttonTool5 = new ButtonTool("New Folder");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("Sort");
    ButtonTool buttonTool6 = new ButtonTool("Delete Folder");
    ButtonTool buttonTool7 = new ButtonTool("Rename Folder");
    ButtonTool buttonTool8 = new ButtonTool("Transfer File");
    PopupMenuTool popupMenuTool5 = new PopupMenuTool("Open");
    PopupMenuTool popupMenuTool6 = new PopupMenuTool("Edit");
    ButtonTool buttonTool9 = new ButtonTool("Bind");
    ButtonTool buttonTool10 = new ButtonTool("Add File");
    ButtonTool buttonTool11 = new ButtonTool("Delete File");
    ButtonTool buttonTool12 = new ButtonTool("Copy to Renewal");
    ButtonTool buttonTool13 = new ButtonTool("Rename File");
    ButtonTool buttonTool14 = new ButtonTool("File Properties");
    ButtonTool buttonTool15 = new ButtonTool("Concatenate Adobe Documents");
    ButtonTool buttonTool16 = new ButtonTool("Split Adobe Document");
    ButtonTool buttonTool17 = new ButtonTool("Abridge Adobe Document");
    ButtonTool buttonTool18 = new ButtonTool("Parse Acord App and View in NetRate");
    ButtonTool buttonTool19 = new ButtonTool("Insert Adobe Document");
    ButtonTool buttonTool20 = new ButtonTool("Replace Adobe Page");
    PopupMenuTool popupMenuTool7 = new PopupMenuTool("PopupMenuTool1");
    ButtonTool buttonTool21 = new ButtonTool("Save As");
    ButtonTool buttonTool22 = new ButtonTool("Save As Zipped");
    ButtonTool buttonTool23 = new ButtonTool("Email");
    ButtonTool buttonTool24 = new ButtonTool("EmailAsPdf");
    ButtonTool buttonTool25 = new ButtonTool("SendToImageRight");
    PopupMenuTool popupMenuTool8 = new PopupMenuTool("Document Pinning");
    PopupMenuTool popupMenuTool9 = new PopupMenuTool("Notes");
    ButtonTool buttonTool26 = new ButtonTool("Filter by Type");
    ButtonTool buttonTool27 = new ButtonTool("Send to DocuSign");
    PopupMenuTool popupMenuTool10 = new PopupMenuTool("Sort");
    ButtonTool buttonTool28 = new ButtonTool("Filename");
    ButtonTool buttonTool29 = new ButtonTool("Compressed");
    ButtonTool buttonTool30 = new ButtonTool("Date Added");
    ButtonTool buttonTool31 = new ButtonTool("File Extension");
    ButtonTool buttonTool32 = new ButtonTool("File Size");
    ButtonTool buttonTool33 = new ButtonTool("Folder");
    PopupMenuTool popupMenuTool11 = new PopupMenuTool("Mail");
    ButtonTool buttonTool34 = new ButtonTool("Show Folders");
    Appearance appearance9 = new Appearance();
    ButtonTool buttonTool35 = new ButtonTool("Enable Folder Filter");
    Appearance appearance10 = new Appearance();
    ButtonTool buttonTool36 = new ButtonTool("File Descriptions");
    Appearance appearance11 = new Appearance();
    ButtonTool buttonTool37 = new ButtonTool("File Names");
    Appearance appearance12 = new Appearance();
    ButtonTool buttonTool38 = new ButtonTool("New Folder");
    Appearance appearance13 = new Appearance();
    ButtonTool buttonTool39 = new ButtonTool("Delete Folder");
    Appearance appearance14 = new Appearance();
    ButtonTool buttonTool40 = new ButtonTool("Rename Folder");
    Appearance appearance15 = new Appearance();
    ButtonTool buttonTool41 = new ButtonTool("Transfer File");
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool42 = new ButtonTool("Bind");
    Appearance appearance17 = new Appearance();
    ButtonTool buttonTool43 = new ButtonTool("View File");
    Appearance appearance18 = new Appearance();
    ButtonTool buttonTool44 = new ButtonTool("Add File");
    Appearance appearance19 = new Appearance();
    ButtonTool buttonTool45 = new ButtonTool("Delete File");
    Appearance appearance20 = new Appearance();
    ButtonTool buttonTool46 = new ButtonTool("File Properties");
    Appearance appearance21 = new Appearance();
    ButtonTool buttonTool47 = new ButtonTool("Concatenate Adobe Documents");
    Appearance appearance22 = new Appearance();
    ButtonTool buttonTool48 = new ButtonTool("Split Adobe Document");
    Appearance appearance23 = new Appearance();
    ButtonTool buttonTool49 = new ButtonTool("Abridge Adobe Document");
    Appearance appearance24 = new Appearance();
    ButtonTool buttonTool50 = new ButtonTool("Save As");
    Appearance appearance25 = new Appearance();
    ButtonTool buttonTool51 = new ButtonTool("Print");
    Appearance appearance26 = new Appearance();
    ButtonTool buttonTool52 = new ButtonTool("Email");
    Appearance appearance27 = new Appearance();
    ButtonTool buttonTool53 = new ButtonTool("Rename File");
    Appearance appearance28 = new Appearance();
    PopupMenuTool popupMenuTool12 = new PopupMenuTool("Document Pinning");
    ButtonTool buttonTool54 = new ButtonTool("Pin Document");
    ButtonTool buttonTool55 = new ButtonTool("Unpin Document");
    ButtonTool buttonTool56 = new ButtonTool("Unpin All Documents");
    PopupMenuTool popupMenuTool13 = new PopupMenuTool("Notes");
    ButtonTool buttonTool57 = new ButtonTool("Create Associated Note");
    ButtonTool buttonTool58 = new ButtonTool("Create Associated Note");
    Appearance appearance29 = new Appearance();
    ButtonTool buttonTool59 = new ButtonTool("Pin Document");
    Appearance appearance30 = new Appearance();
    ButtonTool buttonTool60 = new ButtonTool("Unpin Document");
    Appearance appearance31 = new Appearance();
    ButtonTool buttonTool61 = new ButtonTool("Unpin All Documents");
    Appearance appearance32 = new Appearance();
    ButtonTool buttonTool62 = new ButtonTool("CollapseExpand");
    Appearance appearance33 = new Appearance();
    PopupMenuTool popupMenuTool14 = new PopupMenuTool("View");
    ButtonTool buttonTool63 = new ButtonTool("File Names");
    ButtonTool buttonTool64 = new ButtonTool("File Descriptions");
    PopupMenuTool popupMenuTool15 = new PopupMenuTool("MailView");
    ButtonTool buttonTool65 = new ButtonTool("Filename");
    Appearance appearance34 = new Appearance();
    ButtonTool buttonTool66 = new ButtonTool("Date Added");
    Appearance appearance35 = new Appearance();
    ButtonTool buttonTool67 = new ButtonTool("File Size");
    Appearance appearance36 = new Appearance();
    ButtonTool buttonTool68 = new ButtonTool("File Extension");
    Appearance appearance37 = new Appearance();
    ButtonTool buttonTool69 = new ButtonTool("Compressed");
    Appearance appearance38 = new Appearance();
    ButtonTool buttonTool70 = new ButtonTool("Date Sent");
    Appearance appearance39 = new Appearance();
    ButtonTool buttonTool71 = new ButtonTool("Date Received");
    Appearance appearance40 = new Appearance();
    PopupMenuTool popupMenuTool16 = new PopupMenuTool("Mail");
    ButtonTool buttonTool72 = new ButtonTool("Date Sent");
    ButtonTool buttonTool73 = new ButtonTool("Date Received");
    PopupMenuTool popupMenuTool17 = new PopupMenuTool("MailView");
    ButtonTool buttonTool74 = new ButtonTool("MailViewDateAdded");
    ButtonTool buttonTool75 = new ButtonTool("MailViewDateReceived");
    ButtonTool buttonTool76 = new ButtonTool("MailViewDateSent");
    ButtonTool buttonTool77 = new ButtonTool("MailViewDateAdded");
    ButtonTool buttonTool78 = new ButtonTool("MailViewDateReceived");
    ButtonTool buttonTool79 = new ButtonTool("MailViewDateSent");
    ButtonTool buttonTool80 = new ButtonTool("Edit (Revision Tracking) ...");
    Appearance appearance41 = new Appearance();
    ButtonTool buttonTool81 = new ButtonTool("Open With ...");
    Appearance appearance42 = new Appearance();
    PopupMenuTool popupMenuTool18 = new PopupMenuTool("Open");
    ButtonTool buttonTool82 = new ButtonTool("View File");
    ButtonTool buttonTool83 = new ButtonTool("Open With ...");
    PopupMenuTool popupMenuTool19 = new PopupMenuTool("Open With");
    PopupMenuTool popupMenuTool20 = new PopupMenuTool("Edit");
    ButtonTool buttonTool84 = new ButtonTool("Edit (Revision Tracking) ...");
    ButtonTool buttonTool85 = new ButtonTool("Edit With (Revision Tracking) ...");
    ButtonTool buttonTool86 = new ButtonTool("Edit With (Revision Tracking) ...");
    Appearance appearance43 = new Appearance();
    PopupMenuTool popupMenuTool21 = new PopupMenuTool("PopupMenuTool1");
    Appearance appearance44 = new Appearance();
    ButtonTool buttonTool87 = new ButtonTool("Print");
    ButtonTool buttonTool88 = new ButtonTool("Advanced Print Options ...");
    ButtonTool buttonTool89 = new ButtonTool("Advanced Print Options ...");
    Appearance appearance45 = new Appearance();
    ButtonTool buttonTool90 = new ButtonTool("Description");
    ButtonTool buttonTool91 = new ButtonTool("Show Enhanced ToolTips");
    ButtonTool buttonTool92 = new ButtonTool("EmailAsPdf");
    ButtonTool buttonTool93 = new ButtonTool("Refresh");
    Appearance appearance46 = new Appearance();
    ButtonTool buttonTool94 = new ButtonTool("SendToImageRight");
    ButtonTool buttonTool95 = new ButtonTool("Folder");
    Appearance appearance47 = new Appearance();
    ButtonTool buttonTool96 = new ButtonTool("Save As Zipped");
    Appearance appearance48 = new Appearance();
    ButtonTool buttonTool97 = new ButtonTool("Filter by Type");
    ButtonTool buttonTool98 = new ButtonTool("Send to DocuSign");
    ButtonTool buttonTool99 = new ButtonTool("Copy to Renewal");
    Appearance appearance49 = new Appearance();
    ButtonTool buttonTool100 = new ButtonTool("Parse Acord App and View in NetRate");
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    ButtonTool buttonTool101 = new ButtonTool("Insert Adobe Document");
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    ButtonTool buttonTool102 = new ButtonTool("Replace Adobe Page");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.pbPreview = new PictureBox();
    this.lblDetails = new System.Windows.Forms.TextBox();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.txtPreviewText = new System.Windows.Forms.TextBox();
    this.trvEntity = new MGATreeView();
    this.daGetFolders = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSql = new SqlConnection();
    this.pnlAssociated = new UltraGroupBox();
    this.txtFilterAssoc = new MGATextBox();
    this.chkEntityOnly = new MGACheckBox();
    this.panelLoading = new System.Windows.Forms.Panel();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new System.Windows.Forms.Label();
    this.lnkAddEntityDoc = new LinkLabel();
    this.pnlDisassociated = new UltraGroupBox();
    this.TabControl1 = new MGATab();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.Label3 = new System.Windows.Forms.Label();
    this.lnkAddUserDoc = new LinkLabel();
    this.trvUser = new MGATreeView();
    this.Splitter1 = new Splitter();
    this.FolderBrowserDialog1 = new FolderBrowserDialog();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.ctxMenu = new UltraToolbarsManager(this.components);
    this._TabDocumentPanel_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._TabDocumentPanel_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._TabDocumentPanel_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._TabDocumentPanel_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.DragDropExtenderUserTree = new DragDropExtender(this.components);
    this.DragDropExtenderEntityTree = new DragDropExtender(this.components);
    this.ds = new dsDocumentPanel();
    ((System.Windows.Forms.Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.pbPreview).BeginInit();
    ((System.Windows.Forms.Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.trvEntity).BeginInit();
    ((ISupportInitialize) this.pnlAssociated).BeginInit();
    ((System.Windows.Forms.Control) this.pnlAssociated).SuspendLayout();
    ((ISupportInitialize) this.txtFilterAssoc).BeginInit();
    ((ISupportInitialize) this.chkEntityOnly).BeginInit();
    this.panelLoading.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.pnlDisassociated).BeginInit();
    ((System.Windows.Forms.Control) this.pnlDisassociated).SuspendLayout();
    ((ISupportInitialize) this.TabControl1).BeginInit();
    ((System.Windows.Forms.Control) this.TabControl1).SuspendLayout();
    ((ISupportInitialize) this.trvUser).BeginInit();
    ((ISupportInitialize) this.ctxMenu).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((System.Windows.Forms.Control) this.UltraTabPageControl1).Controls.Add((System.Windows.Forms.Control) this.pbPreview);
    ((System.Windows.Forms.Control) this.UltraTabPageControl1).Controls.Add((System.Windows.Forms.Control) this.lblDetails);
    ((System.Windows.Forms.Control) this.UltraTabPageControl1).Location = new System.Drawing.Point(1, 20);
    ((System.Windows.Forms.Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((System.Windows.Forms.Control) this.UltraTabPageControl1).Size = new Size(273, 160 /*0xA0*/);
    this.pbPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.pbPreview.Location = new System.Drawing.Point(186, 35);
    this.pbPreview.Name = "pbPreview";
    this.pbPreview.Size = new Size(79, 79);
    this.pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pbPreview.TabIndex = 9;
    this.pbPreview.TabStop = false;
    this.lblDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lblDetails.BackColor = Color.WhiteSmoke;
    this.lblDetails.BorderStyle = BorderStyle.None;
    this.lblDetails.Location = new System.Drawing.Point(3, 2);
    this.lblDetails.Multiline = true;
    this.lblDetails.Name = "lblDetails";
    this.lblDetails.Size = new Size(177, 111);
    this.lblDetails.TabIndex = 8;
    ((System.Windows.Forms.Control) this.UltraTabPageControl2).Controls.Add((System.Windows.Forms.Control) this.txtPreviewText);
    ((System.Windows.Forms.Control) this.UltraTabPageControl2).Location = new System.Drawing.Point(-10000, -10000);
    ((System.Windows.Forms.Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((System.Windows.Forms.Control) this.UltraTabPageControl2).Size = new Size(273, 160 /*0xA0*/);
    this.txtPreviewText.BackColor = Color.White;
    this.txtPreviewText.Dock = DockStyle.Fill;
    this.txtPreviewText.Location = new System.Drawing.Point(0, 0);
    this.txtPreviewText.Multiline = true;
    this.txtPreviewText.Name = "txtPreviewText";
    this.txtPreviewText.ReadOnly = true;
    this.txtPreviewText.ScrollBars = ScrollBars.Both;
    this.txtPreviewText.Size = new Size(273, 160 /*0xA0*/);
    this.txtPreviewText.TabIndex = 0;
    ((System.Windows.Forms.Control) this.trvEntity).AllowDrop = true;
    ((System.Windows.Forms.Control) this.trvEntity).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.Gray;
    this.trvEntity.Appearance = (AppearanceBase) appearance1;
    this.trvEntity.BorderStyle = (UIElementBorderStyle) 1;
    this.ctxMenu.SetContextMenuUltra((Component) this.trvEntity, "contextMenu");
    ((System.Windows.Forms.Control) this.trvEntity).Enabled = false;
    ((System.Windows.Forms.Control) this.trvEntity).Location = new System.Drawing.Point(5, 40);
    ((System.Windows.Forms.Control) this.trvEntity).Name = "trvEntity";
    override1.SelectionType = (SelectType) 2;
    this.trvEntity.Override = override1;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.trvEntity.ScrollBarLook = scrollBarLook1;
    this.trvEntity.SelectionBehavior = (SelectionBehavior) 1;
    this.trvEntity.ShowLines = false;
    ((System.Windows.Forms.Control) this.trvEntity).Size = new Size(269, 130);
    ((System.Windows.Forms.Control) this.trvEntity).TabIndex = 0;
    ((UltraControlBase) this.trvEntity).UseFlatMode = (DefaultableBoolean) 1;
    this.daGetFolders.SelectCommand = this.SqlSelectCommand1;
    this.daGetFolders.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDocumentFolders", new DataColumnMapping[5]
      {
        new DataColumnMapping("FolderID", "FolderID"),
        new DataColumnMapping("ParentFolderID", "ParentFolderID"),
        new DataColumnMapping("FolderName", "FolderName"),
        new DataColumnMapping("IsDeletable", "IsDeletable"),
        new DataColumnMapping("SecureResourceGuid", "SecureResourceGuid")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT     FolderID, ParentFolderID, FolderName, IsDeletable, SecureResourceGuid FROM         tblDocumentFolders (NOLOCK)";
    this.SqlSelectCommand1.Connection = this.cnSql;
    this.cnSql.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSql.FireInfoMessageEventOnUserErrors = false;
    ((System.Windows.Forms.Control) this.pnlAssociated).Controls.Add((System.Windows.Forms.Control) this.txtFilterAssoc);
    ((System.Windows.Forms.Control) this.pnlAssociated).Controls.Add((System.Windows.Forms.Control) this.chkEntityOnly);
    ((System.Windows.Forms.Control) this.pnlAssociated).Controls.Add((System.Windows.Forms.Control) this.panelLoading);
    ((System.Windows.Forms.Control) this.pnlAssociated).Controls.Add((System.Windows.Forms.Control) this.trvEntity);
    ((System.Windows.Forms.Control) this.pnlAssociated).Controls.Add((System.Windows.Forms.Control) this.lnkAddEntityDoc);
    this.pnlAssociated.Dock = DockStyle.Top;
    appearance2.ForeColor = Color.FromArgb(21, 66, 139);
    this.pnlAssociated.HeaderAppearance = (AppearanceBase) appearance2;
    ((System.Windows.Forms.Control) this.pnlAssociated).Location = new System.Drawing.Point(0, 28);
    ((System.Windows.Forms.Control) this.pnlAssociated).Name = "pnlAssociated";
    ((System.Windows.Forms.Control) this.pnlAssociated).Size = new Size(279, 174);
    ((System.Windows.Forms.Control) this.pnlAssociated).TabIndex = 5;
    this.pnlAssociated.Text = "Associated Documents";
    this.pnlAssociated.ViewStyle = (GroupBoxViewStyle) 2;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFilterAssoc).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtFilterAssoc).BackColor = Color.White;
    ((System.Windows.Forms.Control) this.txtFilterAssoc).Dock = DockStyle.Top;
    ((System.Windows.Forms.Control) this.txtFilterAssoc).Location = new System.Drawing.Point(2, 19);
    this.txtFilterAssoc.MGAStyle = MGAStyles.Blue;
    ((System.Windows.Forms.Control) this.txtFilterAssoc).Name = "txtFilterAssoc";
    ((TextEditorControlBase) this.txtFilterAssoc).NullText = "Filter Document";
    ((System.Windows.Forms.Control) this.txtFilterAssoc).Size = new Size(275, 20);
    ((System.Windows.Forms.Control) this.txtFilterAssoc).TabIndex = 8;
    ((UltraControlBase) this.txtFilterAssoc).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFilterAssoc).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkEntityOnly).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkEntityOnly).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEntityOnly).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkEntityOnly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((System.Windows.Forms.Control) this.chkEntityOnly).Location = new System.Drawing.Point(160 /*0xA0*/, 1);
    ((System.Windows.Forms.Control) this.chkEntityOnly).Name = "chkEntityOnly";
    ((System.Windows.Forms.Control) this.chkEntityOnly).Size = new Size(108, 17);
    ((System.Windows.Forms.Control) this.chkEntityOnly).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkEntityOnly).Text = "Show Entity Only";
    this.panelLoading.Controls.Add((System.Windows.Forms.Control) this.PictureBox1);
    this.panelLoading.Controls.Add((System.Windows.Forms.Control) this.Label1);
    this.panelLoading.Location = new System.Drawing.Point(1, 40);
    this.panelLoading.Name = "panelLoading";
    this.panelLoading.Size = new Size(275, 28);
    this.panelLoading.TabIndex = 6;
    this.panelLoading.Visible = false;
    this.PictureBox1.Image = (System.Drawing.Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new System.Drawing.Point(3, 3);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.Location = new System.Drawing.Point(25, 6);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(59, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Loading ...";
    this.lnkAddEntityDoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkAddEntityDoc.AutoSize = true;
    this.lnkAddEntityDoc.Enabled = false;
    this.lnkAddEntityDoc.Location = new System.Drawing.Point(344, 19);
    this.lnkAddEntityDoc.Name = "lnkAddEntityDoc";
    this.lnkAddEntityDoc.Size = new Size(43, 13);
    this.lnkAddEntityDoc.TabIndex = 5;
    this.lnkAddEntityDoc.TabStop = true;
    this.lnkAddEntityDoc.Text = "Add file";
    ((System.Windows.Forms.Control) this.pnlDisassociated).Controls.Add((System.Windows.Forms.Control) this.TabControl1);
    ((System.Windows.Forms.Control) this.pnlDisassociated).Controls.Add((System.Windows.Forms.Control) this.Label3);
    ((System.Windows.Forms.Control) this.pnlDisassociated).Controls.Add((System.Windows.Forms.Control) this.lnkAddUserDoc);
    ((System.Windows.Forms.Control) this.pnlDisassociated).Controls.Add((System.Windows.Forms.Control) this.trvUser);
    this.pnlDisassociated.Dock = DockStyle.Fill;
    appearance5.ForeColor = Color.FromArgb(21, 66, 139);
    this.pnlDisassociated.HeaderAppearance = (AppearanceBase) appearance5;
    ((System.Windows.Forms.Control) this.pnlDisassociated).Location = new System.Drawing.Point(0, 204);
    ((System.Windows.Forms.Control) this.pnlDisassociated).Name = "pnlDisassociated";
    ((System.Windows.Forms.Control) this.pnlDisassociated).Size = new Size(279, 246);
    ((System.Windows.Forms.Control) this.pnlDisassociated).TabIndex = 6;
    this.pnlDisassociated.Text = "Disassociated Documents";
    this.pnlDisassociated.ViewStyle = (GroupBoxViewStyle) 2;
    appearance6.BackColor = Color.Gainsboro;
    ((UltraTabControlBase) this.TabControl1).Appearance = (AppearanceBase) appearance6;
    ((System.Windows.Forms.Control) this.TabControl1).Controls.Add((System.Windows.Forms.Control) this.UltraTabSharedControlsPage1);
    ((System.Windows.Forms.Control) this.TabControl1).Controls.Add((System.Windows.Forms.Control) this.UltraTabPageControl1);
    ((System.Windows.Forms.Control) this.TabControl1).Controls.Add((System.Windows.Forms.Control) this.UltraTabPageControl2);
    ((System.Windows.Forms.Control) this.TabControl1).Dock = DockStyle.Bottom;
    ((System.Windows.Forms.Control) this.TabControl1).Location = new System.Drawing.Point(2, 63 /*0x3F*/);
    ((System.Windows.Forms.Control) this.TabControl1).Name = "TabControl1";
    appearance7.BackColor = Color.WhiteSmoke;
    appearance7.BorderColor = Color.Gray;
    ((UltraTabControlBase) this.TabControl1).SelectedTabAppearance = (AppearanceBase) appearance7;
    ((UltraTabControlBase) this.TabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((System.Windows.Forms.Control) this.TabControl1).Size = new Size(275, 181);
    ((UltraTabControlBase) this.TabControl1).Style = (UltraTabControlStyle) 12;
    ((System.Windows.Forms.Control) this.TabControl1).TabIndex = 10;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Details";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Text";
    ((UltraTabControlBase) this.TabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraControlBase) this.TabControl1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.TabControl1).UseOsThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.UltraTabSharedControlsPage1).Location = new System.Drawing.Point(-10000, -10000);
    ((System.Windows.Forms.Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((System.Windows.Forms.Control) this.UltraTabSharedControlsPage1).Size = new Size(273, 160 /*0xA0*/);
    this.Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Label3.BorderStyle = BorderStyle.FixedSingle;
    this.Label3.Location = new System.Drawing.Point(-1, 257);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(371, 1);
    this.Label3.TabIndex = 7;
    this.lnkAddUserDoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkAddUserDoc.AutoSize = true;
    this.lnkAddUserDoc.Location = new System.Drawing.Point(344, 10);
    this.lnkAddUserDoc.Name = "lnkAddUserDoc";
    this.lnkAddUserDoc.Size = new Size(43, 13);
    this.lnkAddUserDoc.TabIndex = 6;
    this.lnkAddUserDoc.TabStop = true;
    this.lnkAddUserDoc.Text = "Add file";
    ((System.Windows.Forms.Control) this.trvUser).AllowDrop = true;
    ((System.Windows.Forms.Control) this.trvUser).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance8.BorderColor = Color.Gray;
    this.trvUser.Appearance = (AppearanceBase) appearance8;
    this.trvUser.BorderStyle = (UIElementBorderStyle) 4;
    this.ctxMenu.SetContextMenuUltra((Component) this.trvUser, "contextMenu");
    ((System.Windows.Forms.Control) this.trvUser).Location = new System.Drawing.Point(3, 22);
    ((System.Windows.Forms.Control) this.trvUser).Name = "trvUser";
    override2.SelectionType = (SelectType) 2;
    this.trvUser.Override = override2;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.trvUser.ScrollBarLook = scrollBarLook2;
    this.trvUser.ShowLines = false;
    ((System.Windows.Forms.Control) this.trvUser).Size = new Size(271, 9);
    ((System.Windows.Forms.Control) this.trvUser).TabIndex = 0;
    ((UltraControlBase) this.trvUser).UseFlatMode = (DefaultableBoolean) 1;
    this.Splitter1.Dock = DockStyle.Top;
    this.Splitter1.Location = new System.Drawing.Point(0, 202);
    this.Splitter1.Name = "Splitter1";
    this.Splitter1.Size = new Size(279, 2);
    this.Splitter1.TabIndex = 7;
    this.Splitter1.TabStop = false;
    this.ctxMenu.DesignerFlags = 0;
    this.ctxMenu.DockWithinContainer = (System.Windows.Forms.Control) this;
    this.ctxMenu.Office2007UICompatibility = false;
    this.ctxMenu.ShowFullMenusDelay = 500;
    this.ctxMenu.ShowMenuShadows = (DefaultableBoolean) 1;
    this.ctxMenu.ShowQuickCustomizeButton = false;
    this.ctxMenu.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    this.ctxMenu.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "contextMenu";
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool15).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool8).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool9).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[34]
    {
      (ToolBase) popupMenuTool3,
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) popupMenuTool4,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) popupMenuTool5,
      (ToolBase) popupMenuTool6,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) popupMenuTool7,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) popupMenuTool8,
      (ToolBase) popupMenuTool9,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool10).SharedPropsInternal).Caption = "Sort";
    ((ToolsCollectionBase) popupMenuTool10.Tools).AddRange(new ToolBase[7]
    {
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30,
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33,
      (ToolBase) popupMenuTool11
    });
    appearance9.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.folder_wrench;
    ((ToolPropsBase) ((ToolBase) buttonTool34).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance9;
    ((ToolPropsBase) ((ToolBase) buttonTool34).SharedPropsInternal).Caption = "Show Folders";
    appearance10.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.folder_find;
    ((ToolPropsBase) ((ToolBase) buttonTool35).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ((ToolPropsBase) ((ToolBase) buttonTool35).SharedPropsInternal).Caption = "Enable Folder Filter";
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).Caption = "File Descriptions";
    appearance12.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance12.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).Caption = "File Names";
    appearance13.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.folder_add;
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).Caption = "New Folder";
    appearance14.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.folder_delete;
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedPropsInternal).Caption = "Delete Folder";
    appearance15.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.folder_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool40).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool40).SharedPropsInternal).Caption = "Rename Folder";
    appearance16.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance16.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool41).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool41).SharedPropsInternal).Caption = "Transfer File ...";
    appearance17.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.link;
    ((ToolPropsBase) ((ToolBase) buttonTool42).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool42).SharedPropsInternal).Caption = "Bind";
    appearance18.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool43).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool43).SharedPropsInternal).Caption = "Open File";
    appearance19.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_add;
    ((ToolPropsBase) ((ToolBase) buttonTool44).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool44).SharedPropsInternal).Caption = "Add File ...";
    appearance20.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_delete;
    ((ToolPropsBase) ((ToolBase) buttonTool45).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ((ToolPropsBase) ((ToolBase) buttonTool45).SharedPropsInternal).Caption = "Delete File";
    appearance21.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance21.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool46).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ((ToolPropsBase) ((ToolBase) buttonTool46).SharedPropsInternal).Caption = "File Properties ...";
    appearance22.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance22.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance22;
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedPropsInternal).Caption = "Concatenate Adobe Documents ...";
    appearance23.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance23.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedPropsInternal).Caption = "Split Adobe Document ...";
    appearance24.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_white_acrobat;
    ((ToolPropsBase) ((ToolBase) buttonTool49).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ((ToolPropsBase) ((ToolBase) buttonTool49).SharedPropsInternal).Caption = "Abridge Adobe Document ...";
    appearance25.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool50).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((ToolPropsBase) ((ToolBase) buttonTool50).SharedPropsInternal).Caption = "Save As ...";
    appearance26.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance26.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool51).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance26;
    ((ToolPropsBase) ((ToolBase) buttonTool51).SharedPropsInternal).Caption = "Print ...";
    appearance27.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.email_go;
    ((ToolPropsBase) ((ToolBase) buttonTool52).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance27;
    ((ToolPropsBase) ((ToolBase) buttonTool52).SharedPropsInternal).Caption = "Email ...";
    appearance28.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance28.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool53).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance28;
    ((ToolPropsBase) ((ToolBase) buttonTool53).SharedPropsInternal).Caption = "Rename File";
    ((ToolPropsBase) ((ToolBase) popupMenuTool12).SharedPropsInternal).Caption = "Document Pinning";
    ((ToolsCollectionBase) popupMenuTool12.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool54,
      (ToolBase) buttonTool55,
      (ToolBase) buttonTool56
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool13).SharedPropsInternal).Caption = "Notes";
    ((ToolsCollectionBase) popupMenuTool13.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool57
    });
    appearance29.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance29;
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedPropsInternal).Caption = "Create Associated Note ...";
    appearance30.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool59).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance30;
    ((ToolPropsBase) ((ToolBase) buttonTool59).SharedPropsInternal).Caption = "Pin Document";
    appearance31.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool60).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance31;
    ((ToolPropsBase) ((ToolBase) buttonTool60).SharedPropsInternal).Caption = "Unpin Document";
    appearance32.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance32.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool61).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance32;
    ((ToolPropsBase) ((ToolBase) buttonTool61).SharedPropsInternal).Caption = "Unpin All Documents";
    appearance33.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.arrow_inout;
    ((ToolPropsBase) ((ToolBase) buttonTool62).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance33;
    ((ToolPropsBase) ((ToolBase) buttonTool62).SharedPropsInternal).Caption = "Collapse";
    ((ToolPropsBase) ((ToolBase) popupMenuTool14).SharedPropsInternal).Caption = "View";
    ((ToolsCollectionBase) popupMenuTool14.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool63,
      (ToolBase) buttonTool64,
      (ToolBase) popupMenuTool15
    });
    appearance34.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance34.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool65).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance34;
    ((ToolPropsBase) ((ToolBase) buttonTool65).SharedPropsInternal).Caption = "Name";
    appearance35.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance35.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool66).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance35;
    ((ToolPropsBase) ((ToolBase) buttonTool66).SharedPropsInternal).Caption = "Date Added";
    appearance36.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance36.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool67).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance36;
    ((ToolPropsBase) ((ToolBase) buttonTool67).SharedPropsInternal).Caption = "File Size";
    appearance37.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance37.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool68).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance37;
    ((ToolPropsBase) ((ToolBase) buttonTool68).SharedPropsInternal).Caption = "File Extension";
    appearance38.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance38.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool69).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance38;
    ((ToolPropsBase) ((ToolBase) buttonTool69).SharedPropsInternal).Caption = "Compressed";
    appearance39.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool70).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance39;
    ((ToolPropsBase) ((ToolBase) buttonTool70).SharedPropsInternal).Caption = "Date Sent";
    appearance40.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance40.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool71).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance40;
    ((ToolPropsBase) ((ToolBase) buttonTool71).SharedPropsInternal).Caption = "Date Received";
    ((ToolPropsBase) ((ToolBase) popupMenuTool16).SharedPropsInternal).Caption = "Mail";
    ((ToolsCollectionBase) popupMenuTool16.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool72,
      (ToolBase) buttonTool73
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool17).SharedPropsInternal).Caption = "Mail Date";
    ((ToolsCollectionBase) popupMenuTool17.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool74,
      (ToolBase) buttonTool75,
      (ToolBase) buttonTool76
    });
    ((ToolPropsBase) ((ToolBase) buttonTool77).SharedPropsInternal).Caption = "Added";
    ((ToolPropsBase) ((ToolBase) buttonTool78).SharedPropsInternal).Caption = "Received";
    ((ToolPropsBase) ((ToolBase) buttonTool79).SharedPropsInternal).Caption = "Sent";
    appearance41.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance41.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool80).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance41;
    ((ToolPropsBase) ((ToolBase) buttonTool80).SharedPropsInternal).Caption = "Edit";
    appearance42.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance42.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool81).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance42;
    ((ToolPropsBase) ((ToolBase) buttonTool81).SharedPropsInternal).Caption = "Open With ...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool18).SharedPropsInternal).Caption = "Open";
    ((ToolsCollectionBase) popupMenuTool18.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool82,
      (ToolBase) buttonTool83
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool19).SharedPropsInternal).Caption = "Open With ...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool20).SharedPropsInternal).Caption = "Edit (Revision Tracking)";
    ((ToolsCollectionBase) popupMenuTool20.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool84,
      (ToolBase) buttonTool85
    });
    appearance43.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance43.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool86).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance43;
    ((ToolPropsBase) ((ToolBase) buttonTool86).SharedPropsInternal).Caption = "Edit With ...";
    appearance44.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.printer;
    ((ToolPropsBase) ((ToolBase) popupMenuTool21).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance44;
    ((ToolPropsBase) ((ToolBase) popupMenuTool21).SharedPropsInternal).Caption = "Print";
    ((ToolsCollectionBase) popupMenuTool21.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool87,
      (ToolBase) buttonTool88
    });
    appearance45.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance45.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool89).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance45;
    ((ToolPropsBase) ((ToolBase) buttonTool89).SharedPropsInternal).Caption = "Advanced Print Options ...";
    ((ToolPropsBase) ((ToolBase) buttonTool90).SharedPropsInternal).Caption = "Description";
    ((ToolPropsBase) ((ToolBase) buttonTool91).SharedPropsInternal).Caption = "Toggle Enhanced ToolTips";
    ((ToolPropsBase) ((ToolBase) buttonTool92).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance27;
    ((ToolPropsBase) ((ToolBase) buttonTool92).SharedPropsInternal).Caption = "Email As PDF...";
    appearance46.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.arrow_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool93).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance46;
    ((ToolPropsBase) ((ToolBase) buttonTool93).SharedPropsInternal).Caption = "Refresh";
    ((ToolPropsBase) ((ToolBase) buttonTool93).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool94).SharedPropsInternal).Caption = "Send To ImageRight";
    appearance47.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance47.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool95).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance47;
    ((ToolPropsBase) ((ToolBase) buttonTool95).SharedPropsInternal).Caption = "Folder";
    appearance48.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.disk_multiple;
    ((ToolPropsBase) ((ToolBase) buttonTool96).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance48;
    ((ToolPropsBase) ((ToolBase) buttonTool96).SharedPropsInternal).Caption = "Save As ... (zipped)";
    ((ToolPropsBase) ((ToolBase) buttonTool97).SharedPropsInternal).Caption = "Filter by Type";
    ((ToolPropsBase) ((ToolBase) buttonTool98).SharedPropsInternal).Caption = "Send to DocuSign";
    appearance49.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_copy;
    ((ToolPropsBase) ((ToolBase) buttonTool99).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance49;
    ((ToolPropsBase) ((ToolBase) buttonTool99).SharedPropsInternal).Caption = "Copy to Renewal";
    appearance50.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_white_acrobat;
    ((ToolPropsBase) ((ToolBase) buttonTool100).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance50;
    appearance51.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_white_acrobat;
    ((ToolPropsBase) ((ToolBase) buttonTool100).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance51;
    ((ToolPropsBase) ((ToolBase) buttonTool100).SharedPropsInternal).Caption = "Parse Acord App and View in NetRate";
    appearance52.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_white_acrobat;
    ((ToolPropsBase) ((ToolBase) buttonTool101).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance52;
    appearance53.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_white_acrobat;
    ((ToolPropsBase) ((ToolBase) buttonTool101).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance53;
    ((ToolPropsBase) ((ToolBase) buttonTool101).SharedPropsInternal).Caption = "Insert Adobe Document...";
    appearance54.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_white_acrobat;
    ((ToolPropsBase) ((ToolBase) buttonTool102).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance54;
    appearance55.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.page_white_acrobat;
    ((ToolPropsBase) ((ToolBase) buttonTool102).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance55;
    ((ToolPropsBase) ((ToolBase) buttonTool102).SharedPropsInternal).Caption = "Replace Adobe Page...";
    this.ctxMenu.Tools.AddRange(new ToolBase[63 /*0x3F*/]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) popupMenuTool10,
      (ToolBase) buttonTool34,
      (ToolBase) buttonTool35,
      (ToolBase) buttonTool36,
      (ToolBase) buttonTool37,
      (ToolBase) buttonTool38,
      (ToolBase) buttonTool39,
      (ToolBase) buttonTool40,
      (ToolBase) buttonTool41,
      (ToolBase) buttonTool42,
      (ToolBase) buttonTool43,
      (ToolBase) buttonTool44,
      (ToolBase) buttonTool45,
      (ToolBase) buttonTool46,
      (ToolBase) buttonTool47,
      (ToolBase) buttonTool48,
      (ToolBase) buttonTool49,
      (ToolBase) buttonTool50,
      (ToolBase) buttonTool51,
      (ToolBase) buttonTool52,
      (ToolBase) buttonTool53,
      (ToolBase) popupMenuTool12,
      (ToolBase) popupMenuTool13,
      (ToolBase) buttonTool58,
      (ToolBase) buttonTool59,
      (ToolBase) buttonTool60,
      (ToolBase) buttonTool61,
      (ToolBase) buttonTool62,
      (ToolBase) popupMenuTool14,
      (ToolBase) buttonTool65,
      (ToolBase) buttonTool66,
      (ToolBase) buttonTool67,
      (ToolBase) buttonTool68,
      (ToolBase) buttonTool69,
      (ToolBase) buttonTool70,
      (ToolBase) buttonTool71,
      (ToolBase) popupMenuTool16,
      (ToolBase) popupMenuTool17,
      (ToolBase) buttonTool77,
      (ToolBase) buttonTool78,
      (ToolBase) buttonTool79,
      (ToolBase) buttonTool80,
      (ToolBase) buttonTool81,
      (ToolBase) popupMenuTool18,
      (ToolBase) popupMenuTool19,
      (ToolBase) popupMenuTool20,
      (ToolBase) buttonTool86,
      (ToolBase) popupMenuTool21,
      (ToolBase) buttonTool89,
      (ToolBase) buttonTool90,
      (ToolBase) buttonTool91,
      (ToolBase) buttonTool92,
      (ToolBase) buttonTool93,
      (ToolBase) buttonTool94,
      (ToolBase) buttonTool95,
      (ToolBase) buttonTool96,
      (ToolBase) buttonTool97,
      (ToolBase) buttonTool98,
      (ToolBase) buttonTool99,
      (ToolBase) buttonTool100,
      (ToolBase) buttonTool101,
      (ToolBase) buttonTool102
    });
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._TabDocumentPanel_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Left).Location = new System.Drawing.Point(0, 28);
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Left).Name = "_TabDocumentPanel_Toolbars_Dock_Area_Left";
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Left).Size = new Size(0, 422);
    this._TabDocumentPanel_Toolbars_Dock_Area_Left.ToolbarsManager = this.ctxMenu;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._TabDocumentPanel_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Right).Location = new System.Drawing.Point(279, 28);
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Right).Name = "_TabDocumentPanel_Toolbars_Dock_Area_Right";
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Right).Size = new Size(0, 422);
    this._TabDocumentPanel_Toolbars_Dock_Area_Right.ToolbarsManager = this.ctxMenu;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._TabDocumentPanel_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Top).Location = new System.Drawing.Point(0, 0);
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Top).Name = "_TabDocumentPanel_Toolbars_Dock_Area_Top";
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Top).Size = new Size(279, 28);
    this._TabDocumentPanel_Toolbars_Dock_Area_Top.ToolbarsManager = this.ctxMenu;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._TabDocumentPanel_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Bottom).Location = new System.Drawing.Point(0, 450);
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Bottom).Name = "_TabDocumentPanel_Toolbars_Dock_Area_Bottom";
    ((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Bottom).Size = new Size(279, 0);
    this._TabDocumentPanel_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ctxMenu;
    this.DragDropExtenderUserTree.DropTarget = (System.Windows.Forms.Control) this.trvUser;
    this.DragDropExtenderEntityTree.DropTarget = (System.Windows.Forms.Control) this.trvEntity;
    this.ds.DataSetName = "dsDocumentPanel";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.BackColor = Color.White;
    this.Controls.Add((System.Windows.Forms.Control) this.pnlDisassociated);
    this.Controls.Add((System.Windows.Forms.Control) this.Splitter1);
    this.Controls.Add((System.Windows.Forms.Control) this.pnlAssociated);
    this.Controls.Add((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Left);
    this.Controls.Add((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Right);
    this.Controls.Add((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((System.Windows.Forms.Control) this._TabDocumentPanel_Toolbars_Dock_Area_Top);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (TabDocumentPanel);
    this.Size = new Size(279, 450);
    ((System.Windows.Forms.Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((System.Windows.Forms.Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.pbPreview).EndInit();
    ((System.Windows.Forms.Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((System.Windows.Forms.Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.trvEntity).EndInit();
    ((ISupportInitialize) this.pnlAssociated).EndInit();
    ((System.Windows.Forms.Control) this.pnlAssociated).ResumeLayout(false);
    ((System.Windows.Forms.Control) this.pnlAssociated).PerformLayout();
    ((ISupportInitialize) this.txtFilterAssoc).EndInit();
    ((ISupportInitialize) this.chkEntityOnly).EndInit();
    this.panelLoading.ResumeLayout(false);
    this.panelLoading.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.pnlDisassociated).EndInit();
    ((System.Windows.Forms.Control) this.pnlDisassociated).ResumeLayout(false);
    ((System.Windows.Forms.Control) this.pnlDisassociated).PerformLayout();
    ((ISupportInitialize) this.TabControl1).EndInit();
    ((System.Windows.Forms.Control) this.TabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.trvUser).EndInit();
    ((ISupportInitialize) this.ctxMenu).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  protected virtual void ClientTriggerTransfer(
    TabDocumentPanel.FileNode fileNodeDropped,
    Guid ControlGuid,
    int FolderID)
  {
  }

  public int PreferredPosition => 3;

  public void AfterLogon()
  {
    DocumentManager.EntityDocumentCollectionChanged += new EventHandler(this.DocumentManager_EntityCollectionChanged);
    DocumentManager.UserDocumentCollectionChanged += new EventHandler(this.DocumentManager_UserCollectionChanged);
  }

  public void BeforeLogOut()
  {
    DocumentManager.EntityDocumentCollectionChanged -= new EventHandler(this.DocumentManager_EntityCollectionChanged);
    DocumentManager.UserDocumentCollectionChanged -= new EventHandler(this.DocumentManager_UserCollectionChanged);
  }

  public DockWindowCreationInfo CreationInfo
  {
    get
    {
      if (this._creationInfo == null)
        this._creationInfo = new DockWindowCreationInfo(nameof (TabDocumentPanel), "Documents", (DockedLocation) 1, "LeftGroupKey", ImageCache.Instance.DocMain, false);
      return this._creationInfo;
    }
  }

  public void InitializeOnSplashLoad()
  {
  }

  void IMdiActivationListener.MDIChildActivating(Form mdiChild)
  {
    this._entityDocs = ObjectFactory.QueryInterface<ISupportDocumentSystem>((object) mdiChild);
    if (this._entityDocs != null)
      ((System.Windows.Forms.Control) this.trvEntity).Enabled = this._entityDocs.AllowAddNewDocument;
    else
      ((System.Windows.Forms.Control) this.trvEntity).Enabled = false;
    this.RefreshTree((UltraTree) this.trvEntity);
    if (this._entityDocs == null)
      return;
    this._entityDocs.EntityInfoChanged += new ISupportDocumentSystem.EntityInfoChangedEventHandler(this.entityDocs_EntityChanged);
  }

  void IMdiActivationListener.MDIChildDeActivate(Form mdiChild)
  {
    if (this._entityDocs == null)
      return;
    this._entityDocs.EntityInfoChanged -= new ISupportDocumentSystem.EntityInfoChangedEventHandler(this.entityDocs_EntityChanged);
    this.SaveCurrentEntityTreeStructure();
    this._entityDocs = (ISupportDocumentSystem) null;
    ((System.Windows.Forms.Control) this.trvEntity).Enabled = false;
    this.RefreshTree((UltraTree) this.trvEntity);
  }

  private TreeNodeStructureSerializer GetStructureSerializer(UltraTree tree, bool createNew)
  {
    TreeNodeStructureSerializer structureSerializer = (TreeNodeStructureSerializer) null;
    if (this._entityDocs != null && this._entityDocs.AllowAddNewDocument && this._entityDocs.EntityGuid != Guid.Empty)
    {
      string key = ((System.Windows.Forms.Control) tree).Name + this._entityDocs.EntityGuid.ToString();
      if (this._structureCache.Contains(key, (string) null))
        structureSerializer = (TreeNodeStructureSerializer) this._structureCache[key];
      else if (createNew)
      {
        this._structureCache.Add(key, (object) new TreeNodeStructureSerializer(tree), DateTimeOffset.Now.AddMinutes(1.0));
        structureSerializer = (TreeNodeStructureSerializer) this._structureCache[key];
      }
    }
    else if (createNew)
      structureSerializer = new TreeNodeStructureSerializer(tree);
    return structureSerializer;
  }

  private void LoadEntityStructure(Guid entityGuid)
  {
    this.GetStructureSerializer((UltraTree) this.trvEntity, false)?.ApplyStructure();
  }

  private void SaveCurrentEntityTreeStructure() => this.SaveCurrentEntityTreeStructure(true);

  private void SaveCurrentEntityTreeStructure(bool saveCurrentNode)
  {
    this.GetStructureSerializer((UltraTree) this.trvEntity, true)?.SaveStructure(saveCurrentNode);
  }

  private void entityDocs_EntityChanged(object sender, EventArgs e)
  {
    if (this.ShowFoldersOnEntityChange())
    {
      Preferences.SetPreference("DockingTabs.Documents.AssociatedDocs.ShowFolders", true);
      Preferences.SetPreference("DockingTabs.Documents.DisassociatedDocs.ShowFolders", true);
    }
    this._entityDocs = sender as ISupportDocumentSystem;
    this.RefreshTree((UltraTree) this.trvEntity);
    ((System.Windows.Forms.Control) this.trvEntity).Enabled = this._entityDocs != null && this._entityDocs.AllowAddNewDocument;
    this.lnkAddEntityDoc.Enabled = this._entityDocs != null && this._entityDocs.AllowAddNewDocument;
  }

  private bool ShowFoldersOnEntityChange()
  {
    int preferenceInt = Preferences.GetPreferenceInt("DockingTabs.Documents.ShowFoldersOnEntityChange.Override");
    return preferenceInt != -1 ? preferenceInt != 0 : MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DockingTabs.Documents.ShowFoldersOnEntityChange", true);
  }

  private void TabDocumentPanel_Load(object sender, EventArgs e)
  {
    this.cnSql.ConnectionString = CurrentUser.Instance.ConnectionString;
    string str = MGATempFolder.MGATempPath + "Watched Files";
    if (!Directory.Exists(str))
      Directory.CreateDirectory(str);
    ((UltraToggleEditorBase) this.chkEntityOnly).Checked = Preferences.GetPreferenceBool("DockingTabs.Documents.AssociatedDocs.FilterEntitiesOnly");
    this._fileWatcher = new MGASystems.Common.FileSystemObserver.FileSystemObserver(str, true);
    this._fileWatcher.ChangedEvent += new FileSystemEvent(this.FileModified);
    this._fileWatcher.RenamedEvent += new FileSystemRenameEvent(this.FileRenamed);
    this._fileWatcher.Start();
    this.trvUser.Override.SortComparer = (IComparer) this.UserDocsSortInfo;
    this.trvUser.Override.Sort = this.UserDocsSortInfo.SortAsc ? (SortType) 1 : (SortType) 2;
    this.trvEntity.Override.SortComparer = (IComparer) this.EntityDocsSortInfo;
    this.trvEntity.Override.Sort = this.EntityDocsSortInfo.SortAsc ? (SortType) 1 : (SortType) 2;
    this.ctxMenu.MenuAnimationStyle = !SystemInformation.TerminalServerSession ? (MenuAnimationStyle) 4 : (MenuAnimationStyle) 0;
    this.RefreshTree((UltraTree) this.trvEntity);
    this.RefreshTree((UltraTree) this.trvUser);
    this._userTreeDragDropHelper = new TabDocumentPanel.TreeDragDropHelper((UltraTree) this.trvUser, this);
    this._entityTreeDragDropHelper = new TabDocumentPanel.TreeDragDropHelper((UltraTree) this.trvEntity, this);
    this.ctxMenu.Toolbars[0].Visible = false;
    ((System.Windows.Forms.Control) this.pnlAssociated).Height = Preferences.GetPreferenceInt("DockingTabs.Documents.AssociatedDocs.Height");
    MDIControls.Instance.MDIParent.FormClosing += new FormClosingEventHandler(this.MdiParent_Closing);
    this._showDocumentTypes = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DocumentSystem.ShowDocumentTypes");
    this._enableDocuSign = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableDocuSign");
    this._canReplaceAdobePage = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DocumentSystem.CanReplaceAdobePage");
  }

  private void MdiParent_Closing(object sender, FormClosingEventArgs e)
  {
    MDIControls.Instance.MDIParent.FormClosing -= new FormClosingEventHandler(this.MdiParent_Closing);
    Preferences.SetPreference("DockingTabs.Documents.AssociatedDocs.Height", ((System.Windows.Forms.Control) this.pnlAssociated).Height);
  }

  private void FileRenamed(string oldFullPath, string oldName, string fullPath, string name)
  {
    string fileName = Path.GetFileName(fullPath);
    string str = Path.GetExtension(fileName);
    string[] collection = new string[3]
    {
      ".doc",
      ".docx",
      ".xlsx"
    };
    List<string> stringList = new List<string>();
    stringList.AddRange((IEnumerable<string>) collection);
    if (!stringList.Contains(str) || fileName.StartsWith("~") || TabDocumentPanel.WatchedFiles == null || !TabDocumentPanel.WatchedFiles.ContainsKey(fullPath))
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.FileModified), (object) fullPath);
  }

  private void FileModified(string fullPath)
  {
    if (TabDocumentPanel.WatchedFiles == null || string.IsNullOrEmpty(Path.GetExtension(Path.GetFileName(fullPath))) || !TabDocumentPanel.WatchedFiles.ContainsKey(fullPath) || this._changedFiles.Contains(fullPath))
      return;
    this._changedFiles.Add(fullPath);
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.FileModified), (object) fullPath);
  }

  private void FileModified(object fp)
  {
    string str1 = (string) fp;
    if (this.InvokeRequired)
    {
      this.BetterInvoke((Delegate) new TabDocumentPanel.FileModifiedHandler(this.FileModified), (object) str1);
    }
    else
    {
      if (string.Compare(Path.GetExtension(str1), ".msg", true) == 0)
        return;
      if (MessageBox.Show((IWin32Window) MDIControls.Instance.MDIParent, Path.GetFileName(str1) + " was modified outside of the IMS.\n\nWould you like to save the revised copy to the document system?", "Document Modified", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        Guid watchedFile = TabDocumentPanel.WatchedFiles[str1];
        string str2 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("DockingTabs.Documents.FileName.RevisionMarker", " - Revised");
        string preferenceString = Preferences.GetPreferenceString("DockingTabs.Documents.FileName.RevisionMarker");
        if (!string.IsNullOrEmpty(preferenceString))
          str2 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(preferenceString.Trim(), "", false) != 0 ? preferenceString : "";
        string str3 = Path.GetFileNameWithoutExtension(str1) + str2;
        while (true)
        {
          str3 = Interaction.InputBox("Please select a filename for this revised document (do not include the file extension):", "Revised Filename", str3) + Path.GetExtension(str1);
          if (str3.IndexOfAny(DocumentManager.GetInvalidFileNameChars()) != -1)
          {
            StringBuilder stringBuilder = new StringBuilder("The following characters are not allowed in a filename:\n\n");
            char[] invalidFileNameChars = DocumentManager.GetInvalidFileNameChars();
            int index = 0;
            while (index < invalidFileNameChars.Length)
            {
              char ch = invalidFileNameChars[index];
              stringBuilder.Append(Conversions.ToString(ch) + " ");
              checked { ++index; }
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            int num = (int) MessageBox.Show(stringBuilder.ToString(), "Invalid Filename", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
            break;
        }
        if (File.Exists(str3))
          File.Delete(str3);
        File.Copy(str1, str3);
        if (Conversions.ToInteger(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DSG", new object[2]
        {
          (object) "@DSG",
          (object) watchedFile
        })) == 0)
        {
          DocumentManager.BeginFileAdd(str3);
        }
        else
        {
          Guid guid = Guid.NewGuid();
          this._uploadedFiles.Add(guid, watchedFile);
          DocumentManager.BeginFileAddWithBind(new DocumentManager.FileAddedAndBound(this.FileAddedAndBound), str3, (ISupportDocumentSystem) new Document(watchedFile), guid);
        }
      }
      this._changedFiles.Remove(str1);
    }
  }

  private void FileAddedAndBound(Guid newDocSystemGuid)
  {
    DocumentManager.CopyAssociations(this._uploadedFiles[newDocSystemGuid], newDocSystemGuid);
  }

  private static Dictionary<string, Guid> WatchedFiles => TabDocumentPanel._watchedFiles;

  public static void AddFileWatch(string fullPath, Guid documentStoreGuid)
  {
    if (TabDocumentPanel.WatchedFiles == null)
      TabDocumentPanel._watchedFiles = new Dictionary<string, Guid>();
    if (TabDocumentPanel.WatchedFiles.ContainsKey(fullPath))
      return;
    TabDocumentPanel.WatchedFiles.Add(fullPath, documentStoreGuid);
  }

  private void DocumentManager_UserCollectionChanged(object sender, EventArgs e)
  {
    this.RefreshTree((UltraTree) this.trvUser);
  }

  private void DocumentManager_EntityCollectionChanged(object sender, EventArgs e)
  {
    if (this._entityDocs == null)
      return;
    this.RefreshTree((UltraTree) this.trvEntity);
  }

  private static string ParseSortCriteria(TabDocumentPanel.SortCriteria criteria)
  {
    string str1 = Enum.GetName(typeof (TabDocumentPanel.SortCriteria), (object) criteria).Replace("Meta", "");
    StringBuilder stringBuilder = new StringBuilder();
    bool flag = true;
    string str2 = str1;
    int index = 0;
    while (index < str2.Length)
    {
      char c = str2[index];
      if (!flag && char.IsUpper(c))
        stringBuilder.Append(" ");
      stringBuilder.Append(c);
      flag = false;
      checked { ++index; }
    }
    return stringBuilder.ToString();
  }

  private void SetSortDescription(
    TabDocumentPanel.SortCriteria criteria,
    SortType direction,
    UltraTree tree)
  {
    string sortCriteria = TabDocumentPanel.ParseSortCriteria(criteria);
    string str = string.Empty;
    switch ((int) direction)
    {
      case 0:
        str = "Def";
        break;
      case 1:
        str = "Asc";
        break;
      case 2:
        str = "Desc";
        break;
      case 3:
        str = "None";
        break;
    }
    if (tree == this.trvEntity)
    {
      if (string.IsNullOrEmpty(this.associatedTitleText))
        this.associatedTitleText = this.pnlAssociated.Text;
      this.pnlAssociated.Text = $"{this.associatedTitleText} ({sortCriteria} {str})";
    }
    else
    {
      if (string.IsNullOrEmpty(this.unassociatedTitleText))
        this.unassociatedTitleText = this.pnlDisassociated.Text;
      this.pnlDisassociated.Text = $"{this.unassociatedTitleText} ({sortCriteria} {str})";
    }
  }

  private void RepositionNode(UltraTree tree)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new TabDocumentPanel.RepositionNodeHandler(this.RepositionNode), (object) tree);
    }
    else
    {
      for (int index = tree.Nodes.Count - 1; index >= 0; index += -1)
      {
        if (tree.Nodes[index] is TabDocumentPanel.FolderNode node && node.ParentFolderID != null)
        {
          UltraTreeNode nodeByKey = tree.GetNodeByKey(node.ParentFolderID);
          try
          {
            if (nodeByKey != null)
              node.Reposition(nodeByKey.Nodes);
          }
          catch (ArgumentException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
          }
          catch (NullReferenceException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
          }
        }
      }
    }
  }

  private void ResetFolders() => this.ds.tblDocumentFolders.Clear();

  public void PopulateFolders(UltraTree tree, int? parentFolderId)
  {
    try
    {
      bool flag1 = tree == this.trvEntity && this.ShouldEnableFolderFiltering();
      List<TabDocumentPanel.FolderNode> folderNodes = new List<TabDocumentPanel.FolderNode>();
      if (tree == this.trvEntity && this._entityDocs == null || ((UltraControlBase) tree).IsUpdating)
        return;
      ((UltraControlBase) tree).BeginUpdate();
      if (!parentFolderId.HasValue && tree.Nodes.Count > 0 || this.ds.tblDocumentFolders.Count == 0)
        tree.Nodes.Clear();
      if (this.ds.tblDocumentFolders.Count == 0)
        DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daGetFolders, (DataTable) this.ds.tblDocumentFolders);
      StringBuilder stringBuilder = new StringBuilder("ParentFolderId ");
      bool flag2 = false;
      if (parentFolderId.HasValue)
      {
        UltraTreeNode nodeByKey = tree.GetNodeByKey(parentFolderId.Value.ToString());
        if (nodeByKey.Nodes.Count == 1 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(nodeByKey.Nodes[0].Text, "PLACEHOLDER", false) == 0)
          nodeByKey.Nodes.RemoveAt(0);
        if (nodeByKey.Nodes.Count == 0)
        {
          stringBuilder.Append("= ");
          stringBuilder.Append(parentFolderId.Value);
        }
        else
          flag2 = true;
      }
      else
        stringBuilder.Append("is null");
      if (!flag2)
      {
        DataRow[] dataRowArray = this.ds.tblDocumentFolders.Select(stringBuilder.ToString());
        int index = 0;
        while (index < dataRowArray.Length)
        {
          dsDocumentPanel.tblDocumentFoldersRow row = (dsDocumentPanel.tblDocumentFoldersRow) dataRowArray[index];
          TabDocumentPanel.FolderNode folderNode = new TabDocumentPanel.FolderNode(row);
          try
          {
            tree.Nodes.Add((UltraTreeNode) folderNode);
            if (this.ds.tblDocumentFolders.Select("parentFolderId = " + Conversions.ToString(row.FolderID)).Length > 0)
              folderNode.Nodes.Add(Guid.NewGuid().ToString(), "PLACEHOLDER");
          }
          catch (NullReferenceException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
          }
          folderNodes.Add(folderNode);
          checked { ++index; }
        }
      }
      this.RepositionNode(tree);
      if (flag1)
        this.FilterFoldersBasedOnEntity(tree, folderNodes);
      this.FilterFoldersBasedOnSecurity(tree, folderNodes);
    }
    finally
    {
      ((UltraControlBase) tree).EndUpdate();
    }
  }

  private bool ShouldEnableFolderFiltering()
  {
    bool flag = Preferences.GetPreferenceBool("DockingTabs.Documents.AssociatedDocs.FilterFoldersByEntity");
    if (!flag && !SecurityManager.Instance.AssertPermission("{60C00A7E-2D44-4108-B607-7F48FBEE7897}"))
      flag = true;
    return flag;
  }

  private bool ShouldShowEntityFolders()
  {
    bool flag = Preferences.GetPreferenceBool("DockingTabs.Documents.AssociatedDocs.ShowFolders");
    if (!flag && !SecurityManager.Instance.AssertPermission("{242C8238-6072-4c25-9B3E-C07D4206CA8C}"))
      flag = true;
    return flag;
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  private void TableQueryCompleted_Files(object sender, TableQueryMultithreadEventArgs e)
  {
    if (this.InvokeRequired)
      throw new ThreadStateException("Must be on the UI thread when calling TableQueryCompleted_Files");
    if (this._entityDocs is IMultiPolicyDisplay entityDocs && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._entityDocs.RecreateTypeName, "MGASystems.IMS.Policies.frmSubmissionGroup", false) == 0)
    {
      // ISSUE: variable of a compiler-generated type
      TabDocumentPanel._Closure\u0024__209\u002D0 closure2090_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      TabDocumentPanel._Closure\u0024__209\u002D0 closure2090_2 = new TabDocumentPanel._Closure\u0024__209\u002D0(closure2090_1);
      // ISSUE: reference to a compiler-generated field
      closure2090_2.\u0024VB\u0024Local_visibleControls = entityDocs.GetVisibleControlGuids();
      // ISSUE: reference to a compiler-generated field
      if (closure2090_2.\u0024VB\u0024Local_visibleControls != null && e.Table.Columns.Contains("ControlGuid"))
      {
        EnumerableRowCollection<DataRow> source = e.Table.AsEnumerable();
        System.Func<DataRow, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (TabDocumentPanel._Closure\u0024__.\u0024I209\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = TabDocumentPanel._Closure\u0024__.\u0024I209\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          TabDocumentPanel._Closure\u0024__.\u0024I209\u002D0 = predicate = (System.Func<DataRow, bool>) ([SpecialName] (row) => row.Field<Guid?>("ControlGuid").HasValue);
        }
        // ISSUE: reference to a compiler-generated method
        List<DataRow> list = source.Where<DataRow>(predicate).Where<DataRow>(new System.Func<DataRow, bool>(closure2090_2._Lambda\u0024__1)).ToList<DataRow>();
        Action<DataRow> action;
        // ISSUE: reference to a compiler-generated field
        if (TabDocumentPanel._Closure\u0024__.\u0024I209\u002D2 != null)
        {
          // ISSUE: reference to a compiler-generated field
          action = TabDocumentPanel._Closure\u0024__.\u0024I209\u002D2;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          TabDocumentPanel._Closure\u0024__.\u0024I209\u002D2 = action = (Action<DataRow>) ([SpecialName] (row) => row.Delete());
        }
        list.ForEach(action);
        e.Table.AcceptChanges();
      }
    }
    object[] key = (object[]) e.Key;
    UltraTree tree = (UltraTree) key[0];
    bool flag1 = (bool) key[1];
    bool flag2 = tree != this.trvEntity ? Preferences.GetPreferenceBool("DockingTabs.Documents.DisassociatedDocs.ShowFolders") : this.ShouldShowEntityFolders();
    try
    {
      ((UltraControlBase) tree).BeginUpdate();
      try
      {
        foreach (DataRow row in e.Table.Rows)
        {
          if (tree == this.trvEntity)
          {
            if (this._entityDocs == null)
            {
              this.panelLoading.Visible = false;
              return;
            }
            try
            {
              // ISSUE: variable of a boxed type
              __Boxed<Guid> entityGuid = (System.ValueType) this._entityDocs.EntityGuid;
              if (this._entityDocs != null)
              {
                if (!this._entityDocs.EntityGuid.Equals(RuntimeHelpers.GetObjectValue(row["EntityGuid"])))
                {
                  if (this._entityDocs.HasControlGUID)
                  {
                    if (!this._entityDocs.ControlGUID.Equals(RuntimeHelpers.GetObjectValue(row["EntityGuid"])))
                      continue;
                  }
                  else
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          TabDocumentPanel.FileNode node = new TabDocumentPanel.FileNode(row, ((System.Windows.Forms.Control) tree).Name);
          if (tree == this.trvEntity && !this.nodeKeyList.Contains(node.Key))
            this.nodeKeyList.Add(node.Key);
          if (flag2)
          {
            if (node.HasFolderID)
            {
              UltraTreeNode nodeByKey = tree.GetNodeByKey(node.FolderID);
              if (nodeByKey == null)
              {
                if (this.ds.tblDocumentFolders.FindByFolderID(Conversions.ToInteger(node.FolderID)) == null)
                {
                  if (tree.GetNodeByKey(node.Key) == null)
                  {
                    try
                    {
                      if (tree == this.trvEntity)
                        node.Visible = this.IsNodeVisible((UltraTreeNode) node);
                      if (tree == this.trvEntity && ((UltraToggleEditorBase) this.chkEntityOnly).Checked)
                      {
                        if (!row.IsNull("EntityGuid"))
                        {
                          object obj = row["EntityGuid"];
                          Guid guid = obj != null ? (Guid) obj : new Guid();
                          if (this._entityDocs != null)
                          {
                            if (this._entityDocs.EntityGuid == guid)
                              tree.Nodes.Add((UltraTreeNode) node);
                          }
                        }
                      }
                      else
                        tree.Nodes.Add((UltraTreeNode) node);
                    }
                    catch (NullReferenceException ex)
                    {
                      ProjectData.SetProjectError((Exception) ex);
                      ProjectData.ClearProjectError();
                    }
                  }
                }
              }
              else if (tree.GetNodeByKey(node.Key) == null && (nodeByKey.Nodes.Count != 1 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(nodeByKey.Nodes[0].Text, "PLACEHOLDER", false) != 0))
              {
                try
                {
                  if (tree == this.trvEntity)
                    node.Visible = this.IsNodeVisible((UltraTreeNode) node);
                  nodeByKey.Nodes.Add((UltraTreeNode) node);
                  if (!nodeByKey.Visible)
                  {
                    if (nodeByKey is TabDocumentPanel.FolderNode folderNode)
                    {
                      if (SecurityManager.Instance.AssertPermission(folderNode.SecureResourceGuid))
                        nodeByKey.Visible = true;
                    }
                    else
                      nodeByKey.Visible = true;
                  }
                }
                catch (NullReferenceException ex)
                {
                  ProjectData.SetProjectError((Exception) ex);
                  ProjectData.ClearProjectError();
                }
              }
            }
            else if (tree.GetNodeByKey(node.Key) == null)
            {
              try
              {
                if (tree == this.trvEntity)
                  node.Visible = this.IsNodeVisible((UltraTreeNode) node);
                if (tree == this.trvEntity && ((UltraToggleEditorBase) this.chkEntityOnly).Checked)
                {
                  if (!row.IsNull("EntityGuid"))
                  {
                    object obj = row["EntityGuid"];
                    Guid guid = obj != null ? (Guid) obj : new Guid();
                    if (this._entityDocs != null)
                    {
                      if (this._entityDocs.EntityGuid == guid)
                        tree.Nodes.Add((UltraTreeNode) node);
                    }
                  }
                }
                else
                  tree.Nodes.Add((UltraTreeNode) node);
              }
              catch (NullReferenceException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                ProjectData.ClearProjectError();
              }
            }
          }
          else if (tree.GetNodeByKey(node.Key) == null)
          {
            try
            {
              if (tree == this.trvEntity)
                node.Visible = this.IsNodeVisible((UltraTreeNode) node);
              if (tree == this.trvEntity && ((UltraToggleEditorBase) this.chkEntityOnly).Checked)
              {
                if (!row.IsNull("EntityGuid"))
                {
                  object obj = row["EntityGuid"];
                  Guid guid = obj != null ? (Guid) obj : new Guid();
                  if (this._entityDocs != null)
                  {
                    if (this._entityDocs.EntityGuid == guid)
                      tree.Nodes.Add((UltraTreeNode) node);
                  }
                }
              }
              else
                tree.Nodes.Add((UltraTreeNode) node);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.AddPinnedDocuments(tree);
      this.RemoveHiddenNodes(tree, tree.Nodes);
      tree.Refresh();
    }
    finally
    {
      ((UltraControlBase) tree).EndUpdate();
    }
    if (this._entityDocs != null && this._entityDocs.CanReCreateEntity)
    {
      if (!flag1)
      {
        try
        {
          this.LoadEntityStructure(this._entityDocs.EntityGuid);
        }
        catch (NullReferenceException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    this.panelLoading.Visible = false;
    try
    {
      if (this._entityDocs == null || !this._entityDocs.AllowAddNewDocument)
        return;
      this.LoadEntityStructure(this._entityDocs.EntityGuid);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void FilterFoldersBasedOnSecurity(
    UltraTree tree,
    List<TabDocumentPanel.FolderNode> folderNodes)
  {
    if (this._entityDocs == null || !(this._entityDocs is System.Windows.Forms.Control) && !(this._entityDocs is System.Windows.Controls.UserControl))
      return;
    try
    {
      foreach (TabDocumentPanel.FolderNode folderNode in folderNodes)
      {
        if (!SecurityManager.Instance.AssertPermission(folderNode.SecureResourceGuid))
          folderNode.Visible = false;
      }
    }
    finally
    {
      List<TabDocumentPanel.FolderNode>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void FilterFoldersBasedOnEntity(
    UltraTree tree,
    List<TabDocumentPanel.FolderNode> folderNodes)
  {
    string entityFilter = frmFetchDoc.GetEntityFilter();
    if (string.IsNullOrEmpty(entityFilter))
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT FolderID FROM tblDocumentFolderTypes (NOLOCK) WHERE AssociatedEntityType = @EntityTypeName", new object[2]
    {
      (object) "@EntityTypeName",
      (object) entityFilter
    });
    try
    {
      foreach (TabDocumentPanel.FolderNode folderNode in folderNodes)
      {
        if (dataTable.Select($"FolderID = {folderNode.Key}").Length == 0)
          folderNode.Visible = false;
      }
    }
    finally
    {
      List<TabDocumentPanel.FolderNode>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void RemoveHiddenNodes(UltraTree tree, TreeNodesCollection nodes)
  {
    for (int index = nodes.Count - 1; index >= 0; index += -1)
    {
      if (nodes[index] is TabDocumentPanel.FolderNode)
      {
        if (!nodes[index].Visible)
          nodes[index].Remove();
        else
          this.RemoveHiddenNodes(tree, nodes[index].Nodes);
      }
    }
  }

  private void RevealParentNodes(UltraTreeNode node)
  {
    if (node == null)
      return;
    if (!node.Visible)
      node.Visible = true;
    this.RevealParentNodes(node.Parent);
  }

  private void RefreshTree(UltraTree tree)
  {
    if (tree == null)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new TabDocumentPanel.RefreshTreeHandler(this.RefreshTree), (object) tree);
    }
    else
    {
      if (tree == this.trvEntity)
      {
        this.panelLoading.Visible = true;
        this.nodeKeyList.Clear();
      }
      if (tree != null && tree.Nodes.Count > 0)
        tree.Nodes.Clear();
      if (tree == this.trvEntity)
      {
        if (this.ShouldShowEntityFolders())
          this.PopulateFolders(tree, new int?());
        this.AfterFoldersPopulated(tree, new int?());
      }
      else
      {
        if (Preferences.GetPreferenceBool("DockingTabs.Documents.DisassociatedDocs.ShowFolders"))
          this.PopulateFolders(tree, new int?());
        this.AfterFoldersPopulated(tree, new int?());
      }
    }
  }

  private void AddPinnedDocuments(UltraTree tree)
  {
    if (tree == this.trvEntity)
      return;
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("GetPinnedDocumentsByUser", (object) "@UserGuid", (object) CurrentUser.Instance.UserGUID);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        TabDocumentPanel.FileNode fileNode = new TabDocumentPanel.FileNode(row, true, ((System.Windows.Forms.Control) tree).Name);
        if (tree.GetNodeByKey(fileNode.Key) == null)
          tree.Nodes.Add((UltraTreeNode) fileNode);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void AfterFoldersPopulated(UltraTree tree, int? fromExpandFolderID)
  {
    TabDocumentPanel tabDocumentPanel = this;
    UltraTree tree1 = tree;
    int? fromExpandFolderID1 = fromExpandFolderID;
    bool hasValue = fromExpandFolderID1.HasValue;
    string str = "";
    List<TabDocumentPanel.FolderNode> list1 = ((IEnumerable) tree1.Nodes).OfType<TabDocumentPanel.FolderNode>().ToList<TabDocumentPanel.FolderNode>();
    if (list1.Any<TabDocumentPanel.FolderNode>())
    {
      List<TabDocumentPanel.FolderNode> source1 = list1;
      System.Func<TabDocumentPanel.FolderNode, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (TabDocumentPanel._Closure\u0024__.\u0024I217\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = TabDocumentPanel._Closure\u0024__.\u0024I217\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        TabDocumentPanel._Closure\u0024__.\u0024I217\u002D0 = predicate = (System.Func<TabDocumentPanel.FolderNode, bool>) ([SpecialName] (node) => node.Expanded);
      }
      IEnumerable<TabDocumentPanel.FolderNode> source2 = source1.Where<TabDocumentPanel.FolderNode>(predicate);
      System.Func<TabDocumentPanel.FolderNode, int> selector1;
      // ISSUE: reference to a compiler-generated field
      if (TabDocumentPanel._Closure\u0024__.\u0024I217\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector1 = TabDocumentPanel._Closure\u0024__.\u0024I217\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        TabDocumentPanel._Closure\u0024__.\u0024I217\u002D1 = selector1 = (System.Func<TabDocumentPanel.FolderNode, int>) ([SpecialName] (node) => Conversions.ToInteger(node.FolderID));
      }
      List<int> list2 = source2.Select<TabDocumentPanel.FolderNode, int>(selector1).ToList<int>();
      if (fromExpandFolderID1.HasValue && !list2.Contains(fromExpandFolderID1.Value))
        list2.Add(fromExpandFolderID1.Value);
      XName name = (XName) "ExpandedFolders";
      List<int> source3 = list2;
      System.Func<int, XElement> selector2;
      // ISSUE: reference to a compiler-generated field
      if (TabDocumentPanel._Closure\u0024__.\u0024I217\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector2 = TabDocumentPanel._Closure\u0024__.\u0024I217\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        TabDocumentPanel._Closure\u0024__.\u0024I217\u002D2 = selector2 = (System.Func<int, XElement>) ([SpecialName] (folderID) => new XElement((XName) "ExpandedFolderID", (object) folderID));
      }
      IEnumerable<XElement> content = source3.Select<int, XElement>(selector2);
      str = new XElement(name, (object) content).ToString();
    }
    else
      str = "";
    if (str == null)
      str = "";
    if (tree1 == this.trvEntity)
    {
      if (this._entityDocs == null || !this._entityDocs.AllowAddNewDocument || this._entityDocs.EntityGuid.Equals(Guid.Empty))
      {
        this.panelLoading.Visible = false;
      }
      else
      {
        DocSupportCache docSupportCache = (DocSupportCache) null;
        try
        {
          docSupportCache = new DocSupportCache(this._entityDocs);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentHandleError(ex);
          this.panelLoading.Visible = false;
          ProjectData.ClearProjectError();
          return;
        }
        if (Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("DocumentSystem_FetchControlFilters", new object[4]
        {
          (object) "@userGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@entityGuid",
          (object) docSupportCache.EntityGUID
        })), 0) != 0)
        {
          this.panelLoading.Visible = false;
          if (closure_2.HasValue)
          {
            UltraTreeNode nodeByKey = closure_1.GetNodeByKey(closure_2.ToString());
            if (nodeByKey != null && ((SubObjectBase) nodeByKey).Tag != null)
            {
              nodeByKey.Text = Conversions.ToString(((SubObjectBase) nodeByKey).Tag);
              ((SubObjectBase) nodeByKey).Tag = (object) null;
            }
          }
          if (!SecurityManager.Instance.AssertPermission("{D3C6588D-56C9-4F1A-8F49-9C5CF6CCA93B}"))
            return;
        }
        if (docSupportCache.HasControlGUID && !((UltraToggleEditorBase) this.chkEntityOnly).Checked)
        {
          if (string.IsNullOrWhiteSpace(closure_0))
          {
            Database.Instance.QueryMultithreadedSP.PerformTableQuery(ThreadPriority.BelowNormal, new TableQueryMultithreadEventHandler(this.TableQueryCompleted_Files), (System.Windows.Forms.Control) MDIControls.Instance.MDIParent, (object) new object[2]
            {
              (object) closure_1,
              (object) hasValue
            }, "DocumentSystem_FetchDocInfoEntityWithControl", (object) "@ControlGUID", (object) docSupportCache.ControlGUID, (object) "@EntityGUID", (object) docSupportCache.EntityGUID);
            Log.Write("Refreshing Docs On Entity: DocumentSystem_FetchDocInfoEntityWithControl", "DocumentSystem.DocumentPanel.Performance");
          }
          else
          {
            Utility.ExecuteThread((DoWorkEventHandler) ([SpecialName] (etSender, etArgs) => etArgs.Result = (object) DefaultDatabase.ExecuteDataSet("DocumentSystem_FetchDocInfoEntityWithControl2", new object[6]
            {
              (object) "@ControlGUID",
              (object) docSupportCache.ControlGUID,
              (object) "@EntityGUID",
              (object) docSupportCache.EntityGUID,
              (object) "@folderIDs",
              (object) closure_0
            })), (RunWorkerCompletedEventHandler) ([SpecialName] (etSender, etArgs) => tabDocumentPanel.ProcessNodeFiles(tree1, etArgs, fromExpandFolderID1)), (ProgressChangedEventHandler) null);
            Log.Write("Refreshing Docs On Entity: DocumentSystem_FetchDocInfoEntityWithControl2", "DocumentSystem.DocumentPanel.Performance");
          }
        }
        else if (string.IsNullOrWhiteSpace(closure_0))
        {
          Database.Instance.QueryMultithreadedSP.PerformTableQuery(ThreadPriority.BelowNormal, new TableQueryMultithreadEventHandler(this.TableQueryCompleted_Files), (System.Windows.Forms.Control) MDIControls.Instance.MDIParent, (object) new object[2]
          {
            (object) closure_1,
            (object) hasValue
          }, "DocumentSystem_FetchDocInfoEntity", (object) "@EntityGUID", (object) docSupportCache.EntityGUID);
          Log.Write("Refreshing Docs On Entity: DocumentSystem_FetchDocInfoEntity", "DocumentSystem.DocumentPanel.Performance");
        }
        else
        {
          Utility.ExecuteThread((DoWorkEventHandler) ([SpecialName] (etSender, etArgs) => etArgs.Result = (object) DefaultDatabase.ExecuteDataSet("DocumentSystem_FetchDocInfoEntity2", new object[4]
          {
            (object) "@EntityGUID",
            (object) docSupportCache.EntityGUID,
            (object) "@folderIDs",
            (object) closure_0
          })), (RunWorkerCompletedEventHandler) ([SpecialName] (etSender, etArgs) => tabDocumentPanel.ProcessNodeFiles(tree1, etArgs, fromExpandFolderID1)), (ProgressChangedEventHandler) null);
          Log.Write("Refreshing Docs On Entity: DocumentSystem_FetchDocInfoEntity2", "DocumentSystem.DocumentPanel.Performance");
        }
      }
    }
    else if (string.IsNullOrWhiteSpace(str))
    {
      Database.Instance.QueryMultithreadedSP.PerformTableQuery(ThreadPriority.BelowNormal, new TableQueryMultithreadEventHandler(this.TableQueryCompleted_Files), (System.Windows.Forms.Control) MDIControls.Instance.MDIParent, (object) new object[2]
      {
        (object) tree1,
        (object) hasValue
      }, "DocumentSystem_FetchDocInfo", (object) "@UserGuid", (object) CurrentUser.Instance.UserGUID);
      Log.Write("Refreshing Docs On Entity: DocumentSystem_FetchDocInfo", "DocumentSystem.DocumentPanel.Performance");
    }
    else
    {
      Utility.ExecuteThread((DoWorkEventHandler) ([SpecialName] (etSender, etArgs) => etArgs.Result = (object) DefaultDatabase.ExecuteDataSet("DocumentSystem_FetchDocInfo2", new object[4]
      {
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@folderIDs",
        (object) str
      })), (RunWorkerCompletedEventHandler) ([SpecialName] (etSender, etArgs) => tabDocumentPanel.ProcessNodeFiles(tree1, etArgs, fromExpandFolderID1)), (ProgressChangedEventHandler) null);
      Log.Write("Refreshing Docs On Entity: DocumentSystem_FetchDocInfo2", "DocumentSystem.DocumentPanel.Performance");
    }
  }

  private void ProcessNodeFiles(
    UltraTree tree,
    RunWorkerCompletedEventArgs etArgs,
    int? fromExpandFolderID)
  {
    // ISSUE: variable of a compiler-generated type
    TabDocumentPanel._Closure\u0024__218\u002D0 closure2180_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    TabDocumentPanel._Closure\u0024__218\u002D0 closure2180_2 = new TabDocumentPanel._Closure\u0024__218\u002D0(closure2180_1);
    // ISSUE: reference to a compiler-generated field
    closure2180_2.\u0024VB\u0024Local_tree = tree;
    DataSet result = (DataSet) etArgs.Result;
    bool hasValue = fromExpandFolderID.HasValue;
    // ISSUE: reference to a compiler-generated field
    this.TableQueryCompleted_Files((object) this, new TableQueryMultithreadEventArgs(result.Tables[1], (object) new object[2]
    {
      (object) closure2180_2.\u0024VB\u0024Local_tree,
      (object) hasValue
    }));
    // ISSUE: reference to a compiler-generated method
    EnumerableRowCollection<UltraTreeNode> source = result.Tables[0].AsEnumerable().Select<DataRow, UltraTreeNode>(new System.Func<DataRow, UltraTreeNode>(closure2180_2._Lambda\u0024__0));
    System.Func<UltraTreeNode, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (TabDocumentPanel._Closure\u0024__.\u0024I218\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = TabDocumentPanel._Closure\u0024__.\u0024I218\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      TabDocumentPanel._Closure\u0024__.\u0024I218\u002D1 = predicate = (System.Func<UltraTreeNode, bool>) ([SpecialName] (node) => node != null && !node.Expanded && node.Nodes.Count == 0);
    }
    List<UltraTreeNode> list = source.Where<UltraTreeNode>(predicate).ToList<UltraTreeNode>();
    try
    {
      foreach (UltraTreeNode ultraTreeNode in list)
        ultraTreeNode.Nodes.Add(Guid.NewGuid().ToString(), "PLACEHOLDER");
    }
    finally
    {
      List<UltraTreeNode>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (!fromExpandFolderID.HasValue)
      return;
    // ISSUE: reference to a compiler-generated field
    UltraTreeNode nodeByKey = closure2180_2.\u0024VB\u0024Local_tree.GetNodeByKey(fromExpandFolderID.ToString());
    if (nodeByKey == null || ((SubObjectBase) nodeByKey).Tag == null)
      return;
    nodeByKey.Text = Conversions.ToString(((SubObjectBase) nodeByKey).Tag);
    ((SubObjectBase) nodeByKey).Tag = (object) null;
  }

  private void DeleteFolderByID(TabDocumentPanel.FolderNode folder)
  {
    foreach (UltraTreeNode node in folder.Nodes)
    {
      if (node is TabDocumentPanel.FolderNode)
      {
        int num = (int) MessageBox.Show("Please delete the sub folders first", "Cannot delete a folder with sub folders", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }
    }
    int integer = Conversions.ToInteger(folder.FolderID);
    if (FolderManager.GetDocumentCountUnderFolder(integer) > 0)
    {
      int num1 = (int) MessageBox.Show("Cannot remove a folder that contains files on some level or entity", "Unable to delete folder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (!FolderManager.IsFolderDeletable(integer))
    {
      int num2 = (int) MessageBox.Show("This folder is marked for use by automation", "Unable to delete folder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        FolderManager.DeleteFolder(integer);
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (ex.Message.Contains("tblCompanyAutomationDocuments"))
        {
          int num3 = (int) MessageBox.Show("This folder is currently in use by Document Automation and cannot be deleted", "Folder in use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
        }
        else
          throw;
      }
      this.ResetFolders();
      CurrentUser.Instance.LogAction("Delete document folder: " + folder.Text, typeof (TabDocumentPanel).ToString());
      this.RefreshTree((UltraTree) this.trvUser);
      this.RefreshTree((UltraTree) this.trvEntity);
    }
  }

  private void TransferFile()
  {
    if (!(this._workingNode is TabDocumentPanel.FileNode workingNode))
      return;
    using (frmDocumentOwnershipTransfer ownershipTransfer = new frmDocumentOwnershipTransfer(true, workingNode.DocumentGUID))
    {
      int num = (int) ownershipTransfer.ShowDialog();
      this.RefreshTree(workingNode.Control);
    }
  }

  private void AddFile()
  {
    OpenFileDialog openFileDialog1 = this.OpenFileDialog1;
    openFileDialog1.CheckFileExists = true;
    openFileDialog1.CheckPathExists = true;
    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    openFileDialog1.Multiselect = true;
    openFileDialog1.DereferenceLinks = true;
    openFileDialog1.ReadOnlyChecked = true;
    openFileDialog1.ShowReadOnly = false;
    if (openFileDialog1.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) != DialogResult.Cancel)
    {
      string[] fileNames = openFileDialog1.FileNames;
      int index = 0;
      while (index < fileNames.Length)
      {
        string path = fileNames[index];
        if (this.ActiveControl != null && this.ActiveControl == this.trvEntity && this._entityDocs != null && this._entityDocs.AllowAddNewDocument)
          DocumentManager.BeginFileAddWithBind(path, this._entityDocs);
        else
          DocumentManager.BeginFileAdd(path);
        checked { ++index; }
      }
    }
  }

  private void CollapseExpand()
  {
    UltraTreeNode workingNode = this._workingNode;
    if (workingNode == null || !(workingNode is TabDocumentPanel.FolderNode))
      return;
    workingNode.Expanded = !workingNode.Expanded;
  }

  private void Properties()
  {
    if (!(this._workingNode is TabDocumentPanel.FileNode workingNode))
      return;
    using (frmDocumentProperties documentProperties = frmDocumentProperties.Create(workingNode.DocumentGUID))
    {
      int num = (int) documentProperties.ShowDialog();
    }
    this.RefreshTree(workingNode.Control);
  }

  private void NewFolder()
  {
    if (this.ActiveControl == null || !(this.ActiveControl is UltraTree))
      return;
    UltraTree activeControl = (UltraTree) this.ActiveControl;
    UltraTreeNode workingNode = this._workingNode;
    TabDocumentPanel.FolderNode folderNode1;
    if (workingNode != null && workingNode is TabDocumentPanel.FolderNode)
    {
      TabDocumentPanel.FolderNode folderNode2 = new TabDocumentPanel.FolderNode(workingNode.Key);
      folderNode2.Text = TabDocumentPanel.GetNewFolderName(workingNode.Nodes, "New Folder");
      folderNode1 = folderNode2;
      workingNode.Nodes.Add((UltraTreeNode) folderNode1);
    }
    else
    {
      TabDocumentPanel.FolderNode folderNode3 = new TabDocumentPanel.FolderNode();
      folderNode3.Text = TabDocumentPanel.GetNewFolderName(activeControl.Nodes, "New Folder");
      folderNode1 = folderNode3;
      activeControl.Nodes.Add((UltraTreeNode) folderNode1);
    }
    folderNode1.BeginEdit();
  }

  private static string GetNewFolderName(TreeNodesCollection nodes, string requestedName)
  {
    string newFolderName;
    if (nodes.Count == 0)
    {
      newFolderName = requestedName;
    }
    else
    {
      string text = requestedName;
      int num = 1;
      while (TabDocumentPanel.NodeTextExists(nodes, text))
      {
        text = $"{requestedName} ({num})";
        ++num;
      }
      newFolderName = text;
    }
    return newFolderName;
  }

  private static bool NodeTextExists(TreeNodesCollection nodes, string text)
  {
    bool flag;
    foreach (UltraTreeNode node in nodes)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(node.Text, text, false) == 0)
      {
        flag = true;
        goto label_5;
      }
    }
    flag = false;
label_5:
    return flag;
  }

  private void DeleteFolder()
  {
    if (this.ActiveControl == null || !(this.ActiveControl is UltraTree) || !(this._workingNode is TabDocumentPanel.FolderNode workingNode))
      return;
    this.DeleteFolderByID(workingNode);
  }

  private static List<SelectedDocInfo> GetSelectedDocInfo(UltraTree tree)
  {
    List<SelectedDocInfo> selectedDocInfo = new List<SelectedDocInfo>();
    int num = ((DisposableObjectCollectionBase) tree.SelectedNodes).Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (tree.SelectedNodes[index] is TabDocumentPanel.FileNode selectedNode)
        selectedDocInfo.Add(new SelectedDocInfo()
        {
          DocumentGuid = selectedNode.DocumentGUID,
          DocumentName = selectedNode.FileName
        });
    }
    return selectedDocInfo;
  }

  private static Guid[] GetSelectedDocGuids(UltraTree tree)
  {
    List<Guid> guidList = new List<Guid>();
    int num = ((DisposableObjectCollectionBase) tree.SelectedNodes).Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (tree.SelectedNodes[index] is TabDocumentPanel.FileNode selectedNode)
        guidList.Add(selectedNode.DocumentGUID);
    }
    return guidList.ToArray();
  }

  private static int GetPinnedNodeCount(UltraTree tree)
  {
    int pinnedNodeCount;
    foreach (UltraTreeNode node in tree.Nodes)
    {
      if (node is TabDocumentPanel.FileNode fileNode && fileNode.Pinned)
        ++pinnedNodeCount;
    }
    return pinnedNodeCount;
  }

  private static void ViewDescriptions()
  {
    Preferences.SetPreference("DockingTabs.Documents.ShowFileNames", false);
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  private static void ViewMailDateReceived()
  {
    Preferences.SetPreference("DockingTabs.Documents.MailDateStyle", 2);
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  private static void ViewMailDatesent()
  {
    Preferences.SetPreference("DockingTabs.Documents.MailDateStyle", 1);
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  private static void ViewMailDateadded()
  {
    Preferences.SetPreference("DockingTabs.Documents.MailDateStyle", 0);
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  private static void ViewFileNames()
  {
    Preferences.SetPreference("DockingTabs.Documents.ShowFileNames", true);
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  private void Bind()
  {
    if (this.ActiveControl == null || !(this.ActiveControl is UltraTree))
      return;
    UltraTree activeControl = (UltraTree) this.ActiveControl;
    TabDocumentPanel.FileNode workingNode = (TabDocumentPanel.FileNode) this._workingNode;
    if (activeControl == this.trvUser)
    {
      if (((DisposableObjectCollectionBase) activeControl.SelectedNodes).Count == 1)
      {
        DocumentManager.BeginBindDocument(workingNode.DocumentGUID, this._entityDocs);
        this.AddNoteToDocument(workingNode.DocumentGUID);
      }
      else
      {
        Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids(activeControl);
        int num = selectedDocGuids.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (index == selectedDocGuids.Length - 1)
            DocumentManager.BindDocument(selectedDocGuids[index], this._entityDocs, false);
          else
            DocumentManager.BindDocument(selectedDocGuids[index], this._entityDocs, true);
        }
      }
    }
    else
    {
      if (((DisposableObjectCollectionBase) activeControl.SelectedNodes).Count == 1)
      {
        DocumentManager.BeginUnbindDocument(workingNode.DocumentGUID, (IRecreatableEntity) this._entityDocs);
      }
      else
      {
        Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids(activeControl);
        int num = selectedDocGuids.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (index == selectedDocGuids.Length - 1)
            DocumentManager.UnbindDocument(selectedDocGuids[index], (IRecreatableEntity) this._entityDocs, false);
          else
            DocumentManager.UnbindDocument(selectedDocGuids[index], (IRecreatableEntity) this._entityDocs, true);
        }
      }
      CurrentUser.Instance.LogAction("Disassociate Document");
    }
  }

  private void AddNoteToDocument(Guid docGuid)
  {
    if (this._entityDocs == null)
      return;
    using (frmFetchDoc frmFetchDoc = frmFetchDoc.Create(true, this._entityDocs))
    {
      frmFetchDoc.SetAsNoteGenerationDisplayOnly();
      frmFetchDoc.TopMost = true;
      if ((!MDIControls.Instance.MDIParent.InvokeRequired ? frmFetchDoc.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) : frmFetchDoc.ShowDialog()) != DialogResult.OK)
        return;
      ISupportDocumentSystem entityDocs = this._entityDocs;
      NoteSupportCache noteSupport = new NoteSupportCache(entityDocs.EntityGuid, entityDocs.EntityName, entityDocs.FriendlyEntityName, entityDocs.RecreateTypeName, entityDocs.HasControlGUID, entityDocs.ControlGUID);
      Guid boundNote;
      if (frmFetchDoc.NoteAttachment == frmFetchDoc.NoteAttachmentType.Diary)
        boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(-1, "", CurrentUser.Instance.UserGUID, "", false, new Guid[1]
        {
          CurrentUser.Instance.UserGUID
        }, new Guid[1]{ CurrentUser.Instance.UserGUID }, (ISupportNoteSystem) noteSupport, DateAndTime.Now.AddDays(7.0), DateAndTime.Now.AddDays(14.0));
      else if (frmFetchDoc.NoteAttachment == frmFetchDoc.NoteAttachmentType.Note)
        boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(-1, "", CurrentUser.Instance.UserGUID, "", false, new Guid[1]
        {
          CurrentUser.Instance.UserGUID
        }, (ISupportNoteSystem) noteSupport);
      if (frmFetchDoc.NoteAttachment != frmFetchDoc.NoteAttachmentType.None)
        Note_System.Instance.UIInteractive.ViewNote(boundNote, new Guid[1]
        {
          docGuid
        }, this._entityDocs);
      try
      {
        if (!frmFetchDoc.CopyToOtherCardsOnSubmission)
          return;
        if (!this._entityDocs.HasControlGUID)
          return;
        try
        {
          EnumerableRowCollection<DataRow> source = Database.Instance.QuerySP.PerformTableQuery("DocumentSystem_FetchOtherQuotesOnSubmission", (object) "@ControlGuid", (object) this._entityDocs.ControlGUID).AsEnumerable();
          System.Func<DataRow, IRecreatableEntity> selector;
          // ISSUE: reference to a compiler-generated field
          if (TabDocumentPanel._Closure\u0024__.\u0024I237\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector = TabDocumentPanel._Closure\u0024__.\u0024I237\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            TabDocumentPanel._Closure\u0024__.\u0024I237\u002D0 = selector = (System.Func<DataRow, IRecreatableEntity>) ([SpecialName] (row) => TabDocumentPanel.GetIRecreatableEntityFromQuote(row.Field<Guid>("QuoteGuid")));
          }
          foreach (IRecreatableEntity recreatableEntity in source.Select<DataRow, IRecreatableEntity>(selector))
          {
            Database.Instance.QuerySP.PerformNonQuery("DocumentSystem_InsertDocumentAssociation", (object) "@DocumentStoreGuid", (object) docGuid, (object) "@AssociatedEntityGuid", (object) recreatableEntity.EntityGuid, (object) "@AssociatedEntityType", (object) recreatableEntity.RecreateTypeName, (object) "@AssociatedEntityName", (object) recreatableEntity.EntityName, (object) "@AssociatedEntityFormName", (object) recreatableEntity.FriendlyEntityName, (object) "@ControlGuid", Interaction.IIf(recreatableEntity.HasControlGUID, (object) recreatableEntity.ControlGUID, (object) DBNull.Value));
            DocumentManager.SendDocumentBoundBroadcastMessage(docGuid, recreatableEntity.EntityGuid, recreatableEntity.RecreateTypeName, recreatableEntity.EntityName, recreatableEntity.FriendlyEntityName, new Guid?(recreatableEntity.HasControlGUID ? recreatableEntity.ControlGUID : new Guid()));
          }
        }
        finally
        {
          IEnumerator<IRecreatableEntity> enumerator;
          enumerator?.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentHandleError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private static IRecreatableEntity GetIRecreatableEntityFromQuote(Guid quoteGuid)
  {
    return (IRecreatableEntity) RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObject(ObjectFactory.Instance.CreateTypeFromString("MGASystems.BusinessObjects.Quote"), new object[1]
    {
      (object) quoteGuid
    }));
  }

  private void RenameFolder()
  {
    if (this.ActiveControl == null || !(this.ActiveControl is UltraTree))
      return;
    UltraTreeNode workingNode = this._workingNode;
    if (workingNode == null || !(workingNode is TabDocumentPanel.FolderNode))
      return;
    workingNode.BeginEdit();
  }

  private void ViewFile() => this.ViewFile(false, false);

  private void ViewFile(bool trackRevisions, bool useOpenWithDialog)
  {
    if (!(this._workingNode is TabDocumentPanel.FileNode workingNode))
      return;
    DocumentManager.BeginViewDocument(workingNode.DocumentGUID, trackRevisions, useOpenWithDialog);
  }

  private void ShowFolders()
  {
    if (this.ActiveControl == this.trvEntity)
    {
      Preferences.SetPreference("DockingTabs.Documents.AssociatedDocs.ShowFolders", !Preferences.GetPreferenceBool("DockingTabs.Documents.AssociatedDocs.ShowFolders"));
      this.RefreshTree((UltraTree) this.trvEntity);
    }
    else
    {
      if (this.ActiveControl != this.trvUser)
        return;
      Preferences.SetPreference("DockingTabs.Documents.DisassociatedDocs.ShowFolders", !Preferences.GetPreferenceBool("DockingTabs.Documents.DisassociatedDocs.ShowFolders"));
      this.RefreshTree((UltraTree) this.trvUser);
    }
  }

  private bool DisplayEnhancedToolTips
  {
    get => Preferences.GetPreferenceBool("DockingTabs.Documents.EnhancedToolTips");
    set => Preferences.SetPreference("DockingTabs.Documents.EnhancedToolTips", value);
  }

  private void PinDocument()
  {
    if (this.ActiveControl == null || !(this.ActiveControl is UltraTree))
      return;
    Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl);
    int index = 0;
    while (index < selectedDocGuids.Length)
    {
      DocumentManager.PinDocument(selectedDocGuids[index]);
      checked { ++index; }
    }
  }

  private void UnpinDocument()
  {
    if (this.ActiveControl == null || !(this.ActiveControl is UltraTree))
      return;
    Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl);
    int index = 0;
    while (index < selectedDocGuids.Length)
    {
      DocumentManager.UnPinDocument(selectedDocGuids[index]);
      checked { ++index; }
    }
  }

  private void EnableFolderFilter()
  {
    Preferences.SetPreference("DockingTabs.Documents.AssociatedDocs.FilterFoldersByEntity", !Preferences.GetPreferenceBool("DockingTabs.Documents.AssociatedDocs.FilterFoldersByEntity"));
    this.RefreshTree((UltraTree) this.trvEntity);
  }

  private void DeleteFile()
  {
    if (MessageBox.Show("Are you sure you want to delete these documents?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.DeleteSelectedUserNodes();
    CurrentUser.Instance.LogAction("Delete Documents");
  }

  private void DeleteSelectedUserNodes()
  {
    List<Guid> guidList = new List<Guid>();
    foreach (UltraTreeNode selectedNode in this.trvUser.SelectedNodes)
    {
      if (selectedNode is TabDocumentPanel.FileNode fileNode)
        guidList.Add(fileNode.DocumentGUID);
    }
    DocumentManager.BeginDeleteDocuments(guidList.ToArray());
  }

  private void SplitAdobeDoc()
  {
    Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl);
    int index = 0;
    while (index < selectedDocGuids.Length)
    {
      DocumentManager.SplitDocument(selectedDocGuids[index]);
      checked { ++index; }
    }
  }

  private void mnuAbridgeAdobeDoc_Click(object sender, EventArgs e)
  {
    Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl);
    if (selectedDocGuids.Length == 1)
    {
      DocumentManager.AbridgeDocument(selectedDocGuids[0]);
    }
    else
    {
      int num = (int) MessageBox.Show("You must select only one document for this action.", "Too many documents selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void SaveAs()
  {
    this.SaveDocumentsToDisk(TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl));
  }

  private void SaveAsZipped()
  {
    Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl);
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.FileName = "Export.zip";
    saveFileDialog.DefaultExt = Path.GetExtension("Export.zip");
    saveFileDialog.Filter = "Zip document (*.zip)|*.zip";
    if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDialog.FileName) && selectedDocGuids != null && selectedDocGuids.Length > 0)
    {
      DocumentManager.BeginExportFilesToZipFile(selectedDocGuids, saveFileDialog.FileName);
    }
    else
    {
      int num = (int) MessageBox.Show("Please choose a valid zip file name");
    }
  }

  private void Print()
  {
    Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl);
    int index = 0;
    while (index < selectedDocGuids.Length)
    {
      DocumentManager.BeginPrintDoc(selectedDocGuids[index]);
      checked { ++index; }
    }
  }

  private void EmailDocument() => this.EmailDocument(false);

  private void EmailDocument(bool convertToPdf)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl);
    using (frmAssociatedEntities associatedEntities = new frmAssociatedEntities(selectedDocGuids))
    {
      if (associatedEntities.HasAssociatedEntites)
      {
        int num = (int) associatedEntities.ShowDialog();
        if (!associatedEntities.Saved)
          return;
        if (this._entityDocs != null && this._entityDocs.HasControlGUID)
        {
          EmailSubjectResolver objectAs = ObjectFactory.Instance.CreateObjectAs<EmailSubjectResolver>();
          if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("AssociateDocumentEmailFolderID") & CurrentUser.UsingOutlook)
            this.SendDocumentEmail(this._entityDocs, objectAs.ResolveSubjectText((IRecreatableEntity) this._entityDocs), selectedDocGuids, associatedEntities.SelectedEmails.ToArray(), convertToPdf, (string[]) null, (string[]) null, associatedEntities.EmailAssociatedFolderID);
          else
            DocumentManager.EmailDocumentsWithoutZipping(this.ActiveControl == this.trvEntity ? this._entityDocs : (ISupportDocumentSystem) null, selectedDocGuids, associatedEntities.SelectedEmails.ToArray(), objectAs.ResolveSubjectText((IRecreatableEntity) this._entityDocs), convertToPdf);
        }
        else
          DocumentManager.EmailDocumentsWithoutZipping(selectedDocGuids, associatedEntities.SelectedEmails.ToArray(), convertToPdf);
      }
      else
        DocumentManager.EmailDocuments(convertToPdf, selectedDocGuids);
    }
  }

  private void RenameFile()
  {
    if (this.ActiveControl == null || !(this.ActiveControl is UltraTree) || !(this._workingNode is TabDocumentPanel.FileNode workingNode))
      return;
    workingNode.Text = workingNode.FileName;
    workingNode.BeginEdit();
  }

  private TabDocumentPanel.FileNode[] SelectedAdobeDocumentFileNodes
  {
    get
    {
      List<TabDocumentPanel.FileNode> fileNodeList = new List<TabDocumentPanel.FileNode>();
      if (this.ActiveControl != null && this.ActiveControl is UltraTree)
      {
        foreach (UltraTreeNode selectedNode in ((UltraTree) this.ActiveControl).SelectedNodes)
        {
          if (selectedNode is TabDocumentPanel.FileNode fileNode && fileNode.FileName.EndsWith(".pdf", true, CultureInfo.InvariantCulture))
            fileNodeList.Add(fileNode);
        }
      }
      return fileNodeList.ToArray();
    }
  }

  private void DisplayFolderFilteringOptions()
  {
    if (this.ActiveControl == this.trvEntity)
    {
      this.ShowMenuItem("Enable Folder Filter");
      if (Preferences.GetPreferenceBool("DockingTabs.Documents.AssociatedDocs.FilterFoldersByEntity"))
        this.SetMenuItemText("Enable Folder Filter", "Disable Folder Filtering");
      else
        this.SetMenuItemText("Enable Folder Filter", "Enable Folder Filtering");
      if (SecurityManager.Instance.AssertPermission("{60C00A7E-2D44-4108-B607-7F48FBEE7897}"))
        return;
      this.HideMenuItem("Enable Folder Filter");
    }
    else
      this.HideMenuItem("Enable Folder Filter");
  }

  private bool IsMenuItemVisible(string key)
  {
    return ((ToolsCollectionBase) this.ctxMenu.Tools)[key].SharedProps.Visible;
  }

  private void DisplaySelectSysParseAccordDocOptions(UltraTreeNode nodeUnderMouse, UltraTree tree)
  {
    this.HideMenuItem("Parse Acord App and View in NetRate");
    AcordParserControlOverride objectAs = ObjectFactory.Instance.CreateObjectAs<AcordParserControlOverride>();
    TabDocumentPanel.FileNode file = nodeUnderMouse as TabDocumentPanel.FileNode;
    if (this._entityDocs == null || file == null || objectAs == null || !objectAs.ShouldDisplayParseTool((IRecreatableEntity) this._entityDocs, file))
      return;
    this.ShowMenuItem("Parse Acord App and View in NetRate");
  }

  private void DisplayImageRightOptions(UltraTreeNode nodeUnderMouse, UltraTree tree)
  {
    this.HideMenuItem("SendToImageRight");
    if (nodeUnderMouse is TabDocumentPanel.FileNode)
    {
      DocumentSystemContextImageRightMenuOverride rightMenuOverride = this.ImageRightMenuOverride;
      if (rightMenuOverride != null && rightMenuOverride.ShouldDisplayImageRightTool((IRecreatableEntity) this._entityDocs))
        this.ShowMenuItem("SendToImageRight");
    }
    this.ToggleMenuItemVisibility("Unpin All Documents", TabDocumentPanel.GetPinnedNodeCount(tree) > 0);
    this.ToggleMenuItemVisibility("Document Pinning", this.IsMenuItemVisible("Pin Document") || this.IsMenuItemVisible("Unpin Document") || this.IsMenuItemVisible("Unpin All Documents"));
  }

  private void DisplayPinningOptions(UltraTreeNode nodeUnderMouse, UltraTree tree)
  {
    this.HideMenuItem("Pin Document");
    this.HideMenuItem("Unpin Document");
    if (nodeUnderMouse is TabDocumentPanel.FileNode fileNode)
    {
      if (this.ActiveControl == this.trvEntity)
        this.ShowMenuItem("Pin Document");
      else
        this.ToggleMenuItemVisibility("Unpin Document", fileNode.Pinned);
    }
    this.ToggleMenuItemVisibility("Unpin All Documents", TabDocumentPanel.GetPinnedNodeCount(tree) > 0);
    this.ToggleMenuItemVisibility("Document Pinning", this.IsMenuItemVisible("Pin Document") || this.IsMenuItemVisible("Unpin Document") || this.IsMenuItemVisible("Unpin All Documents"));
  }

  private bool DisplayShowFoldersMenu(UltraTree tree)
  {
    bool flag = true;
    if (this.ActiveControl == this.trvEntity)
      flag = this.ShouldShowEntityFolders();
    else if (this.ActiveControl == this.trvUser)
      flag = Preferences.GetPreferenceBool("DockingTabs.Documents.DisassociatedDocs.ShowFolders");
    if (flag)
      this.SetMenuItemText("Show Folders", "Hide Folders");
    else
      this.SetMenuItemText("Show Folders", "Show Folders");
    if (flag && tree.Nodes.Count == 0)
      this.HideMenuItem("Show Folders");
    if (!SecurityManager.Instance.AssertPermission("{242C8238-6072-4c25-9B3E-C07D4206CA8C}"))
      this.HideMenuItem("Show Folders");
    return flag;
  }

  private void HideItemsBasedOnNodeType(UltraTreeNode nodeUnderMouse, UltraTree tree)
  {
    TabDocumentPanel.FileNode fileNode = nodeUnderMouse as TabDocumentPanel.FileNode;
    if (nodeUnderMouse != null && fileNode != null)
    {
      this.ShowMenuItem("File Properties");
      this.ShowMenuItem("Save As");
      this.ShowMenuItem("Print");
      this.ShowMenuItem("Email");
      if (DocumentManager.CanConvertToPdf(fileNode.FileName))
        this.ShowMenuItem("EmailAsPdf");
      else
        this.HideMenuItem("EmailAsPdf");
      this.ShowMenuItem("View File");
      this.ShowMenuItem("Rename File");
      this.ShowMenuItem("Split Adobe Document");
      if (tree == this.trvUser)
        this.ShowMenuItem("Delete File");
      this.ShowMenuItem("Transfer File");
      this.ToggleMenuItemVisibility("Notes", tree == this.trvEntity);
    }
    else
    {
      this.HideMenuItem("Split Adobe Document");
      this.HideMenuItem("Rename File");
      this.HideMenuItem("File Properties");
      this.HideMenuItem("View File");
      this.HideMenuItem("Save As");
      this.HideMenuItem("Print");
      this.HideMenuItem("Email");
      this.HideMenuItem("EmailAsPdf");
      this.HideMenuItem("Transfer File");
      this.HideMenuItem("Notes");
    }
  }

  private void DisplayMenuItemsBasedOnSecurity(UltraTree tree)
  {
    if (this.IsMenuItemVisible("Bind"))
    {
      if (tree == this.trvUser)
        this.ToggleMenuItemVisibility("Bind", SecurityManager.Instance.AssertPermission("{463F6A83-2388-4535-A781-1DB0A7985187}"));
      else
        this.ToggleMenuItemVisibility("Bind", SecurityManager.Instance.AssertPermission("{16EF6A9D-91A2-45c7-AB12-AC6A601368DE}"));
    }
    if (this.IsMenuItemVisible("Transfer File"))
      this.ToggleMenuItemVisibility("Transfer File", SecurityManager.Instance.AssertPermission("{A4C4CE34-0130-4bea-B7BD-7FF75DB73E82}"));
    if (this.IsMenuItemVisible("View File"))
      this.ToggleMenuItemVisibility("View File", SecurityManager.Instance.AssertPermission("{7994442C-0ECF-492b-8949-C8D67814751C}"));
    if (this.IsMenuItemVisible("Delete File"))
      this.ToggleMenuItemVisibility("Delete File", SecurityManager.Instance.AssertPermission("{A24AE1FA-B6C5-4e4d-BC52-3B4FE0343104}"));
    if (this.IsMenuItemVisible("File Properties"))
      this.ToggleMenuItemVisibility("File Properties", SecurityManager.Instance.AssertPermission("{F64B30DF-7B2B-436e-BB1E-AD21C5D23F79}"));
    if (this.IsMenuItemVisible("Save As"))
      this.ToggleMenuItemVisibility("Save As", SecurityManager.Instance.AssertPermission("{BB22B0B4-0841-4147-B58B-33C7C3DCA163}"));
    if (this.IsMenuItemVisible("Print"))
      this.ToggleMenuItemVisibility("Print", SecurityManager.Instance.AssertPermission("{443BB180-4020-4407-9A91-B8A1A985B87A}"));
    if (this.IsMenuItemVisible("Email"))
      this.ToggleMenuItemVisibility("Email", SecurityManager.Instance.AssertPermission("{B91DE12D-F7DC-40e1-969C-6A0447EEC928}"));
    if (this.IsMenuItemVisible("EmailAsPdf"))
      this.ToggleMenuItemVisibility("EmailAsPdf", SecurityManager.Instance.AssertPermission("{B91DE12D-F7DC-40e1-969C-6A0447EEC928}"));
    if (this.IsMenuItemVisible("New Folder"))
      this.ToggleMenuItemVisibility("New Folder", SecurityManager.Instance.AssertPermission("{741550D6-3346-4900-B071-D0D347A0A6E8}"));
    if (this.IsMenuItemVisible("Delete Folder"))
      this.ToggleMenuItemVisibility("Delete Folder", SecurityManager.Instance.AssertPermission("{741550D6-3346-4900-B071-D0D347A0A6E8}"));
    if (this.IsMenuItemVisible("Rename Folder"))
      this.ToggleMenuItemVisibility("Rename Folder", SecurityManager.Instance.AssertPermission("{741550D6-3346-4900-B071-D0D347A0A6E8}"));
    if (this.IsMenuItemVisible("Rename File"))
      this.ToggleMenuItemVisibility("Rename File", SecurityManager.Instance.AssertPermission("{741550D6-3346-4900-B071-D0D347A0A6E8}"));
    if (this.IsMenuItemVisible("Split Adobe Document"))
      this.ToggleMenuItemVisibility("Split Adobe Document", SecurityManager.Instance.AssertPermission("{ECC3C7CB-B41B-415a-843D-5540DAAEE2B1}"));
    if (this.IsMenuItemVisible("Concatenate Adobe Documents"))
      this.ToggleMenuItemVisibility("Concatenate Adobe Documents", SecurityManager.Instance.AssertPermission("{ECC3C7CB-B41B-415a-843D-5540DAAEE2B1}"));
    if (!this.IsMenuItemVisible("Abridge Adobe Document"))
      return;
    this.ToggleMenuItemVisibility("Abridge Adobe Document", SecurityManager.Instance.AssertPermission("{ECC3C7CB-B41B-415a-843D-5540DAAEE2B1}"));
  }

  private void FilterByType()
  {
    using (frmChooseDocType frmChooseDocType = frmChooseDocType.Create(this._filterTypeGuid))
    {
      if (frmChooseDocType.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      this._filterTypeGuid = (Guid) frmChooseDocType.cboDocumentType.Value;
      this.pnlAssociated.Text = !this._filterTypeGuid.Equals(Guid.Empty) ? "Associated Documents (Filtered)" : "Associated Documents";
      this.SetNodeVisibility();
    }
  }

  private void tree_AfterLabelEdit(object sender, NodeEventArgs e)
  {
    if (e.TreeNode is TabDocumentPanel.FolderNode)
    {
      TabDocumentPanel.FolderNode treeNode = (TabDocumentPanel.FolderNode) e.TreeNode;
      if (treeNode.IsNew)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(treeNode.Text, string.Empty, false) != 0)
        {
          treeNode.IsNew = false;
          treeNode.Selected = true;
          if (treeNode.ParentFolderID == null)
          {
            FolderManager.CreateFolder(treeNode.Text);
            CurrentUser.Instance.LogAction("Add document folder: " + treeNode.Text, typeof (TabDocumentPanel).ToString());
          }
          else
          {
            FolderManager.CreateFolder(treeNode.Text, Conversions.ToInteger(treeNode.ParentFolderID));
            CurrentUser.Instance.LogAction($"Add document folder: {treeNode.Text} to parent folder: {treeNode.Parent.Text}", typeof (TabDocumentPanel).ToString());
          }
          this.ResetFolders();
        }
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(treeNode.Text, string.Empty, false) != 0)
      {
        treeNode.Selected = true;
        FolderManager.RenameFolder(Conversions.ToInteger(treeNode.FolderID), treeNode.Text);
        this.ResetFolders();
        CurrentUser.Instance.LogAction("Rename document folder to " + treeNode.Text, typeof (TabDocumentPanel).ToString());
      }
      this.RefreshTree((UltraTree) this.trvUser);
      this.RefreshTree((UltraTree) this.trvEntity);
    }
    else
    {
      if (!(e.TreeNode is TabDocumentPanel.FileNode))
        return;
      TabDocumentPanel.FileNode treeNode = (TabDocumentPanel.FileNode) e.TreeNode;
      if (treeNode.Text.Length > 0)
      {
        string fileExtension1 = TabDocumentPanel.GetFileExtension(treeNode.FileName);
        string fileExtension2 = TabDocumentPanel.GetFileExtension(treeNode.Text);
        if (string.IsNullOrEmpty(fileExtension2))
        {
          TabDocumentPanel.FileNode fileNode;
          string str = (fileNode = treeNode).Text + fileExtension1;
          fileNode.Text = str;
          treeNode.FileName = treeNode.Text;
          treeNode.EndEdit(true);
        }
        else
        {
          if (string.Compare(fileExtension2, fileExtension1, true) != 0)
          {
            treeNode.Text = treeNode.Text.Replace(fileExtension2, fileExtension1);
            treeNode.EndEdit(false);
          }
          treeNode.Selected = true;
          Database.Instance.QueryText.PerformNonQuery("UPDATE dbo.tblDocumentStore SET  FileName = @FileName WHERE DocumentStoreGUID = @DocumentStoreGUID", (object) "@FileName", (object) treeNode.Text, (object) "@DocumentStoreGUID", (object) treeNode.DocumentGUID);
          treeNode.FileName = treeNode.Text;
          new Document(treeNode.DocumentGUID).LogForAllEntities($"Rename Document Filename to \"{treeNode.Text}\"");
        }
      }
      else
        treeNode.Text = treeNode.FileName;
    }
  }

  private static string GetFileExtension(string text)
  {
    return !text.Contains(".") ? string.Empty : text.Substring(text.LastIndexOf("."));
  }

  private void trvEntity_ValidateLabelEdit(object sender, ValidateLabelEditEventArgs e)
  {
    TreeNodesCollection treeNodesCollection = e.Node.Parent == null ? e.Node.Control.Nodes : e.Node.Parent.Nodes;
    if (treeNodesCollection != null && treeNodesCollection.Count > 1)
    {
      foreach (UltraTreeNode ultraTreeNode in treeNodesCollection)
      {
        if ((ultraTreeNode is TabDocumentPanel.FolderNode || ultraTreeNode is TabDocumentPanel.FileNode) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ultraTreeNode.Text, e.LabelEditText, false) == 0)
        {
          ((CancelEventArgs) e).Cancel = true;
          return;
        }
      }
    }
    if (e.LabelEditText.Length <= 0)
      return;
    if (e.LabelEditText.IndexOfAny("\\/:*\"<>|".ToCharArray()) != -1)
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (e.LabelEditText.Length <= (int) byte.MaxValue)
        return;
      ((CancelEventArgs) e).Cancel = true;
    }
  }

  private bool OnEntityTreeDragDrop(DragEventArgs e)
  {
    bool flag;
    if (this._entityDocs != null && this._entityDocs.AllowAddNewDocument)
    {
      if (e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode", false))
      {
        TabDocumentPanel.FileNode data = (TabDocumentPanel.FileNode) e.Data.GetData("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(data.ControlKey, ((System.Windows.Forms.Control) this.trvUser).Name, false) == 0)
        {
          DocumentManager.BeginBindDocument(data.DocumentGUID, this._entityDocs);
          flag = true;
          goto label_27;
        }
      }
      else if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop, false))
      {
        string[] data = (string[]) e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
        int index = 0;
        while (index < data.Length)
        {
          DocumentManager.FileAddWithBind(data[index], this._entityDocs);
          checked { ++index; }
        }
      }
      if (e.Data.GetData("ByteData", false) is List<ByteData> data1)
      {
        try
        {
          TabDocumentPanel.ParseEmailOptionsStorageBegin();
          try
          {
            foreach (ByteData byteData in data1)
            {
              string str1 = MGATempFolder.MGATempRandomFolderPath + byteData.FileName;
              int num1 = 259;
              string str2;
              try
              {
                str2 = FilePath.Resolve(str1);
              }
              catch (PathTooLongException ex)
              {
                ProjectData.SetProjectError((Exception) ex);
                int num2 = num1 - 1;
                string fileName = Path.GetFileName(str1);
                string str3 = str1.Replace(fileName, "");
                int num3 = num2 - str3.Length;
                string path2 = fileName.Substring(fileName.Length - num3);
                int num4 = (int) MessageBox.Show($"The filename generated from the email subject has been shortened To '{path2}'.", "The specified path, file name, or both exceed the system-defined maximum length.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                str2 = Path.Combine(MGATempFolder.MGATempRandomFolderPath, path2);
                ProjectData.ClearProjectError();
              }
              using (FileStream fileStream = new FileStream(str2, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
              {
                byte[] bytes = byteData.GetBytes();
                fileStream.Write(bytes, 0, bytes.Length);
              }
              if (str2.EndsWith(".msg", true, CultureInfo.InvariantCulture))
              {
                string[] email = TabDocumentPanel.ParseEmail(str2);
                int index = 0;
                while (index < email.Length)
                {
                  DocumentManager.FileAddWithBind(email[index], this._entityDocs);
                  checked { ++index; }
                }
              }
              else
                DocumentManager.FileAddWithBind(str2, this._entityDocs);
            }
          }
          finally
          {
            List<ByteData>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        finally
        {
          TabDocumentPanel.ParseEmailOptionsStorageComplete();
        }
      }
    }
label_27:
    return flag;
  }

  private bool OnUserTreeDragDrop(DragEventArgs e, List<Guid> docGuids)
  {
    bool flag;
    if (this._entityDocs != null && this._entityDocs.AllowAddNewDocument && e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode", false))
    {
      TabDocumentPanel.FileNode data = (TabDocumentPanel.FileNode) e.Data.GetData("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(data.ControlKey, ((System.Windows.Forms.Control) this.trvEntity).Name, false) == 0)
      {
        DocSupportCache docSupport = new DocSupportCache(this._entityDocs);
        DocumentManager.BeginUnbindDocument(data.DocumentGUID, (IRecreatableEntity) docSupport);
        flag = true;
        goto label_36;
      }
    }
    if (!e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode", false))
    {
      if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop, false))
      {
        string[] data = (string[]) e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
        int index = 0;
        while (index < data.Length)
        {
          string path = data[index];
          docGuids.Add(DocumentManager.FileAdd(path));
          checked { ++index; }
        }
      }
      else if (e.Data.GetDataPresent("ByteData", false))
      {
        if (e.Data.GetData("ByteData", false) is List<ByteData> data1)
        {
          try
          {
            TabDocumentPanel.ParseEmailOptionsStorageBegin();
            try
            {
              foreach (ByteData byteData in data1)
              {
                string str = FilePath.Resolve(MGATempFolder.MGATempRandomFolderPath + byteData.FileName);
                using (FileStream fileStream = new FileStream(str, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                  byte[] bytes = byteData.GetBytes();
                  fileStream.Write(bytes, 0, bytes.Length);
                }
                if (str.EndsWith(".msg", true, CultureInfo.InvariantCulture))
                {
                  string[] email = TabDocumentPanel.ParseEmail(str);
                  int index = 0;
                  while (index < email.Length)
                  {
                    string path = email[index];
                    docGuids.Add(DocumentManager.FileAdd(path));
                    checked { ++index; }
                  }
                }
                else
                  docGuids.Add(DocumentManager.FileAdd(str));
              }
            }
            finally
            {
              List<ByteData>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
          catch (RepositoryWriterException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            RepositoryWriterException repositoryWriterException = ex;
            string str;
            if (repositoryWriterException.InnerException is AggregateException)
            {
              AggregateException innerException = (AggregateException) repositoryWriterException.InnerException;
              string newLine = Environment.NewLine;
              System.Collections.ObjectModel.ReadOnlyCollection<Exception> innerExceptions = innerException.InnerExceptions;
              System.Func<Exception, string> selector;
              // ISSUE: reference to a compiler-generated field
              if (TabDocumentPanel._Closure\u0024__.\u0024I276\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                selector = TabDocumentPanel._Closure\u0024__.\u0024I276\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                TabDocumentPanel._Closure\u0024__.\u0024I276\u002D0 = selector = (System.Func<Exception, string>) ([SpecialName] (exc) => exc.Message);
              }
              IEnumerable<string> values = innerExceptions.Select<Exception, string>(selector);
              str = string.Join(newLine, values);
            }
            else if (repositoryWriterException.InnerException is RepositoryWriterException)
              str = repositoryWriterException.InnerException.Message;
            else
              throw;
            int num = (int) MessageBox.Show($"Errors encountered during document upload:{Environment.NewLine}{Environment.NewLine}{str}", "Error Uploading Document");
            ProjectData.ClearProjectError();
          }
          catch (OperationCanceledException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            ProjectData.ClearProjectError();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            int num = (int) MessageBox.Show(ex.Message, "Error Uploading Document");
            ProjectData.ClearProjectError();
          }
          finally
          {
            TabDocumentPanel.ParseEmailOptionsStorageComplete();
          }
        }
      }
    }
label_36:
    return flag;
  }

  private bool OnTreeDragDrop(object sender, DragEventArgs e, List<Guid> docGuids)
  {
    return sender != this.trvUser ? this.OnEntityTreeDragDrop(e) : this.OnUserTreeDragDrop(e, docGuids);
  }

  private void SaveDocumentsToDisk(Guid[] documentGuids)
  {
    try
    {
      FolderBrowserDialog folderBrowserDialog1 = this.FolderBrowserDialog1;
      folderBrowserDialog1.Description = "Please choose a directory to save to";
      folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
      if (folderBrowserDialog1.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string selectedPath = folderBrowserDialog1.SelectedPath;
      MDIControls.Instance.MDIParent.Cursor = MgaCursors.WaitCursor;
      Guid[] guidArray = documentGuids;
      int index = 0;
      while (index < guidArray.Length)
      {
        this.SaveDocumentToDisk(guidArray[index], selectedPath);
        checked { ++index; }
      }
    }
    catch (Win32Exception ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      Win32Exception win32Exception = ex;
      if (win32Exception.ErrorCode == -2147467259 /*0x80004005*/)
      {
        int num = (int) MessageBox.Show(win32Exception.Message, "Windows Cannot Open File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      ProjectData.ClearProjectError();
    }
    finally
    {
      MDIControls.Instance.MDIParent.Cursor = MgaCursors.Default;
    }
  }

  private void SaveDocumentToDisk(Guid documentGuid, string savetodirectory)
  {
    Metadata documentMetadata = DocumentManager.GetDocumentMetadata(documentGuid);
    byte[] documentBinary = DocumentManager.GetDocumentBinary(documentGuid);
    bool setting = SystemSettings.GetSetting<bool>("SaveDocument.UseDescription", false);
    string fileName = documentMetadata.FileName;
    string str1 = FilePath.Resolve(savetodirectory, fileName);
    string str2 = Path.Combine(savetodirectory, $"{documentMetadata.DocumentStoreGuid}.zip");
    if (documentMetadata.Compressed)
    {
      using (FileStream fileStream = new FileStream(str2, FileMode.Create))
      {
        fileStream.Write(documentBinary, 0, documentBinary.Length);
        fileStream.Close();
      }
      if (setting)
        ZipUtility.ExtractAndMoveFile(str2, str1);
      else
        this.ZipUtility1.ExtractFilesFromZipArchive(str2, savetodirectory);
      File.Delete(str2);
    }
    else
    {
      try
      {
        using (FileStream fileStream = new FileStream(str1, FileMode.Create))
        {
          fileStream.Write(documentBinary, 0, documentBinary.Length);
          fileStream.Close();
        }
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("This item is already open", "Cannot open two instances of the same document", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ProjectData.ClearProjectError();
        return;
      }
    }
    CurrentUser.Instance.LogAction($"Downloaded Document - \"{documentMetadata.Description}\"", documentMetadata.DocumentStoreGuid);
  }

  private void lnkAddEntityDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    OpenFileDialog openFileDialog1 = this.OpenFileDialog1;
    openFileDialog1.CheckFileExists = true;
    openFileDialog1.CheckPathExists = true;
    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    openFileDialog1.Multiselect = true;
    openFileDialog1.ReadOnlyChecked = true;
    openFileDialog1.DereferenceLinks = true;
    openFileDialog1.ShowReadOnly = false;
    if (openFileDialog1.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) != DialogResult.Cancel)
    {
      string[] fileNames = openFileDialog1.FileNames;
      int index = 0;
      while (index < fileNames.Length)
      {
        DocumentManager.BeginFileAddWithBind(fileNames[index], this._entityDocs);
        checked { ++index; }
      }
    }
  }

  private void lnkAddUserDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    OpenFileDialog openFileDialog1 = this.OpenFileDialog1;
    openFileDialog1.CheckFileExists = true;
    openFileDialog1.CheckPathExists = true;
    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    openFileDialog1.Multiselect = true;
    openFileDialog1.DereferenceLinks = true;
    openFileDialog1.ReadOnlyChecked = true;
    openFileDialog1.ShowReadOnly = false;
    if (openFileDialog1.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) != DialogResult.Cancel)
    {
      string[] fileNames = openFileDialog1.FileNames;
      int index = 0;
      while (index < fileNames.Length)
      {
        DocumentManager.BeginFileAdd(fileNames[index]);
        checked { ++index; }
      }
    }
  }

  private void SetSort(TabDocumentPanel.SortCriteria sort)
  {
    if (this.ActiveControl == null || !(this.ActiveControl is UltraTree))
      return;
    UltraTree activeControl = (UltraTree) this.ActiveControl;
    if (activeControl == this.trvUser)
    {
      this.UserDocsSortInfo.SortCriteria = sort;
      activeControl.Override.Sort = !this.UserDocsSortInfo.SortAsc ? (SortType) 2 : (SortType) 1;
    }
    else
    {
      this.EntityDocsSortInfo.SortCriteria = sort;
      activeControl.Override.Sort = !this.EntityDocsSortInfo.SortAsc ? (SortType) 2 : (SortType) 1;
    }
    SortType sort1 = activeControl.Override.Sort;
    activeControl.Override.Sort = (SortType) 3;
    activeControl.Override.Sort = sort1;
    this.SetSortDescription(sort, activeControl.Override.Sort, activeControl);
  }

  private void SetSort(TabDocumentPanel.SortCriteria sort, UltraTree tree)
  {
    if (tree == this.trvUser)
    {
      this.UserDocsSortInfo.SortCriteria = sort;
      tree.Override.Sort = !this.UserDocsSortInfo.SortAsc ? (SortType) 2 : (SortType) 1;
    }
    else
    {
      this.EntityDocsSortInfo.SortCriteria = sort;
      tree.Override.Sort = !this.EntityDocsSortInfo.SortAsc ? (SortType) 2 : (SortType) 1;
    }
    SortType sort1 = tree.Override.Sort;
    tree.Override.Sort = (SortType) 3;
    tree.Override.Sort = sort1;
    this.SetSortDescription(sort, tree.Override.Sort, tree);
  }

  private void SetDetails(UltraTreeNode node)
  {
    this.txtPreviewText.Text = string.Empty;
    if (this.DesignMode)
      return;
    this.pbPreview.Image = (System.Drawing.Image) null;
    TabDocumentPanel.FileNode fileNode = node as TabDocumentPanel.FileNode;
    if (node is TabDocumentPanel.FolderNode)
    {
      this.lblDetails.Text = $"Folder Name: {node.Text}";
    }
    else
    {
      if (fileNode == null)
        return;
      this.txtPreviewText.Text = fileNode.FormattedToolTip;
      string str = "Root";
      if (fileNode.Parent is TabDocumentPanel.FolderNode parent)
        str = parent.Text;
      this.lblDetails.Text = string.Format("File Name: {1}, Date: {2}{0}Folder: {8}{0}Type: {6}{0}Compressed: {3}{0}Size (uncompressed): {4}{0}Desc: {5}{0}{7}", (object) "\r\n", (object) fileNode.FileName, (object) fileNode.DateAdded, (object) fileNode.Compressed, (object) Strings.FormatNumber((object) fileNode.OriginalFileSize, 0), (object) fileNode.Description, (object) fileNode.FileAssociation, (object) TabDocumentPanel.FormatMetaXml(fileNode.MetaXml), (object) str);
      Database.Instance.QueryMultithreadedText.PerformScalarQuery(ThreadPriority.Lowest, (System.Windows.Forms.Control) MDIControls.Instance.MDIParent, (object) "PreviewImage", "SELECT DocumentThumbnail FROM tblDocumentStore (NOLOCK) WHERE DocumentStoreGUID = @DocumentStoreGUID", new ScalarQueryMultithreadedEventHandler(this.PreviewPic_ScalarQueryCompleted), (object) "@DocumentStoreGUID", (object) fileNode.DocumentGUID);
      NoteSupportCache noteSupportCache = new NoteSupportCache(fileNode.DocumentGUID, "", "", "", false, Guid.Empty);
    }
  }

  private static string FormatMetaXml(string metaXml)
  {
    string str1;
    if (string.IsNullOrEmpty(metaXml))
    {
      str1 = string.Empty;
    }
    else
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(metaXml);
      XmlNode xmlNode = xmlDocument.SelectSingleNode("//MailInfo");
      if (xmlNode != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlNode.Name, "MailInfo", false) == 0)
      {
        string str2 = string.Format("Sent:{1}{0}Recvd:{2}", (object) "\r\n", (object) xmlNode.Attributes["Sent"].Value, (object) xmlNode.Attributes["Received"].Value);
        if (xmlNode.Attributes["Source"] != null)
          str2 += $"{"\r\n"}Source:{xmlNode.Attributes["Source"].Value}";
        str1 = str2;
      }
      else
        str1 = string.Empty;
    }
    return str1;
  }

  private void tree_AfterActivate(object sender, NodeEventArgs e)
  {
    if (e.TreeNode == null)
      return;
    this.SetDetails(e.TreeNode);
  }

  private void pbPreview_MouseEnter(object sender, EventArgs e)
  {
    if (this.pbPreview.Image == null)
      return;
    if (this._floater == null)
      this._floater = new TabDocumentPanel.FloatControl();
    System.Drawing.Point position = Cursor.Position;
    position.Offset(0, -this.pbPreview.Image.Height);
    this._floater.Location = position;
    this._floater.ShowFloating(this.pbPreview.Image);
  }

  private void pbPreview_MouseLeave(object sender, EventArgs e)
  {
    if (this._floater == null)
      return;
    this._floater.Hide();
    this._floater.Dispose();
    this._floater = (TabDocumentPanel.FloatControl) null;
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  private void PreviewPic_ScalarQueryCompleted(object sender, ScalarQueryMultithreadedEventArgs e)
  {
    System.Drawing.Image image = this.pbPreview.Image;
    this.pbPreview.Image = (System.Drawing.Image) null;
    image?.Dispose();
    if (Database.IsValueNull(RuntimeHelpers.GetObjectValue(e.Result)))
      return;
    byte[] result = (byte[]) e.Result;
    if (result == null || result.Length <= 0)
      return;
    MemoryStream memoryStream = new MemoryStream(result);
    try
    {
      this.pbPreview.Image = (System.Drawing.Image) new Bitmap((Stream) memoryStream);
      memoryStream.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  internal static void ParseEmailOptionsStorageBegin()
  {
    TabDocumentPanel._inParseEmailOptionsStorageOperation = true;
    TabDocumentPanel._savedImportOptions = new frmMessageDropOptions.MessageImportOptions?();
  }

  internal static void ParseEmailOptionsStorageComplete()
  {
    TabDocumentPanel._inParseEmailOptionsStorageOperation = false;
    TabDocumentPanel._savedImportOptions = new frmMessageDropOptions.MessageImportOptions?();
  }

  internal static string[] ParseEmail(string emailPath)
  {
    MapiMessage mapiMessage = MapiMessage.FromFile(emailPath);
    string[] email;
    if (mapiMessage.Attachments.Count > 0)
    {
      frmMessageDropOptions.MessageImportOptions? nullable = new frmMessageDropOptions.MessageImportOptions?();
      if (TabDocumentPanel._inParseEmailOptionsStorageOperation && TabDocumentPanel._savedImportOptions.HasValue)
        nullable = new frmMessageDropOptions.MessageImportOptions?(TabDocumentPanel._savedImportOptions.Value);
      else if (TabDocumentPanel._inParseEmailOptionsStorageOperation)
      {
        using (frmMessageDropOptions messageDropOptions = new frmMessageDropOptions(true))
        {
          if (messageDropOptions.ShowDialog() == DialogResult.OK)
          {
            nullable = new frmMessageDropOptions.MessageImportOptions?(messageDropOptions.ImportOptions);
            TabDocumentPanel._savedImportOptions = nullable;
          }
        }
      }
      else
      {
        using (frmMessageDropOptions messageDropOptions = new frmMessageDropOptions())
        {
          if (messageDropOptions.ShowDialog() == DialogResult.OK)
            nullable = new frmMessageDropOptions.MessageImportOptions?(messageDropOptions.ImportOptions);
        }
      }
      if (nullable.HasValue)
      {
        switch (nullable.Value)
        {
          case frmMessageDropOptions.MessageImportOptions.FullMessage:
            email = new string[1]{ emailPath };
            goto label_37;
          case frmMessageDropOptions.MessageImportOptions.MessageOnly:
            MapiMessage.RemoveAttachments(emailPath);
            email = new string[1]{ emailPath };
            goto label_37;
          case frmMessageDropOptions.MessageImportOptions.AttachmentOnly:
            List<string> stringList1 = new List<string>();
            try
            {
              foreach (MapiAttachment attachment in (IEnumerable<MapiAttachment>) mapiMessage.Attachments)
              {
                string str = $"{MGATempFolder.CreateTempSubdirectory()}{attachment.LongFileName}";
                attachment.Save(str);
                stringList1.Add(str);
              }
            }
            finally
            {
              IEnumerator<MapiAttachment> enumerator;
              enumerator?.Dispose();
            }
            email = stringList1.ToArray();
            goto label_37;
          case frmMessageDropOptions.MessageImportOptions.FullMessageAttachmentsBrokenOut:
            List<string> stringList2 = new List<string>();
            try
            {
              foreach (MapiAttachment attachment in (IEnumerable<MapiAttachment>) mapiMessage.Attachments)
              {
                string str = $"{MGATempFolder.CreateTempSubdirectory()}{attachment.LongFileName}";
                attachment.Save(str);
                stringList2.Add(str);
              }
            }
            finally
            {
              IEnumerator<MapiAttachment> enumerator;
              enumerator?.Dispose();
            }
            stringList2.Add(emailPath);
            email = stringList2.ToArray();
            goto label_37;
        }
      }
    }
    email = new string[1]{ emailPath };
label_37:
    return email;
  }

  private void UploadEntityMessageFiles_AttachmentsFound(string file)
  {
    this._documentGuidsFromMessageFiles.Add(DocumentManager.FileAddWithBind(file, this._entityDocs));
  }

  private void UploadNonEntityMessageFiles_AttachmentsFound(string file)
  {
    this._documentGuidsFromMessageFiles.Add(DocumentManager.FileAdd(file));
  }

  private void tree_DoubleClick(object sender, EventArgs e)
  {
    UltraTree ultraTree = (UltraTree) sender;
    if (!(ultraTree.GetNodeFromPoint(((System.Windows.Forms.Control) ultraTree).PointToClient(Cursor.Position)) is TabDocumentPanel.FileNode nodeFromPoint))
      return;
    if (SecurityManager.Instance.AssertPermission("{7994442C-0ECF-492b-8949-C8D67814751C}"))
    {
      if (SystemSettings.GetSetting<bool>("DocumentSystem.TrackRevisionOnDblClick", false))
        DocumentManager.BeginViewDocument(nodeFromPoint.DocumentGUID, true, false);
      else
        DocumentManager.BeginViewDocument(nodeFromPoint.DocumentGUID);
    }
    else
    {
      int num = (int) MessageBox.Show("You currently do not have sufficient permission to view documents from the document handler.", "Security Clearance Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  public void ShowItem() => DockingManager.ShowAndActivate(this.CreationInfo.Key);

  private void trvUser_KeyUp(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Delete || MessageBox.Show("Are you sure you want to delete these documents?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.DeleteSelectedUserNodes();
  }

  private void trvEntity_BeforeExpand(object sender, CancelableNodeEventArgs e)
  {
    TabDocumentPanel.FolderNode treeNode = e.TreeNode as TabDocumentPanel.FolderNode;
    UltraTree control = e.TreeNode.Control;
    if (treeNode == null)
      return;
    ((SubObjectBase) treeNode).Tag = (object) treeNode.Text;
    treeNode.Text += " Loading...";
    int? nullable = new int?(Conversions.ToInteger(treeNode.FolderID));
    this.PopulateFolders(control, nullable);
    this.AfterFoldersPopulated(control, nullable);
  }

  private void HideMenuItem(string key)
  {
    ((ToolsCollectionBase) this.ctxMenu.Tools)[key].SharedProps.Visible = false;
  }

  private void ShowMenuItem(string key)
  {
    ((ToolsCollectionBase) this.ctxMenu.Tools)[key].SharedProps.Visible = true;
  }

  private void ToggleMenuItemVisibility(string key, bool visible)
  {
    ((ToolsCollectionBase) this.ctxMenu.Tools)[key].SharedProps.Visible = visible;
  }

  private void HideAllMenuItems()
  {
    foreach (ToolBase tool in (ToolsCollectionBase) this.ctxMenu.Tools)
      tool.SharedProps.Visible = false;
  }

  private void ShowAllMenuItems()
  {
    foreach (ToolBase tool in (ToolsCollectionBase) this.ctxMenu.Tools)
      tool.SharedProps.Visible = true;
    try
    {
      ((ToolsCollectionBase) this.ctxMenu.Tools)["Add File"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{907B56F7-0C11-4CB7-869C-1A2F62191C98}");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void SetMenuItemText(string key, string text)
  {
    ((ToolPropsBase) ((ToolsCollectionBase) this.ctxMenu.Tools)[key].SharedProps).Caption = text;
  }

  private void contextMenu_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((CancelableToolEventArgs) e).Tool.Key, "contextMenu", false) != 0)
      return;
    if (!SecurityManager.Instance.AssertPermission("{72A4A5DB-D9D1-4181-8338-43EB57313025}"))
    {
      this.HideAllMenuItems();
    }
    else
    {
      try
      {
        Cursor.Current = MgaCursors.WaitCursor;
        this.ShowAllMenuItems();
        this.HideMenuItem("Delete File");
        if (this.ActiveControl == null || !(this.ActiveControl is UltraTree))
          return;
        UltraTree activeControl = (UltraTree) this.ActiveControl;
        UltraTreeNode nodeFromPoint = activeControl.GetNodeFromPoint(((System.Windows.Forms.Control) activeControl).PointToClient(Cursor.Position));
        this._workingNode = nodeFromPoint;
        activeControl.ActiveNode = nodeFromPoint;
        if (nodeFromPoint != null)
        {
          if (((DisposableObjectCollectionBase) activeControl.SelectedNodes).Count == 1)
            activeControl.SelectedNodes.Clear();
          nodeFromPoint.Selected = true;
        }
        bool visible = this.DisplayShowFoldersMenu(activeControl);
        this.DisplayFolderFilteringOptions();
        this.DisplayImageRightOptions(nodeFromPoint, activeControl);
        this.DisplaySelectSysParseAccordDocOptions(nodeFromPoint, activeControl);
        this.ToggleMenuItemVisibility("New Folder", visible);
        this.DisplayPinningOptions(nodeFromPoint, activeControl);
        TabDocumentPanel.FolderNode folderNode = nodeFromPoint as TabDocumentPanel.FolderNode;
        this.ToggleMenuItemVisibility("Delete Folder", folderNode != null);
        if (folderNode != null && folderNode.HasNodes)
        {
          if (nodeFromPoint.Expanded)
          {
            this.SetMenuItemText("CollapseExpand", "Collapse");
            ((ToolPropsBase) ((ToolsCollectionBase) this.ctxMenu.Tools)["CollapseExpand"].SharedProps).AppearancesSmall.Appearance.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.arrow_in;
          }
          else
          {
            this.SetMenuItemText("CollapseExpand", "Expand");
            ((ToolPropsBase) ((ToolsCollectionBase) this.ctxMenu.Tools)["CollapseExpand"].SharedProps).AppearancesSmall.Appearance.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.arrow_out;
          }
        }
        else
          this.HideMenuItem("CollapseExpand");
        this.ToggleMenuItemVisibility("Rename Folder", folderNode != null);
        this.HideItemsBasedOnNodeType(nodeFromPoint, activeControl);
        this.ToggleMenuItemVisibility("Concatenate Adobe Documents", this.SelectedAdobeDocumentFileNodes.Length >= 2);
        this.ToggleMenuItemVisibility("Abridge Adobe Document", this.SelectedAdobeDocumentFileNodes.Length == 1);
        this.ToggleMenuItemVisibility("Split Adobe Document", this.SelectedAdobeDocumentFileNodes.Length == 1);
        this.ToggleMenuItemVisibility("Insert Adobe Document", this.SelectedAdobeDocumentFileNodes.Length > 0 && this.SelectedAdobeDocumentFileNodes.Length <= 2);
        this.ToggleMenuItemVisibility("Replace Adobe Page", this.SelectedAdobeDocumentFileNodes.Length > 0 & this._canReplaceAdobePage);
        this.ToggleMenuItemVisibility("Filter by Type", this._showDocumentTypes && activeControl == this.trvEntity);
        bool flag1 = nodeFromPoint is TabDocumentPanel.FileNode fileNode && DocuSignUtil.IsSupportedFileType(Path.GetExtension(fileNode.FileName));
        this.ToggleMenuItemVisibility("Send to DocuSign", this._enableDocuSign && flag1 && this._entityDocs != null && this._entityDocs.HasControlGUID && activeControl == this.trvEntity && fileNode != null);
        bool flag2 = false;
        this._renewalControlGuid = new Guid?();
        if (this._entityDocs != null && this._entityDocs.HasControlGUID)
        {
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spRenewalControlGuid", new object[2]
          {
            (object) "@ControlGuid",
            (object) this._entityDocs.ControlGUID
          });
          if (dataTable.Rows.Count > 0)
          {
            this._renewalControlGuid = new Guid?(dataTable.Rows[0].Field<Guid>("ControlGuid"));
            this._renewedFromControlNo = dataTable.Rows[0].Field<int>("RenewedFromControlNo");
          }
          flag2 = this._renewalControlGuid.HasValue;
        }
        this.ToggleMenuItemVisibility("Copy to Renewal", this._entityDocs != null && this._entityDocs.HasControlGUID && flag2 && activeControl == this.trvEntity && fileNode != null);
        if (this._entityDocs != null && this._entityDocs.AllowAddNewDocument && fileNode != null)
        {
          string str1 = nodeFromPoint.Text;
          if (str1.Length > 21)
            str1 = $"{str1.Substring(0, 20)}...";
          string str2 = this._entityDocs.EntityName;
          if (str2.Length > 80 /*0x50*/)
            str2 = $"{str2.Substring(0, 80 /*0x50*/)}...";
          string Left = (string) Interaction.IIf(activeControl == this.trvUser, (object) "Associate", (object) "Disassociate");
          this.SetMenuItemText("Bind", string.Format(Left + " {0} to {1}", (object) str1, (object) str2));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Associate", false) == 0)
            ((ToolPropsBase) ((ToolsCollectionBase) this.ctxMenu.Tools)["Bind"].SharedProps).AppearancesSmall.Appearance.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.link_add;
          else
            ((ToolPropsBase) ((ToolsCollectionBase) this.ctxMenu.Tools)["Bind"].SharedProps).AppearancesSmall.Appearance.Image = (object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.link_break;
        }
        else
          this.HideMenuItem("Bind");
        this.DisplayMenuItemsBasedOnSecurity(activeControl);
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  private void CreateAssociatedNoteOnDocument()
  {
    if (this.ActiveControl != this.trvEntity || this.trvEntity.ActiveNode == null || !(this.trvEntity.ActiveNode is TabDocumentPanel.FileNode))
      return;
    TabDocumentPanel.FileNode activeNode = (TabDocumentPanel.FileNode) this.trvEntity.ActiveNode;
    ISupportNoteDocumentBinding noteDocumentBinding = TabDocumentPanel.Inspect<ISupportNoteDocumentBinding>((System.Windows.Forms.Control) Note_System.Instance.UIInteractive.CreateBoundNote((ISupportNoteSystem) new NoteSupportCache(this._entityDocs.EntityGuid, this._entityDocs.EntityName, this._entityDocs.FriendlyEntityName, this._entityDocs.RecreateTypeName, this._entityDocs.HasControlGUID, this._entityDocs.ControlGUID)));
    if (noteDocumentBinding == null)
      return;
    noteDocumentBinding.ExternalDocumentToBindTo = new Guid?(activeNode.DocumentGUID);
    NoteSupportCache noteSupportCache = new NoteSupportCache(activeNode.DocumentGUID, $"Note Bound to {activeNode.FileName}", $"Note Bound to {activeNode.FileName}", "NotARealNamespace.NotARecreatableType.Document", false, Guid.Empty);
    noteDocumentBinding.SecondaryAssociation = (ISupportNoteSystem) noteSupportCache;
  }

  public static T Inspect<T>(System.Windows.Forms.Control item) where T : class
  {
    T obj1 = item as T;
    PropertyInfo property = item.GetType().GetProperty("Child");
    if ((object) property != null)
      obj1 = property.GetValue((object) item, (object[]) null) as T;
    T obj2;
    if ((object) obj1 != null)
    {
      obj2 = obj1;
    }
    else
    {
      try
      {
        foreach (System.Windows.Forms.Control control in item.Controls)
        {
          T obj3 = TabDocumentPanel.Inspect<T>(control);
          if ((object) obj3 != null)
          {
            obj2 = obj3;
            goto label_12;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      obj2 = default (T);
    }
label_12:
    return obj2;
  }

  private DocumentSystemContextImageRightMenuOverride ImageRightMenuOverride
  {
    get
    {
      if (this._imageRightMenuOverride == null)
        this._imageRightMenuOverride = ObjectFactory.Instance.CreateObject(typeof (DocumentSystemContextImageRightMenuOverride)) as DocumentSystemContextImageRightMenuOverride;
      return this._imageRightMenuOverride;
    }
  }

  private void HandleContextMenuClick(string key)
  {
    string str = key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
    {
      case 33732141:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Open With ...", false) != 0)
          break;
        this.ViewFile(false, true);
        break;
      case 135637716:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Refresh", false) != 0 || !(this.ActiveControl is UltraTree activeControl1))
          break;
        this.RefreshTree(activeControl1);
        break;
      case 486666510:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Delete Folder", false) != 0)
          break;
        this.DeleteFolder();
        break;
      case 689809906:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Edit (Revision Tracking) ...", false) != 0)
          break;
        this.ViewFile(true, false);
        break;
      case 816668494:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Bind", false) != 0)
          break;
        this.Bind();
        break;
      case 826183192:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Edit With (Revision Tracking) ...", false) != 0)
          break;
        this.ViewFile(true, true);
        break;
      case 1053316775:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Replace Adobe Page", false) != 0)
          break;
        List<SelectedDocInfo> selectedDocInfo1 = TabDocumentPanel.GetSelectedDocInfo((UltraTree) this.ActiveControl);
        if (selectedDocInfo1.Count > 0)
        {
          ObjectFactory.Instance.CreateObjectAs<ReplacePDFController>().DisplayUI(this._entityDocs.ControlGUID, ReplacePDFInfo.Create(selectedDocInfo1), (Action<ReplacePDFInfo>) ([SpecialName] (returnInfo) =>
          {
            if (returnInfo == null)
              return;
            string path = DocumentManager.ReplaceDocumentPages(returnInfo);
            if (this.ActiveControl != null && this.ActiveControl == this.trvEntity && this._entityDocs != null && this._entityDocs.AllowAddNewDocument)
              DocumentManager.BeginFileAddWithBind(path, this._entityDocs);
            else
              DocumentManager.BeginFileAdd(path);
          }));
          break;
        }
        int num1 = (int) MessageBox.Show("You must select at least one document for this action.", "Select document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 1211423320:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Delete File", false) != 0)
          break;
        this.DeleteFile();
        break;
      case 1251650436:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Filter by Type", false) != 0)
          break;
        this.FilterByType();
        break;
      case 1779948316:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Send to DocuSign", false) != 0)
          break;
        List<DocuSignDocument> docList = new List<DocuSignDocument>();
        foreach (UltraTreeNode selectedNode in this.trvEntity.SelectedNodes)
        {
          if (selectedNode is TabDocumentPanel.FileNode fileNode)
          {
            DocuSignDocument docuSignDocument = new DocuSignDocument()
            {
              FileName = fileNode.FileName,
              DocumentGuid = fileNode.DocumentGUID
            };
            docList.Add(docuSignDocument);
          }
        }
        ((SendToDocuSignController) ObjectFactory.Instance.CreateObject(typeof (SendToDocuSignController))).DisplayUI(this._entityDocs.ControlGUID, docList);
        break;
      case 1797501203:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "File Names", false) != 0)
          break;
        TabDocumentPanel.ViewFileNames();
        break;
      case 1905504172:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Advanced Print Options ...", false) != 0)
          break;
        FormSettings.ShowFormDialog(typeof (AdvancedPrintOptions));
        break;
      case 1911050090:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Add File", false) != 0)
          break;
        this.AddFile();
        break;
      case 1989247150:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Show Enhanced ToolTips", false) != 0)
          break;
        this.DisplayEnhancedToolTips = !this.DisplayEnhancedToolTips;
        break;
      case 2114910205:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Split Adobe Document", false) != 0)
          break;
        this.SplitAdobeDoc();
        break;
      case 2167366340:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Parse Acord App and View in NetRate", false) != 0)
          break;
        AcordParserControlOverride objectAs = ObjectFactory.Instance.CreateObjectAs<AcordParserControlOverride>();
        TabDocumentPanel.FileNode workingNode = this._workingNode as TabDocumentPanel.FileNode;
        if (this._entityDocs == null || workingNode == null || objectAs == null)
          break;
        objectAs.HandleClick((IRecreatableEntity) this._entityDocs, workingNode);
        break;
      case 2335130708:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Transfer File", false) != 0)
          break;
        this.TransferFile();
        break;
      case 2340089671:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "New Folder", false) != 0)
          break;
        this.NewFolder();
        break;
      case 2553967563:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Abridge Adobe Document", false) != 0)
          break;
        Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids((UltraTree) this.ActiveControl);
        if (selectedDocGuids.Length == 1)
        {
          DocumentManager.AbridgeDocument(selectedDocGuids[0]);
          break;
        }
        int num2 = (int) MessageBox.Show("You must select only one document for this action.", "Too many documents selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 2788221018:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "File Descriptions", false) != 0)
          break;
        TabDocumentPanel.ViewDescriptions();
        break;
      case 2867965184:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "File Properties", false) != 0)
          break;
        this.Properties();
        break;
      case 2887717897:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Show Folders", false) != 0)
          break;
        this.ShowFolders();
        break;
      case 2911357104:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Enable Folder Filter", false) != 0)
          break;
        this.EnableFolderFilter();
        break;
      case 3023440125:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "MailViewDateSent", false) != 0)
          break;
        TabDocumentPanel.ViewMailDatesent();
        break;
      case 3152858100:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "MailViewDateReceived", false) != 0)
          break;
        TabDocumentPanel.ViewMailDateReceived();
        break;
      case 3171528670:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "View File", false) != 0)
          break;
        this.ViewFile(false, false);
        break;
      case 3322159135:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "MailViewDateAdded", false) != 0)
          break;
        TabDocumentPanel.ViewMailDateadded();
        break;
      case 3571170696:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Insert Adobe Document", false) != 0)
          break;
        List<SelectedDocInfo> selectedDocInfo2 = TabDocumentPanel.GetSelectedDocInfo((UltraTree) this.ActiveControl);
        if (selectedDocInfo2.Count < 3)
        {
          ObjectFactory.Instance.CreateObjectAs<InsertPDFController>().DisplayUI(this._entityDocs.ControlGUID, InsertPDFInfo.Create(selectedDocInfo2), (Action<InsertPDFInfo>) ([SpecialName] (returnInfo) =>
          {
            if (returnInfo == null)
              return;
            string path = DocumentManager.InsertDocument(returnInfo);
            if (this.ActiveControl != null && this.ActiveControl == this.trvEntity && this._entityDocs != null && this._entityDocs.AllowAddNewDocument)
              DocumentManager.BeginFileAddWithBind(path, this._entityDocs);
            else
              DocumentManager.BeginFileAdd(path);
          }));
          break;
        }
        int num3 = (int) MessageBox.Show("You must select only one or two documents for this action.", "Too many documents selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      case 3803579147:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "SendToImageRight", false) != 0 || this._entityDocs == null || !(this.ActiveControl is UltraTree activeControl2))
          break;
        this.ImageRightMenuOverride?.SendFilesToImageRight((IRecreatableEntity) this._entityDocs, TabDocumentPanel.GetSelectedDocGuids(activeControl2));
        break;
      case 4078590255:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Concatenate Adobe Documents", false) != 0)
          break;
        if (this._entityDocs != null)
        {
          DocumentManager.ConcatenateAdobeDocuments(this.SelectedAdobeDocumentFileNodes, (ISupportDocumentSystem) new DocSupportCache(this._entityDocs));
          break;
        }
        DocumentManager.ConcatenateAdobeDocuments(this.SelectedAdobeDocumentFileNodes);
        break;
      case 4129175913:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Rename Folder", false) != 0)
          break;
        this.RenameFolder();
        break;
      case 4189192045:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Copy to Renewal", false) != 0 || !this._renewalControlGuid.HasValue)
          break;
        Guid identifier = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 QuoteGuid FROM tblQuotes WHERE ControlGuid = @ControlGuid ORDER BY QuoteID DESC", new object[2]
        {
          (object) "@ControlGuid",
          (object) this._renewalControlGuid.Value
        });
        ISupportDocumentSystem docSupport = (ISupportDocumentSystem) ObjectFactory.Instance.CreateObject(ObjectFactory.Instance.CreateTypeFromString("MGASystems.BusinessObjects.Quote"), new object[1]
        {
          (object) identifier
        });
        List<(Guid, string)> valueTupleList = new List<(Guid, string)>();
        foreach (UltraTreeNode selectedNode in this.trvEntity.SelectedNodes)
        {
          if (selectedNode is TabDocumentPanel.FileNode fileNode)
            valueTupleList.Add((fileNode.DocumentGUID, fileNode.FileName));
        }
        try
        {
          foreach ((Guid, string) valueTuple in valueTupleList)
          {
            DocumentManager.BindDocument(valueTuple.Item1, docSupport);
            CurrentUser.Instance.LogAction($"Copy document {valueTuple.Item2} from Control #{this._renewedFromControlNo.ToString()}", identifier);
          }
          break;
        }
        finally
        {
          List<(Guid, string)>.Enumerator enumerator;
          enumerator.Dispose();
        }
    }
  }

  private void HandleContextMenuClick2(string key)
  {
    string str = key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
    {
      case 93797368:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Save As", false) != 0)
          break;
        this.SaveAs();
        break;
      case 104168189:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Folder", false) != 0)
          break;
        this.SetSort(TabDocumentPanel.SortCriteria.Folder);
        break;
      case 488336838:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Unpin Document", false) != 0)
          break;
        this.UnpinDocument();
        break;
      case 1122566820:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Date Received", false) != 0)
          break;
        this.SetSort(TabDocumentPanel.SortCriteria.MetaMailReceived);
        break;
      case 1127555431:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Email", false) != 0)
          break;
        this.EmailDocument();
        break;
      case 1222138868:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Compressed", false) != 0)
          break;
        this.SetSort(TabDocumentPanel.SortCriteria.Compressed);
        break;
      case 1499528776:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "File Size", false) != 0)
          break;
        this.SetSort(TabDocumentPanel.SortCriteria.FileSize);
        break;
      case 1634418620:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Save As Zipped", false) != 0)
          break;
        this.SaveAsZipped();
        break;
      case 1999819791:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Rename File", false) != 0)
          break;
        this.RenameFile();
        break;
      case 2120566246:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "File Extension", false) != 0)
          break;
        this.SetSort(TabDocumentPanel.SortCriteria.FileAssociation);
        break;
      case 2571076141:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Date Sent", false) != 0)
          break;
        this.SetSort(TabDocumentPanel.SortCriteria.MetaMailSent);
        break;
      case 2749056371:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "EmailAsPdf", false) != 0)
          break;
        this.EmailDocument(true);
        break;
      case 3083093498:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CollapseExpand", false) != 0)
          break;
        this.CollapseExpand();
        break;
      case 3182042804:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Unpin All Documents", false) != 0)
          break;
        DocumentManager.ClearAllPinnedDocuments();
        break;
      case 3760858280:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Filename", false) != 0)
          break;
        if (Preferences.GetPreferenceBool("DockingTabs.Documents.ShowFileNames"))
        {
          this.SetSort(TabDocumentPanel.SortCriteria.FileName);
          break;
        }
        this.SetSort(TabDocumentPanel.SortCriteria.Description);
        break;
      case 3879400639:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Create Associated Note", false) != 0)
          break;
        this.CreateAssociatedNoteOnDocument();
        break;
      case 3895594280:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Print", false) != 0)
          break;
        this.Print();
        break;
      case 3922025325:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Pin Document", false) != 0)
          break;
        this.PinDocument();
        break;
      case 4026012527:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Date Added", false) != 0)
          break;
        this.SetSort(TabDocumentPanel.SortCriteria.DateAdded);
        break;
    }
  }

  private void contextMenu_ToolClick(object sender, ToolClickEventArgs e)
  {
    this.HandleContextMenuClick(((ToolEventArgs) e).Tool.Key);
    this.HandleContextMenuClick2(((ToolEventArgs) e).Tool.Key);
  }

  private void tree_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    UltraTree ultraTree = (UltraTree) sender;
    if (!Preferences.GetPreferenceBool("DockingTabs.Documents.EnhancedToolTips") && System.Windows.Forms.Control.ModifierKeys != Keys.Shift || !(e.Element is NodeTextUIElement))
      return;
    System.Drawing.Point point;
    ref System.Drawing.Point local = ref point;
    Rectangle rect = e.Element.Rect;
    int x = rect.X;
    rect = e.Element.Rect;
    int y = rect.Y;
    local = new System.Drawing.Point(x, y);
    UltraTreeNode nodeFromPoint = ultraTree.GetNodeFromPoint(point);
    if (nodeFromPoint == null || !(nodeFromPoint is TabDocumentPanel.FileNode fileNode) || System.Windows.Forms.Control.MouseButtons == MouseButtons.Left || string.IsNullOrEmpty(fileNode.FormattedToolTip))
      return;
    UltraToolTipInfo ultraToolTipInfo = new UltraToolTipInfo(fileNode.FormattedToolTip, (ToolTipImage) 0, "", (DefaultableBoolean) 1);
  }

  private void trvEntity_KeyUp(object sender, KeyEventArgs e)
  {
    if (this.trvEntity.ActiveNode == null || e.KeyCode != Keys.Delete || this.trvEntity.ActiveNode.IsEditing || !SecurityManager.Instance.AssertPermission("{16EF6A9D-91A2-45c7-AB12-AC6A601368DE}"))
      return;
    UltraTree tree = (UltraTree) sender;
    Guid[] selectedDocGuids = TabDocumentPanel.GetSelectedDocGuids(tree);
    if (tree.ActiveNode.IsEditing)
      return;
    if (selectedDocGuids.Length == 1)
    {
      DocumentManager.BeginUnbindDocument(selectedDocGuids[0], this._entityDocs.EntityGuid);
    }
    else
    {
      int num = selectedDocGuids.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (index == selectedDocGuids.Length - 1)
          DocumentManager.UnbindDocument(selectedDocGuids[index], (IRecreatableEntity) this._entityDocs, false);
        else
          DocumentManager.UnbindDocument(selectedDocGuids[index], (IRecreatableEntity) this._entityDocs, true);
      }
    }
  }

  private void trvEntity_Click(object sender, EventArgs e)
  {
    UltraTree ultraTree = (UltraTree) sender;
    switch ((object) ultraTree.GetNodeFromPoint(((System.Windows.Forms.Control) ultraTree).PointToClient(Cursor.Position)))
    {
      case null:
        this.SaveCurrentEntityTreeStructure(false);
        break;
      case TabDocumentPanel.FileNode node1:
        this.UpdateActiveNode((UltraTreeNode) node1, (UltraTree) this.trvEntity);
        this.SaveCurrentEntityTreeStructure(true);
        break;
      case TabDocumentPanel.FolderNode node2:
        this.UpdateActiveNode((UltraTreeNode) node2, (UltraTree) this.trvEntity);
        this.SaveCurrentEntityTreeStructure(true);
        break;
      default:
        this.SaveCurrentEntityTreeStructure(false);
        break;
    }
  }

  private void UpdateActiveNode(UltraTreeNode node, UltraTree tree) => tree.ActiveNode = node;

  private void chkEntityOnly_CheckedChanged(object sender, EventArgs e)
  {
    Preferences.SetPreference("DockingTabs.Documents.AssociatedDocs.FilterEntitiesOnly", ((UltraToggleEditorBase) this.chkEntityOnly).Checked);
    this.RefreshTree((UltraTree) this.trvEntity);
  }

  private static bool ShouldShowFileAddDialog()
  {
    bool flag;
    switch (Preferences.GetPreferenceInt("MGASystems.IMS.Email.DocSupport.Override"))
    {
      case 0:
        flag = false;
        break;
      case 1:
        flag = true;
        break;
      default:
        flag = SystemSettings.GetSetting<bool>("Outlook.TrackSentEmails.DisplayFileAddDialog", false);
        break;
    }
    return flag;
  }

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    if (!(eventGuid == BroadcastMessages.OutlookEmailSent))
      return;
    string propertyValue1 = "";
    int propertyValue2 = -1;
    if (!(context is MailItem mailItem))
      return;
    string proposedFileName = MGATempFolder.MGATempRandomFolderPath + mailItem.Subject;
    if (!proposedFileName.EndsWith(".msg"))
      proposedFileName += ".msg";
    string str = FilePath.Resolve(proposedFileName);
    if (OutlookTracker.TryGetMailItemUserPropertyValue<string>(RuntimeHelpers.GetObjectValue(context), "MGASystems.IMS.Email.DocSupport", ref propertyValue1))
    {
      ISupportDocumentSystem documentSupport = (ISupportDocumentSystem) DocSupportCache.FromString(propertyValue1);
      // ISSUE: reference to a compiler-generated method
      mailItem.SaveAs(str, RuntimeHelpers.GetObjectValue((object) Missing.Value));
      if (OutlookTracker.TryGetMailItemUserPropertyValue<int>(RuntimeHelpers.GetObjectValue(context), "MGASystems.IMS.Email.DocFolderID", ref propertyValue2))
        this.UploadEmailDocumentOnUIThread(str, documentSupport, propertyValue2);
      else
        this.UploadEmailDocumentOnUIThread(str, documentSupport);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      mailItem.SaveAs(str, RuntimeHelpers.GetObjectValue((object) Missing.Value));
      this.UploadEmailDocumentOnUIThread(str);
    }
  }

  private void UploadEmailDocumentOnUIThread(
    string path,
    ISupportDocumentSystem documentSupport = null,
    int folderId = -1)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) ([SpecialName] (documentPath, docSupport) => TabDocumentPanel.UploadEmailDocument(documentPath, docSupport, folderId)), (object) path, (object) documentSupport);
    else
      TabDocumentPanel.UploadEmailDocument(path, documentSupport, folderId);
  }

  private static void UploadEmailDocument(
    string path,
    ISupportDocumentSystem documentSupport,
    int folderId)
  {
    if (documentSupport == null)
    {
      if (TabDocumentPanel.ShouldShowFileAddDialog())
        DocumentManager.BeginFileAdd(path);
      else
        DocumentManager.BeginFileAdd(path, folderId, Path.GetFileNameWithoutExtension(path));
    }
    else if (TabDocumentPanel.ShouldShowFileAddDialog())
      DocumentManager.BeginFileAddWithBind(path, documentSupport);
    else
      DocumentManager.BeginFileAddWithBind(path, folderId, Path.GetFileNameWithoutExtension(path), documentSupport);
  }

  private void txtFilterAssoc_TextChanged(object sender, EventArgs e) => this.SetNodeVisibility();

  private void SetNodeVisibility()
  {
    try
    {
      foreach (string nodeKey in this.nodeKeyList)
      {
        UltraTreeNode nodeByKey = this.trvEntity.GetNodeByKey(nodeKey);
        if (nodeByKey != null)
          nodeByKey.Visible = this.IsNodeVisible(nodeByKey);
      }
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private bool IsNodeVisible(UltraTreeNode node)
  {
    bool flag1 = true;
    bool flag2 = true;
    if (!this._filterTypeGuid.Equals(Guid.Empty) && node is TabDocumentPanel.FileNode)
    {
      TabDocumentPanel.FileNode fileNode = (TabDocumentPanel.FileNode) node;
      if (fileNode.TypeGuid.HasValue)
      {
        if (!fileNode.TypeGuid.Equals((object) this._filterTypeGuid))
          flag1 = false;
      }
      else
        flag1 = false;
    }
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtFilterAssoc).Text))
      flag2 = node.Text.ToLower().Contains(((TextEditorControlBase) this.txtFilterAssoc).Text.ToLower());
    return flag1 && flag2;
  }

  private void SendDocumentEmail(
    ISupportDocumentSystem docSupport,
    string subject,
    Guid[] documentGuids,
    string[] toRecipients,
    bool convertToPdf,
    string[] ccList,
    string[] bcList,
    int emailAssociatedFolderID)
  {
    MessageObject message = new MessageObject();
    message.Subject = subject;
    string[] strArray1 = toRecipients;
    int index1 = 0;
    while (index1 < strArray1.Length)
    {
      string str = strArray1[index1];
      message.Recipients.Add(str);
      checked { ++index1; }
    }
    List<string> stringList = new List<string>();
    Guid[] guidArray = documentGuids;
    int index2 = 0;
    while (index2 < guidArray.Length)
    {
      Guid documentStoreGuid = guidArray[index2];
      message.FileAttachments.Add(DocumentManager.SaveDocumentToFile(documentStoreGuid));
      checked { ++index2; }
    }
    if (ccList != null)
    {
      string[] strArray2 = ccList;
      int index3 = 0;
      while (index3 < strArray2.Length)
      {
        string str = strArray2[index3];
        message.CCRecipients.Add(str);
        checked { ++index3; }
      }
    }
    if (bcList != null)
    {
      string[] strArray3 = bcList;
      int index4 = 0;
      while (index4 < strArray3.Length)
      {
        string str = strArray3[index4];
        message.BCCRecipients.Add(str);
        checked { ++index4; }
      }
    }
    message.SendOutlook = OutlookSendType.Show;
    if (Utility.IsNull((object) message.HTMLBody) && MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Outlook.DefaultToHtmlBody"))
      message.HTMLBody = " ";
    if (docSupport != null)
    {
      message.UserProperties.Clear();
      message.UserProperties.Add((object) "MGASystems.IMS.Email.DocSupport", (object) new DocSupportCache(docSupport).ToString());
      int num = -1;
      if (emailAssociatedFolderID != -1)
        num = emailAssociatedFolderID;
      else if (documentGuids.Length == 1)
        num = DocumentManager.GetDocumentMetadata(documentGuids[0]).FolderId;
      if (num != -1)
        message.UserProperties.Add((object) "MGASystems.IMS.Email.DocFolderID", (object) num);
    }
    bool setting = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Outlook.TrackSentEmails");
    MGASystems.Common.Email.Outlook.Send(message, setting);
  }

  private enum SortCriteria
  {
    FileName,
    DateAdded,
    FileSize,
    FileAssociation,
    Compressed,
    MetaMailSent,
    MetaMailReceived,
    Description,
    Folder,
  }

  private class TreeSortInfo : IComparer
  {
    private string _criteriaKey;
    private string _ascKey;

    public TreeSortInfo(string criteriaKey, string ascKey)
    {
      this._criteriaKey = criteriaKey;
      this._ascKey = ascKey;
    }

    public bool SortAsc => Preferences.GetPreferenceBool(this._ascKey);

    public TabDocumentPanel.SortCriteria SortCriteria
    {
      get
      {
        return (TabDocumentPanel.SortCriteria) Enum.Parse(typeof (TabDocumentPanel.SortCriteria), Conversions.ToString(Preferences.GetPreferenceInt(this._criteriaKey)));
      }
      set
      {
        if (value == this.SortCriteria)
          Preferences.SetPreference(this._ascKey, !this.SortAsc);
        else
          Preferences.SetPreference(this._criteriaKey, (int) value);
      }
    }

    public int Compare(object x, object y)
    {
      return this.InternalCompare(RuntimeHelpers.GetObjectValue(x), RuntimeHelpers.GetObjectValue(y));
    }

    [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
    private static TabDocumentPanel.TreeSortInfo.MetaXmlResult PreEvaluateMetaXml(
      string metaXmlNodeX,
      string metaXmlNodeY)
    {
      TabDocumentPanel.TreeSortInfo.MetaXmlResult metaXml = new TabDocumentPanel.TreeSortInfo.MetaXmlResult();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(metaXmlNodeX, metaXmlNodeY, false) == 0)
        metaXml.CompareResult = 0;
      else if (string.IsNullOrEmpty(metaXmlNodeX) && !string.IsNullOrEmpty(metaXmlNodeY))
        metaXml.CompareResult = -1;
      else if (!string.IsNullOrEmpty(metaXmlNodeX) && string.IsNullOrEmpty(metaXmlNodeY))
      {
        metaXml.CompareResult = 1;
      }
      else
      {
        try
        {
          metaXml.xmlDocX = new XmlDocument();
          metaXml.xmlDocX.LoadXml(metaXmlNodeX);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          metaXml.xmlDocY = new XmlDocument();
          metaXml.xmlDocY.LoadXml(metaXmlNodeY);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        metaXml.CompareResult = metaXml.xmlDocX == null || metaXml.xmlDocY == null ? (metaXml.xmlDocX == null ? -1 : 1) : 2;
      }
      return metaXml;
    }

    private static int SortMetaXmlMail(
      string metaXmlNodeX,
      string metaXmlNodeY,
      TabDocumentPanel.SortCriteria criteria)
    {
      TabDocumentPanel.TreeSortInfo.MetaXmlResult metaXml = TabDocumentPanel.TreeSortInfo.PreEvaluateMetaXml(metaXmlNodeX, metaXmlNodeY);
      int num;
      if (metaXml.CompareResult == 2)
      {
        XmlNode xmlNode1 = metaXml.xmlDocX.SelectSingleNode("//MailInfo");
        XmlNode xmlNode2 = metaXml.xmlDocY.SelectSingleNode("//MailInfo");
        if (xmlNode1 != null && xmlNode2 != null)
        {
          DateTime date1;
          DateTime date2;
          switch (criteria)
          {
            case TabDocumentPanel.SortCriteria.MetaMailSent:
              date1 = TabDocumentPanel.TreeSortInfo.ToDate(xmlNode1.Attributes["Sent"].Value);
              date2 = TabDocumentPanel.TreeSortInfo.ToDate(xmlNode2.Attributes["Sent"].Value);
              break;
            case TabDocumentPanel.SortCriteria.MetaMailReceived:
              date1 = TabDocumentPanel.TreeSortInfo.ToDate(xmlNode1.Attributes["Received"].Value);
              date2 = TabDocumentPanel.TreeSortInfo.ToDate(xmlNode2.Attributes["Received"].Value);
              break;
            default:
              throw new InvalidOperationException("Invalid sort criteria passed into SortMetaXmlMail");
          }
          num = DateTime.Compare(date1, date2);
        }
        else
          num = xmlNode1 == null || xmlNode2 != null ? (xmlNode2 == null || xmlNode1 != null ? 0 : -1) : 1;
      }
      else
        num = metaXml.CompareResult;
      return num;
    }

    private static DateTime ToDate(string dateString)
    {
      DateTime date;
      if (string.IsNullOrWhiteSpace(dateString))
      {
        date = DateTime.Now;
      }
      else
      {
        try
        {
          date = Conversions.ToDate(dateString);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          date = DateTime.Now;
          ProjectData.ClearProjectError();
        }
      }
      return date;
    }

    private int InternalCompare(object x, object y)
    {
      TabDocumentPanel.FolderNode folderNode1 = x as TabDocumentPanel.FolderNode;
      TabDocumentPanel.FolderNode folderNode2 = y as TabDocumentPanel.FolderNode;
      TabDocumentPanel.FileNode fileNode1 = x as TabDocumentPanel.FileNode;
      TabDocumentPanel.FileNode fileNode2 = y as TabDocumentPanel.FileNode;
      int num1;
      if (folderNode1 != null && folderNode2 != null)
        num1 = string.Compare(folderNode1.Text, folderNode2.Text);
      else if (fileNode1 != null && fileNode2 != null)
      {
        switch (this.SortCriteria)
        {
          case TabDocumentPanel.SortCriteria.FileName:
            num1 = string.Compare(fileNode1.FileName, fileNode2.FileName);
            break;
          case TabDocumentPanel.SortCriteria.DateAdded:
            num1 = DateTime.Compare(fileNode1.DateAdded, fileNode2.DateAdded);
            break;
          case TabDocumentPanel.SortCriteria.FileSize:
            num1 = fileNode1.OriginalFileSize != fileNode2.OriginalFileSize ? (fileNode1.OriginalFileSize > fileNode2.OriginalFileSize ? -1 : 1) : 0;
            break;
          case TabDocumentPanel.SortCriteria.FileAssociation:
            num1 = string.Compare(fileNode1.FileAssociation, fileNode2.FileAssociation);
            break;
          case TabDocumentPanel.SortCriteria.Compressed:
            num1 = fileNode1.Compressed != fileNode2.Compressed ? (!fileNode1.Compressed || fileNode2.Compressed ? -1 : 1) : 0;
            break;
          case TabDocumentPanel.SortCriteria.MetaMailSent:
          case TabDocumentPanel.SortCriteria.MetaMailReceived:
            num1 = TabDocumentPanel.TreeSortInfo.SortMetaXmlMail(fileNode1.MetaXml, fileNode2.MetaXml, this.SortCriteria);
            break;
          case TabDocumentPanel.SortCriteria.Description:
            num1 = string.Compare(fileNode1.Description, fileNode2.Description);
            break;
          case TabDocumentPanel.SortCriteria.Folder:
            string strA = "";
            if (fileNode1.HasFolderID)
              strA = fileNode1.FolderID;
            string strB = "";
            if (fileNode2.HasFolderID)
              strB = fileNode2.FolderID;
            num1 = string.Compare(strA, strB);
            break;
        }
      }
      else
      {
        int num2 = 0;
        if (folderNode1 != null)
          num2 = 1;
        else if (folderNode2 != null)
          num2 = -1;
        if (this.SortAsc)
          num2 *= -1;
        num1 = num2;
      }
      return num1;
    }

    private class MetaXmlResult
    {
      public int CompareResult;
      public XmlDocument xmlDocX;
      public XmlDocument xmlDocY;
    }
  }

  private enum MailDateStyle
  {
    DateAdded,
    DateSent,
    DateReceived,
  }

  private delegate void FileModifiedHandler(object fullPath);

  [SuppressMessage("Microsoft.Usage", "CA2229:ImplementSerializationConstructors")]
  [Serializable]
  internal sealed class FolderNode : UltraTreeNode
  {
    private Guid _secureResourceGuid;
    private string _parentKey;
    private bool _isNew;

    public FolderNode(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public FolderNode(dsDocumentPanel.tblDocumentFoldersRow row)
      : base(row.FolderID.ToString(), row.FolderName)
    {
      this._secureResourceGuid = row.SecureResourceGuid;
      if (!row.IsParentFolderIDNull())
        this._parentKey = row.ParentFolderID.ToString();
      this.LeftImages.Add((object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.folder);
    }

    public FolderNode(string parentKey)
    {
      this._parentKey = parentKey;
      this._isNew = true;
    }

    public FolderNode() => this._isNew = true;

    public Guid SecureResourceGuid => this._secureResourceGuid;

    public string ParentFolderID => this._parentKey;

    public bool IsNew
    {
      get => this._isNew;
      set => this._isNew = value;
    }

    public string FolderID => this.Key;
  }

  private delegate void RepositionNodeHandler(UltraTree tree);

  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  [SuppressMessage("Microsoft.Usage", "CA2229:ImplementSerializationConstructors")]
  [Serializable]
  public sealed class FileNode : UltraTreeNode
  {
    private string _fileDropPath;
    private bool _pinned;
    private DataRow _row;
    private static FileTypeIconCollection _fileTypeIconCollection;
    private string _controlKey;
    private string _formattedToolTip;

    internal string FileDropPath
    {
      get => this._fileDropPath;
      set => this._fileDropPath = value;
    }

    private static FileTypeIconCollection FileTypeIcons
    {
      get
      {
        if (TabDocumentPanel.FileNode._fileTypeIconCollection == null)
          TabDocumentPanel.FileNode._fileTypeIconCollection = new FileTypeIconCollection();
        return TabDocumentPanel.FileNode._fileTypeIconCollection;
      }
    }

    public Guid? TypeGuid
    {
      get
      {
        object objectValue = RuntimeHelpers.GetObjectValue(this._row["TypeGUID"]);
        return !Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) ? (Guid?) objectValue : new Guid?();
      }
    }

    public FileNode(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      DataTable dataTable = (DataTable) info.GetValue("Table", typeof (DataTable));
      object obj = info.GetValue("DocumentStoreGuid", typeof (Guid));
      Guid guid = obj != null ? (Guid) obj : new Guid();
      this._row = dataTable.Select($"DocumentStoreGuid = '{guid}'")[0];
      this._controlKey = Conversions.ToString(info.GetValue(nameof (ControlKey), typeof (string)));
      this.Key = guid.ToString();
      this.Enabled = SecurityManager.Instance.AssertPermission("{7994442C-0ECF-492b-8949-C8D67814751C}", 10);
    }

    public FileNode(DataRow row, string controlKey)
    {
      this._controlKey = controlKey;
      this._row = row;
      this.Key = this.DocumentGUID.ToString();
      try
      {
        this.LeftImages.Add((object) TabDocumentPanel.FileNode.FileTypeIcons.FindIcon(new FileInfo(frmDownloadDocument.FixLongFilename(this.FileName)).Extension));
      }
      catch (NotSupportedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      this.Enabled = SecurityManager.Instance.AssertPermission("{7994442C-0ECF-492b-8949-C8D67814751C}", 10);
      if (Preferences.GetPreferenceBool("DockingTabs.Documents.ShowFileNames"))
        this.Text = $"{this.FileName}, {this.GetDisplayDateString()}";
      else
        this.Text = $"{this.Description}, {this.GetDisplayDateString()}";
    }

    private string GetDisplayDateString()
    {
      string displayDateString;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.FileAssociation, "Outlook Item", false) == 0)
      {
        TabDocumentPanel.MailDateStyle preferenceInt = (TabDocumentPanel.MailDateStyle) Preferences.GetPreferenceInt("DockingTabs.Documents.MailDateStyle");
        if (preferenceInt == TabDocumentPanel.MailDateStyle.DateAdded)
          displayDateString = this.DateAdded.ToString();
        else if (string.IsNullOrEmpty(this.MetaXml))
        {
          displayDateString = this.DateAdded.ToString();
        }
        else
        {
          XmlDocument xmlDocument = new XmlDocument();
          try
          {
            xmlDocument.LoadXml(this.MetaXml);
          }
          catch (XmlException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            displayDateString = this.DateAdded.ToString();
            ProjectData.ClearProjectError();
            goto label_10;
          }
          XmlNode xmlNode = xmlDocument.SelectSingleNode("//MailInfo");
          displayDateString = xmlNode == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlNode.Name, "MailInfo", false) != 0 ? this.DateAdded.ToString() : (preferenceInt != TabDocumentPanel.MailDateStyle.DateReceived ? $"Sent:{xmlNode.Attributes["Sent"].Value}" : $"Recvd:{xmlNode.Attributes["Received"].Value}");
        }
      }
      else
        displayDateString = this.DateAdded.ToString();
label_10:
      return displayDateString;
    }

    public FileNode(DataRow row, bool pinned, string controlKey)
      : this(row, controlKey)
    {
      this.LeftImages.Add((object) ImageCache.Instance.Pin);
      this._pinned = pinned;
    }

    public bool Pinned => this._pinned;

    public string ControlKey => this._controlKey;

    [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
    public Guid DocumentGUID
    {
      get
      {
        object obj = this._row["DocumentStoreGuid"];
        return obj == null ? new Guid() : (Guid) obj;
      }
    }

    public string Description
    {
      get
      {
        return this._row.IsNull(nameof (Description)) ? string.Empty : Conversions.ToString(this._row[nameof (Description)]);
      }
    }

    public string FileAssociation => Conversions.ToString(this._row[nameof (FileAssociation)]);

    public DateTime DateAdded => Conversions.ToDate(this._row[nameof (DateAdded)]);

    public string FileName
    {
      get
      {
        return frmDownloadDocument.RemoveInvalidCharsFromFileName(Conversions.ToString(this._row[nameof (FileName)]));
      }
      set => this._row[nameof (FileName)] = (object) value;
    }

    public bool Compressed => Conversions.ToBoolean(this._row[nameof (Compressed)]);

    public int OriginalFileSize => Conversions.ToInteger(this._row[nameof (OriginalFileSize)]);

    public override string ToString()
    {
      return !Preferences.GetPreferenceBool("DockingTabs.Documents.ShowFileNames") ? this.Description : this.FileName;
    }

    [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "Member")]
    public string FolderID => Conversions.ToString(this._row[nameof (FolderID)]);

    [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "Member")]
    public bool HasFolderID => !this._row.IsNull("FolderID");

    [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      base.GetObjectData(info, context);
      this._controlKey = ((System.Windows.Forms.Control) this.Control).Name;
      info.AddValue("Table", (object) this._row.Table, typeof (DataTable));
      info.AddValue("DocumentStoreGuid", (object) this.DocumentGUID, typeof (Guid));
      info.AddValue("ControlKey", (object) this._controlKey, typeof (string));
    }

    public void ForceSetControlKey()
    {
      if (this.Control == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((System.Windows.Forms.Control) this.Control).Name, this._controlKey, false) == 0)
        return;
      this._controlKey = ((System.Windows.Forms.Control) this.Control).Name;
    }

    public string MetaXml
    {
      get
      {
        string metaXml;
        if (!this._row.IsNull(nameof (MetaXml)))
        {
          string str = Conversions.ToString(this._row[nameof (MetaXml)]);
          metaXml = str.Length < 8000 ? str : string.Empty;
        }
        else
          metaXml = string.Empty;
        return metaXml;
      }
    }

    public string FormattedToolTip
    {
      get
      {
        if (string.IsNullOrEmpty(this._formattedToolTip))
          this._formattedToolTip = !string.IsNullOrEmpty(this.MetaXml) ? $"{this.Text}\r\n{TabDocumentPanel.FileNode.FormatMetaXml(this.MetaXml)}" : this.Text;
        return this._formattedToolTip;
      }
    }

    private static string FormatMetaXml(string metaXml)
    {
      string str1;
      if (string.IsNullOrEmpty(metaXml))
      {
        str1 = string.Empty;
      }
      else
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(metaXml);
        XmlNode xmlNode = xmlDocument.SelectSingleNode("//MailInfo");
        if (xmlNode != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xmlNode.Name, "MailInfo", false) == 0)
        {
          string str2 = string.Format("Sent:{1}{0}Recvd:{2}", (object) "\r\n", (object) xmlNode.Attributes["Sent"].Value, (object) xmlNode.Attributes["Received"].Value);
          if (xmlNode.Attributes["Subject"] != null)
            str2 += $"{"\r\n"}Subject:{xmlNode.Attributes["Subject"].Value}";
          if (xmlNode.Attributes["Body"] != null)
            str2 += $"{"\r\n"}{xmlNode.Attributes["Body"].Value}";
          str1 = str2;
        }
        else
          str1 = string.Empty;
      }
      return str1;
    }
  }

  private delegate void RefreshTreeHandler(UltraTree tree);

  private class TreeDragDropHelper : IDisposable
  {
    private readonly UltraTree _tree;
    private Rectangle _dragBoxFromMouseDown;
    private UltraTreeNode _itemUnderMouse;
    private readonly Cursor _dragCursor;
    private readonly TabDocumentPanel _documentPanel;
    private bool _rightMouseButtonDown;

    public TreeDragDropHelper(UltraTree tree, TabDocumentPanel documentPanel)
    {
      this._tree = tree;
      this._documentPanel = documentPanel;
      Log.Write("TreeDragDropHelper constructor", "DocumentSystem.DocumentPanel");
      if (!((System.Windows.Forms.Control) this._tree).AllowDrop)
        Log.Write("TreeDragDropHelper tree.AllowDrop = false", "DocumentSystem.DocumentPanel");
      else
        Log.Write("TreeDragDropHelper tree.AllowDrop = true", "DocumentSystem.DocumentPanel");
      ((System.Windows.Forms.Control) this._tree).MouseMove += new MouseEventHandler(this.tree_MouseMove);
      ((System.Windows.Forms.Control) this._tree).DragDrop += new DragEventHandler(this.tree_DragDrop);
      ((System.Windows.Forms.Control) this._tree).MouseDown += new MouseEventHandler(this.tree_MouseDown);
      ((System.Windows.Forms.Control) this._tree).MouseUp += new MouseEventHandler(this.tree_MouseUp);
      ((System.Windows.Forms.Control) this._tree).DragOver += new DragEventHandler(this.tree_DragOver);
    }

    public void Dispose()
    {
      ((System.Windows.Forms.Control) this._tree).DragOver -= new DragEventHandler(this.tree_DragOver);
      ((System.Windows.Forms.Control) this._tree).MouseMove -= new MouseEventHandler(this.tree_MouseMove);
      ((System.Windows.Forms.Control) this._tree).DragDrop -= new DragEventHandler(this.tree_DragDrop);
      ((System.Windows.Forms.Control) this._tree).MouseDown -= new MouseEventHandler(this.tree_MouseDown);
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
        this._dragBoxFromMouseDown = new Rectangle(new System.Drawing.Point(e.X - (int) Math.Round((double) dragSize.Width / 2.0), e.Y - (int) Math.Round((double) dragSize.Height / 2.0)), dragSize);
      }
    }

    private void tree_MouseUp(object sender, MouseEventArgs e)
    {
      this._dragBoxFromMouseDown = Rectangle.Empty;
      this._itemUnderMouse = (UltraTreeNode) null;
    }

    private void tree_MouseMove(object sender, MouseEventArgs e)
    {
      int num1 = (e.Button & MouseButtons.Left) == MouseButtons.Left ? 1 : 0;
      this._rightMouseButtonDown = (e.Button & MouseButtons.Right) == MouseButtons.Right;
      if (num1 == 0 && !this._rightMouseButtonDown || !(this._dragBoxFromMouseDown != Rectangle.Empty))
        return;
      if (this._dragBoxFromMouseDown.Contains(e.X, e.Y))
        return;
      try
      {
        if (this._itemUnderMouse is TabDocumentPanel.FolderNode && !SecurityManager.Instance.AssertPermission("{741550D6-3346-4900-B071-D0D347A0A6E8}") || this._itemUnderMouse is TabDocumentPanel.FileNode && !SecurityManager.Instance.AssertPermission("{20E00F1B-79BA-4D04-AB6F-13A63F0BF8A9}") || this._itemUnderMouse == null)
          return;
        if (this._itemUnderMouse is TabDocumentPanel.FileNode itemUnderMouse)
        {
          itemUnderMouse.ForceSetControlKey();
          MGADataObject data = new MGADataObject((object) itemUnderMouse);
          List<string> stringList = new List<string>();
          foreach (UltraTreeNode selectedNode in itemUnderMouse.Control.SelectedNodes)
          {
            if (selectedNode is TabDocumentPanel.FileNode fileNode)
            {
              fileNode.FileDropPath = MGATempFolder.MGATempRandomFolderPath + Path.GetFileName(fileNode.FileName);
              stringList.Add(fileNode.FileDropPath);
            }
          }
          string str = MGATempFolder.MGATempRandomFolderPath + itemUnderMouse.FileName;
          data.SetData(System.Windows.Forms.DataFormats.FileDrop, true, (object) stringList.ToArray());
          int num2 = (int) ((System.Windows.Forms.Control) this._tree).DoDragDrop((object) data, DragDropEffects.Copy);
        }
        else
        {
          if (!(this._itemUnderMouse is TabDocumentPanel.FolderNode))
            return;
          int num3 = (int) ((System.Windows.Forms.Control) this._tree).DoDragDrop((object) this._itemUnderMouse, DragDropEffects.Copy);
        }
      }
      finally
      {
        if ((object) this._dragCursor != null)
          this._dragCursor.Dispose();
      }
    }

    private void tree_DragOver(object sender, DragEventArgs e)
    {
      Log.Write("tree_DragOver begin", "DocumentSystem.DocumentPanel");
      this._rightMouseButtonDown = (e.KeyState & 2) == 2;
      if (!SecurityManager.Instance.AssertPermission("{907B56F7-0C11-4CB7-869C-1A2F62191C98}"))
      {
        e.Effect = DragDropEffects.None;
      }
      else
      {
        if (Log.LogCategoryDestinations["DocumentSystem.DocumentPanel"] != LogDestination.Disabled)
        {
          string message = "tree_DragOver Supported Data Formats";
          string[] formats = e.Data.GetFormats(false);
          int index = 0;
          while (index < formats.Length)
          {
            string str = formats[index];
            message += str;
            checked { ++index; }
          }
          Log.Write(message, "DocumentSystem.DocumentPanel");
        }
        if (e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode", false) || e.Data.GetDataPresent("ByteData", false) || e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop, false) || e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FolderNode", false))
        {
          e.Effect = DragDropEffects.Copy;
          Log.Write("tree_DragOver.DragDropEffects.Copy", "DocumentSystem.DocumentPanel");
        }
        Log.Write("tree_DragOver end", "DocumentSystem.DocumentPanel");
      }
    }

    private void DroppedFolderNode(DragEventArgs e, UltraTreeNode itemUnderMouse)
    {
      TabDocumentPanel.FolderNode data = (TabDocumentPanel.FolderNode) e.Data.GetData("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FolderNode");
      foreach (UltraTreeNode ultraTreeNode in itemUnderMouse == null ? this._tree.Nodes : itemUnderMouse.Nodes)
      {
        if (string.Compare(ultraTreeNode.Text, data.Text, true) == 0)
        {
          if (itemUnderMouse == null)
          {
            int num = (int) MessageBox.Show($"Folder '{"Root"}' already contains a folder named '{data.Text}', drop cancelled.", "Folder Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          int num1 = (int) MessageBox.Show($"Folder '{itemUnderMouse.Text}' already contains a folder named '{data.Text}', drop cancelled.", "Folder Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      TabDocumentPanel.FolderNode folderNode1 = itemUnderMouse as TabDocumentPanel.FolderNode;
      TabDocumentPanel.FileNode fileNode = itemUnderMouse as TabDocumentPanel.FileNode;
      if (itemUnderMouse != null)
      {
        for (TabDocumentPanel.FolderNode folderNode2 = folderNode1 == null ? (TabDocumentPanel.FolderNode) itemUnderMouse.Parent : folderNode1; folderNode2 != null; folderNode2 = (TabDocumentPanel.FolderNode) folderNode2.Parent)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(folderNode2.FolderID, data.FolderID, false) == 0)
          {
            int num = (int) MessageBox.Show($"Cannot copy {data.Text}: The destination folder is a subfolder of the source folder.", "Unable to Copy Folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
      }
      if (SecurityManager.Instance.AssertPermission("{9BE131D4-47F3-4A47-9C64-2512CA875E19}"))
      {
        string action = string.Empty;
        if (itemUnderMouse == null)
        {
          FolderManager.MoveFolderToRoot(Conversions.ToInteger(data.FolderID));
          action = $"Folder: {data.Text} Was Moved From {data.Parent.Text} To the Root. ";
        }
        else if (folderNode1 != null)
        {
          FolderManager.MoveFolder(Conversions.ToInteger(data.FolderID), Conversions.ToInteger(folderNode1.FolderID));
          if (Utility.IsNull((object) data.Parent))
            action = $"Folder: {data.Text} Was Moved From Root To {folderNode1.Text}, FolderID: {folderNode1.FolderID}";
          else
            action = $"Folder: {data.Text} Was Moved From {data.Parent.Text} To {folderNode1.Text}, FolderID: {folderNode1.FolderID}";
        }
        else if (fileNode != null)
        {
          FolderManager.MoveFolder(Conversions.ToInteger(data.FolderID), Conversions.ToInteger(fileNode.FolderID));
          action = $"{data.Text} Was Moved From {data.Parent.Text} To {fileNode.Text}";
        }
        CurrentUser.Instance.LogAction(action, typeof (TabDocumentPanel).ToString());
      }
      else
      {
        int num2 = (int) MessageBox.Show("You currently do not have permission to move folders in IMS, please contact your IMS administrator.", "Action Denied");
      }
      this._documentPanel.ResetFolders();
    }

    private void DroppedFileNode(
      bool copyFile,
      DragEventArgs e,
      UltraTreeNode itemUnderMouse,
      List<Guid> docGuids,
      List<string> docFileNames)
    {
      TabDocumentPanel.FileNode data = (TabDocumentPanel.FileNode) e.Data.GetData("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode");
      TabDocumentPanel.FolderNode folderNode = itemUnderMouse as TabDocumentPanel.FolderNode;
      TabDocumentPanel.FileNode fileNode1 = itemUnderMouse as TabDocumentPanel.FileNode;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(data.ControlKey, "trvEntity", false) != 0)
      {
        docGuids.Add(data.DocumentGUID);
        docFileNames.Add(data.FileName);
      }
      string action = string.Empty;
      if (itemUnderMouse == null)
      {
        if (copyFile)
        {
          DocumentManager.CopyDocumentToRootFolder(data.DocumentGUID);
          action = $"Document: {data.FileName} was copied to the Root";
        }
        else
        {
          DocumentManager.MoveDocumentToRoot(data.DocumentGUID);
          action = $"Document: {data.FileName} was moved to the Root";
        }
      }
      else if (folderNode != null)
      {
        if (FolderManager.FolderExists(Conversions.ToInteger(folderNode.FolderID)))
        {
          if (copyFile)
          {
            DocumentManager.CopyDocumentToFolder(data.DocumentGUID, Conversions.ToInteger(folderNode.FolderID));
            action = $"Document: {data.FileName} was copied to folder {folderNode.Text}, FolderID: {folderNode.FolderID}";
          }
          else
          {
            DocumentManager.MoveDocument(data.DocumentGUID, Conversions.ToInteger(folderNode.FolderID));
            action = $"Document: {data.FileName} was moved to folder {folderNode.Text}, FolderID: {folderNode.FolderID}";
          }
        }
        else
        {
          int num = (int) MessageBox.Show("We could Not drop ths file into the directory specified because the folder no longer exists", "Folder has been deleted, please Try again", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this._documentPanel.ResetFolders();
        }
        foreach (UltraTreeNode selectedNode in this._tree.SelectedNodes)
        {
          if (selectedNode is TabDocumentPanel.FileNode fileNode2 && !fileNode2.DocumentGUID.Equals(data.DocumentGUID))
          {
            if (FolderManager.FolderExists(Conversions.ToInteger(folderNode.FolderID)))
            {
              if (copyFile)
              {
                DocumentManager.CopyDocumentToFolder(fileNode2.DocumentGUID, Conversions.ToInteger(folderNode.FolderID));
                action = $"Document: {data.FileName} was copied to folder {folderNode.Text}, FolderID: {folderNode.FolderID}";
              }
              else
              {
                DocumentManager.MoveDocument(fileNode2.DocumentGUID, Conversions.ToInteger(folderNode.FolderID));
                action = $"Document: {data.FileName} was moved to folder {folderNode.Text}, FolderID: {folderNode.FolderID}";
              }
            }
            else
            {
              int num = (int) MessageBox.Show("We could Not drop ths file into the directory specified because the folder no longer exists", "Folder has been deleted, please Try again", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              this._documentPanel.ResetFolders();
            }
          }
        }
      }
      else if (fileNode1 != null)
      {
        if (fileNode1.Parent == null)
        {
          if (copyFile)
          {
            DocumentManager.CopyDocumentToRootFolder(data.DocumentGUID);
            action = $"Document: {data.FileName} was copied to the Root";
          }
          else
          {
            DocumentManager.MoveDocumentToRoot(data.DocumentGUID);
            action = $"Document: {data.FileName} was moved to the Root";
          }
        }
        else
        {
          TabDocumentPanel.FolderNode parent = (TabDocumentPanel.FolderNode) fileNode1.Parent;
          if (FolderManager.FolderExists(Conversions.ToInteger(parent.FolderID)))
          {
            if (copyFile)
            {
              DocumentManager.CopyDocumentToFolder(data.DocumentGUID, Conversions.ToInteger(parent.FolderID));
              action = $"Document: {data.FileName} was copied to folder {parent.Text}, FolderID: {parent.FolderID}";
            }
            else
            {
              DocumentManager.MoveDocument(data.DocumentGUID, Conversions.ToInteger(parent.FolderID));
              action = $"Document: {data.FileName} was moved to folder {parent.Text}, FolderID: {parent.FolderID}";
            }
          }
          else
          {
            int num = (int) MessageBox.Show("We could Not drop ths file into the directory specified because the folder no longer exists", "Folder has been deleted, please Try again", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this._documentPanel.ResetFolders();
          }
        }
      }
      if (!string.IsNullOrEmpty(action))
        CurrentUser.Instance.LogAction(action, data.DocumentGUID, typeof (TabDocumentPanel).ToString());
      if (folderNode == null || this._documentPanel._entityDocs == null)
        return;
      this._documentPanel.ClientTriggerTransfer(data, this._documentPanel._entityDocs.ControlGUID, Conversions.ToInteger(folderNode.FolderID));
    }

    private void tree_DragDrop(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode", false) && this._rightMouseButtonDown)
      {
        System.Windows.Forms.ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
        contextMenu.Tag = (object) new Tuple<MGATreeView, DragEventArgs>((MGATreeView) sender, e);
        contextMenu.MenuItems.Add("Copy here", new EventHandler(this.OnCopyDocumentClick));
        contextMenu.MenuItems.Add("Move here", new EventHandler(this.OnMoveDocumentClick));
        contextMenu.MenuItems.Add("-");
        contextMenu.MenuItems.Add("Cancel");
        contextMenu.Show((System.Windows.Forms.Control) sender, ((System.Windows.Forms.Control) this._tree).PointToClient(new System.Drawing.Point(e.X, e.Y)));
      }
      else
        this.HandleTreeDragDrop(RuntimeHelpers.GetObjectValue(sender), e, false);
    }

    private void OnCopyDocumentClick(object sender, EventArgs e)
    {
      System.Windows.Forms.ContextMenu contextMenu = ((System.Windows.Forms.Menu) sender).GetContextMenu();
      Tuple<MGATreeView, DragEventArgs> tag = (Tuple<MGATreeView, DragEventArgs>) contextMenu.Tag;
      this.HandleTreeDragDrop((object) tag.Item1, tag.Item2, true);
      contextMenu.Dispose();
    }

    private void OnMoveDocumentClick(object sender, EventArgs e)
    {
      System.Windows.Forms.ContextMenu contextMenu = ((System.Windows.Forms.Menu) sender).GetContextMenu();
      Tuple<MGATreeView, DragEventArgs> tag = (Tuple<MGATreeView, DragEventArgs>) contextMenu.Tag;
      this.HandleTreeDragDrop((object) tag.Item1, tag.Item2, false);
      contextMenu.Dispose();
    }

    private void HandleTreeDragDrop(object sender, DragEventArgs e, bool copyFile)
    {
      try
      {
        List<Guid> docGuids = new List<Guid>();
        List<string> docFileNames = new List<string>();
        UltraTreeNode nodeFromPoint = this._tree.GetNodeFromPoint(((System.Windows.Forms.Control) this._tree).PointToClient(new System.Drawing.Point(e.X, e.Y)));
        DocumentManager.CurrentFolderID = !(nodeFromPoint is TabDocumentPanel.FolderNode folderNode) ? string.Empty : folderNode.FolderID;
        if (e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FolderNode", false))
          this.DroppedFolderNode(e, nodeFromPoint);
        else if (e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode", false))
          this.DroppedFileNode(copyFile, e, nodeFromPoint, docGuids, docFileNames);
        this._documentPanel.OnTreeDragDrop(RuntimeHelpers.GetObjectValue(sender), e, docGuids);
        if (sender == this._documentPanel.trvEntity)
          this._documentPanel.RefreshTree((UltraTree) this._documentPanel.trvEntity);
        else if (sender == this._documentPanel.trvUser)
          this._documentPanel.RefreshTree((UltraTree) this._documentPanel.trvUser);
        if (e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode", false) && e.Data.GetData("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode") is TabDocumentPanel.FileNode data && !string.IsNullOrEmpty(data.ControlKey))
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(data.ControlKey, ((System.Windows.Forms.Control) this._documentPanel.trvEntity).Name, false) == 0)
          {
            if (sender != this._documentPanel.trvEntity)
              this._documentPanel.RefreshTree((UltraTree) this._documentPanel.trvEntity);
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(data.ControlKey, ((System.Windows.Forms.Control) this._documentPanel.trvUser).Name, false) == 0 && sender != this._documentPanel.trvUser)
            this._documentPanel.RefreshTree((UltraTree) this._documentPanel.trvUser);
        }
        if (sender != this._documentPanel.trvEntity || docGuids.Count != 1)
          return;
        Guid guid = docGuids[0];
        if (guid.Equals(Guid.Empty) || this._documentPanel._entityDocs == null)
          return;
        using (frmFetchDoc frmFetchDoc = frmFetchDoc.Create(true, this._documentPanel._entityDocs))
        {
          frmFetchDoc.SetAsNoteDiaryGenerationDisplayOnly();
          frmFetchDoc.Description = docFileNames[0].ToString();
          if ((!MDIControls.Instance.MDIParent.InvokeRequired ? frmFetchDoc.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) : frmFetchDoc.ShowDialog()) != DialogResult.OK)
            return;
          ISupportDocumentSystem entityDocs = this._documentPanel._entityDocs;
          NoteSupportCache noteSupport = new NoteSupportCache(entityDocs.EntityGuid, entityDocs.EntityName, entityDocs.FriendlyEntityName, entityDocs.RecreateTypeName, entityDocs.HasControlGUID, entityDocs.ControlGUID);
          Guid boundNote;
          if (frmFetchDoc.NoteAttachment == frmFetchDoc.NoteAttachmentType.Diary)
            boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(-1, "", CurrentUser.Instance.UserGUID, "", false, new Guid[1]
            {
              CurrentUser.Instance.UserGUID
            }, new Guid[1]{ CurrentUser.Instance.UserGUID }, (ISupportNoteSystem) noteSupport, DateAndTime.Now.AddDays(7.0), DateAndTime.Now.AddDays(14.0));
          else if (frmFetchDoc.NoteAttachment == frmFetchDoc.NoteAttachmentType.Note)
            boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(-1, "", CurrentUser.Instance.UserGUID, "", false, new Guid[1]
            {
              CurrentUser.Instance.UserGUID
            }, (ISupportNoteSystem) noteSupport);
          if (frmFetchDoc.NoteAttachment == frmFetchDoc.NoteAttachmentType.None)
            return;
          Note_System.Instance.UIInteractive.ViewNote(boundNote, new Guid[1]
          {
            guid
          }, this._documentPanel._entityDocs);
        }
      }
      finally
      {
        DocumentManager.ResetFolderIdToReuse();
      }
    }
  }

  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  public class FloatControl : System.Windows.Forms.Control
  {
    private System.Drawing.Image _image;

    public void ShowFloating(System.Drawing.Image img)
    {
      if (img == null)
        throw new ArgumentNullException(nameof (img));
      if (this.Handle.Equals((object) IntPtr.Zero))
        this.CreateControl();
      this._image = img;
      this.Size = new Size(img.Width, img.Height);
      NativeMethods.SetParent(this.Handle, IntPtr.Zero);
      NativeMethods.ShowWindow(this.Handle, 1);
    }

    protected override CreateParams CreateParams
    {
      [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        CreateParams createParams = base.CreateParams;
        createParams.ExStyle |= 134217864 /*0x08000088*/;
        createParams.Parent = IntPtr.Zero;
        return createParams;
      }
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    protected override void WndProc(ref Message m)
    {
      if (m.Msg == 132)
        m.Result = new IntPtr(-1);
      else
        base.WndProc(ref m);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      e.Graphics.DrawImage(this._image, new System.Drawing.Point(0, 0));
      Graphics graphics = e.Graphics;
      Pen controlDarkDark = SystemPens.ControlDarkDark;
      Rectangle clientRectangle = this.ClientRectangle;
      int width = clientRectangle.Width - 1;
      clientRectangle = this.ClientRectangle;
      int height = clientRectangle.Height - 1;
      graphics.DrawRectangle(controlDarkDark, 0, 0, width, height);
    }
  }
}
