// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAStatusComboBox
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

[ToolboxBitmap(typeof (ComboBox))]
[Designer(typeof (MGAComboBoxDesigner))]
public sealed class MGAStatusComboBox : ComboBox
{
  private IContainer components;
  private string _statusMember;
  private MGAStatusLook _mgaStatusLook;
  private Color _originalForeColor;
  private Font _originalControlFont;
  private Font _strikeThruFont;

  public MGAStatusComboBox()
  {
    this.DrawItem += new DrawItemEventHandler(this.MGACombobox_DrawItem);
    this.SelectedValueChanged += new EventHandler(this.MGAComboBox_SelectedValueChanged);
    this._statusMember = "(none)";
    this._originalForeColor = this.ForeColor;
    this._originalControlFont = this.Font;
    this.InitializeComponent();
    if (this.DesignMode)
      base.DrawMode = DrawMode.Normal;
    else
      base.DrawMode = DrawMode.OwnerDrawFixed;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent() => this.components = (IContainer) new System.ComponentModel.Container();

  protected override void RefreshItem(int index) => base.RefreshItem(index);

  protected override void SetItemsCore(IList items) => base.SetItemsCore(items);

  [Browsable(false)]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public new DrawMode DrawMode
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

  private DataTable DataSourceTable
  {
    get
    {
      return !(this.DataSource is DataTable) ? (!(this.DataSource is DataView) ? (DataTable) null : ((DataView) this.DataSource).Table) : (DataTable) this.DataSource;
    }
  }

  private void MGACombobox_DrawItem(object sender, DrawItemEventArgs e)
  {
    if (this.DesignMode)
      return;
    ComboBox cb = (ComboBox) sender;
    if (this.DataSourceTable == null || this.DataSourceTable != null && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DisplayMember, string.Empty, false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.StatusMember, string.Empty, false) == 0))
    {
      this.DrawCurrentItem(cb, e, MGAStatusLook.DisplayAction.Normal);
    }
    else
    {
      int num = this.StatusFromIndex(e.Index);
      if (num == this.MGAStatusLook.ActiveValue)
        this.DrawCurrentItem(cb, e, this.MGAStatusLook.ActiveValueDisplayAction);
      else if (num == this.MGAStatusLook.InActiveValue)
        this.DrawCurrentItem(cb, e, this.MGAStatusLook.InActiveValueDisplayAction);
      else if (num == this.MGAStatusLook.ClosedValue)
        this.DrawCurrentItem(cb, e, this.MGAStatusLook.ClosedValueDisplayAction);
      else
        this.DrawCurrentItem(cb, e, MGAStatusLook.DisplayAction.Error);
    }
  }

  private Color ForeColorFromSelectedItem()
  {
    Color color;
    if (this._mgaStatusLook == null || this.DataSource == null || this.SelectedIndex == -1)
    {
      color = this._originalForeColor;
    }
    else
    {
      int num = this.StatusFromIndex(this.SelectedIndex);
      color = num != this.MGAStatusLook.ActiveValue ? (num != this.MGAStatusLook.InActiveValue ? (num != this.MGAStatusLook.ClosedValue ? this.MGAStatusLook.ErrorForeColor : this.MGAStatusLook.DisabledStrikeThruForeColor) : this.MGAStatusLook.DisabledForeColor) : this.MGAStatusLook.NormalForeColor;
    }
    return color;
  }

  private void DrawCurrentItem(
    ComboBox cb,
    DrawItemEventArgs drawArgs,
    MGAStatusLook.DisplayAction displayAction)
  {
    DrawItemEventArgs drawItemEventArgs = drawArgs;
    drawItemEventArgs.DrawBackground();
    if (drawArgs.Index == -1)
      return;
    Brush brush1 = (Brush) null;
    Font prototype = this._originalControlFont;
    Brush brush2 = (Brush) null;
    Font font1 = (Font) null;
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
          font1 = new Font(prototype, prototype.Style | FontStyle.Strikeout);
          prototype = font1;
          break;
      }
    }
    string empty = string.Empty;
    string str = this.DataSourceTable == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DisplayMember, string.Empty, false) == 0 ? (!this.DesignMode ? cb.Items[drawItemEventArgs.Index].ToString() : this.Text) : Conversions.ToString(((DataRowView) cb.Items[drawItemEventArgs.Index])[this.DisplayMember]);
    Graphics graphics = drawItemEventArgs.Graphics;
    string s = str;
    Font font2 = prototype;
    Brush brush3 = brush1;
    double x = (double) drawItemEventArgs.Bounds.X;
    Rectangle bounds = drawItemEventArgs.Bounds;
    double y = (double) bounds.Y;
    bounds = drawItemEventArgs.Bounds;
    double width = (double) bounds.Width;
    bounds = drawItemEventArgs.Bounds;
    double height = (double) bounds.Height;
    RectangleF layoutRectangle = new RectangleF((float) x, (float) y, (float) width, (float) height);
    graphics.DrawString(s, font2, brush3, layoutRectangle);
    brush2?.Dispose();
    font1?.Dispose();
    drawItemEventArgs.DrawFocusRectangle();
  }

  private int StatusFromIndex(int index)
  {
    return Conversions.ToInteger(this.DataSourceTable.Rows[index][this.StatusMember]);
  }

  private Font StrikeThruFont
  {
    get
    {
      if (this._strikeThruFont == null)
        this._strikeThruFont = new Font(this._originalControlFont, this._originalControlFont.Style | FontStyle.Strikeout);
      return this._strikeThruFont;
    }
  }

  private Font FontFromSelectedItem
  {
    get
    {
      return this._mgaStatusLook == null || this.DataSource == null || this.SelectedIndex == -1 ? this._originalControlFont : (this.StatusFromIndex(this.SelectedIndex) != this.MGAStatusLook.ClosedValue ? this._originalControlFont : this.StrikeThruFont);
    }
  }

  private void MGAComboBox_SelectedValueChanged(object sender, EventArgs e)
  {
    this.ForeColor = this.ForeColorFromSelectedItem();
    this.Font = this.FontFromSelectedItem;
  }
}
