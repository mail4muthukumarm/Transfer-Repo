// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAMaskedEdit
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinMaskedEdit;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGAMaskedEdit : UltraMaskedEdit, ISupportInitialize
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
        MGAMaskedEdit.InitializeAppearance(this.Appearance, this._mgaStyle);
      }
      ((UltraControlBase) this).Refresh();
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool ShouldSerializeAppearance()
  {
    return this._mgaStyle == MGAStyles.None && base.ShouldSerializeAppearance();
  }

  public static void InitializeAppearance(AppearanceBase app, MGAStyles style)
  {
    AppearanceBase appearanceBase = app;
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
    MGAMaskedEdit.InitializeAppearance(this.Appearance, this._mgaStyle);
  }

  public MGAMaskedEdit()
  {
    this._mgaStyle = MGAStyles.Gray;
    MGAMaskedEdit.InitializeAppearance(this.Appearance, this._mgaStyle);
    this.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraControlBase) this).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this).DoubleBuffered = true;
    this.PromptCharacterAppearance.ForeColor = Color.Gray;
  }

  [DefaultValue(typeof (UIElementBorderStyle), "Solid")]
  public UIElementBorderStyle BorderStyle
  {
    get => base.BorderStyle;
    set => base.BorderStyle = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public AppearanceBase PromptCharacterAppearance
  {
    get => base.PromptCharacterAppearance;
    set => base.PromptCharacterAppearance = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public bool FlatMode
  {
    get => ((UltraControlBase) this).UseFlatMode > 0;
    set
    {
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public bool SupportThemes
  {
    get => ((UltraControlBase) this).UseOsThemes > 0;
    set
    {
    }
  }
}
