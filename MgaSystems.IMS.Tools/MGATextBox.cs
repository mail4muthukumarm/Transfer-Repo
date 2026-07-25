// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGATextBox
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

public class MGATextBox : UltraTextEditor
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
        MGATextBox.InitializeAppearance(((TextEditorControlBase) this).Appearance, this._mgaStyle);
      }
      ((UltraControlBase) this).Refresh();
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool ShouldSerializeAppearance()
  {
    return this._mgaStyle == MGAStyles.None && ((TextEditorControlBase) this).ShouldSerializeAppearance();
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
    appearanceBase.BackColor = Color.White;
    appearanceBase.ForeColor = Color.Black;
  }

  protected override void OnEndInit()
  {
    if (this._mgaStyle == MGAStyles.None)
      return;
    MGATextBox.InitializeAppearance(((TextEditorControlBase) this).Appearance, this._mgaStyle);
  }

  public MGATextBox()
  {
    ((Control) this).KeyUp += new KeyEventHandler(this.MGATextBox_KeyUp);
    this._mgaStyle = MGAStyles.Gray;
    MGATextBox.InitializeAppearance(((TextEditorControlBase) this).Appearance, this._mgaStyle);
    ((UltraControlBase) this).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this).DoubleBuffered = true;
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

  private void MGATextBox_KeyUp(object sender, KeyEventArgs e)
  {
    if ((e.Modifiers & Keys.Control) != Keys.Control || string.Compare(e.KeyCode.ToString(), "A", true) != 0)
      return;
    ((TextEditorControlBase) sender).SelectAll();
    e.Handled = true;
  }
}
