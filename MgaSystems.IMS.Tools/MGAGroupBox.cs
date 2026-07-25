// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAGroupBox
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win.Misc;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (UltraGroupBox))]
public sealed class MGAGroupBox : UltraGroupBox
{
  public MGAGroupBox()
  {
    this.ContentAreaAppearance.BackColor = Color.FromArgb(239, 247, 253);
    this.ContentAreaAppearance.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.SupportThemes = false;
    this.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this).DoubleBuffered = true;
    this.HeaderAppearance.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
  }
}
