// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAStatusListbox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (ListBox))]
[Designer(typeof (MGAListBoxDesigner))]
public sealed class MGAStatusListbox : ListBox
{
  private IContainer components;
  private string _statusMember;
  private MGAStatusLook _mgaStatusLook;

  public MGAStatusListbox()
  {
    this.DrawItem += new DrawItemEventHandler(this.MGAListbox_DrawItem);
    this._statusMember = "(none)";
    this.InitializeComponent();
    if (this.DesignMode)
      base.DrawMode = DrawMode.Normal;
    else
      base.DrawMode = DrawMode.OwnerDrawFixed;
  }

  protected override void Dispose(bool disposing)
  {
    GC.SuppressFinalize((object) this);
    if (disposing && this.components != null)
      this.components.Dispose();
    this.CleanUp();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent() => this.components = (IContainer) new System.ComponentModel.Container();

  protected override void RefreshItem(int index) => base.RefreshItem(index);

  protected override void SetItemsCore(IList items) => base.SetItemsCore(items);

  [Browsable(false)]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public override DrawMode DrawMode
  {
    get => !this.DesignMode ? DrawMode.OwnerDrawFixed : DrawMode.Normal;
    set
    {
      if (this.DesignMode)
        base.DrawMode = DrawMode.Normal;
      else
        base.DrawMode = DrawMode.OwnerDrawFixed;
    }
  }

  [Category("Data")]
  [Description("Indicates the property to display for the items in this control.")]
  [DefaultValue("(none)")]
  [Editor(typeof (StatusMemberUITypeEditor), typeof (UITypeEditor))]
  public string StatusMember
  {
    get => this._statusMember;
    set => this._statusMember = value;
  }

  [Category("Appearance")]
  [Description("The Status Look object associated with this control that displays how it is rendered.")]
  public MGAStatusLook MGAStatusLook
  {
    get => this._mgaStatusLook;
    set => this._mgaStatusLook = value;
  }

  private void ResetMGAStatusLook() => this._mgaStatusLook = (MGAStatusLook) null;

  private bool ShouldSerializeMGAStatusLook() => this._mgaStatusLook != null;

  private void MGAListbox_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (this.DesignMode)
      return;
    ListBox listbox = (ListBox) sender;
    if (this.DataSourceTable == null || this.DataSourceTable != null && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DisplayMember, string.Empty, false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.StatusMember, string.Empty, false) == 0))
    {
      this.DrawCurrentItem(listbox, e, MGAStatusLook.DisplayAction.Normal);
    }
    else
    {
      int num = this.StatusFromIndex(e.Index);
      if (num == this.MGAStatusLook.ActiveValue)
        this.DrawCurrentItem(listbox, e, this.MGAStatusLook.ActiveValueDisplayAction);
      else if (num == this.MGAStatusLook.InActiveValue)
        this.DrawCurrentItem(listbox, e, this.MGAStatusLook.InActiveValueDisplayAction);
      else if (num == this.MGAStatusLook.ClosedValue)
        this.DrawCurrentItem(listbox, e, this.MGAStatusLook.ClosedValueDisplayAction);
      else
        this.DrawCurrentItem(listbox, e, MGAStatusLook.DisplayAction.Error);
    }
  }

  private void CleanUp() => this._mgaStatusLook = (MGAStatusLook) null;

  private void DrawCurrentItem(
    ListBox listbox,
    DrawItemEventArgs drawArgs,
    MGAStatusLook.DisplayAction displayAction)
  {
    DrawItemEventArgs drawItemEventArgs = drawArgs;
    drawItemEventArgs.DrawBackground();
    if (drawArgs.Index == -1)
      return;
    Brush brush1 = (Brush) null;
    Font font1 = drawItemEventArgs.Font;
    Font font2 = (Font) null;
    Brush brush2 = (Brush) null;
    if (this.MGAStatusLook == null)
    {
      brush2 = (Brush) new SolidBrush(drawItemEventArgs.ForeColor);
      brush1 = brush2;
    }
    else
    {
      switch (displayAction)
      {
        case MGAStatusLook.DisplayAction.Error:
          brush1 = this.MGAStatusLook.ActionBrushError;
          break;
        case MGAStatusLook.DisplayAction.Normal:
          brush1 = this.MGAStatusLook.ActionBrushNormal;
          break;
        case MGAStatusLook.DisplayAction.Disabled:
          brush1 = this.MGAStatusLook.ActionBrushDisabled;
          break;
        case MGAStatusLook.DisplayAction.DisabledStrike:
          brush1 = this.MGAStatusLook.ActionBrushDisabledStrike;
          font2 = new Font(drawItemEventArgs.Font, drawItemEventArgs.Font.Style | FontStyle.Strikeout);
          font1 = font2;
          break;
      }
    }
    string empty = string.Empty;
    string str = this.DataSourceTable == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DisplayMember, string.Empty, false) == 0 ? (!this.DesignMode ? listbox.Items[drawItemEventArgs.Index].ToString() : this.Text) : Conversions.ToString(((DataRowView) listbox.Items[drawItemEventArgs.Index])[this.DisplayMember]);
    Graphics graphics = drawItemEventArgs.Graphics;
    string s = str;
    Font font3 = font1;
    Brush brush3 = brush1;
    double x = (double) drawItemEventArgs.Bounds.X;
    Rectangle bounds = drawItemEventArgs.Bounds;
    double y = (double) bounds.Y;
    bounds = drawItemEventArgs.Bounds;
    double width = (double) bounds.Width;
    bounds = drawItemEventArgs.Bounds;
    double height = (double) bounds.Height;
    RectangleF layoutRectangle = new RectangleF((float) x, (float) y, (float) width, (float) height);
    graphics.DrawString(s, font3, brush3, layoutRectangle);
    brush2?.Dispose();
    font2?.Dispose();
    drawItemEventArgs.DrawFocusRectangle();
  }

  private int StatusFromIndex(int index)
  {
    return Conversions.ToInteger(this.DataSourceTable.Rows[index][this.StatusMember]);
  }

  private DataTable DataSourceTable
  {
    get
    {
      return !(this.DataSource is DataTable) ? (!(this.DataSource is DataView) ? (DataTable) null : ((DataView) this.DataSource).Table) : (DataTable) this.DataSource;
    }
  }
}
