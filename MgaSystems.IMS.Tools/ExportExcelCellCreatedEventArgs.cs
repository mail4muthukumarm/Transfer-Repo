// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ExportExcelCellCreatedEventArgs
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;

#nullable disable
namespace MGASystems.Tools;

public class ExportExcelCellCreatedEventArgs : EventArgs
{
  private string _numberFormat;
  private int _row;
  private int _column;

  public int Row => this._row;

  public int Column => this._column;

  public string NumberFormat
  {
    get => this._numberFormat;
    set => this._numberFormat = value;
  }

  public ExportExcelCellCreatedEventArgs(int row, int column, string numberFormat)
  {
    this._row = row;
    this._numberFormat = numberFormat;
    this._column = column;
  }
}
