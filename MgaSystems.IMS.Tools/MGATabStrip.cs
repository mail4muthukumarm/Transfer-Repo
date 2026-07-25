// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGATabStrip
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinTabControl;
using System.Drawing;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGATabStrip : UltraTabStripControl
{
  public MGATabStrip()
  {
    ((UltraTabControlBase) this).Appearance.BackColor = Color.Gainsboro;
    ((UltraTabControlBase) this).SelectedTabAppearance.BorderColor = Color.Gray;
    ((UltraControlBase) this).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraTabControlBase) this).SelectedTabAppearance.BackColor = Color.WhiteSmoke;
    ((UltraTabControlBase) this).Style = (UltraTabControlStyle) 12;
    ((UltraControlBase) this).UseOsThemes = (DefaultableBoolean) 2;
  }
}
