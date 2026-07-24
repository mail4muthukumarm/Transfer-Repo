// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.TextReadOnlyButtonColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public class TextReadOnlyButtonColumn<TDisplayItem> : TextEditButtonColumn<TDisplayItem>
{
  public TextReadOnlyButtonColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, string> getBoundValueFromDisplayItemFunc,
    object buttonImage,
    Action<TDisplayItem> buttonAction,
    bool disableButtonWithRow,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, false, getBoundValueFromDisplayItemFunc, (Action<TDisplayItem, string>) ((_, __) => { }), buttonImage, buttonAction, disableButtonWithRow, getCellColorFromDisplayItemFunc)
  {
  }

  public TextReadOnlyButtonColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, string> getBoundValueFromDisplayItemFunc,
    object buttonImage,
    Action<TDisplayItem> buttonAction,
    bool disableButtonWithRow,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, false, getBoundValueFromDisplayItemFunc, (Action<TDisplayItem, string>) ((_, __) => { }), buttonImage, buttonAction, disableButtonWithRow, getCellColorFromDisplayItemFunc)
  {
  }

  protected override Activation CellActivation => (Activation) 3;
}
