// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGACheckBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGACheckBox : UltraCheckEditor, ISupportInitialize
{
  private MGAStyles _mgaStyle;

  [DefaultValue(typeof (MGAStyles), "Gray")]
  public MGAStyles MGAStyle
  {
    get => this._mgaStyle;
    set
    {
      if (this._mgaStyle != value)
      {
        this._mgaStyle = value;
        MGACheckBox.InitializeAppearance(((UltraToggleEditorBase) this).Appearance, this._mgaStyle);
      }
      ((UltraControlBase) this).Refresh();
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool ShouldSerializeAppearance()
  {
    return this._mgaStyle == MGAStyles.None && ((UltraToggleEditorBase) this).ShouldSerializeAppearance();
  }

  public static void InitializeAppearance(AppearanceBase app, MGAStyles style)
  {
    AppearanceBase appearanceBase = app;
    appearanceBase.ForeColor = Color.Black;
    switch (style)
    {
      case MGAStyles.Gray:
        appearanceBase.BorderColor = Color.Gray;
        break;
      case MGAStyles.Blue:
        appearanceBase.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
        break;
    }
  }

  public void BeginInit()
  {
  }

  public void EndInit()
  {
    if (this._mgaStyle == MGAStyles.None)
      return;
    MGACheckBox.InitializeAppearance(((UltraToggleEditorBase) this).Appearance, this._mgaStyle);
  }

  public MGACheckBox()
  {
    this._mgaStyle = MGAStyles.Gray;
    MGACheckBox.InitializeAppearance(((UltraToggleEditorBase) this).Appearance, this._mgaStyle);
    ((Control) this).DoubleBuffered = true;
    ((UltraToggleEditorBase) this).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean FlatMode
  {
    get => ((UltraControlBase) this).UseFlatMode;
    set
    {
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean SupportThemes
  {
    get => ((UltraControlBase) this).UseOsThemes;
    set
    {
    }
  }
}
