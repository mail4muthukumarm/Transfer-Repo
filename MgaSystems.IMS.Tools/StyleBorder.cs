// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.StyleBorder
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class StyleBorder
{
  private StyleBorderProperties properties;
  private string _Bordertype;

  public string BorderType
  {
    get => this._Bordertype;
    set => this._Bordertype = value;
  }

  public int ArgbColor
  {
    get => this.properties.ArgbColor;
    set => this.properties.ArgbColor = value;
  }

  public Color Color
  {
    get => this.properties.Color;
    set => this.properties.Color = value;
  }

  public CellBorderType LineStyle
  {
    get => this.properties.LineStyle;
    set => this.properties.LineStyle = value;
  }

  public StyleBorder() => this.properties = new StyleBorderProperties();

  public StyleBorder(Style s, MGASystems.AsposeFacade.Cells.BorderType bt)
  {
    this.properties = new StyleBorderProperties();
    Border border = s.Borders[bt];
    this.ArgbColor = border.ArgbColor;
    this.Color = border.Color;
    this.LineStyle = border.LineStyle;
    this.BorderType = bt.ToString();
  }
}
