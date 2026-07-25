// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.StyleFont
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using System;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class StyleFont
{
  private int m_argbColor;
  private int m_Color;
  private string m_capsType;
  private int m_charset;
  private double m_doubleSize;
  private bool m_isBold;
  private bool m_isItalic;
  private bool m_isNormalizeHeights;
  private bool m_isStrikeout;
  private bool m_isSubscript;
  private bool m_isSuperscript;
  private string m_name;
  private double m_scriptOffset;
  private int m_size;
  private string m_strikeType;
  private string m_underline;

  public int ArgbColor
  {
    get => this.m_argbColor;
    set => this.m_argbColor = value;
  }

  public int Color
  {
    get => this.m_Color;
    set => this.m_Color = value;
  }

  public TextCapsType CapsType
  {
    get => (TextCapsType) Enum.Parse(typeof (TextCapsType), this.m_capsType);
    set => this.m_capsType = value.ToString();
  }

  public int Charset
  {
    get => this.m_charset;
    set => this.m_charset = value;
  }

  public double DoubleSize
  {
    get => this.m_doubleSize;
    set => this.m_doubleSize = value;
  }

  public bool IsBold
  {
    get => this.m_isBold;
    set => this.m_isBold = value;
  }

  public bool IsItalic
  {
    get => this.m_isItalic;
    set => this.m_isItalic = value;
  }

  public bool IsNormalizeHeights
  {
    get => this.m_isNormalizeHeights;
    set => this.m_isNormalizeHeights = value;
  }

  public bool IsStrikeout
  {
    get => this.m_isStrikeout;
    set => this.m_isStrikeout = value;
  }

  public bool IsSubscript
  {
    get => this.m_isSubscript;
    set => this.m_isSubscript = value;
  }

  public bool IsSuperscript
  {
    get => this.m_isSuperscript;
    set => this.m_isSuperscript = value;
  }

  public string Name
  {
    get => this.m_name;
    set => this.m_name = value;
  }

  public double ScriptOffset
  {
    get => this.m_scriptOffset;
    set => this.m_scriptOffset = value;
  }

  public int Size
  {
    get => this.m_size;
    set => this.m_size = value;
  }

  public TextStrikeType StrikeType
  {
    get => (TextStrikeType) Enum.Parse(typeof (TextStrikeType), this.m_strikeType);
    set => this.m_strikeType = value.ToString();
  }

  public FontUnderlineType Underline
  {
    get => (FontUnderlineType) Enum.Parse(typeof (FontUnderlineType), this.m_underline);
    set => this.m_underline = value.ToString();
  }

  public StyleFont()
  {
  }

  public StyleFont(Font fnt)
  {
    this.ArgbColor = fnt.ArgbColor;
    this.Color = fnt.Color.ToArgb();
    this.CapsType = fnt.CapsType;
    this.Charset = fnt.Charset;
    this.DoubleSize = fnt.DoubleSize;
    this.IsBold = fnt.IsBold;
    this.IsItalic = fnt.IsItalic;
    this.IsNormalizeHeights = fnt.IsNormalizeHeights;
    this.IsStrikeout = fnt.IsStrikeout;
    this.IsSubscript = fnt.IsSubscript;
    this.IsSuperscript = fnt.IsSuperscript;
    this.Name = fnt.Name;
    this.ScriptOffset = fnt.ScriptOffset;
    this.Size = fnt.Size;
    this.StrikeType = fnt.StrikeType;
    this.Underline = fnt.Underline;
  }
}
