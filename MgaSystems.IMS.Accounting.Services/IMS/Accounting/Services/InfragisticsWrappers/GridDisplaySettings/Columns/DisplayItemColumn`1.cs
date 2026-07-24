// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.DisplayItemColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public class DisplayItemColumn<TDisplayItem> : 
  DisplayColumn<TDisplayItem, TDisplayItem>,
  IReadOnlyColumn<TDisplayItem>,
  IUltraGridColumnSettings<TDisplayItem>,
  IUltraGridColumnSettings,
  IUniqueObject<string>,
  IUniqueObject,
  IReadOnlyColumn
{
  public DisplayItemColumn(
    string headerCaption,
    int width,
    bool visible,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, (Func<TDisplayItem, TDisplayItem>) (displayItem => displayItem), getCellColorFromDisplayItemFunc)
  {
    this.Visible = visible;
  }

  public DisplayItemColumn(
    string identifier,
    string headerCaption,
    int width,
    bool visible,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, (Func<TDisplayItem, TDisplayItem>) (displayItem => displayItem), getCellColorFromDisplayItemFunc)
  {
    this.Visible = visible;
  }
}
