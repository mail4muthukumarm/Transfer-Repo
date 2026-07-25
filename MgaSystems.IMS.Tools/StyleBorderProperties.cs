// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.StyleBorderProperties
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class StyleBorderProperties
{
  public int ArgbColor;
  private int _color;
  private string _lineStyle;

  public Color Color
  {
    get => Color.FromArgb(this._color);
    set => this._color = value.ToArgb();
  }

  public CellBorderType LineStyle
  {
    get
    {
      return Operators.CompareString(this._lineStyle, (string) null, false) != 0 ? (CellBorderType) Enum.Parse(typeof (CellBorderType), this._lineStyle) : (CellBorderType) Enum.Parse(typeof (CellBorderType), "None");
    }
    set => this._lineStyle = value.ToString();
  }
}
