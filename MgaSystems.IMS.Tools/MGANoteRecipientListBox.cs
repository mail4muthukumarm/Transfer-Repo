// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGANoteRecipientListBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGANoteRecipientListBox : ListBox
{
  private ToolTip _toolTip;
  private MGANoteRecipientListBox.MGANoteRecipientListItem _lastItem;

  public MGANoteRecipientListBox()
  {
    this.DrawMode = DrawMode.OwnerDrawFixed;
    this.Sorted = true;
    this.AddUser(Guid.NewGuid(), "UserA", false, MGANoteRecipientListBox.DiaryStatus.None);
    this.AddUser(Guid.NewGuid(), "UserB", false, MGANoteRecipientListBox.DiaryStatus.Complete);
    this.AddUser(Guid.NewGuid(), "UserC", false, MGANoteRecipientListBox.DiaryStatus.NotComplete);
    this.AddUser(Guid.NewGuid(), "UserD", true, MGANoteRecipientListBox.DiaryStatus.None);
    this.AddUser(Guid.NewGuid(), "UserE", true, MGANoteRecipientListBox.DiaryStatus.Complete);
    this.AddUser(Guid.NewGuid(), "UserF", true, MGANoteRecipientListBox.DiaryStatus.NotComplete);
  }

  protected override void OnDrawItem(DrawItemEventArgs e)
  {
    base.OnDrawItem(e);
    if (this.Items.Count == 0)
      return;
    int index = e.Index;
    if (e.Index == -1)
      index = 0;
    MGANoteRecipientListBox.MGANoteRecipientListItem recipientListItem = (MGANoteRecipientListBox.MGANoteRecipientListItem) base.Items[index];
    e.DrawBackground();
    int height1 = e.Bounds.Height;
    Rectangle rect = new Rectangle(e.Bounds.Width - (height1 + 4), e.Bounds.Y, height1, height1);
    switch (recipientListItem.Diary)
    {
      case MGANoteRecipientListBox.DiaryStatus.Complete:
        e.Graphics.DrawImage(ImageCache.Instance.NoteDiaryComplete, rect);
        break;
      case MGANoteRecipientListBox.DiaryStatus.NotComplete:
        e.Graphics.DrawImage(ImageCache.Instance.NoteDiaryNotComplete, rect);
        break;
    }
    rect.Offset(-(height1 + 4), 0);
    if (recipientListItem.NoteRead)
      e.Graphics.DrawImage(ImageCache.Instance.NoteRead, rect);
    else
      e.Graphics.DrawImage(ImageCache.Instance.NoteUnread, rect);
    RectangleF layoutRectangle;
    ref RectangleF local = ref layoutRectangle;
    double x = (double) e.Bounds.X;
    double y = (double) (e.Bounds.Y - 1);
    int width1 = e.Bounds.Width;
    Rectangle bounds = e.Bounds;
    int num = bounds.Right - rect.Left;
    double width2 = (double) (width1 - num);
    bounds = e.Bounds;
    double height2 = (double) bounds.Height;
    local = new RectangleF((float) x, (float) y, (float) width2, (float) height2);
    StringFormat format = new StringFormat();
    format.Trimming = StringTrimming.EllipsisCharacter;
    if (recipientListItem.RequiresAction)
    {
      Font font = new Font(e.Font, FontStyle.Bold);
      e.Graphics.DrawString(recipientListItem.ToString(), font, Brushes.Black, layoutRectangle, format);
      font.Dispose();
    }
    else
      e.Graphics.DrawString(recipientListItem.ToString(), e.Font, Brushes.Black, layoutRectangle, format);
    format.Dispose();
    e.DrawFocusRectangle();
  }

  public void AddUser(
    Guid userGuid,
    string userName,
    bool noteRead,
    MGANoteRecipientListBox.DiaryStatus diary)
  {
    base.Items.Add((object) new MGANoteRecipientListBox.MGANoteRecipientListItem(userGuid, userName, noteRead, diary));
  }

  public void Clear() => base.Items.Clear();

  public void RemoveUser(Guid userGuid)
  {
    int num = base.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (((MGANoteRecipientListBox.MGANoteRecipientListItem) base.Items[index]).UserGUID.Equals(userGuid))
      {
        base.Items.Remove(RuntimeHelpers.GetObjectValue(base.Items[index]));
        this.Refresh();
        break;
      }
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new ListBox.ObjectCollection Items => base.Items;

  private ToolTip ToolTip
  {
    get
    {
      if (this._toolTip == null)
        this._toolTip = new ToolTip();
      this._toolTip.InitialDelay = 5;
      return this._toolTip;
    }
  }

  protected override void Dispose(bool disposing)
  {
    base.Dispose(disposing);
    if (this._toolTip == null)
      return;
    this._toolTip.Dispose();
  }

  protected override void OnMouseMove(MouseEventArgs e)
  {
    base.OnMouseMove(e);
    int index = this.IndexFromPoint(e.X, e.Y);
    if (index >= 0)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(base.Items[index]);
      if (objectValue == null || !(objectValue is MGANoteRecipientListBox.MGANoteRecipientListItem recipientListItem) || recipientListItem == this._lastItem)
        return;
      string caption = string.Empty;
      if (recipientListItem.RequiresAction)
      {
        if (recipientListItem.NoteRead)
        {
          switch (recipientListItem.Diary)
          {
            case MGANoteRecipientListBox.DiaryStatus.None:
              caption = $"{recipientListItem.ToString()} has read this entry";
              break;
            case MGANoteRecipientListBox.DiaryStatus.Complete:
              caption = $"{recipientListItem.ToString()} has satisfied all specified requirements for this entry";
              break;
            case MGANoteRecipientListBox.DiaryStatus.NotComplete:
              caption = $"{recipientListItem.ToString()} has read, but has not completed this diary";
              break;
          }
        }
        else
        {
          switch (recipientListItem.Diary)
          {
            case MGANoteRecipientListBox.DiaryStatus.None:
              caption = $"{recipientListItem.ToString()} has not read this note";
              break;
            case MGANoteRecipientListBox.DiaryStatus.Complete:
              caption = $"{recipientListItem.ToString()} has not read this diary";
              break;
            case MGANoteRecipientListBox.DiaryStatus.NotComplete:
              caption = $"{recipientListItem.ToString()} has not read or completed this diary";
              break;
          }
        }
      }
      else
        caption = $"{recipientListItem.ToString()} has satisfied all specified requirements for this entry";
      this.ToolTip.SetToolTip((Control) this, caption);
    }
    else
      this.ToolTip.SetToolTip((Control) this, string.Empty);
  }

  public enum DiaryStatus
  {
    None,
    Complete,
    NotComplete,
  }

  [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
  public sealed class MGANoteRecipientListItem
  {
    private Guid _userGuid;
    private string _userName;
    private bool _noteRead;
    private MGANoteRecipientListBox.DiaryStatus _diary;

    public MGANoteRecipientListItem(
      Guid userGUID,
      string userName,
      bool noteRead,
      MGANoteRecipientListBox.DiaryStatus diary)
    {
      this._userGuid = userGUID;
      this._noteRead = noteRead;
      this._userName = userName;
      this._diary = diary;
    }

    public bool NoteRead => this._noteRead;

    public MGANoteRecipientListBox.DiaryStatus Diary => this._diary;

    public Guid UserGUID => this._userGuid;

    public override string ToString() => this._userName;

    public bool RequiresAction
    {
      get => this.Diary != MGANoteRecipientListBox.DiaryStatus.None || !this.NoteRead;
    }
  }
}
