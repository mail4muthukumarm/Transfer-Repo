// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGADateTimePicker
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGADateTimePicker : UltraDateTimeEditor
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
        MGADateTimePicker.InitializeAppearance(this.Appearance, this._mgaStyle);
        MGADateTimePicker.InitializeButtonAppearance(this.ButtonAppearance, this._mgaStyle);
      }
      ((UltraControlBase) this).Refresh();
    }
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

  public static void InitializeButtonAppearance(AppearanceBase app, MGAStyles style)
  {
    AppearanceBase appearanceBase = app;
    switch (style)
    {
      case MGAStyles.Gray:
        appearanceBase.BackColor = Color.LightGray;
        appearanceBase.BackColor2 = Color.White;
        appearanceBase.BackGradientStyle = (GradientStyle) 2;
        appearanceBase.BorderColor = Color.LightGray;
        appearanceBase.ForeColor = Color.FromArgb(60, 60, 60);
        break;
      case MGAStyles.Blue:
        appearanceBase.AlphaLevel = (short) 14;
        appearanceBase.BackColor = Color.FromArgb(0, 0, 246, 253);
        appearanceBase.BackColor2 = Color.FromArgb(133, 162, 221);
        appearanceBase.BackColorAlpha = (Alpha) 2;
        appearanceBase.BackGradientAlignment = (GradientAlignment) 4;
        appearanceBase.BackGradientStyle = (GradientStyle) 5;
        appearanceBase.BorderAlpha = (Alpha) 1;
        appearanceBase.BorderColor = Color.FromArgb(78, 122, 171);
        appearanceBase.ForeColor = Color.FromArgb(49, 85, 153);
        appearanceBase.ForegroundAlpha = (Alpha) 2;
        break;
    }
  }

  protected override void OnEndInit()
  {
    if (this._mgaStyle == MGAStyles.None)
      return;
    MGADateTimePicker.InitializeAppearance(this.Appearance, this._mgaStyle);
    MGADateTimePicker.InitializeButtonAppearance(this.ButtonAppearance, this._mgaStyle);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool ShouldSerializeAppearance()
  {
    return this._mgaStyle == MGAStyles.None && base.ShouldSerializeAppearance();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool ShouldSerializeButtonAppearance()
  {
    return this._mgaStyle == MGAStyles.None && base.ShouldSerializeButtonAppearance();
  }

  public MGADateTimePicker()
  {
    this._mgaStyle = MGAStyles.Gray;
    MGADateTimePicker.InitializeAppearance(this.ButtonAppearance, this._mgaStyle);
    MGADateTimePicker.InitializeButtonAppearance(this.ButtonAppearance, this._mgaStyle);
    this.FlatMode = (DefaultableBoolean) 1;
    this.BorderStyle = (UIElementBorderStyle) 4;
    this.SupportThemes = (DefaultableBoolean) 2;
    ((Control) this).DoubleBuffered = true;
  }

  [DefaultValue(typeof (UIElementBorderStyle), "Solid")]
  public UIElementBorderStyle BorderStyle
  {
    get => base.BorderStyle;
    set => base.BorderStyle = value;
  }

  protected override void OnClick(EventArgs e)
  {
    ((UltraControlBase) this).OnClick(e);
    if (!this.IsInEditMode)
      return;
    int selectionStart = ((UltraWinEditorMaskedControlBase) this).SelectionStart;
    if (selectionStart >= 0 && selectionStart <= 2)
    {
      ((UltraWinEditorMaskedControlBase) this).SelectionStart = 0;
      ((UltraWinEditorMaskedControlBase) this).SelectionLength = 2;
    }
    else if (selectionStart >= 3 && selectionStart <= 5)
    {
      ((UltraWinEditorMaskedControlBase) this).SelectionStart = 3;
      ((UltraWinEditorMaskedControlBase) this).SelectionLength = 2;
    }
    else
    {
      ((UltraWinEditorMaskedControlBase) this).SelectionStart = 6;
      ((UltraWinEditorMaskedControlBase) this).SelectionLength = 4;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean FlatMode
  {
    get => ((UltraControlBase) this).UseFlatMode;
    set => ((UltraControlBase) this).UseFlatMode = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean SupportThemes
  {
    get => ((UltraControlBase) this).UseOsThemes;
    set => ((UltraControlBase) this).UseOsThemes = value;
  }
}
