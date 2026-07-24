// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.OptionStackController`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack.Options.BaseClasses;
using MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.OptionStack;

[Obsolete]
public abstract class OptionStackController<TDisplayItem> : 
  MvcControllerBase<IOptionStackModel<TDisplayItem>, IOptionStackView<TDisplayItem>>,
  IOptionStackController<TDisplayItem>,
  IOptionStackController,
  ISaveDataController,
  IMvcController,
  ITopControlController,
  IRequestParentSize
{
  public abstract IParentFormSettings ParentFormSettings { get; }

  public ISizeSettings ParentSizeSettings
  {
    get => (ISizeSettings) new PlaceholderSizeSettings(this.ParentFormSettings);
  }

  public abstract OptionStackSetSettings<TDisplayItem> GetDisplayOptions();

  public abstract IToolbarItem[] GetToolBarItems();

  public void RequestReset() => this.View.RequestCloseForm(DialogResult.Cancel);

  public void RequestSave()
  {
    foreach (IOptionStackOptionSetting<TDisplayItem> controlSetting in this.View.ControlSettings)
      controlSetting.UpdateDisplayItem(this.Model.DisplayItem);
    this.View.RequestCloseForm(DialogResult.OK);
  }
}
