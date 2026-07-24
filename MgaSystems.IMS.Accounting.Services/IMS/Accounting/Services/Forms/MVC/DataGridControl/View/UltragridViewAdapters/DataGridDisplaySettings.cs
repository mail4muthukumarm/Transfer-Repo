// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters.DataGridDisplaySettings
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;

public class DataGridDisplaySettings : IDataGridDisplaySettings
{
  public DataGridDisplaySettings(
    IDisplayColumnSettings[] columns,
    bool allowRowFiltering,
    TextAlignment headerAlignment,
    TextAlignment textAlignment)
  {
    this.Columns = columns ?? throw new ArgumentNullException(nameof (columns));
    this.AllowRowFiltering = allowRowFiltering;
    this.HeaderAlignment = headerAlignment;
    this.TextAlignment = textAlignment;
  }

  public DataGridDisplaySettings(IDisplayColumnSettings[] columns)
    : this(columns, true, TextAlignment.Left, TextAlignment.Left)
  {
  }

  public IDisplayColumnSettings[] Columns { get; }

  public bool AllowRowFiltering { get; }

  public TextAlignment HeaderAlignment { get; }

  public TextAlignment TextAlignment { get; }
}
