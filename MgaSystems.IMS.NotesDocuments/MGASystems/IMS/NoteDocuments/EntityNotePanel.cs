// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.EntityNotePanel
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class EntityNotePanel : UserControl
{
  private IContainer components;
  private Label Label1;
  private ImageList ImageList1;
  private Guid _noteGUID;
  private bool _hasPlaceHolder;

  public EntityNotePanel() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual ListView ListView1
  {
    get => this._ListView1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ListView1_DoubleClick);
      LabelEditEventHandler editEventHandler = new LabelEditEventHandler(this.ListView1_AfterLabelEdit);
      ListView listView1_1 = this._ListView1;
      if (listView1_1 != null)
      {
        listView1_1.DoubleClick -= eventHandler;
        listView1_1.AfterLabelEdit -= editEventHandler;
      }
      this._ListView1 = value;
      ListView listView1_2 = this._ListView1;
      if (listView1_2 == null)
        return;
      listView1_2.DoubleClick += eventHandler;
      listView1_2.AfterLabelEdit += editEventHandler;
    }
  }

  private virtual ContextMenu ctxMain
  {
    get => this._ctxMain;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ctxMain_Popup);
      ContextMenu ctxMain1 = this._ctxMain;
      if (ctxMain1 != null)
        ctxMain1.Popup -= eventHandler;
      this._ctxMain = value;
      ContextMenu ctxMain2 = this._ctxMain;
      if (ctxMain2 == null)
        return;
      ctxMain2.Popup += eventHandler;
    }
  }

  private virtual MenuItem mnuRename
  {
    get => this._mnuRename;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuRename_Click);
      MenuItem mnuRename1 = this._mnuRename;
      if (mnuRename1 != null)
        mnuRename1.Click -= eventHandler;
      this._mnuRename = value;
      MenuItem mnuRename2 = this._mnuRename;
      if (mnuRename2 == null)
        return;
      mnuRename2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EntityNotePanel));
    this.Label1 = new Label();
    this.ListView1 = new ListView();
    this.ctxMain = new ContextMenu();
    this.mnuRename = new MenuItem();
    this.ImageList1 = new ImageList(this.components);
    this.SuspendLayout();
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label1.Location = new Point(24, 5);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(376, 16 /*0x10*/);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Entities this note is associated to";
    this.Label1.TextAlign = ContentAlignment.TopRight;
    this.ListView1.AllowDrop = true;
    this.ListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ListView1.BorderStyle = BorderStyle.FixedSingle;
    this.ListView1.ContextMenu = this.ctxMain;
    this.ListView1.LabelEdit = true;
    this.ListView1.Location = new Point(0, 24);
    this.ListView1.Name = "ListView1";
    this.ListView1.Size = new Size(408, 208 /*0xD0*/);
    this.ListView1.SmallImageList = this.ImageList1;
    this.ListView1.TabIndex = 5;
    this.ListView1.UseCompatibleStateImageBehavior = false;
    this.ListView1.View = View.SmallIcon;
    this.ctxMain.MenuItems.AddRange(new MenuItem[1]
    {
      this.mnuRename
    });
    this.mnuRename.Index = 0;
    this.mnuRename.Text = "Rename";
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "");
    this.BackColor = Color.WhiteSmoke;
    this.Controls.Add((Control) this.ListView1);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (EntityNotePanel);
    this.Size = new Size(408, 232);
    this.ResumeLayout(false);
  }

  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
  public Guid NoteGUID
  {
    get => this._noteGUID;
    set
    {
      if (this._noteGUID.Equals(value))
        return;
      this._noteGUID = value;
      this.BeginRefreshUI();
    }
  }

  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "1#")]
  public void AddPlaceHolderItem(string entityName, Guid entityGUID, string entityType)
  {
    this.ListView1.Items.Clear();
    this._hasPlaceHolder = true;
    this.ListView1.Items.Add((ListViewItem) new EntityListItem(entityName, string.Empty, entityGUID, entityType, true));
  }

  public void Reset()
  {
    this._hasPlaceHolder = false;
    this.ListView1.Items.Clear();
    this.BeginRefreshUI();
  }

  private void BeginRefreshUI()
  {
    Database.Instance.QueryMultithreadedText.PerformTableQuery(ThreadPriority.BelowNormal, new TableQueryMultithreadEventHandler(this.RefreshUI_TableQueryCompleted), (Control) this, (object) "AssociatedEntityNotePanel_RefreshUI", "SELECT EntityType,AssociatedEntityGUID, EntityName, EntityFormName FROM dbo.tblNoteEntities (NOLOCK) WHERE NoteGUID = @NoteGUID", (object) "@NoteGUID", (object) this._noteGUID);
  }

  public EntityListItem[] GetEditedEntityListItems()
  {
    List<EntityListItem> entityListItemList = new List<EntityListItem>();
    try
    {
      foreach (ListViewItem listViewItem in this.ListView1.Items)
      {
        if (listViewItem is EntityListItem entityListItem && entityListItem.IsPlaceHolder && entityListItem.IsEdited)
          entityListItemList.Add(entityListItem);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return entityListItemList.ToArray();
  }

  private void RefreshUI_TableQueryCompleted(object sender, TableQueryMultithreadEventArgs e)
  {
    if (this._hasPlaceHolder)
      return;
    this.ListView1.Items.Clear();
    try
    {
      foreach (DataRow row in e.Table.Rows)
        this.ListView1.Items.Add((ListViewItem) new EntityListItem(Database.IsNull(RuntimeHelpers.GetObjectValue(row["EntityName"]), ""), Database.IsNull(RuntimeHelpers.GetObjectValue(row["EntityFormName"]), ""), Database.IsNull(RuntimeHelpers.GetObjectValue(row["AssociatedEntityGUID"]), Guid.Empty), Database.IsNull(RuntimeHelpers.GetObjectValue(row["EntityType"]), "")));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void ListView1_DoubleClick(object sender, EventArgs e)
  {
    if (this.ListView1.SelectedItems.Count <= 0)
      return;
    EntityListItem selectedItem = (EntityListItem) this.ListView1.SelectedItems[0];
    Type entityType = selectedItem.EntityType;
    if ((object) entityType == null)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObject(entityType));
    if (!(objectValue is IRecreatableEntity recreatableEntity))
      return;
    bool flag = false;
    try
    {
      flag = recreatableEntity.RecreateEntityInitialize(selectedItem.EntityGUID);
    }
    catch (InvalidCastException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("The control number could not be found in the database, this association will be removed.", "Error opening association", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      Note_System.Instance.NonInteractive.UnbindNote(this.NoteGUID, selectedItem.EntityGUID);
      this.Reset();
      ProjectData.ClearProjectError();
    }
    if (!flag || !(objectValue is Form form))
      return;
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
  }

  private void mnuRename_Click(object sender, EventArgs e)
  {
    if (this.ListView1.SelectedItems.Count <= 0 || !(this.ListView1.SelectedItems[0] is EntityListItem selectedItem))
      return;
    selectedItem.BeginEdit();
  }

  private void ListView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
  {
    if (this.ListView1.SelectedItems.Count <= 0 || !(this.ListView1.SelectedItems[0] is EntityListItem selectedItem) || e.Label == null)
      return;
    Note_System.Instance.NonInteractive.EditEntityDescription(this.NoteGUID, selectedItem.EntityGUID, e.Label);
  }

  private void ctxMain_Popup(object sender, EventArgs e)
  {
    Point client = this.ListView1.PointToClient(Cursor.Position);
    ListViewItem itemAt = this.ListView1.GetItemAt(client.X, client.Y);
    if (itemAt != null && itemAt is EntityListItem)
    {
      this.ListView1.SelectedItems.Clear();
      itemAt.Selected = true;
      this.mnuRename.Visible = true;
    }
    else
      this.mnuRename.Visible = false;
  }
}
