// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAButton
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public class MGAButton : UltraButton, ISupportInitialize
{
  public static void InitializeAppearance(AppearanceBase app)
  {
    AppearanceBase appearanceBase = app;
    appearanceBase.BackColor = Color.FromArgb(248, 248, 248);
    appearanceBase.BackColor2 = Color.FromArgb(250, 250, 250);
    appearanceBase.BorderColor = Color.DarkGray;
    appearanceBase.BackGradientStyle = (GradientStyle) 2;
    appearanceBase.ImageHAlign = (HAlign) 2;
    appearanceBase.ImageVAlign = (VAlign) 2;
  }

  public MGAButton()
  {
    MGAButton.InitializeAppearance(((ControlBase) this).Appearance);
    ((Control) this).DoubleBuffered = true;
    ((UltraButtonBase) this).ButtonStyle = (UIElementButtonStyle) 14;
    ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraButtonBase) this).ShowFocusRect = false;
  }

  [DefaultValue(typeof (UIElementButtonStyle), "WindowsXPCommandButton")]
  public UIElementButtonStyle ButtonStyle
  {
    get => ((UltraButtonBase) this).ButtonStyle;
    set => ((UltraButtonBase) this).ButtonStyle = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public bool ShowFocusRect
  {
    get => ((UltraButtonBase) this).ShowFocusRect;
    set => ((UltraButtonBase) this).ShowFocusRect = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public bool ShowOutline
  {
    get => ((UltraButtonBase) this).ShowOutline;
    set => ((UltraButtonBase) this).ShowOutline = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean HotTracking
  {
    get => ((ControlBase) this).UseHotTracking;
    set => ((ControlBase) this).UseHotTracking = value;
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public AppearanceBase HotTrackAppearance
  {
    get => ((ControlBase) this).HotTrackAppearance;
    set => ((ControlBase) this).HotTrackAppearance = value;
  }

  [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "Value")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean FlatMode
  {
    get => ((UltraControlBase) this).UseFlatMode;
    set
    {
    }
  }

  [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "Value")]
  [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public DefaultableBoolean UseOSThemes
  {
    get => (DefaultableBoolean) 2;
    set
    {
    }
  }

  protected override Size DefaultSize => new Size(40, 40);

  protected override int CalculateWidthAvailable(int width)
  {
    int widthAvailable;
    return widthAvailable;
  }

  public void BeginInit()
  {
  }

  public void EndInit()
  {
  }
}
