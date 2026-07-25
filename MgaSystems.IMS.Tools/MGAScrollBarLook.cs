// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGAScrollBarLook
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win.UltraWinScrollBar;
using System.Drawing;

#nullable disable
namespace MGASystems.Tools;

public sealed class MGAScrollBarLook : ScrollBarLook
{
  public MGAScrollBarLook()
  {
    this.TrackAppearance.BackColor = Color.White;
    this.TrackAppearance.BorderColor = Color.WhiteSmoke;
    this.ButtonAppearance.BackColor = Color.WhiteSmoke;
    this.ButtonAppearance.BorderColor = Color.Silver;
  }
}
