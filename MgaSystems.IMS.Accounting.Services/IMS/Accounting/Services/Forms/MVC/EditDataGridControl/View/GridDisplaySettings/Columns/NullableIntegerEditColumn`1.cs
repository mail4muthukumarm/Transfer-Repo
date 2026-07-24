// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns.NullableIntegerEditColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;

public class NullableIntegerEditColumn<TDisplayItem> : EditColumn<TDisplayItem, int?>
{
  protected override ColumnStyle ColumnDisplayStyle { get; } = (ColumnStyle) 1;

  public NullableIntegerEditColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, int?> getDisplayValueFunc,
    Action<TDisplayItem, int?> setFromDisplayValueAction,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getDisplayValueFunc, setFromDisplayValueAction, getCellColorFromDisplayItemFunc)
  {
  }

  public NullableIntegerEditColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, int?> getDisplayValueFunc,
    Action<TDisplayItem, int?> setFromDisplayValueAction,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getDisplayValueFunc, setFromDisplayValueAction, getCellColorFromDisplayItemFunc)
  {
  }

  protected override int? CastToEditType(object newCellValue)
  {
    return newCellValue == null ? new int?() : new int?(int.Parse(newCellValue.ToString()));
  }
}
