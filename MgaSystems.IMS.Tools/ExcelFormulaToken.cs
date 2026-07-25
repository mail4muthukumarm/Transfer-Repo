// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ExcelFormulaToken
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

#nullable disable
namespace MGASystems.Tools;

public class ExcelFormulaToken
{
  private string _value;
  private ExcelFormulaTokenType _type;
  private ExcelFormulaTokenSubtype _subtype;

  private ExcelFormulaToken()
  {
  }

  internal ExcelFormulaToken(string value, ExcelFormulaTokenType type)
    : this(value, type, ExcelFormulaTokenSubtype.Nothing)
  {
  }

  internal ExcelFormulaToken(
    string value,
    ExcelFormulaTokenType type,
    ExcelFormulaTokenSubtype subtype)
  {
    this._value = value;
    this._type = type;
    this._subtype = subtype;
  }

  public string Value
  {
    get => this._value;
    internal set => this._value = value;
  }

  public ExcelFormulaTokenType Type
  {
    get => this._type;
    internal set => this._type = value;
  }

  public ExcelFormulaTokenSubtype Subtype
  {
    get => this._subtype;
    internal set => this._subtype = value;
  }
}
