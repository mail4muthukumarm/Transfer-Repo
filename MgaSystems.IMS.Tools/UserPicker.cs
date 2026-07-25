// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.UserPicker
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win.Misc;
using MGASystems.Tools.BaseClasses;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (UserPicker))]
public class UserPicker : MGABaseUserControl
{
  private IContainer components;
  private ImageList imgList;
  private ColumnHeader ColumnHeader1;
  private Label Label1;
  private Label Label2;
  private ContextMenu ctxUsers;
  private CheckedListBox lstSelectedUsers;
  private DataTable _groupTable;
  private DataTable _userTable;
  private string _groupGUIDMember;
  private string _groupDisplayMember;
  private string _userGUIDMember;
  private string _userDisplayMember;
  private bool dataLoaded;
  private WeakReference _weakRefUserPickerGUIDAddingEventArgs;
  private const int CONST_GROUPIMAGE_INDEX = 0;

  public event UserPicker.UserPickerGUIDAddingEventHandler UserGUIDAdding;

  public UserPicker() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual ListView lstUsers
  {
    get => this._lstUsers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lstUsers_DoubleClick);
      ListView lstUsers1 = this._lstUsers;
      if (lstUsers1 != null)
        lstUsers1.DoubleClick -= eventHandler;
      this._lstUsers = value;
      ListView lstUsers2 = this._lstUsers;
      if (lstUsers2 == null)
        return;
      lstUsers2.DoubleClick += eventHandler;
    }
  }

  private virtual UltraButton btnAdd
  {
    get => this._btnAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      UltraButton btnAdd1 = this._btnAdd;
      if (btnAdd1 != null)
        ((Control) btnAdd1).Click -= eventHandler;
      this._btnAdd = value;
      UltraButton btnAdd2 = this._btnAdd;
      if (btnAdd2 == null)
        return;
      ((Control) btnAdd2).Click += eventHandler;
    }
  }

  private virtual MenuItem mnuRemove
  {
    get => this._mnuRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuRemove_Click);
      MenuItem mnuRemove1 = this._mnuRemove;
      if (mnuRemove1 != null)
        mnuRemove1.Click -= eventHandler;
      this._mnuRemove = value;
      MenuItem mnuRemove2 = this._mnuRemove;
      if (mnuRemove2 == null)
        return;
      mnuRemove2.Click += eventHandler;
    }
  }

  private virtual UltraButton btnDelete
  {
    get => this._btnDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BtnDelete_Click);
      UltraButton btnDelete1 = this._btnDelete;
      if (btnDelete1 != null)
        ((Control) btnDelete1).Click -= eventHandler;
      this._btnDelete = value;
      UltraButton btnDelete2 = this._btnDelete;
      if (btnDelete2 == null)
        return;
      ((Control) btnDelete2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ResourceManager resourceManager = new ResourceManager(typeof (UserPicker));
    ListViewItem listViewItem1 = new ListViewItem(new string[1]
    {
      "Test"
    }, 0, SystemColors.WindowText, SystemColors.Window, new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
    ListViewItem listViewItem2 = new ListViewItem(new string[1]
    {
      "Test 2"
    }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
    this.imgList = new ImageList(this.components);
    this.lstUsers = new ListView();
    this.ColumnHeader1 = new ColumnHeader();
    this.btnAdd = new UltraButton();
    this.Label1 = new Label();
    this.btnDelete = new UltraButton();
    this.Label2 = new Label();
    this.ctxUsers = new ContextMenu();
    this.mnuRemove = new MenuItem();
    this.lstSelectedUsers = new CheckedListBox();
    this.SuspendLayout();
    this.imgList.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.imgList.ImageStream = (ImageListStreamer) resourceManager.GetObject("imgList.ImageStream");
    this.imgList.TransparentColor = Color.Transparent;
    this.lstUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.lstUsers.BorderStyle = BorderStyle.FixedSingle;
    this.lstUsers.Columns.AddRange(new ColumnHeader[1]
    {
      this.ColumnHeader1
    });
    this.lstUsers.FullRowSelect = true;
    this.lstUsers.Items.AddRange(new ListViewItem[2]
    {
      listViewItem1,
      listViewItem2
    });
    this.lstUsers.Location = new Point(0, 16 /*0x10*/);
    this.lstUsers.Name = "lstUsers";
    this.lstUsers.Size = new Size(192 /*0xC0*/, 238);
    this.lstUsers.SmallImageList = this.imgList;
    this.lstUsers.Sorting = SortOrder.Ascending;
    this.lstUsers.TabIndex = 3;
    this.lstUsers.View = View.SmallIcon;
    this.ColumnHeader1.Text = "";
    this.ColumnHeader1.Width = 206;
    ((Control) this.btnAdd).Location = new Point(208 /*0xD0*/, 24);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(56, 24);
    ((Control) this.btnAdd).TabIndex = 4;
    ((ControlBase) this.btnAdd).Text = ">>";
    this.Label1.BorderStyle = BorderStyle.FixedSingle;
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(192 /*0xC0*/, 16 /*0x10*/);
    this.Label1.TabIndex = 5;
    this.Label1.Text = "Names";
    ((Control) this.btnDelete).Location = new Point(208 /*0xD0*/, 56);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new Size(56, 24);
    ((Control) this.btnDelete).TabIndex = 7;
    ((ControlBase) this.btnDelete).Text = "<<";
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label2.BorderStyle = BorderStyle.FixedSingle;
    this.Label2.Location = new Point(280, 0);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(200, 16 /*0x10*/);
    this.Label2.TabIndex = 8;
    this.Label2.Text = "Receipients";
    this.ctxUsers.MenuItems.AddRange(new MenuItem[1]
    {
      this.mnuRemove
    });
    this.mnuRemove.Index = 0;
    this.mnuRemove.Text = "Remove";
    this.lstSelectedUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstSelectedUsers.BorderStyle = BorderStyle.FixedSingle;
    this.lstSelectedUsers.IntegralHeight = false;
    this.lstSelectedUsers.Location = new Point(280, 16 /*0x10*/);
    this.lstSelectedUsers.Name = "lstSelectedUsers";
    this.lstSelectedUsers.Size = new Size(200, 240 /*0xF0*/);
    this.lstSelectedUsers.TabIndex = 9;
    this.Controls.Add((Control) this.lstSelectedUsers);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.lstUsers);
    this.Name = nameof (UserPicker);
    this.Size = new Size(480, 256 /*0x0100*/);
    this.ResumeLayout(false);
  }

  [Description("Sets/Gets the image used to display groups")]
  [Category("Appearance")]
  public Image GroupImage
  {
    get
    {
      return !this.DesignMode ? (this.imgList.Images.Count != 1 ? (Image) null : this.imgList.Images[0]) : (Image) null;
    }
    set
    {
      if (value == null)
        return;
      if (this.imgList.Images.Count == 1)
        this.imgList.Images[0] = value;
      else
        this.imgList.Images.Add(value);
    }
  }

  [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
  [Browsable(false)]
  public MustCompleteContextGUID[] SelectedUsers
  {
    get
    {
      MustCompleteContextGUID[] selectedUsers = new MustCompleteContextGUID[this.lstSelectedUsers.Items.Count - 1 + 1];
      try
      {
        foreach (TaggedListItem taggedListItem in (ListBox.ObjectCollection) this.lstSelectedUsers.Items)
        {
          int index;
          selectedUsers[index] = (MustCompleteContextGUID) taggedListItem.Tag;
          selectedUsers[index].MustComplete = this.lstSelectedUsers.CheckedIndices.Contains(index);
          ++index;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return selectedUsers;
    }
  }

  [Description("Sets/Gets the group table used to fill the control")]
  [Category("Data")]
  public DataTable GroupTable
  {
    get => this._groupTable;
    set => this._groupTable = value;
  }

  [Description("Sets/Gets the user table used to fill the control")]
  [Category("Data")]
  public DataTable UserTable
  {
    get => this._userTable;
    set => this._userTable = value;
  }

  [Description("Sets/Gets the column used to get the group GUID")]
  [Category("Data")]
  [Editor(typeof (UserPicker.UserPickerGUIDTypeUIEditor), typeof (UITypeEditor))]
  public string UserGUIDMember
  {
    get => this._userGUIDMember;
    set => this._userGUIDMember = value;
  }

  [Description("Sets/Gets the column used to get the user display text")]
  [Category("Data")]
  [Editor(typeof (UserPicker.UserPickerDisplayTypeUIEditor), typeof (UITypeEditor))]
  public string UserDisplayMember
  {
    get => this._userDisplayMember;
    set => this._userDisplayMember = value;
  }

  [Description("Sets/Gets the column used to get the user GUID")]
  [Category("Data")]
  [Editor(typeof (UserPicker.UserPickerGUIDTypeUIEditor), typeof (UITypeEditor))]
  public string GroupGUIDMember
  {
    get => this._groupGUIDMember;
    set => this._groupGUIDMember = value;
  }

  [Description("Sets/Gets the column used to get the group display text")]
  [Category("Data")]
  [Editor(typeof (UserPicker.UserPickerDisplayTypeUIEditor), typeof (UITypeEditor))]
  public string GroupDisplayMember
  {
    get => this._groupDisplayMember;
    set => this._groupDisplayMember = value;
  }

  [Description("Sets/Gets the text on the remove button")]
  [Category("Appearance")]
  [DefaultValue("<<")]
  public string RemoveButtonText
  {
    get => ((ControlBase) this.btnDelete).Text;
    set => ((ControlBase) this.btnDelete).Text = value;
  }

  [Description("Sets/Gets the text on the add button")]
  [Category("Appearance")]
  [DefaultValue(">>")]
  public string AddButtonText
  {
    get => ((ControlBase) this.btnAdd).Text;
    set => ((ControlBase) this.btnAdd).Text = value;
  }

  private UserPickerGUIDAddingEventArgs UserPickerGUIDAddingEventArgs
  {
    get
    {
      if (this._weakRefUserPickerGUIDAddingEventArgs == null)
        this._weakRefUserPickerGUIDAddingEventArgs = new WeakReference((object) new UserPickerGUIDAddingEventArgs());
      UserPickerGUIDAddingEventArgs guidAddingEventArgs = (UserPickerGUIDAddingEventArgs) this._weakRefUserPickerGUIDAddingEventArgs.Target;
      if (guidAddingEventArgs == null)
      {
        guidAddingEventArgs = new UserPickerGUIDAddingEventArgs();
        this._weakRefUserPickerGUIDAddingEventArgs.Target = (object) guidAddingEventArgs;
      }
      return guidAddingEventArgs;
    }
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  public void Reset()
  {
    this.lstUsers.BeginUpdate();
    this.lstUsers.Items.Clear();
    this.lstSelectedUsers.Items.Clear();
    if (this.UserTable != null)
    {
      try
      {
        foreach (DataRow row in this.UserTable.Rows)
        {
          try
          {
            MustCompleteContextGUID completeContextGuid = new MustCompleteContextGUID((Guid) row[this.UserGUIDMember], GuidContext.User);
            UserPickerGUIDAddingEventArgs guidAddingEventArgs = this.UserPickerGUIDAddingEventArgs;
            guidAddingEventArgs.Cancel = false;
            guidAddingEventArgs.UserGUID = (ContextGuid) completeContextGuid;
            // ISSUE: reference to a compiler-generated field
            UserPicker.UserPickerGUIDAddingEventHandler userGuidAddingEvent = this.UserGUIDAddingEvent;
            if (userGuidAddingEvent != null)
              userGuidAddingEvent((object) this, guidAddingEventArgs);
            if (!guidAddingEventArgs.Cancel)
              this.lstUsers.Items.Add((string) row[this.UserDisplayMember]).Tag = (object) completeContextGuid;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
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
    if (this.GroupTable != null)
    {
      Font font = new Font(this.Font, FontStyle.Bold);
      try
      {
        foreach (DataRow row in this.GroupTable.Rows)
        {
          try
          {
            MustCompleteContextGUID completeContextGuid = new MustCompleteContextGUID((Guid) row[this.GroupGUIDMember], GuidContext.Group);
            UserPickerGUIDAddingEventArgs guidAddingEventArgs = this.UserPickerGUIDAddingEventArgs;
            guidAddingEventArgs.Cancel = false;
            guidAddingEventArgs.UserGUID = (ContextGuid) completeContextGuid;
            // ISSUE: reference to a compiler-generated field
            UserPicker.UserPickerGUIDAddingEventHandler userGuidAddingEvent = this.UserGUIDAddingEvent;
            if (userGuidAddingEvent != null)
              userGuidAddingEvent((object) this, guidAddingEventArgs);
            if (!guidAddingEventArgs.Cancel)
            {
              ListViewItem listViewItem = this.lstUsers.Items.Add((string) row[this.GroupDisplayMember]);
              listViewItem.Tag = (object) completeContextGuid;
              listViewItem.Font = font;
              listViewItem.ImageIndex = 0;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
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
    this.lstUsers.EndUpdate();
  }

  private void lstUsers_DoubleClick(object sender, EventArgs e) => this.AddSelectedUsers();

  private void btnAdd_Click(object sender, EventArgs e) => this.AddSelectedUsers();

  private void mnuRemove_Click(object sender, EventArgs e) => this.RemoveSelectedUsers();

  private void BtnDelete_Click(object sender, EventArgs e) => this.RemoveSelectedUsers();

  private void AddSelectedUsers()
  {
    if (this.lstUsers.SelectedItems == null)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.lstUsers.SelectedItems)
        this.AddSelectedUserNoDuplicates((MustCompleteContextGUID) selectedItem.Tag, selectedItem.Text);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void AddSelectedUserNoDuplicates(MustCompleteContextGUID contextGuid, string displayName)
  {
    try
    {
      foreach (TaggedListItem taggedListItem in (ListBox.ObjectCollection) this.lstSelectedUsers.Items)
      {
        if (((ContextGuid) taggedListItem.Tag).Guid.Equals(contextGuid.Guid))
          return;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lstSelectedUsers.Items.Add((object) new TaggedListItem(displayName, (object) contextGuid), true);
  }

  private void RemoveSelectedUsers() => this.lstSelectedUsers.ClearSelected();

  protected override void OnPaint(PaintEventArgs e)
  {
    base.OnPaint(e);
    if (this.dataLoaded)
      return;
    this.Reset();
    this.dataLoaded = true;
  }

  protected override Size DefaultSize => new Size(480, 256 /*0x0100*/);

  [SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances")]
  public delegate void UserPickerGUIDAddingEventHandler(
    object sender,
    UserPickerGUIDAddingEventArgs e);

  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  public sealed class UserPickerGUIDTypeUIEditor : ListTypeUIEditor
  {
    protected override void LoadListBox(
      Component control,
      ITypeDescriptorContext context,
      ListBox listbox)
    {
      UserPicker userPicker = (UserPicker) control;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.PropertyDescriptor.Name, "GroupGUIDMember", false) == 0)
      {
        if (userPicker.GroupTable == null)
          return;
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) userPicker.GroupTable.Columns)
          {
            if ((object) column.DataType == (object) typeof (Guid))
              listbox.Items.Add((object) column.ColumnName);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        if (userPicker.UserTable == null)
          return;
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) userPicker.UserTable.Columns)
          {
            if ((object) column.DataType == (object) typeof (Guid))
              listbox.Items.Add((object) column.ColumnName);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
  }

  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  public sealed class UserPickerDisplayTypeUIEditor : ListTypeUIEditor
  {
    protected override void LoadListBox(
      Component control,
      ITypeDescriptorContext context,
      ListBox listbox)
    {
      UserPicker userPicker = (UserPicker) control;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.PropertyDescriptor.Name, "GroupDisplayMember", false) == 0)
      {
        if (userPicker.GroupTable == null)
          return;
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) userPicker.GroupTable.Columns)
          {
            if ((object) column.DataType == (object) typeof (string))
              listbox.Items.Add((object) column.ColumnName);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        if (userPicker.UserTable == null)
          return;
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) userPicker.UserTable.Columns)
          {
            if ((object) column.DataType == (object) typeof (string))
              listbox.Items.Add((object) column.ColumnName);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }
  }
}
