// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit.MultiLineTextEditForm
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit;

public class MultiLineTextEditForm(
  MultiLineTextEditModel model,
  MultiLineTextEditController controller) : 
  ToolbarForm<MultiLineTextEditController, MultiLineTextEditView, MultiLineTextEditModel>(model, new MultiLineTextEditView(), controller)
{
  public MultiLineTextEditForm(
    Func<string> getEditValue,
    Action<string> setEditValue,
    int width,
    int height,
    string name)
    : this(new MultiLineTextEditModel(getEditValue, setEditValue), new MultiLineTextEditController(width, height, name))
  {
  }
}
