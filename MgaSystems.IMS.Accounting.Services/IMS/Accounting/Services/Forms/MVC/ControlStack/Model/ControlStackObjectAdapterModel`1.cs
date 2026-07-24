// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Model.ControlStackObjectAdapterModel`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.Utility;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.FormActionDurationStatistics;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ControlStack.Model;

public class ControlStackObjectAdapterModel<TDisplayItem> : 
  MvcModelBase,
  IControlStackObjectAdapterModel<TDisplayItem>,
  IControlStackObjectAdapterModel,
  IMvcModel,
  ISave,
  ILoadable
  where TDisplayItem : class
{
  private TDisplayItem _displayItem;

  object IControlStackObjectAdapterModel.DisplayItem => (object) this.DisplayItem;

  private Action<TDisplayItem> _saveAction { get; }

  private Action<TDisplayItem> _resetAction { get; }

  private Func<TDisplayItem> _getDataSourceFunc { get; }

  public TDisplayItem DisplayItem
  {
    get
    {
      if ((object) this._displayItem == null)
        this.Load();
      return this._displayItem;
    }
  }

  public ControlStackObjectAdapterModel(
    Func<TDisplayItem> getDataSourceFunc,
    Action<TDisplayItem> saveAction = null,
    Action<TDisplayItem> resetAction = null)
  {
    this._getDataSourceFunc = getDataSourceFunc ?? throw new ArgumentNullException(nameof (getDataSourceFunc));
    this._saveAction = saveAction ?? (Action<TDisplayItem>) (_ => { });
    this._resetAction = resetAction ?? (Action<TDisplayItem>) (_ => { });
  }

  public ControlStackObjectAdapterModel(
    TDisplayItem dataSource,
    Action<TDisplayItem> saveAction = null,
    Action<TDisplayItem> resetAction = null)
    : this((Func<TDisplayItem>) (() => dataSource), saveAction, resetAction)
  {
    if ((object) dataSource == null)
      throw new ArgumentNullException();
  }

  public void Load() => this._displayItem = this._getDataSourceFunc();

  public void ResetChanges() => this._resetAction(this.DisplayItem);

  public void SaveChanges() => this._saveAction(this.DisplayItem);
}
