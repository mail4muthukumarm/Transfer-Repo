// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns.DateReadOnlyColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;

public class DateReadOnlyColumn<TDisplayItem> : DisplayColumn<TDisplayItem, DateTime?>
{
  public DateReadOnlyColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, DateTime?> getDisplayValueFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getDisplayValueFunc, getCellColorFromDisplayItemFunc)
  {
  }

  public DateReadOnlyColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, DateTime?> getDisplayValueFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getDisplayValueFunc, getCellColorFromDisplayItemFunc)
  {
  }
}
