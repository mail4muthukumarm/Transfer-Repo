// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns.TextEditColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;

public class TextEditColumn<TDisplayItem> : EditColumn<TDisplayItem, string>
{
  protected override ColumnStyle ColumnDisplayStyle { get; } = (ColumnStyle) 1;

  protected override CellClickAction CellClickAction { get; }

  public TextEditColumn(
    string headerCaption,
    int width,
    bool selectWhenEdit,
    Func<TDisplayItem, string> getBoundValueFromDisplayItemFunc,
    Action<TDisplayItem, string> setValueAction,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getBoundValueFromDisplayItemFunc, setValueAction, getCellColorFromDisplayItemFunc)
  {
    this.CellClickAction = selectWhenEdit ? (CellClickAction) 4 : (CellClickAction) 1;
  }

  public TextEditColumn(
    string identifier,
    string headerCaption,
    int width,
    bool selectWhenEdit,
    Func<TDisplayItem, string> getBoundValueFromDisplayItemFunc,
    Action<TDisplayItem, string> setValueAction,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getBoundValueFromDisplayItemFunc, setValueAction, getCellColorFromDisplayItemFunc)
  {
    this.CellClickAction = selectWhenEdit ? (CellClickAction) 4 : (CellClickAction) 1;
  }

  protected override string CastToEditType(object newCellValue) => newCellValue.ToString();
}
