// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model.UltraGridDataModel`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics;
using System.Collections;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.Model;

public abstract class UltraGridDataModel<TDisplayItem> : 
  ValidateModelBase,
  IUltraGridDataModel<TDisplayItem>,
  IUltraGridDataModel,
  IValidateModel,
  IMvcModel,
  IValidate,
  ILoadable
{
  private TDisplayItem[] _displayItems;

  IEnumerable IUltraGridDataModel.DisplayItems => (IEnumerable) this.DisplayItems;

  public virtual TDisplayItem[] DisplayItems
  {
    get
    {
      if (this._displayItems == null)
        this.Load();
      return this._displayItems;
    }
  }

  public virtual void Load()
  {
    this._displayItems = this.GetDisplayItems();
    this.NotifyObservers();
  }

  protected abstract TDisplayItem[] GetDisplayItems();
}
