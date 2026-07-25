// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGACheckedListBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGACheckedListBox : CheckedListBoxEx, ISupportInitialize
{
  private MGAStyles _mgaStyle;

  public MGACheckedListBox()
  {
    this._mgaStyle = MGAStyles.Gray;
    this.BorderStyle = BorderStyle.FixedSingle;
    this.BorderColor = Color.Gray;
    this.DoubleBuffered = true;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new Color BorderColor
  {
    get => base.BorderColor;
    set
    {
    }
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new BorderStyle BorderStyle
  {
    get => base.BorderStyle;
    set
    {
    }
  }

  [DefaultValue(typeof (MGAStyles), "Gray")]
  public MGAStyles MGAStyle
  {
    get => this._mgaStyle;
    set
    {
      if (this._mgaStyle != value)
      {
        this._mgaStyle = value;
        this.InitializeAppearance(this._mgaStyle);
      }
      this.Refresh();
    }
  }

  public void InitializeAppearance(MGAStyles style)
  {
    switch (style)
    {
      case MGAStyles.Gray:
        this.BorderColor = Color.Gray;
        break;
      case MGAStyles.Blue:
        this.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
        break;
    }
  }

  private bool ShouldSerializeBorderStyle() => false;

  private bool ShouldSerializeBorderColor() => this._mgaStyle == MGAStyles.None;

  public void BeginInit()
  {
  }

  public void EndInit() => this.InitializeAppearance(this._mgaStyle);
}
