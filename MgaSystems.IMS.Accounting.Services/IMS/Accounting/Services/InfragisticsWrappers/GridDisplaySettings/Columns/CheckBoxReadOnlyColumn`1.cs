// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.CheckBoxReadOnlyColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public class CheckBoxReadOnlyColumn<TDisplayItem> : DisplayColumn<TDisplayItem, bool>
{
  protected override ColumnStyle ColumnDisplayStyle => (ColumnStyle) 3;

  public CheckBoxReadOnlyColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, bool> getDisplayValueFunc)
    : base(headerCaption, width, getDisplayValueFunc)
  {
  }

  public CheckBoxReadOnlyColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, bool> getDisplayValueFunc)
    : base(identifier, headerCaption, width, getDisplayValueFunc)
  {
  }
}
