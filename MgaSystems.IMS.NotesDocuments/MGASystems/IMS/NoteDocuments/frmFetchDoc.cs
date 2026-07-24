// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmFetchDoc
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTree;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmFetchDoc : Form
{
  private readonly ISupportDocumentSystem _docSupport;
  private bool _hideControl;
  private int _folderID;
  private frmFetchDoc.NoteAttachmentType _noteAttachment;
  private bool _showNoteCheckBox;
  private bool _ignoreCheckClick;
  private bool _copyForwardOnRenewal;
  private bool _CopyForwardOnlyOnce;
  private Guid _typeGuid;
  private bool _BasicMode;
  public bool DriverMode;
  private IContainer components;

  public frmFetchDoc(bool showNoteCheckbox, ISupportDocumentSystem docSupport)
    : this(docSupport)
  {
    this._showNoteCheckBox = showNoteCheckbox;
  }

  public frmFetchDoc(ISupportDocumentSystem docSupport)
  {
    this.Load += new EventHandler(this.frmFetchDoc_Load);
    this._folderID = -1;
    this._noteAttachment = frmFetchDoc.NoteAttachmentType.Note;
    this.DriverMode = false;
    if (docSupport != null)
      this._docSupport = (ISupportDocumentSystem) new DocSupportCache(docSupport);
    this.InitializeComponent();
  }

  public frmFetchDoc(
    bool BasicMode,
    string Description,
    int FolderID,
    ISupportDocumentSystem docSupport)
  {
    this.Load += new EventHandler(this.frmFetchDoc_Load);
    this._folderID = -1;
    this._noteAttachment = frmFetchDoc.NoteAttachmentType.Note;
    this.DriverMode = false;
    this.InitializeComponent();
    if (docSupport != null)
      this._docSupport = (ISupportDocumentSystem) new DocSupportCache(docSupport);
    this.Description = Description;
    if (FolderID > 0)
      DocumentManager.CurrentFolderID = FolderID.ToString();
    this._BasicMode = BasicMode;
  }

  public static frmFetchDoc Create(ISupportDocumentSystem docSupport)
  {
    return (frmFetchDoc) ObjectFactory.Instance.CreateForm(typeof (frmFetchDoc), new object[1]
    {
      (object) docSupport
    });
  }

  public static frmFetchDoc Create(
    bool showCheckboxes,
    string Description,
    string FolderID,
    ISupportDocumentSystem docSupport)
  {
    return (frmFetchDoc) ObjectFactory.Instance.CreateForm(typeof (frmFetchDoc), new object[4]
    {
      (object) showCheckboxes,
      (object) Description,
      (object) FolderID,
      (object) docSupport
    });
  }

  public static frmFetchDoc Create(bool showNoteCheckbox, ISupportDocumentSystem docSupport)
  {
    return (frmFetchDoc) ObjectFactory.Instance.CreateForm(typeof (frmFetchDoc), new object[2]
    {
      (object) showNoteCheckbox,
      (object) docSupport
    });
  }

  public virtual string GetAdditionalSaveData() => "";

  public bool CopyToOtherCardsOnSubmission { get; }

  public Guid TypeGuid => this._typeGuid;

  public bool HideControl
  {
    get => this._hideControl;
    set => this._hideControl = value;
  }

  protected virtual MGACheckBox chkCopyAssociationForwardOnlyOnce
  {
    get => this._chkCopyAssociationForwardOnlyOnce;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkCopyAssociationForwardOnlyOnce_CheckedChanged_1);
      MGACheckBox associationForwardOnlyOnce1 = this._chkCopyAssociationForwardOnlyOnce;
      if (associationForwardOnlyOnce1 != null)
        ((UltraToggleEditorBase) associationForwardOnlyOnce1).CheckedChanged -= eventHandler;
      this._chkCopyAssociationForwardOnlyOnce = value;
      MGACheckBox associationForwardOnlyOnce2 = this._chkCopyAssociationForwardOnlyOnce;
      if (associationForwardOnlyOnce2 == null)
        return;
      ((UltraToggleEditorBase) associationForwardOnlyOnce2).CheckedChanged += eventHandler;
    }
  }

  public bool CopyForwardOnRenewal => this._copyForwardOnRenewal;

  public bool CopyForwardOnlyOnce => this._CopyForwardOnlyOnce;

  private static bool ShouldEnableFolderFiltering()
  {
    bool flag = Preferences.GetPreferenceBool("DockingTabs.Documents.AssociatedDocs.FilterFoldersByEntity");
    if (!flag && !SecurityManager.Instance.AssertPermission("{60C00A7E-2D44-4108-B607-7F48FBEE7897}"))
      flag = true;
    return flag;
  }

  public static void PopulateFolders(UltraTree tree) => frmFetchDoc.PopulateFolders(tree, true);

  public static string GetEntityFilter()
  {
    IRecreatableEntity recreatableEntity = ObjectFactory.QueryInterface<IRecreatableEntity>((object) MDIControls.Instance.MDIParent.ActiveMdiChild);
    string entityFilter;
    if (recreatableEntity != null && recreatableEntity is System.Windows.Forms.Control | recreatableEntity is System.Windows.Controls.Control)
    {
      object[] customAttributes = (!(recreatableEntity is System.Windows.Forms.Control) ? (MemberInfo) ((System.Windows.Controls.Control) recreatableEntity).GetType() : (MemberInfo) ((System.Windows.Forms.Control) recreatableEntity).GetType()).GetCustomAttributes(typeof (DocumentFolderFilterAttribute), true);
      if (customAttributes != null & customAttributes.Length == 0)
      {
        Type typeFromString = ObjectFactory.Instance.CreateTypeFromString(recreatableEntity.RecreateTypeName);
        if ((object) typeFromString != null)
          customAttributes = typeFromString.GetCustomAttributes(typeof (DocumentFolderFilterAttribute), true);
      }
      if (customAttributes != null && customAttributes.Length == 1)
      {
        entityFilter = recreatableEntity.RecreateTypeName;
        goto label_7;
      }
    }
    entityFilter = string.Empty;
label_7:
    return entityFilter;
  }

  private static void PopulateNodes(UltraTree tree, TreeNodesCollection nodes, int? parentFolderID)
  {
    bool tag = (bool) ((System.Windows.Forms.Control) tree).Tag;
    List<FolderInfo> folders = FolderManager.GetFolders(parentFolderID, tag ? frmFetchDoc.GetEntityFilter() : "");
    try
    {
      ((UltraControlBase) tree).BeginUpdate();
      TreeNodesCollection treeNodesCollection = nodes;
      List<FolderInfo> source = folders;
      Func<FolderInfo, frmFetchDoc.FolderNode> selector;
      // ISSUE: reference to a compiler-generated field
      if (frmFetchDoc._Closure\u0024__.\u0024I40\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = frmFetchDoc._Closure\u0024__.\u0024I40\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmFetchDoc._Closure\u0024__.\u0024I40\u002D0 = selector = (Func<FolderInfo, frmFetchDoc.FolderNode>) ([SpecialName] (folder) =>
        {
          frmFetchDoc.FolderNode folderNode = new frmFetchDoc.FolderNode(folder);
          if (folder.ChildCount > 0)
            folderNode.Nodes.Add().Text = "PLACEHOLDER";
          return folderNode;
        });
      }
      frmFetchDoc.FolderNode[] array = source.Select<FolderInfo, frmFetchDoc.FolderNode>(selector).ToArray<frmFetchDoc.FolderNode>();
      treeNodesCollection.AddRange((UltraTreeNode[]) array);
    }
    finally
    {
      ((UltraControlBase) tree).EndUpdate();
    }
  }

  public static void PopulateFolders(UltraTree tree, bool allowFiltering, bool autoRefresh = false)
  {
    int setting = MGASystems.Common.Settings.SystemSettings.GetSetting<int>("DocumentSystem.AddDocument.OverrideFolderFiltering", -1);
    if (setting != -1)
      allowFiltering = setting == 1;
    ((System.Windows.Forms.Control) tree).Tag = ((System.Windows.Forms.Control) tree).Tag == null ? (object) allowFiltering : throw new InvalidOperationException("Tree.Tag must be null");
    tree.BeforeExpand += new BeforeNodeChangedEventHandler(frmFetchDoc.tree_BeforeExpand);
    tree.Nodes.Clear();
    frmFetchDoc.PopulateNodes(tree, tree.Nodes, new int?());
    tree.Override.Sort = (SortType) 1;
  }

  private static void tree_BeforeExpand(object sender, CancelableNodeEventArgs e)
  {
    UltraTree tree = (UltraTree) sender;
    if (e.TreeNode.Nodes.Count != 1 || Operators.CompareString(e.TreeNode.Nodes[0].Text, "PLACEHOLDER", false) != 0)
      return;
    e.TreeNode.Nodes.Clear();
    frmFetchDoc.PopulateNodes(tree, e.TreeNode.Nodes, new int?(int.Parse(((frmFetchDoc.FolderNode) e.TreeNode).FolderID)));
  }

  private void frmFetchDoc_Load(object sender, EventArgs e)
  {
    if (string.IsNullOrWhiteSpace(DefaultDatabase.ConnectionString))
      return;
    frmFetchDoc.PopulateFolders(this.treeFolders);
    if (Operators.CompareString(DocumentManager.CurrentFolderID, string.Empty, false) != 0)
    {
      UltraTreeNode nodeByKey1 = this.treeFolders.GetNodeByKey(DocumentManager.CurrentFolderID);
      if (nodeByKey1 != null)
      {
        nodeByKey1.BringIntoView(true);
        nodeByKey1.Selected = true;
      }
      else
      {
        try
        {
          string str = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("DocumentSystem_ResolveFolderPath", new object[2]
          {
            (object) "@folderID",
            (object) DocumentManager.CurrentFolderID
          })), "");
          if (!string.IsNullOrWhiteSpace(str))
          {
            if (str.Contains("\\"))
            {
              try
              {
                string[] source = str.Replace("ROOT\\", "").Split("\\".ToCharArray());
                Func<string, bool> predicate;
                // ISSUE: reference to a compiler-generated field
                if (frmFetchDoc._Closure\u0024__.\u0024I43\u002D0 != null)
                {
                  // ISSUE: reference to a compiler-generated field
                  predicate = frmFetchDoc._Closure\u0024__.\u0024I43\u002D0;
                }
                else
                {
                  // ISSUE: reference to a compiler-generated field
                  frmFetchDoc._Closure\u0024__.\u0024I43\u002D0 = predicate = (Func<string, bool>) ([SpecialName] (pathNodeKey) => !string.IsNullOrWhiteSpace(pathNodeKey));
                }
                foreach (UltraTreeNode ultraTreeNode in ((IEnumerable<string>) source).Where<string>(predicate).Select<string, UltraTreeNode>((Func<string, UltraTreeNode>) ([SpecialName] (pathNodeKey) => this.treeFolders.GetNodeByKey(pathNodeKey))))
                {
                  if (ultraTreeNode != null)
                    ultraTreeNode.Expanded = true;
                }
              }
              finally
              {
                IEnumerator<UltraTreeNode> enumerator;
                enumerator?.Dispose();
              }
              UltraTreeNode nodeByKey2 = this.treeFolders.GetNodeByKey(DocumentManager.CurrentFolderID);
              if (nodeByKey2 != null)
              {
                nodeByKey2.BringIntoView(true);
                nodeByKey2.Selected = true;
              }
            }
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
    ((System.Windows.Forms.Control) this.chkAttachNote).Visible = this._showNoteCheckBox;
    ((System.Windows.Forms.Control) this.chkAttachDiary).Visible = this._showNoteCheckBox;
    if (((KeyedSubObjectsCollectionBase) this.treeFolders.Nodes).All.Length == 0)
      ((System.Windows.Forms.Control) this.treeFolders).Enabled = false;
    bool setting = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DocumentSystem.ShowDocumentTypes");
    ((System.Windows.Forms.Control) this.cboDocumentType).Visible = setting;
    this.lblDocumentType.Visible = setting;
    if (setting)
    {
      ((UltraGridBase) this.cboDocumentType).DataSource = (object) DefaultDatabase.ExecuteDataTable("DocumentSystem_FetchSelectableDocumentTypes");
      ((UltraDropDownBase) this.cboDocumentType).DisplayMember = "TypeName";
      ((UltraDropDownBase) this.cboDocumentType).ValueMember = "TypeGuid";
    }
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DocumentSystem.ShowCopyToOtherCards") && this._docSupport != null && this._docSupport.HasControlGUID)
    {
      if (DefaultDatabase.ExecuteDataTable("DocumentSystem_FetchOtherQuotesOnSubmission", new object[2]
      {
        (object) "@ControlGuid",
        (object) this._docSupport.ControlGUID
      }).Rows.Count > 0)
        ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).Visible = true;
    }
    if (this._BasicMode)
      this.SetBasicMode();
    if (this.DriverMode)
      this.SetForDriverDoc();
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("AssociatedEntities.Email.ShowFolders"))
      return;
    try
    {
      foreach (System.Windows.Forms.Control control in this.Controls)
      {
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(control.Tag)) && control.Tag.ToString().EqualsNoCase("HideControl"))
          control.Hide();
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public bool HasFolderId => this._folderID != -1;

  public int FolderId => this._folderID;

  public string Description
  {
    get => ((TextEditorControlBase) this.txtDescription).Text;
    set => ((TextEditorControlBase) this.txtDescription).Text = value;
  }

  public void SetAsNoteDiaryGenerationDisplayOnly()
  {
    this.labelChooseFolder.Enabled = false;
    ((System.Windows.Forms.Control) this.treeFolders).Enabled = false;
    ((System.Windows.Forms.Control) this.txtDescription).Enabled = false;
  }

  public void SetAsNoteGenerationDisplayOnly()
  {
    this.labelChooseFolder.Enabled = false;
    ((System.Windows.Forms.Control) this.treeFolders).Enabled = false;
    ((System.Windows.Forms.Control) this.txtDescription).Enabled = false;
  }

  public frmFetchDoc.NoteAttachmentType NoteAttachment => this._noteAttachment;

  public void SetBasicMode()
  {
    try
    {
      foreach (System.Windows.Forms.Control control in this.Controls)
      {
        string name = control.Name;
        if (Operators.CompareString(name, "labelChooseFolder", false) != 0 && Operators.CompareString(name, "btnReset", false) != 0 && Operators.CompareString(name, "treeFolders", false) != 0 && Operators.CompareString(name, "Label2", false) != 0 && Operators.CompareString(name, "txtDescription", false) != 0 && Operators.CompareString(name, "MgaButton1", false) != 0)
          control.Visible = false;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void MgaButton1_Click(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.treeFolders.SelectedNodes).Count == 1)
      this._folderID = Conversions.ToInteger(((frmFetchDoc.FolderNode) this.treeFolders.SelectedNodes[0]).FolderID);
    this._noteAttachment = !((UltraToggleEditorBase) this.chkAttachNote).Checked ? (!((UltraToggleEditorBase) this.chkAttachDiary).Checked ? frmFetchDoc.NoteAttachmentType.None : frmFetchDoc.NoteAttachmentType.Diary) : frmFetchDoc.NoteAttachmentType.Note;
    if (((UltraToggleEditorBase) this.chkUseSameFolder).Checked)
      DocumentManager.FolderIdToReuse = this._folderID;
    if (this.cboDocumentType.SelectedIndex > 0)
      this._typeGuid = (Guid) this.cboDocumentType.Value;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void txtDescription_AfterEnterEditMode(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtDescription).SelectionStart = 0;
    ((TextEditorControlBase) this.txtDescription).SelectionLength = ((TextEditorControlBase) this.txtDescription).TextLength;
  }

  private void chkCopyForwardOnRenewal_CheckedChanged(object sender, EventArgs e)
  {
    this._copyForwardOnRenewal = ((UltraToggleEditorBase) this.chkCopyForwardOnRenewal).Checked;
  }

  private void chkAttachDiary_Click(object sender, EventArgs e)
  {
    if (this._ignoreCheckClick)
      return;
    this._ignoreCheckClick = true;
    if (((UltraToggleEditorBase) this.chkAttachNote).Checked)
      ((UltraToggleEditorBase) this.chkAttachNote).Checked = false;
    this._ignoreCheckClick = false;
  }

  private void chkAttachNote_Click(object sender, EventArgs e)
  {
    if (this._ignoreCheckClick)
      return;
    this._ignoreCheckClick = true;
    if (((UltraToggleEditorBase) this.chkAttachDiary).Checked)
      ((UltraToggleEditorBase) this.chkAttachDiary).Checked = false;
    this._ignoreCheckClick = false;
  }

  private void btnReset_Click(object sender, EventArgs e) => this.treeFolders.SelectedNodes.Clear();

  private void chkCopyAssociationToOtherCards_Click(object sender, EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    this._CopyToOtherCardsOnSubmission = ((UltraToggleEditorBase) this.chkCopyAssociationToOtherCards).Checked;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("treeFolders")]
  protected virtual UltraTree treeFolders { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtDescription
  {
    get => this._txtDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtDescription_AfterEnterEditMode);
      MGATextBox txtDescription1 = this._txtDescription;
      if (txtDescription1 != null)
        ((TextEditorControlBase) txtDescription1).AfterEnterEditMode -= eventHandler;
      this._txtDescription = value;
      MGATextBox txtDescription2 = this._txtDescription;
      if (txtDescription2 == null)
        return;
      ((TextEditorControlBase) txtDescription2).AfterEnterEditMode += eventHandler;
    }
  }

  private virtual MGAButton MgaButton1
  {
    get => this._MgaButton1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaButton1_Click);
      MGAButton mgaButton1_1 = this._MgaButton1;
      if (mgaButton1_1 != null)
        ((System.Windows.Forms.Control) mgaButton1_1).Click -= eventHandler;
      this._MgaButton1 = value;
      MGAButton mgaButton1_2 = this._MgaButton1;
      if (mgaButton1_2 == null)
        return;
      ((System.Windows.Forms.Control) mgaButton1_2).Click += eventHandler;
    }
  }

  private virtual MGACheckBox chkAttachNote
  {
    get => this._chkAttachNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkAttachNote_Click);
      MGACheckBox chkAttachNote1 = this._chkAttachNote;
      if (chkAttachNote1 != null)
        ((System.Windows.Forms.Control) chkAttachNote1).Click -= eventHandler;
      this._chkAttachNote = value;
      MGACheckBox chkAttachNote2 = this._chkAttachNote;
      if (chkAttachNote2 == null)
        return;
      ((System.Windows.Forms.Control) chkAttachNote2).Click += eventHandler;
    }
  }

  private virtual MGACheckBox chkAttachDiary
  {
    get => this._chkAttachDiary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkAttachDiary_Click);
      MGACheckBox chkAttachDiary1 = this._chkAttachDiary;
      if (chkAttachDiary1 != null)
        ((System.Windows.Forms.Control) chkAttachDiary1).Click -= eventHandler;
      this._chkAttachDiary = value;
      MGACheckBox chkAttachDiary2 = this._chkAttachDiary;
      if (chkAttachDiary2 == null)
        return;
      ((System.Windows.Forms.Control) chkAttachDiary2).Click += eventHandler;
    }
  }

  protected virtual MGACheckBox chkCopyForwardOnRenewal
  {
    get => this._chkCopyForwardOnRenewal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkCopyForwardOnRenewal_CheckedChanged);
      MGACheckBox forwardOnRenewal1 = this._chkCopyForwardOnRenewal;
      if (forwardOnRenewal1 != null)
        ((UltraToggleEditorBase) forwardOnRenewal1).CheckedChanged -= eventHandler;
      this._chkCopyForwardOnRenewal = value;
      MGACheckBox forwardOnRenewal2 = this._chkCopyForwardOnRenewal;
      if (forwardOnRenewal2 == null)
        return;
      ((UltraToggleEditorBase) forwardOnRenewal2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("labelChooseFolder")]
  internal virtual System.Windows.Forms.Label labelChooseFolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnReset
  {
    get => this._btnReset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnReset_Click);
      MGAButton btnReset1 = this._btnReset;
      if (btnReset1 != null)
        ((System.Windows.Forms.Control) btnReset1).Click -= eventHandler;
      this._btnReset = value;
      MGAButton btnReset2 = this._btnReset;
      if (btnReset2 == null)
        return;
      ((System.Windows.Forms.Control) btnReset2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboDocumentType")]
  private virtual MGASimpleComboBox cboDocumentType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDocumentType")]
  private virtual System.Windows.Forms.Label lblDocumentType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkCopyAssociationToOtherCards
  {
    get => this._chkCopyAssociationToOtherCards;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkCopyAssociationToOtherCards_Click);
      MGACheckBox associationToOtherCards1 = this._chkCopyAssociationToOtherCards;
      if (associationToOtherCards1 != null)
        ((UltraToggleEditorBase) associationToOtherCards1).CheckedChanged -= eventHandler;
      this._chkCopyAssociationToOtherCards = value;
      MGACheckBox associationToOtherCards2 = this._chkCopyAssociationToOtherCards;
      if (associationToOtherCards2 == null)
        return;
      ((UltraToggleEditorBase) associationToOtherCards2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkUseSameFolder")]
  internal virtual MGACheckBox chkUseSameFolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.labelChooseFolder = new System.Windows.Forms.Label();
    this.treeFolders = new UltraTree();
    this.txtDescription = new MGATextBox();
    this.MgaButton1 = new MGAButton();
    this.chkAttachNote = new MGACheckBox();
    this.chkAttachDiary = new MGACheckBox();
    this.chkUseSameFolder = new MGACheckBox();
    this.chkCopyForwardOnRenewal = new MGACheckBox();
    this.btnReset = new MGAButton();
    this.lblDocumentType = new System.Windows.Forms.Label();
    this.cboDocumentType = new MGASimpleComboBox();
    this.chkCopyAssociationToOtherCards = new MGACheckBox();
    this.chkCopyAssociationForwardOnlyOnce = new MGACheckBox();
    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
    ((ISupportInitialize) this.treeFolders).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.MgaButton1).BeginInit();
    ((ISupportInitialize) this.chkAttachNote).BeginInit();
    ((ISupportInitialize) this.chkAttachDiary).BeginInit();
    ((ISupportInitialize) this.chkUseSameFolder).BeginInit();
    ((ISupportInitialize) this.chkCopyForwardOnRenewal).BeginInit();
    ((ISupportInitialize) this.btnReset).BeginInit();
    ((ISupportInitialize) this.cboDocumentType).BeginInit();
    ((ISupportInitialize) this.chkCopyAssociationToOtherCards).BeginInit();
    ((ISupportInitialize) this.chkCopyAssociationForwardOnlyOnce).BeginInit();
    this.SuspendLayout();
    label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label.AutoSize = true;
    label.Location = new System.Drawing.Point(8, 292);
    label.Name = "Label2";
    label.Size = new Size(109, 13);
    label.TabIndex = 2;
    label.Tag = (object) "HideControl";
    label.Text = "Description (optional)";
    this.labelChooseFolder.AutoSize = true;
    this.labelChooseFolder.Location = new System.Drawing.Point(5, 9);
    this.labelChooseFolder.Name = "labelChooseFolder";
    this.labelChooseFolder.Size = new Size(188, 13);
    this.labelChooseFolder.TabIndex = 1;
    this.labelChooseFolder.Text = "Choose a destination folder (optional)";
    ((System.Windows.Forms.Control) this.treeFolders).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.Gray;
    this.treeFolders.Appearance = (AppearanceBase) appearance1;
    ((System.Windows.Forms.Control) this.treeFolders).Location = new System.Drawing.Point(8, 32 /*0x20*/);
    ((System.Windows.Forms.Control) this.treeFolders).Name = "treeFolders";
    ((System.Windows.Forms.Control) this.treeFolders).Size = new Size(342, (int) byte.MaxValue);
    ((System.Windows.Forms.Control) this.treeFolders).TabIndex = 0;
    ((UltraControlBase) this.treeFolders).UseFlatMode = (DefaultableBoolean) 1;
    ((System.Windows.Forms.Control) this.txtDescription).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((System.Windows.Forms.Control) this.txtDescription).Location = new System.Drawing.Point(8, 323);
    ((System.Windows.Forms.Control) this.txtDescription).Name = "txtDescription";
    ((System.Windows.Forms.Control) this.txtDescription).Size = new Size(342, 20);
    ((System.Windows.Forms.Control) this.txtDescription).TabIndex = 3;
    ((System.Windows.Forms.Control) this.txtDescription).Tag = (object) "HideControl";
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.MgaButton1).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.MgaButton1).Appearance = (AppearanceBase) appearance3;
    ((System.Windows.Forms.Control) this.MgaButton1).Location = new System.Drawing.Point(270, 406);
    ((System.Windows.Forms.Control) this.MgaButton1).Name = "MgaButton1";
    ((System.Windows.Forms.Control) this.MgaButton1).Size = new Size(80 /*0x50*/, 24);
    ((System.Windows.Forms.Control) this.MgaButton1).TabIndex = 4;
    ((ControlBase) this.MgaButton1).Text = "Continue";
    this.MgaButton1.UseOSThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.chkAttachNote).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAttachNote).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkAttachNote).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((System.Windows.Forms.Control) this.chkAttachNote).Location = new System.Drawing.Point(176 /*0xB0*/, 344);
    ((System.Windows.Forms.Control) this.chkAttachNote).Name = "chkAttachNote";
    ((System.Windows.Forms.Control) this.chkAttachNote).Size = new Size(152, 20);
    ((System.Windows.Forms.Control) this.chkAttachNote).TabIndex = 5;
    ((System.Windows.Forms.Control) this.chkAttachNote).Tag = (object) "HideControl";
    ((UltraToggleEditorBase) this.chkAttachNote).Text = "Attach note to document";
    ((UltraControlBase) this.chkAttachNote).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAttachNote).UseOsThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.chkAttachDiary).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkAttachDiary).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkAttachDiary).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((System.Windows.Forms.Control) this.chkAttachDiary).Location = new System.Drawing.Point(8, 344);
    ((System.Windows.Forms.Control) this.chkAttachDiary).Name = "chkAttachDiary";
    ((System.Windows.Forms.Control) this.chkAttachDiary).Size = new Size(152, 20);
    ((System.Windows.Forms.Control) this.chkAttachDiary).TabIndex = 6;
    ((System.Windows.Forms.Control) this.chkAttachDiary).Tag = (object) "HideControl";
    ((UltraToggleEditorBase) this.chkAttachDiary).Text = "Attach diary to document";
    ((UltraControlBase) this.chkAttachDiary).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkAttachDiary).UseOsThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.chkUseSameFolder).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseSameFolder).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkUseSameFolder).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((System.Windows.Forms.Control) this.chkUseSameFolder).Location = new System.Drawing.Point(8, 362);
    ((System.Windows.Forms.Control) this.chkUseSameFolder).Name = "chkUseSameFolder";
    ((System.Windows.Forms.Control) this.chkUseSameFolder).Size = new Size(200, 19);
    ((System.Windows.Forms.Control) this.chkUseSameFolder).TabIndex = 7;
    ((System.Windows.Forms.Control) this.chkUseSameFolder).Tag = (object) "HideControl";
    ((UltraToggleEditorBase) this.chkUseSameFolder).Text = "Use same folder for multiple files";
    ((UltraControlBase) this.chkUseSameFolder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseSameFolder).UseOsThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.chkCopyForwardOnRenewal).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCopyForwardOnRenewal).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkCopyForwardOnRenewal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((System.Windows.Forms.Control) this.chkCopyForwardOnRenewal).Location = new System.Drawing.Point(136, 290);
    ((System.Windows.Forms.Control) this.chkCopyForwardOnRenewal).Name = "chkCopyForwardOnRenewal";
    ((System.Windows.Forms.Control) this.chkCopyForwardOnRenewal).Size = new Size(152, 16 /*0x10*/);
    ((System.Windows.Forms.Control) this.chkCopyForwardOnRenewal).TabIndex = 8;
    ((System.Windows.Forms.Control) this.chkCopyForwardOnRenewal).Tag = (object) "HideControl";
    ((UltraToggleEditorBase) this.chkCopyForwardOnRenewal).Text = "Copy Forward on Renewal";
    ((UltraControlBase) this.chkCopyForwardOnRenewal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCopyForwardOnRenewal).UseOsThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.btnReset).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance8.BackColor = Color.FromArgb(248, 248, 248);
    appearance8.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.DarkGray;
    appearance8.ImageHAlign = (HAlign) 2;
    appearance8.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnReset).Appearance = (AppearanceBase) appearance8;
    ((System.Windows.Forms.Control) this.btnReset).Location = new System.Drawing.Point(270, 5);
    ((System.Windows.Forms.Control) this.btnReset).Name = "btnReset";
    ((System.Windows.Forms.Control) this.btnReset).Size = new Size(80 /*0x50*/, 24);
    ((System.Windows.Forms.Control) this.btnReset).TabIndex = 9;
    ((System.Windows.Forms.Control) this.btnReset).Tag = (object) "HideControl";
    ((ControlBase) this.btnReset).Text = "Reset";
    this.btnReset.UseOSThemes = (DefaultableBoolean) 2;
    this.lblDocumentType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblDocumentType.AutoSize = true;
    this.lblDocumentType.Location = new System.Drawing.Point(8, 395);
    this.lblDocumentType.Name = "lblDocumentType";
    this.lblDocumentType.Size = new Size(82, 13);
    this.lblDocumentType.TabIndex = 10;
    this.lblDocumentType.Tag = (object) "HideControl";
    this.lblDocumentType.Text = "Document Type";
    ((System.Windows.Forms.Control) this.cboDocumentType).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboDocumentType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDocumentType.DropDownStyle = (UltraComboStyle) 1;
    ((System.Windows.Forms.Control) this.cboDocumentType).Location = new System.Drawing.Point(8, 409);
    ((System.Windows.Forms.Control) this.cboDocumentType).Name = "cboDocumentType";
    ((System.Windows.Forms.Control) this.cboDocumentType).Size = new Size(234, 21);
    ((System.Windows.Forms.Control) this.cboDocumentType).TabIndex = 36;
    ((System.Windows.Forms.Control) this.cboDocumentType).Tag = (object) "HideControl";
    ((UltraControlBase) this.cboDocumentType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDocumentType).UseOsThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance9.BorderColor = Color.Gray;
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCopyAssociationToOtherCards).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.chkCopyAssociationToOtherCards).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).Location = new System.Drawing.Point(8, 378);
    ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).Name = "chkCopyAssociationToOtherCards";
    ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).Size = new Size(234, 19);
    ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).TabIndex = 37;
    ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).Tag = (object) "HideControl";
    ((UltraToggleEditorBase) this.chkCopyAssociationToOtherCards).Text = "Associate to all cards on the submission";
    ((UltraControlBase) this.chkCopyAssociationToOtherCards).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCopyAssociationToOtherCards).UseOsThemes = (DefaultableBoolean) 2;
    ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).Visible = false;
    ((System.Windows.Forms.Control) this.chkCopyAssociationForwardOnlyOnce).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance10.BorderColor = Color.Gray;
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((System.Windows.Forms.Control) this.chkCopyAssociationForwardOnlyOnce).Location = new System.Drawing.Point(136, 308);
    ((System.Windows.Forms.Control) this.chkCopyAssociationForwardOnlyOnce).Name = "chkCopyAssociationForwardOnlyOnce";
    ((System.Windows.Forms.Control) this.chkCopyAssociationForwardOnlyOnce).Size = new Size(214, 15);
    ((System.Windows.Forms.Control) this.chkCopyAssociationForwardOnlyOnce).TabIndex = 40;
    ((System.Windows.Forms.Control) this.chkCopyAssociationForwardOnlyOnce).Tag = (object) "HideControl";
    ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Text = "Copy Association Forward Only Once";
    this.AcceptButton = (IButtonControl) this.MgaButton1;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(358, 432);
    this.Controls.Add((System.Windows.Forms.Control) this.chkCopyAssociationForwardOnlyOnce);
    this.Controls.Add((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards);
    this.Controls.Add((System.Windows.Forms.Control) this.cboDocumentType);
    this.Controls.Add((System.Windows.Forms.Control) this.lblDocumentType);
    this.Controls.Add((System.Windows.Forms.Control) this.btnReset);
    this.Controls.Add((System.Windows.Forms.Control) this.chkCopyForwardOnRenewal);
    this.Controls.Add((System.Windows.Forms.Control) this.chkUseSameFolder);
    this.Controls.Add((System.Windows.Forms.Control) this.chkAttachDiary);
    this.Controls.Add((System.Windows.Forms.Control) this.chkAttachNote);
    this.Controls.Add((System.Windows.Forms.Control) this.MgaButton1);
    this.Controls.Add((System.Windows.Forms.Control) this.txtDescription);
    this.Controls.Add((System.Windows.Forms.Control) label);
    this.Controls.Add((System.Windows.Forms.Control) this.labelChooseFolder);
    this.Controls.Add((System.Windows.Forms.Control) this.treeFolders);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmFetchDoc);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "New document";
    ((ISupportInitialize) this.treeFolders).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.MgaButton1).EndInit();
    ((ISupportInitialize) this.chkAttachNote).EndInit();
    ((ISupportInitialize) this.chkAttachDiary).EndInit();
    ((ISupportInitialize) this.chkUseSameFolder).EndInit();
    ((ISupportInitialize) this.chkCopyForwardOnRenewal).EndInit();
    ((ISupportInitialize) this.btnReset).EndInit();
    ((ISupportInitialize) this.cboDocumentType).EndInit();
    ((ISupportInitialize) this.chkCopyAssociationToOtherCards).EndInit();
    ((ISupportInitialize) this.chkCopyAssociationForwardOnlyOnce).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public void SetForDriverDoc()
  {
    try
    {
      foreach (System.Windows.Forms.Control control in this.Controls)
      {
        if (Operators.CompareString(control.Name, "Label2", false) == 0)
          control.Visible = false;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((System.Windows.Forms.Control) this.chkCopyForwardOnRenewal).Visible = false;
    ((System.Windows.Forms.Control) this.chkCopyAssociationForwardOnlyOnce).Visible = false;
    ((System.Windows.Forms.Control) this.txtDescription).Visible = false;
    ((System.Windows.Forms.Control) this.chkAttachDiary).Visible = false;
    ((System.Windows.Forms.Control) this.chkAttachNote).Visible = false;
    ((System.Windows.Forms.Control) this.chkUseSameFolder).Visible = false;
    ((System.Windows.Forms.Control) this.chkCopyAssociationToOtherCards).Visible = false;
    this.lblDocumentType.Visible = false;
    ((System.Windows.Forms.Control) this.cboDocumentType).Visible = false;
  }

  private void chkCopyAssociationForwardOnlyOnce_CheckedChanged_1(object sender, EventArgs e)
  {
    this._CopyForwardOnlyOnce = ((UltraToggleEditorBase) this.chkCopyAssociationForwardOnlyOnce).Checked;
  }

  public enum NoteAttachmentType
  {
    None,
    Diary,
    Note,
  }

  [SuppressMessage("Microsoft.Usage", "CA2229:ImplementSerializationConstructors")]
  [Serializable]
  internal sealed class FolderNode : UltraTreeNode
  {
    private Guid _secureResourceGuid;
    private readonly string _parentKey;
    private bool _isNew;

    public FolderNode(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public FolderNode(FolderInfo folder)
      : base(folder.FolderID.ToString(), folder.FolderName)
    {
      this._secureResourceGuid = folder.SecureResourceGuid;
      if (!folder.ParentFolderID.HasValue)
        this._parentKey = folder.ParentFolderID.Value.ToString();
      this.LeftImages.Add((object) MGASystems.IMS.NoteDocuments.My.Resources.Resources.folder);
    }

    public FolderNode(dsFetchDoc.tblDocumentFoldersRow row)
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

  internal sealed class FolderNodeOld : UltraTreeNode
  {
    private readonly string _parentKey;

    public FolderNodeOld(dsFetchDoc.tblDocumentFoldersRow row)
      : base(row.FolderID.ToString(), row.FolderName)
    {
      if (!row.IsParentFolderIDNull())
        this._parentKey = row.ParentFolderID.ToString();
      this.LeftImages.Add((object) ImageCache.Instance.Folder);
    }

    public string FolderID => this.Key;

    public string ParentFolderID => this._parentKey;
  }
}
