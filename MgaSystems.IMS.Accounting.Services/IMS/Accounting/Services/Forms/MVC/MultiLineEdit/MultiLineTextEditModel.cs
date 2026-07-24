// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit.MultiLineTextEditModel
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MultiLineEdit;

public class MultiLineTextEditModel : MvcModelBase, ISaveModel, IMvcModel, ISave
{
  private string multiLineText;
  private readonly Action<string> _setValueFunc;

  public string MultiLineText
  {
    get => this.multiLineText;
    set
    {
      this.multiLineText = value;
      this.NotifyObservers();
    }
  }

  public MultiLineTextEditModel(Func<string> getValueFunc, Action<string> setValueFunc)
  {
    if (getValueFunc == null)
      throw new ArgumentNullException(nameof (getValueFunc));
    this.MultiLineText = getValueFunc() ?? string.Empty;
    this._setValueFunc = setValueFunc ?? throw new ArgumentNullException(nameof (setValueFunc));
  }

  public void SaveChanges() => this._setValueFunc(this.MultiLineText);

  public void ResetChanges()
  {
  }
}
