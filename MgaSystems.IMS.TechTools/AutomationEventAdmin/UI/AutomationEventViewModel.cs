// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.AutomationEventAdmin.UI.AutomationEventViewModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using Mga.Wpf.Ims.Commands;
using Mga.Wpf.Ims.DialogService;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.Validation;
using MgaSystems.IMS.TechTools.AutomationEventAdmin.Model;
using MgaSystems.IMS.TechTools.SharedModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

#nullable disable
namespace MgaSystems.IMS.TechTools.AutomationEventAdmin.UI;

public abstract class AutomationEventViewModel : BindingObject, ISubmittable
{
  private readonly IWinMsgBoxService _msgBoxSvc;

  [NotificationProperty]
  public virtual AutomationEventManager AutomationEventManager { get; set; }

  [NotificationProperty]
  public virtual AutomationEvent SelectedItem { get; set; }

  internal static AutomationEventViewModel Create(IWinMsgBoxService msgBoxService)
  {
    return NotifyProxyTypeManager.Allocate<AutomationEventViewModel>(new object[1]
    {
      (object) msgBoxService
    });
  }

  public AutomationEventViewModel(IWinMsgBoxService msgBoxService)
  {
    this._msgBoxSvc = msgBoxService;
    this.AutomationEventManager = AutomationEventManager.Create();
    AutomationEventManager automationEventManager = this.AutomationEventManager;
    if ((automationEventManager != null ? (((Collection<AutomationEvent>) automationEventManager.AutomationEventList).Count > 0 ? 1 : 0) : 0) == 0)
      return;
    this.SelectedItem = ((Collection<AutomationEvent>) this.AutomationEventManager.AutomationEventList)[0];
  }

  public RelayCommand SaveCommand
  {
    get
    {
      return new RelayCommand((Action) (() =>
      {
        List<ValidationResult> source = this.SubmitChanges();
        if (source.Count <= 0)
          return;
        int num = (int) this._msgBoxSvc.ShowMessageBox("Please fix the following before saving:\n" + string.Join("\n", source.Select<ValidationResult, string>((Func<ValidationResult, string>) (errorMessage => errorMessage.ErrorMessage))), "Automation Event Admin", MessageBoxButton.OK);
      }), (Func<bool>) (() => this.HasChanges));
    }
  }

  public List<ValidationResult> SubmitChanges() => this.AutomationEventManager.SubmitChanges();

  public RelayCommand AddAutomationEventCommand
  {
    get
    {
      return new RelayCommand((Action) (() => this.SelectedItem = this.AutomationEventManager.NewAutomationEvent()));
    }
  }

  public bool HasChanges => this.AutomationEventManager.HasChanges;
}
