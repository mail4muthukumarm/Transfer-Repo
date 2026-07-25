// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.CellRange
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class CellRange
{
  private int m_columnCount;
  private int m_firstColumn;
  private int m_firstRow;
  private string m_name;
  private int m_rowCount;

  public int ColumnCount
  {
    get => this.m_columnCount;
    set => this.m_columnCount = value;
  }

  public int FirstColumn
  {
    get => this.m_firstColumn;
    set => this.m_firstColumn = value;
  }

  public int FirstRow
  {
    get => this.m_firstRow;
    set => this.m_firstRow = value;
  }

  public string Name
  {
    get => this.m_name;
    set => this.m_name = value;
  }

  public int RowCount
  {
    get => this.m_rowCount;
    set => this.m_rowCount = value;
  }

  public CellRange()
  {
  }

  public CellRange(int FirstRow, int FirstColumn, int RowCount, int ColumnCount, string Name)
  {
    this.m_columnCount = ColumnCount;
    this.m_firstColumn = FirstColumn;
    this.m_firstRow = FirstRow;
    this.m_name = Name;
    this.m_rowCount = RowCount;
  }
}
