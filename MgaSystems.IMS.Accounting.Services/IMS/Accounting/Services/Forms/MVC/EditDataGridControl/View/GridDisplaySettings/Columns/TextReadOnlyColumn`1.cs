// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns.TextReadOnlyColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;

public class TextReadOnlyColumn<TDisplayItem> : 
  DisplayColumn<TDisplayItem, string>,
  IComboBoxColumn<TDisplayItem>,
  IComboBoxColumn,
  IReadOnlyColumn,
  IUltraGridColumnSettings,
  IUniqueObject<string>,
  IUniqueObject,
  IReadOnlyColumn<TDisplayItem>,
  IUltraGridColumnSettings<TDisplayItem>
{
  public TextReadOnlyColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, object> getBoundValueFromDisplayItemFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, TextReadOnlyColumn<TDisplayItem>.GetBoundValue(getBoundValueFromDisplayItemFunc), getCellColorFromDisplayItemFunc)
  {
  }

  public TextReadOnlyColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, object> getBoundValueFromDisplayItemFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, TextReadOnlyColumn<TDisplayItem>.GetBoundValue(getBoundValueFromDisplayItemFunc), getCellColorFromDisplayItemFunc)
  {
  }

  public bool IsComboBoxSelectionDisplayColumn { get; set; }

  private static Func<TDisplayItem, string> GetBoundValue(
    Func<TDisplayItem, object> getBoundValueFromDisplayItemFunc)
  {
    if (getBoundValueFromDisplayItemFunc == null)
      throw new ArgumentNullException(nameof (getBoundValueFromDisplayItemFunc));
    return (Func<TDisplayItem, string>) (item => (object) item == null ? string.Empty : getBoundValueFromDisplayItemFunc(item)?.ToString() ?? string.Empty);
  }
}
