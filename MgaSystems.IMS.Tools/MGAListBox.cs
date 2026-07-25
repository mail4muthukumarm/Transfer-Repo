// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAListBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public class MGAListBox : ListBoxEx, ISupportInitialize
{
  private MGAStyles _mgaStyle;

  public MGAListBox()
  {
    this._mgaStyle = MGAStyles.Gray;
    this.BorderStyle = BorderStyle.FixedSingle;
    this.BorderColor = Color.Gray;
    this.DoubleBuffered = true;
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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new Color BorderColor
  {
    get => base.BorderColor;
    set => base.BorderColor = value;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new BorderStyle BorderStyle
  {
    get => base.BorderStyle;
    set => base.BorderStyle = value;
  }

  public void BeginInit()
  {
  }

  public void EndInit()
  {
    if (this._mgaStyle == MGAStyles.None)
      return;
    this.InitializeAppearance(this._mgaStyle);
  }
}
