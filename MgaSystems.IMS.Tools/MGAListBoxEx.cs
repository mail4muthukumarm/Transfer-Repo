// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAListBoxEx
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (ListBox))]
public sealed class MGAListBoxEx : ListBox
{
  private Color _disabledItemColor;
  private WeakReference _mgaDrawListItemEventArgsWeakRef;
  private Size _checkSize;

  public event MGADrawListItemEventHandler PreDrawItemEx;

  public event ItemCheckEventHandler ItemCheckEvent;

  public MGAListBoxEx()
  {
    this._disabledItemColor = SystemColors.GrayText;
    this._checkSize = new Size(13, 13);
    base.DrawMode = DrawMode.OwnerDrawFixed;
  }

  public void ResetDrawMode() => base.DrawMode = DrawMode.OwnerDrawFixed;

  public bool ShouldSerializeDrawMode() => base.DrawMode != DrawMode.OwnerDrawFixed;

  public override DrawMode DrawMode
  {
    get => base.DrawMode;
    set => base.DrawMode = value;
  }

  [DefaultValue(typeof (Color), "GrayText")]
  [Category("Appearance")]
  [Description("The color used to render disabled listitems")]
  public Color DisabledItemColor
  {
    get => this._disabledItemColor;
    set => this._disabledItemColor = value;
  }

  private MGADrawListItemEventArgs MGADrawListItemEventArgs
  {
    get
    {
      if (this._mgaDrawListItemEventArgsWeakRef == null)
        this._mgaDrawListItemEventArgsWeakRef = new WeakReference((object) new MGADrawListItemEventArgs());
      MGADrawListItemEventArgs listItemEventArgs = (MGADrawListItemEventArgs) this._mgaDrawListItemEventArgsWeakRef.Target;
      if (listItemEventArgs == null)
      {
        listItemEventArgs = new MGADrawListItemEventArgs();
        this._mgaDrawListItemEventArgsWeakRef.Target = (object) listItemEventArgs;
      }
      return listItemEventArgs;
    }
  }

  protected override void OnDrawItem(DrawItemEventArgs e)
  {
    if (this.Items.Count > 0 && e.Index > -1)
    {
      MGADrawListItemEventArgs listItemEventArgs = this.MGADrawListItemEventArgs;
      listItemEventArgs.ItemInfo = e;
      listItemEventArgs.ShowCheck = true;
      listItemEventArgs.Enabled = false;
      listItemEventArgs.Checked = false;
      // ISSUE: reference to a compiler-generated field
      MGADrawListItemEventHandler preDrawItemExEvent = this.PreDrawItemExEvent;
      if (preDrawItemExEvent != null)
        preDrawItemExEvent((object) this, listItemEventArgs);
      e.DrawBackground();
      bool flag = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
      if (flag)
        e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
      string s = this.Items[e.Index].ToString();
      SolidBrush solidBrush1 = new SolidBrush(this.ForeColor);
      SolidBrush solidBrush2 = new SolidBrush(this.DisabledItemColor);
      if (flag)
        e.Graphics.DrawString(s, e.Font, SystemBrushes.HighlightText, (float) (e.Bounds.X + this._checkSize.Width + 3), (float) e.Bounds.Y);
      else if (listItemEventArgs.Enabled)
        e.Graphics.DrawString(s, e.Font, (Brush) solidBrush1, (float) (e.Bounds.X + this._checkSize.Width + 3), (float) e.Bounds.Y);
      else
        e.Graphics.DrawString(s, e.Font, (Brush) solidBrush2, (float) (e.Bounds.X + this._checkSize.Width + 3), (float) e.Bounds.Y);
      ButtonState state = !listItemEventArgs.Checked ? ButtonState.Normal : ButtonState.Checked;
      Rectangle rectangle = new Rectangle(new Point(0, e.Bounds.Location.Y), this._checkSize);
      if (listItemEventArgs.ShowCheck)
        ControlPaint.DrawCheckBox(e.Graphics, rectangle, state);
      solidBrush1.Dispose();
      solidBrush2.Dispose();
    }
    base.OnDrawItem(e);
  }

  protected override void OnMouseDown(MouseEventArgs e)
  {
    int index = this.IndexFromPoint(new Point(e.X, e.Y));
    if (index < 0)
      return;
    ItemCheckEventArgs e1 = new ItemCheckEventArgs(index, CheckState.Indeterminate, CheckState.Indeterminate);
    // ISSUE: reference to a compiler-generated field
    ItemCheckEventHandler itemCheckEventEvent = this.ItemCheckEventEvent;
    if (itemCheckEventEvent != null)
      itemCheckEventEvent((object) this, e1);
    this.Invalidate(this.GetItemRectangle(index));
    base.OnMouseDown(e);
  }
}
