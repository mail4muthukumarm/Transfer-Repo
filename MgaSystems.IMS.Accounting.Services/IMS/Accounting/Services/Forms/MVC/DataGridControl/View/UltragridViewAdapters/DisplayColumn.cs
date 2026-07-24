// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters.DisplayColumn
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;

public class DisplayColumn : IDisplayColumnSettings
{
  private Func<IMvcModel, string> _getValueFunc;

  public DisplayColumn(
    string propertyName,
    int width,
    string headerCaption,
    Type dataType,
    Func<IMvcModel, string> getValueFunc)
  {
    this.PropertyName = propertyName;
    this.Width = width;
    this.HeaderCaption = headerCaption;
    this.DataType = dataType;
    this._getValueFunc = getValueFunc ?? throw new ArgumentNullException(nameof (getValueFunc));
  }

  public object GetValueForDisplayObject(IMvcModel displayObject)
  {
    return (object) this._getValueFunc(displayObject);
  }

  public string PropertyName { get; }

  public int Width { get; }

  public string HeaderCaption { get; }

  public Type DataType { get; }
}
