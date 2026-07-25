// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ExcelExportBadDataDefinitionException
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class ExcelExportBadDataDefinitionException : FormatException
{
  private string _msg;

  public ExcelExportBadDataDefinitionException(StyleInXML _value, string Message)
  {
    this.Value = _value;
    this._msg = Message;
  }

  public StyleInXML Value { get; set; }

  public override string Message => this._msg;
}
