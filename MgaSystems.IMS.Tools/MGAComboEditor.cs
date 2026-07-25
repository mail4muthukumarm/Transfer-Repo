// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAComboEditor
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinScrollBar;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public class MGAComboEditor : UltraComboEditor
{
  private MGAStyles _mgaStyle;

  [DefaultValue(typeof (MGAStyles), "Gray")]
  public MGAStyles MGAStyle
  {
    get => this._mgaStyle;
    set
    {
      if (value == this._mgaStyle)
        return;
      this._mgaStyle = value;
      this.SetupAppearances();
    }
  }

  private void SetupAppearances()
  {
    if (this.MGAStyle == MGAStyles.Blue)
      this.SetBlueAppearance();
    else
      this.SetGrayAppearance();
  }

  private void SetCommonAppearances()
  {
    new ScrollBarLook().ViewStyle = (ScrollBarViewStyle) 3;
    Appearance appearance = new Appearance();
    ((UltraControlBase) this).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 2;
    appearance.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((TextEditorControlBase) this).Appearance.ForeColor = Color.Black;
  }

  private void SetGrayAppearance()
  {
    this.SetCommonAppearances();
    ((TextEditorControlBase) this).Appearance.BorderColor = Color.Gray;
    AppearanceBase buttonAppearance = this.ButtonAppearance;
    buttonAppearance.BackColor = Color.LightGray;
    buttonAppearance.BackColor2 = Color.White;
    buttonAppearance.BackGradientStyle = (GradientStyle) 2;
    buttonAppearance.BorderColor = Color.LightGray;
    buttonAppearance.ForeColor = Color.FromArgb(60, 60, 60);
  }

  private void SetBlueAppearance()
  {
    this.SetCommonAppearances();
    ((TextEditorControlBase) this).Appearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((TextEditorControlBase) this).BorderStyle = (UIElementBorderStyle) 4;
    ((TextEditorControlBase) this).CharacterCasing = CharacterCasing.Normal;
    AppearanceBase buttonAppearance = this.ButtonAppearance;
    buttonAppearance.AlphaLevel = (short) 14;
    buttonAppearance.BackColor = Color.FromArgb(0, 0, 246, 253);
    buttonAppearance.BackColor2 = Color.FromArgb(133, 162, 221);
    buttonAppearance.BackColorAlpha = (Alpha) 2;
    buttonAppearance.BackGradientAlignment = (GradientAlignment) 4;
    buttonAppearance.BackGradientStyle = (GradientStyle) 5;
    buttonAppearance.BorderAlpha = (Alpha) 1;
    buttonAppearance.BorderColor = Color.FromArgb(78, 122, 171);
    buttonAppearance.ForeColor = Color.FromArgb(49, 85, 153);
    buttonAppearance.ForegroundAlpha = (Alpha) 2;
    ((TextEditorControlBase) this).Appearance.BorderColor = Color.FromArgb(78, 122, 171);
  }
}
