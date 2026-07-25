// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.RECT
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System.Drawing;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

internal struct RECT
{
  public int Left;
  public int Top;
  public int Right;
  public int Bottom;

  public RECT(Size size)
  {
    this.Left = 0;
    this.Top = 0;
    this.Right = size.Width;
    this.Bottom = size.Height;
  }

  public void Inflate(double scale)
  {
    this.Right = (int) ((double) this.Right * scale);
    this.Bottom = (int) ((double) this.Bottom * scale);
  }
}
